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

            var rooms = new[] 
            {
                new Room() { tuid = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "Room 1", description = "Room 1 Description" }
            };
            var cabinets = new[] 
            {
                new Cabinet() { tuid = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 1", description = "Cabinet 1", room = rooms.First(x => x.name == "Room 1") }
            };

            context.Cabinets.AddOrUpdate(cabinets);
            context.Rooms.AddOrUpdate(rooms);


        }
    }
}
