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

            context.Rooms.AddOrUpdate(
                new Room() { tuid = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "Room 1", description = "Room 1 Description" }
            );
            context.Cabinets.AddOrUpdate( 
                new Cabinet() { tuid = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 1", description = "Cabinet 1", room = context.Rooms.First(x => x.name == "Room 1") },
                new Cabinet() { tuid = new Guid("bbcccbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 2", description = "Cabinet 2", room = context.Rooms.First(x => x.name == "Room 1") }
            );

        }
    }
}
