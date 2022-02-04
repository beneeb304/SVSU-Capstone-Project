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
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            //Create mock user data in the Users table
            context.Users.AddOrUpdate(
                new User() { tuid = new Guid("abaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), svsu_id = "500001", first_name = "Alexander", last_name = "Buckstiegel", email = "awbuckst@svsu.edu", phone = "", password = "Capstone424", isAdmin = true },
                new User() { tuid = new Guid("baaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), svsu_id = "500002", first_name = "Ann", last_name = "Krause", email = "aekrause@svsu.edu", phone = "", password = "Capstone424", isAdmin = true },
                new User() { tuid = new Guid("caaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), svsu_id = "500003", first_name = "Ariel", last_name = "Taylor", email = "aataylo3@svsu.edu", phone = "", password = "Capstone424", isAdmin = true },
                new User() { tuid = new Guid("daaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), svsu_id = "500004", first_name = "Benjamin", last_name = "Neeb", email = "brneeb@svsu.edu", phone = "", password = "Capstone424", isAdmin = true },
                new User() { tuid = new Guid("eaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), svsu_id = "500005", first_name = "Brett", last_name = "Previdi", email = "bcprevid@svsu.edu", phone = "", password = "Capstone424", isAdmin = true },
                new User() { tuid = new Guid("ddaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), svsu_id = "500006", first_name = "Devin", last_name = "Campbell", email = "dscampbe@svsu.edu", phone = "", password = "Capstone424", isAdmin = true },
                new User() { tuid = new Guid("fcfaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), svsu_id = "500007", first_name = "Durrell", last_name = "Pigee", email = "depigee@svsu.edu", phone = "", password = "Capstone424", isAdmin = true },
                new User() { tuid = new Guid("cfcaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), svsu_id = "500008", first_name = "Hunter", last_name = "Clipper", email = "hmclippe@svsu.edu", phone = "", password = "Capstone424", isAdmin = true },
                new User() { tuid = new Guid("fafaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), svsu_id = "500009", first_name = "James", last_name = "Hax", email = "jhax@svsu.edu", phone = "", password = "Capstone424", isAdmin = true },
                new User() { tuid = new Guid("fffaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), svsu_id = "500010", first_name = "Lamar", last_name = "Scott", email = "ldscott2@svsu.edu", phone = "", password = "Capstone424", isAdmin = true },
                new User() { tuid = new Guid("bbbaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), svsu_id = "500011", first_name = "Maxwell", last_name = "Grevais", email = "mtgrevai@svsu.edu", phone = "", password = "Capstone424", isAdmin = true },
                new User() { tuid = new Guid("cccaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), svsu_id = "500012", first_name = "Michael", last_name = "Cardinalli", email = "macardin@svsu.edu", phone = "", password = "Capstone424", isAdmin = true },
                new User() { tuid = new Guid("cbaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), svsu_id = "500013", first_name = "Michael", last_name = "Simon", email = "mjsimon1@svsu.edu", phone = "", password = "Capstone424", isAdmin = true },
                new User() { tuid = new Guid("bcaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), svsu_id = "500014", first_name = "Omar", last_name = "Salih", email = "osalih@svsu.edu", phone = "", password = "Capstone424", isAdmin = true },
                new User() { tuid = new Guid("ccaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), svsu_id = "000001", first_name = "Scott", last_name = "James", email = "james@svsu.edu", phone = "", password = "Capstone424", isAdmin = true },
                new User() { tuid = new Guid("bbaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), svsu_id = "500016", first_name = "Taylor", last_name = "Debolt", email = "tsdebolt@svsu.edu", phone = "", password = "Capstone424", isAdmin = true },
                new User() { tuid = new Guid("baaaabaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), svsu_id = "500017", first_name = "Trevor", last_name = "Eurich", email = "taeurich@svsu.edu", phone = "", password = "Capstone424", isAdmin = true }
            );

            //Create mock category data in the Categories table
            context.Categories.AddOrUpdate(
                new Category() { tuid = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "Asset", description = "Asset" },
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
                new Vendor() { tuid = new Guid("bbaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "Walgreens", description = "www.walgreens.com" },
                new Vendor() { tuid = new Guid("faaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "Walmart", description = "www.walmart.com" },
                new Vendor() { tuid = new Guid("aababaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "GTSimulators", description = "gtsimulators.com" },
                new Vendor() { tuid = new Guid("accaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "Medline", description = "medline.com" }
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
                    new Room() { tuid = new Guid("ccaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "HE 110", description = "HE 110 Description" },
                    new Room() { tuid = new Guid("bcaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "HE 111", description = "HE 111 Description" },
                    new Room() { tuid = new Guid("ccaabaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "HE 230", description = "HE 230 Description" },
                    new Room() { tuid = new Guid("daaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "HE 240", description = "HE 240 Description" },
                    new Room() { tuid = new Guid("eaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "HE 314", description = "HE 314 Description" },
                    new Room() { tuid = new Guid("faaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "HE 327", description = "HE 327 Description" },
                    new Room() { tuid = new Guid("aaaadaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "HE 400", description = "HE 400 Description" },
                    new Room() { tuid = new Guid("daabaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "HE 402", description = "HE 402 Description" },
                    new Room() { tuid = new Guid("acaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "HE 515", description = "HE 515 Description" },
                    new Room() { tuid = new Guid("caaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "HE 516", description = "HE 516 Description" }
            );

            //Create mock cabinet data in the Cabinets table
            context.Cabinets.AddOrUpdate(
                new Cabinet() { tuid = new Guid("aaaaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 1", description = "Cabinet 1", room = context.Rooms.First(x => x.name == "HE 110") },
                new Cabinet() { tuid = new Guid("abaaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 1", description = "Cabinet 1", room = context.Rooms.First(x => x.name == "HE 111") },
                new Cabinet() { tuid = new Guid("acaaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 2", description = "Cabinet 2", room = context.Rooms.First(x => x.name == "HE 110") },
                new Cabinet() { tuid = new Guid("adaaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 2", description = "Cabinet 2", room = context.Rooms.First(x => x.name == "HE 111") },
                new Cabinet() { tuid = new Guid("aeaaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 3", description = "Cabinet 3", room = context.Rooms.First(x => x.name == "HE 110") },
                new Cabinet() { tuid = new Guid("afaaaaaa-aaaa-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 3", description = "Cabinet 3", room = context.Rooms.First(x => x.name == "HE 111") },
                new Cabinet() { tuid = new Guid("aabaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 4", description = "Cabinet 4", room = context.Rooms.First(x => x.name == "HE 110") },
                new Cabinet() { tuid = new Guid("aacaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 4", description = "Cabinet 4", room = context.Rooms.First(x => x.name == "HE 111") },
                new Cabinet() { tuid = new Guid("aadaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 5", description = "Cabinet 5", room = context.Rooms.First(x => x.name == "HE 110") },
                new Cabinet() { tuid = new Guid("aaeaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 5", description = "Cabinet 5", room = context.Rooms.First(x => x.name == "HE 111") },
                new Cabinet() { tuid = new Guid("aafaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 6", description = "Cabinet 6", room = context.Rooms.First(x => x.name == "HE 110") },
                new Cabinet() { tuid = new Guid("aaabaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 6", description = "Cabinet 6", room = context.Rooms.First(x => x.name == "HE 111") },
                new Cabinet() { tuid = new Guid("aaacaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 1", description = "Cabinet 1", room = context.Rooms.First(x => x.name == "HE 230") },
                new Cabinet() { tuid = new Guid("aaadaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 1", description = "Cabinet 1", room = context.Rooms.First(x => x.name == "HE 240") },
                new Cabinet() { tuid = new Guid("aaaeaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 2", description = "Cabinet 2", room = context.Rooms.First(x => x.name == "HE 230") },
                new Cabinet() { tuid = new Guid("aaafaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 2", description = "Cabinet 2", room = context.Rooms.First(x => x.name == "HE 240") },
                new Cabinet() { tuid = new Guid("aaaabaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 3", description = "Cabinet 3", room = context.Rooms.First(x => x.name == "HE 230") },
                new Cabinet() { tuid = new Guid("aaaacaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 3", description = "Cabinet 3", room = context.Rooms.First(x => x.name == "HE 240") },
                new Cabinet() { tuid = new Guid("aaaadaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 4", description = "Cabinet 4", room = context.Rooms.First(x => x.name == "HE 230") },
                new Cabinet() { tuid = new Guid("aaaaeaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 4", description = "Cabinet 4", room = context.Rooms.First(x => x.name == "HE 240") },
                new Cabinet() { tuid = new Guid("aaaafaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 5", description = "Cabinet 5", room = context.Rooms.First(x => x.name == "HE 230") },
                new Cabinet() { tuid = new Guid("aaaaabaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 5", description = "Cabinet 5", room = context.Rooms.First(x => x.name == "HE 240") },
                new Cabinet() { tuid = new Guid("aaaaacaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 6", description = "Cabinet 6", room = context.Rooms.First(x => x.name == "HE 230") },
                new Cabinet() { tuid = new Guid("aaaaadaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 6", description = "Cabinet 6", room = context.Rooms.First(x => x.name == "HE 240") },
                new Cabinet() { tuid = new Guid("aaaaaeaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 1", description = "Cabinet 1", room = context.Rooms.First(x => x.name == "HE 314") },
                new Cabinet() { tuid = new Guid("aaaaafaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 1", description = "Cabinet 1", room = context.Rooms.First(x => x.name == "HE 327") },
                new Cabinet() { tuid = new Guid("aaaaaaba-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 2", description = "Cabinet 2", room = context.Rooms.First(x => x.name == "HE 314") },
                new Cabinet() { tuid = new Guid("aaaaaaca-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 2", description = "Cabinet 2", room = context.Rooms.First(x => x.name == "HE 327") },
                new Cabinet() { tuid = new Guid("aaaaaada-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 3", description = "Cabinet 3", room = context.Rooms.First(x => x.name == "HE 314") },
                new Cabinet() { tuid = new Guid("aaaaaaea-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 3", description = "Cabinet 3", room = context.Rooms.First(x => x.name == "HE 327") },
                new Cabinet() { tuid = new Guid("aaaaaafa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 4", description = "Cabinet 4", room = context.Rooms.First(x => x.name == "HE 314") },
                new Cabinet() { tuid = new Guid("aaaaaaab-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 4", description = "Cabinet 4", room = context.Rooms.First(x => x.name == "HE 327") },
                new Cabinet() { tuid = new Guid("aaaaaaac-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 5", description = "Cabinet 5", room = context.Rooms.First(x => x.name == "HE 314") },
                new Cabinet() { tuid = new Guid("aaaaaaad-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 5", description = "Cabinet 5", room = context.Rooms.First(x => x.name == "HE 327") },
                new Cabinet() { tuid = new Guid("aaaaaaae-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 6", description = "Cabinet 6", room = context.Rooms.First(x => x.name == "HE 314") },
                new Cabinet() { tuid = new Guid("aaaaaaaf-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 6", description = "Cabinet 6", room = context.Rooms.First(x => x.name == "HE 327") },
                new Cabinet() { tuid = new Guid("abbaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 1", description = "Cabinet 1", room = context.Rooms.First(x => x.name == "HE 400") },
                new Cabinet() { tuid = new Guid("abcaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 1", description = "Cabinet 1", room = context.Rooms.First(x => x.name == "HE 402") },
                new Cabinet() { tuid = new Guid("abdaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 2", description = "Cabinet 2", room = context.Rooms.First(x => x.name == "HE 400") },
                new Cabinet() { tuid = new Guid("abeaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 2", description = "Cabinet 2", room = context.Rooms.First(x => x.name == "HE 402") },
                new Cabinet() { tuid = new Guid("abfaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 3", description = "Cabinet 3", room = context.Rooms.First(x => x.name == "HE 400") },
                new Cabinet() { tuid = new Guid("acbaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 3", description = "Cabinet 3", room = context.Rooms.First(x => x.name == "HE 402") },
                new Cabinet() { tuid = new Guid("accaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 4", description = "Cabinet 4", room = context.Rooms.First(x => x.name == "HE 400") },
                new Cabinet() { tuid = new Guid("acdaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 4", description = "Cabinet 4", room = context.Rooms.First(x => x.name == "HE 402") },
                new Cabinet() { tuid = new Guid("acfaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 5", description = "Cabinet 5", room = context.Rooms.First(x => x.name == "HE 400") },
                new Cabinet() { tuid = new Guid("adbaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 5", description = "Cabinet 5", room = context.Rooms.First(x => x.name == "HE 402") },
                new Cabinet() { tuid = new Guid("adcaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 6", description = "Cabinet 6", room = context.Rooms.First(x => x.name == "HE 400") },
                new Cabinet() { tuid = new Guid("addaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 6", description = "Cabinet 6", room = context.Rooms.First(x => x.name == "HE 402") },
                new Cabinet() { tuid = new Guid("adeaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 1", description = "Cabinet 1", room = context.Rooms.First(x => x.name == "HE 515") },
                new Cabinet() { tuid = new Guid("adfaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 1", description = "Cabinet 1", room = context.Rooms.First(x => x.name == "HE 516") },
                new Cabinet() { tuid = new Guid("aebaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 2", description = "Cabinet 2", room = context.Rooms.First(x => x.name == "HE 515") },
                new Cabinet() { tuid = new Guid("aecaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 2", description = "Cabinet 2", room = context.Rooms.First(x => x.name == "HE 516") },
                new Cabinet() { tuid = new Guid("aedaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 3", description = "Cabinet 3", room = context.Rooms.First(x => x.name == "HE 515") },
                new Cabinet() { tuid = new Guid("aeeaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 3", description = "Cabinet 3", room = context.Rooms.First(x => x.name == "HE 516") },
                new Cabinet() { tuid = new Guid("aefaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 4", description = "Cabinet 4", room = context.Rooms.First(x => x.name == "HE 515") },
                new Cabinet() { tuid = new Guid("afbaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 4", description = "Cabinet 4", room = context.Rooms.First(x => x.name == "HE 516") },
                new Cabinet() { tuid = new Guid("afcaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 5", description = "Cabinet 5", room = context.Rooms.First(x => x.name == "HE 515") },
                new Cabinet() { tuid = new Guid("afdaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 5", description = "Cabinet 5", room = context.Rooms.First(x => x.name == "HE 516") },
                new Cabinet() { tuid = new Guid("afeaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 6", description = "Cabinet 6", room = context.Rooms.First(x => x.name == "HE 515") },
                new Cabinet() { tuid = new Guid("affaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 6", description = "Cabinet 6", room = context.Rooms.First(x => x.name == "HE 516") },
                new Cabinet() { tuid = new Guid("aafcaaaa-bbba-bbbb-bbbb-bbbbbbbbbbbb"), name = "Floor Item", description = "Floor Item", room = context.Rooms.First(x => x.name == "HE 110") },
                new Cabinet() { tuid = new Guid("aaabcaaa-bbbc-bbbb-bbbb-bbbbbbbbbbbb"), name = "Floor Item", description = "Floor Item", room = context.Rooms.First(x => x.name == "HE 111") },
                new Cabinet() { tuid = new Guid("aafcaaaa-bcbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Floor Item", description = "Floor Item", room = context.Rooms.First(x => x.name == "HE 230") },
                new Cabinet() { tuid = new Guid("aaabcaaa-babb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Floor Item", description = "Floor Item", room = context.Rooms.First(x => x.name == "HE 240") },
                new Cabinet() { tuid = new Guid("aafcaaaa-bfbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Floor Item", description = "Floor Item", room = context.Rooms.First(x => x.name == "HE 314") },
                new Cabinet() { tuid = new Guid("aaabcaaa-bebb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Floor Item", description = "Floor Item", room = context.Rooms.First(x => x.name == "HE 327") },
                new Cabinet() { tuid = new Guid("aafcaaaa-ebbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Floor Item", description = "Floor Item", room = context.Rooms.First(x => x.name == "HE 400") },
                new Cabinet() { tuid = new Guid("aaabcaaa-dbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Floor Item", description = "Floor Item", room = context.Rooms.First(x => x.name == "HE 402") },
                new Cabinet() { tuid = new Guid("aafcaaaa-cbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Floor Item", description = "Floor Item", room = context.Rooms.First(x => x.name == "HE 515") },
                new Cabinet() { tuid = new Guid("aaabcaaa-abbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Floor Item", description = "Floor Item", room = context.Rooms.First(x => x.name == "HE 516") }
            );

            //Create mock commodity data in the Commodities table
            context.Commodites.AddOrUpdate(
                new Commodity() { tuid = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "Non-Latex Gloves", description = "Non-Latex Gloves", alert_quantity = 50, category = context.Categories.First(x => x.name == "PPE") },
                new Commodity() { tuid = new Guid("abaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "Cotton Balls", description = "Cotton Balls", alert_quantity = 50, category = context.Categories.First(x => x.name == "Consumable") },
                new Commodity() { tuid = new Guid("acaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "Sterile Alchohol Prep Pad", description = "Sertile Alchohol Prep Pads", alert_quantity = 50, category = context.Categories.First(x => x.name == "Consumable") },
                new Commodity() { tuid = new Guid("adaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "Hypodermic Needles", description = "Hypodermic Needles", alert_quantity = 50, category = context.Categories.First(x => x.name == "Consumable") },
                new Commodity() { tuid = new Guid("aeaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "Lock Syringes", description = "Lock Syringes", alert_quantity = 50, category = context.Categories.First(x => x.name == "Consumable") },
                new Commodity() { tuid = new Guid("afaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "CPR Manikin and AED Kit", description = "CPR Manikin and AED Kit", alert_quantity = 1, category = context.Categories.First(x => x.name == "Asset") },
                new Commodity() { tuid = new Guid("abbaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "IV Training Arm", description = "IV Training Arm", alert_quantity = 1, category = context.Categories.First(x => x.name == "Asset") },
                new Commodity() { tuid = new Guid("abcaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "OLED Fingertip Pulse Oximeter", description = "OLED Fingertip Pulse Oximeter", alert_quantity = 1, category = context.Categories.First(x => x.name == "Asset") },
                new Commodity() { tuid = new Guid("abdaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "MedVision Adult Patient Simulator", description = "MedVision Adult Patient Simulator", alert_quantity = 1, category = context.Categories.First(x => x.name == "High Fidelity Simulator") },
                new Commodity() { tuid = new Guid("abeaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "MedVision Pediatric Patient Simulator", description = "MedVision Pediatric Patient Simulator", alert_quantity = 1, category = context.Categories.First(x => x.name == "High Fidelity Simulator") },
                new Commodity() { tuid = new Guid("abfaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "MedVision Infant Patient Simulator", description = "MedVision Infant Patient Simulator", alert_quantity = 1, category = context.Categories.First(x => x.name == "High Fidelity Simulator") },
                new Commodity() { tuid = new Guid("acbaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "Venturi Oxygen Mask", description = "Venturi Oxygen Mask", alert_quantity = 1, category = context.Categories.First(x => x.name == "Asset") },
                new Commodity() { tuid = new Guid("accaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "Medline Nonskid Polypropylene Shoe Covers", description = "Medline Nonskid Polypropylene Shoe Covers", alert_quantity = 50, category = context.Categories.First(x => x.name == "PPE") },
                new Commodity() { tuid = new Guid("acdaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "Lightweight Polypropylene Isolation Gowns", description = "Lightweight Polypropylene Isolation Gowns", alert_quantity = 15, category = context.Categories.First(x => x.name == "PPE") },
                new Commodity() { tuid = new Guid("aceaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "N95 Particulate Respiratory and Surgical Mask", description = "N95 Particulate Respiratory and Surgical Mask", alert_quantity = 60, category = context.Categories.First(x => x.name == "PPE") },
                new Commodity() { tuid = new Guid("acfaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "Manual Exam Table", description = "Manual Exam Table", alert_quantity = 1, category = context.Categories.First(x => x.name == "Asset") }
                );

            //Create mock quantity data in the Quantities table
            context.Quantities.AddOrUpdate(
                new Quantity() { tuid = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), quantity = 300, cabinet = context.Cabinets.First(x => x.name == "Cabinet 1" && x.room.name == "HE 110"), commodity = context.Commodites.First(x => x.name == "Non-Latex Gloves"), nlevel = context.NLevels.First(x => x.name == "1") },
                new Quantity() { tuid = new Guid("baaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), quantity = 500, cabinet = context.Cabinets.First(x => x.name == "Cabinet 3" && x.room.name == "HE 111"), commodity = context.Commodites.First(x => x.name == "Cotton Balls"), nlevel = context.NLevels.First(x => x.name == "1") },
                new Quantity() { tuid = new Guid("caaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), quantity = 500, cabinet = context.Cabinets.First(x => x.name == "Cabinet 3" && x.room.name == "HE 110"), commodity = context.Commodites.First(x => x.name == "Sterile Alchohol Prep Pad"), nlevel = context.NLevels.First(x => x.name == "1") },
                new Quantity() { tuid = new Guid("daaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), quantity = 80, cabinet = context.Cabinets.First(x => x.name == "Cabinet 4" && x.room.name == "HE 230"), commodity = context.Commodites.First(x => x.name == "Hypodermic Needles"), nlevel = context.NLevels.First(x => x.name == "2") },
                new Quantity() { tuid = new Guid("eaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), quantity = 80, cabinet = context.Cabinets.First(x => x.name == "Cabinet 2" && x.room.name == "HE 240"), commodity = context.Commodites.First(x => x.name == "Lock Syringes"), nlevel = context.NLevels.First(x => x.name == "2") },
                new Quantity() { tuid = new Guid("faaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), quantity = 2, cabinet = context.Cabinets.First(x => x.name == "Cabinet 6" && x.room.name == "HE 110"), commodity = context.Commodites.First(x => x.name == "CPR Manikin And AED Kit"), nlevel = context.NLevels.First(x => x.name == "1") },
                new Quantity() { tuid = new Guid("abaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), quantity = 4, cabinet = context.Cabinets.First(x => x.name == "Cabinet 1" && x.room.name == "HE 314"), commodity = context.Commodites.First(x => x.name == "IV Training Arm"), nlevel = context.NLevels.First(x => x.name == "3") },
                new Quantity() { tuid = new Guid("acaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), quantity = 5, cabinet = context.Cabinets.First(x => x.name == "Cabinet 6" && x.room.name == "HE 327"), commodity = context.Commodites.First(x => x.name == "OLED Fingertip Pulse Oximeter"), nlevel = context.NLevels.First(x => x.name == "3") },
                new Quantity() { tuid = new Guid("adaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), quantity = 3, cabinet = context.Cabinets.First(x => x.name == "Floor Item" && x.room.name == "HE 400"), commodity = context.Commodites.First(x => x.name == "MedVision Adult Patient Simulator"), nlevel = context.NLevels.First(x => x.name == "4") },
                new Quantity() { tuid = new Guid("aeaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), quantity = 3, cabinet = context.Cabinets.First(x => x.name == "Floor Item" && x.room.name == "HE 515"), commodity = context.Commodites.First(x => x.name == "MedVision Pediatric Patient Simulator"), nlevel = context.NLevels.First(x => x.name == "5") },
                new Quantity() { tuid = new Guid("afaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), quantity = 3, cabinet = context.Cabinets.First(x => x.name == "Floor Item" && x.room.name == "HE 516"), commodity = context.Commodites.First(x => x.name == "MedVision Infant Patient Simulator"), nlevel = context.NLevels.First(x => x.name == "5") },
                new Quantity() { tuid = new Guid("aabaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), quantity = 200, cabinet = context.Cabinets.First(x => x.name == "Cabinet 2" && x.room.name == "HE 327"), commodity = context.Commodites.First(x => x.name == "Venturi Oxygen Mask"), nlevel = context.NLevels.First(x => x.name == "3") },
                new Quantity() { tuid = new Guid("aacaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), quantity = 75, cabinet = context.Cabinets.First(x => x.name == "Cabinet 2" && x.room.name == "HE 111"), commodity = context.Commodites.First(x => x.name == "Medline Nonskid Polypropylene Shoe Covers"), nlevel = context.NLevels.First(x => x.name == "1") },
                new Quantity() { tuid = new Guid("aadaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), quantity = 200, cabinet = context.Cabinets.First(x => x.name == "Cabinet 3" && x.room.name == "HE 111"), commodity = context.Commodites.First(x => x.name == "Lightweight Polypropylene Isolation Gowns"), nlevel = context.NLevels.First(x => x.name == "1") },
                new Quantity() { tuid = new Guid("aaeaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), quantity = 300, cabinet = context.Cabinets.First(x => x.name == "Cabinet 5" && x.room.name == "HE 110"), commodity = context.Commodites.First(x => x.name == "N95 Particulate Respiratory and Surgical Mask"), nlevel = context.NLevels.First(x => x.name == "1") },
                new Quantity() { tuid = new Guid("aafaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), quantity = 3, cabinet = context.Cabinets.First(x => x.name == "Floor Item" && x.room.name == "HE 516"), commodity = context.Commodites.First(x => x.name == "Manual Exam Table"), nlevel = context.NLevels.First(x => x.name == "NP") }
                );

            //Create mock vendoritems data in the VendorItems table
            context.VendorItems.AddOrUpdate(
                new VendorItem() { tuid = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), costInCents = 25, commodity = context.Commodites.First(x => x.name == "Non-Latex Gloves"), vendor = context.Vendors.First(x => x.name == "Medline") },
                new VendorItem() { tuid = new Guid("baaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), costInCents = 25, commodity = context.Commodites.First(x => x.name == "Cotton Balls"), vendor = context.Vendors.First(x => x.name == "Medline") },
                new VendorItem() { tuid = new Guid("caaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), costInCents = 40, commodity = context.Commodites.First(x => x.name == "Sterile Alchohol Prep Pad"), vendor = context.Vendors.First(x => x.name == "Medline") },
                new VendorItem() { tuid = new Guid("daaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), costInCents = 75, commodity = context.Commodites.First(x => x.name == "Hypodermic Needles"), vendor = context.Vendors.First(x => x.name == "Medline") },
                new VendorItem() { tuid = new Guid("eaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), costInCents = 75, commodity = context.Commodites.First(x => x.name == "Lock Syringes"), vendor = context.Vendors.First(x => x.name == "Medline") },
                new VendorItem() { tuid = new Guid("faaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), costInCents = 900, commodity = context.Commodites.First(x => x.name == "CPR Manikin And AED Kit"), vendor = context.Vendors.First(x => x.name == "Medline") },
                new VendorItem() { tuid = new Guid("abaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), costInCents = 600, commodity = context.Commodites.First(x => x.name == "IV Training Arm"), vendor = context.Vendors.First(x => x.name == "Medline") },
                new VendorItem() { tuid = new Guid("acaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), costInCents = 150, commodity = context.Commodites.First(x => x.name == "OLED Fingertip Pulse Oximeter"), vendor = context.Vendors.First(x => x.name == "Medline") },
                new VendorItem() { tuid = new Guid("adaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), costInCents = 8000, commodity = context.Commodites.First(x => x.name == "MedVision Adult Patient Simulator"), vendor = context.Vendors.First(x => x.name == "GTSimulators") },
                new VendorItem() { tuid = new Guid("aeaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), costInCents = 7500, commodity = context.Commodites.First(x => x.name == "MedVision Pediatric Patient Simulator"), vendor = context.Vendors.First(x => x.name == "GTSimulators") },
                new VendorItem() { tuid = new Guid("afaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), costInCents = 6000, commodity = context.Commodites.First(x => x.name == "MedVision Infant Patient Simulator"), vendor = context.Vendors.First(x => x.name == "GTSimulators") },
                new VendorItem() { tuid = new Guid("aabaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), costInCents = 40, commodity = context.Commodites.First(x => x.name == "Venturi Oxygen Mask"), vendor = context.Vendors.First(x => x.name == "Medline") },
                new VendorItem() { tuid = new Guid("aacaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), costInCents = 40, commodity = context.Commodites.First(x => x.name == "Medline Nonskid Polypropylene Shoe Covers"), vendor = context.Vendors.First(x => x.name == "Medline") },
                new VendorItem() { tuid = new Guid("aadaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), costInCents = 40, commodity = context.Commodites.First(x => x.name == "Lightweight Polypropylene Isolation Gowns"), vendor = context.Vendors.First(x => x.name == "Medline") },
                new VendorItem() { tuid = new Guid("aaeaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), costInCents = 30, commodity = context.Commodites.First(x => x.name == "N95 Particulate Respiratory and Surgical Mask"), vendor = context.Vendors.First(x => x.name == "Medline") },
                new VendorItem() { tuid = new Guid("aafaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), costInCents = 15000, commodity = context.Commodites.First(x => x.name == "Manual Exam Table"), vendor = context.Vendors.First(x => x.name == "Medline") }
                );

            //Create mock logs data in the Logs table
            context.Logs.AddOrUpdate(
                new Log() { tuid = new Guid("bbbbbbbb-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), action = "Add Item", timestamp = "", notes = "Added 250 gloves", quantityChange = 250, commodity = context.Commodites.First(x => x.name == "Non-Latex Gloves"), user = context.Users.First(x => x.svsu_id == "500010") },
                new Log() { tuid = new Guid("cccccccc-cccc-cccc-cccc-cccccccccccd"), action = "Consumed Item", timestamp = "", notes = "Consumed 5 alchohol prep pads", quantityChange = 5, commodity = context.Commodites.First(x => x.name == "Sterile Alchohol Prep Pad"), user = context.Users.First(x => x.svsu_id == "500006") },
                new Log() { tuid = new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"), action = "Checked Out Simulator", timestamp = "", notes = "Checked out MedVision Adult Patient Simulator", quantityChange = 1, commodity = context.Commodites.First(x => x.name == "MedVision Adult Patient Simulator"), user = context.Users.First(x => x.svsu_id == "500003") }

                );




        }
    }
}
