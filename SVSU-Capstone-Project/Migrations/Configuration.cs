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

        protected override void Seed(InvDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.dsRooms.AddOrUpdate(
                new Room() { uidTuid = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strName = "Room 1", strDescription = "Room 1 strDescription" }
            );
            context.dsCabinets.AddOrUpdate( 
                new Cabinet() { uidTuid = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 1", strDescription = "Cabinet 1", objRoom = context.dsRooms.First(x => x.strName == "Room 1") },
                new Cabinet() { uidTuid = new Guid("bbcccbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 2", strDescription = "Cabinet 2", objRoom = context.dsRooms.First(x => x.strName == "Room 1") }
            );

        }
    }
}
