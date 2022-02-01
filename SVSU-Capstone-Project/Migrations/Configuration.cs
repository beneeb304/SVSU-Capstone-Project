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

            context.Users.AddOrUpdate(
            new User() { tuid = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), svsu_id = "1", first_name = "Alexander", last_name = "Buckstiegel", email = "awbuckst@svsu.edu", password = "Capstone424", isAdmin = true },
            new User() { tuid = new Guid("baaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), svsu_id = "2", first_name = "Ann", last_name = "Krause", email = "aekrause@svsu.edu", password = "Capstone424", isAdmin = true },
            new User() { tuid = new Guid("caaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), svsu_id = "3", first_name = "Ariel", last_name = "Taylor", email = "aataylo3@svsu.edu", password = "Capstone424", isAdmin = true },
            new User() { tuid = new Guid("daaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), svsu_id = "4", first_name = "Benjamin", last_name = "Neeb", email = "brneeb@svsu.edu", password = "Capstone424", isAdmin = true },
            new User() { tuid = new Guid("eaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), svsu_id = "5", first_name = "Brett", last_name = "Previdi", email = "bcprevid@svsu.edu", password = "Capstone424", isAdmin = true },
            new User() { tuid = new Guid("faaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), svsu_id = "6", first_name = "Devin", last_name = "Campbell", email = "dscampbe@svsu.edu", password = "Capstone424", isAdmin = true },
            new User() { tuid = new Guid("gaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), svsu_id = "7", first_name = "Durrell", last_name = "Pigee", email = "depigee@svsu.edu", password = "Capstone424", isAdmin = true },
            new User() { tuid = new Guid("haaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), svsu_id = "8", first_name = "Hunter", last_name = "Clipper", email = "hmclippe@svsu.edu", password = "Capstone424", isAdmin = true },
            new User() { tuid = new Guid("iaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), svsu_id = "9", first_name = "James", last_name = "Hax", email = "jhax@svsu.edu", password = "Capstone424", isAdmin = true },
            new User() { tuid = new Guid("jaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), svsu_id = "10", first_name = "Lamar", last_name = "Scott", email = "ldscott2@svsu.edu", password = "Capstone424", isAdmin = true },
            new User() { tuid = new Guid("kaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), svsu_id = "11", first_name = "Maxwell", last_name = "Grevais", email = "mtgrevai@svsu.edu", password = "Capstone424", isAdmin = true },
            new User() { tuid = new Guid("laaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), svsu_id = "12", first_name = "Michael", last_name = "Cardinalli", email = "macardin@svsu.edu", password = "Capstone424", isAdmin = true },
            new User() { tuid = new Guid("maaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), svsu_id = "13", first_name = "Michael", last_name = "Simon", email = "mjsimon1@svsu.edu", password = "Capstone424", isAdmin = true },
            new User() { tuid = new Guid("naaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), svsu_id = "14", first_name = "Omar", last_name = "Salih", email = "osalih@svsu.edu", password = "Capstone424", isAdmin = true },
            new User() { tuid = new Guid("oaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), svsu_id = "15", first_name = "Scott", last_name = "James", email = "james@svsu.edu", password = "Capstone424", isAdmin = true },
            new User() { tuid = new Guid("paaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), svsu_id = "16", first_name = "Taylor", last_name = "Debolt", email = "tsdebolt@svsu.edu", password = "Capstone424", isAdmin = true },
            new User() { tuid = new Guid("qaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), svsu_id = "17", first_name = "Trevor", last_name = "Eurich", email = "taeurich@svsu.edu", password = "Capstone424", isAdmin = true }
            );

            //Create mock category data in the Categories table
            context.Categories.AddOrUpdate(
                new Category() { tuid = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "Assets", description = "Assets" },
                new Category() { tuid = new Guid("baaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "Consumable", description = "Consumable" },
                new Category() { tuid = new Guid("caaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "Low Fidelity Simulator", description = "Low Fidelity Simulator" },
                new Category() { tuid = new Guid("daaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "High Fidelity Simulator", description = "High Fidelity Simulator" },
                new Category() { tuid = new Guid("eaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "PPE", description = "PPE" }
                );

            //Create mock Vendor data in the Vendors table
            context.Vendors.AddOrUpdate(
                new Vendor() { tuid = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "Amazon", description = "www.amazon.com" },
                new Vendor() { tuid = new Guid("baaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "Binsons", description = "www.binsons.com" },
                new Vendor() { tuid = new Guid("caaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "McKesson", description = "www.mckesson.com" },
                new Vendor() { tuid = new Guid("daaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "SafeChain", description = "www.safechain.com" },
                new Vendor() { tuid = new Guid("eaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "Walgreens", description = "www.walgreens.com" },
                new Vendor() { tuid = new Guid("faaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "Walmart", description = "www.walmart.com" }
                );

            //Create mock NLevel data in the NLevels table
            context.NLevels.AddOrUpdate(
                new NLevel() { tuid = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "1", description = "1" },
                new NLevel() { tuid = new Guid("baaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "2", description = "2" },
                new NLevel() { tuid = new Guid("caaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "3", description = "3" },
                new NLevel() { tuid = new Guid("daaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "4", description = "4" },
                new NLevel() { tuid = new Guid("eaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "5", description = "5" },
                new NLevel() { tuid = new Guid("faaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "NP", description = "NP" }
                );


            //Create mock room data in the Rooms table
            context.Rooms.AddOrUpdate(
                new Room() { tuid = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "HE 110", description = "HE 110 Description" },
                new Room() { tuid = new Guid("baaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "HE 111", description = "HE 111 Description" },
                new Room() { tuid = new Guid("caaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "HE 230", description = "HE 230 Description" },
                new Room() { tuid = new Guid("daaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "HE 240", description = "HE 240 Description" },
                new Room() { tuid = new Guid("eaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "HE 314", description = "HE 314 Description" },
                new Room() { tuid = new Guid("faaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "HE 327", description = "HE 327 Description" },
                new Room() { tuid = new Guid("gaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "HE 400", description = "HE 400 Description" },
                new Room() { tuid = new Guid("haaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "HE 402", description = "HE 402 Description" },
                new Room() { tuid = new Guid("iaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "HE 515", description = "HE 515 Description" },
                new Room() { tuid = new Guid("jaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "HE 516", description = "HE 516 Description" }
            );
            //Create mock cabinet data in the Cabinets table
            context.Cabinets.AddOrUpdate(
                new Cabinet() { tuid = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 1", description = "Cabinet 1", room = context.Rooms.First(x => x.name == "Room 1") },
                new Cabinet() { tuid = new Guid("bbcccbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 1", description = "Cabinet 1", room = context.Rooms.First(x => x.name == "Room 1") }
            );


        }
    }
}
