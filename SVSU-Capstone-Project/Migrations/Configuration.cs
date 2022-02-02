namespace SVSU_Capstone_Project.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<InvDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed( InvDb context )
        {
            context.dsRooms.AddOrUpdate(
                new Room() { uidTuid = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strName = "Room 1", strDescription = "Room 1" },
                new Room() { uidTuid = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaabaaaaaaa"), strName = "Room 2", strDescription = "Room 2" }
            );
            context.dsCabinets.AddOrUpdate(
                new Cabinet() { uidTuid = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 1", strDescription = "Cabinet 1", objRoom = context.dsRooms.First(x => x.strName == "Room 1") },
                new Cabinet() { uidTuid = new Guid("bbcccbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 1", strDescription = "Cabinet 1", objRoom = context.dsRooms.First(x => x.strName == "Room 2") }
            );
            context.dsQuantities.AddOrUpdate(
                new Quantity() {
                    uidTuid = new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                    objCabinet = context.dsCabinets.Include("objRoom").First(x => x.strName == "Cabinet 1" && x.objRoom.strName == "Room 1"),
                    objCommodity = context.dsCommodites.First(x => x.strName == "Commodity 1"),
                    intQuantity = 10
                }
            );
        }
    }
}
