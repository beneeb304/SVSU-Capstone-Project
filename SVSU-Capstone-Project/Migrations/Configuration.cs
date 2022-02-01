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

            //Create mock user data in the Users table
            context.Users.AddOrUpdate(
            new User() { tuid = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), svsu_id = "500001", first_name = "Alexander", last_name = "Buckstiegel", email = "awbuckst@svsu.edu", password = "Capstone424", isAdmin = true },
            new User() { tuid = new Guid("baaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), svsu_id = "500002", first_name = "Ann", last_name = "Krause", email = "aekrause@svsu.edu", password = "Capstone424", isAdmin = true },
            new User() { tuid = new Guid("caaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), svsu_id = "500003", first_name = "Ariel", last_name = "Taylor", email = "aataylo3@svsu.edu", password = "Capstone424", isAdmin = true },
            new User() { tuid = new Guid("daaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), svsu_id = "500004", first_name = "Benjamin", last_name = "Neeb", email = "brneeb@svsu.edu", password = "Capstone424", isAdmin = true },
            new User() { tuid = new Guid("eaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), svsu_id = "500005", first_name = "Brett", last_name = "Previdi", email = "bcprevid@svsu.edu", password = "Capstone424", isAdmin = true },
            new User() { tuid = new Guid("faaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), svsu_id = "500006", first_name = "Devin", last_name = "Campbell", email = "dscampbe@svsu.edu", password = "Capstone424", isAdmin = true },
            new User() { tuid = new Guid("gaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), svsu_id = "500007", first_name = "Durrell", last_name = "Pigee", email = "depigee@svsu.edu", password = "Capstone424", isAdmin = true },
            new User() { tuid = new Guid("haaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), svsu_id = "500008", first_name = "Hunter", last_name = "Clipper", email = "hmclippe@svsu.edu", password = "Capstone424", isAdmin = true },
            new User() { tuid = new Guid("iaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), svsu_id = "500009", first_name = "James", last_name = "Hax", email = "jhax@svsu.edu", password = "Capstone424", isAdmin = true },
            new User() { tuid = new Guid("jaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), svsu_id = "500010", first_name = "Lamar", last_name = "Scott", email = "ldscott2@svsu.edu", password = "Capstone424", isAdmin = true },
            new User() { tuid = new Guid("kaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), svsu_id = "500011", first_name = "Maxwell", last_name = "Grevais", email = "mtgrevai@svsu.edu", password = "Capstone424", isAdmin = true },
            new User() { tuid = new Guid("laaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), svsu_id = "500012", first_name = "Michael", last_name = "Cardinalli", email = "macardin@svsu.edu", password = "Capstone424", isAdmin = true },
            new User() { tuid = new Guid("maaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), svsu_id = "500013", first_name = "Michael", last_name = "Simon", email = "mjsimon1@svsu.edu", password = "Capstone424", isAdmin = true },
            new User() { tuid = new Guid("naaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), svsu_id = "500014", first_name = "Omar", last_name = "Salih", email = "osalih@svsu.edu", password = "Capstone424", isAdmin = true },
            new User() { tuid = new Guid("oaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), svsu_id = "000001", first_name = "Scott", last_name = "James", email = "james@svsu.edu", password = "Capstone424", isAdmin = true },
            new User() { tuid = new Guid("paaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), svsu_id = "500016", first_name = "Taylor", last_name = "Debolt", email = "tsdebolt@svsu.edu", password = "Capstone424", isAdmin = true },
            new User() { tuid = new Guid("qaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), svsu_id = "500017", first_name = "Trevor", last_name = "Eurich", email = "taeurich@svsu.edu", password = "Capstone424", isAdmin = true }
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
                new Vendor() { tuid = new Guid("eaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "Walgreens", description = "www.walgreens.com" },
                new Vendor() { tuid = new Guid("faaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "Walmart", description = "www.walmart.com" },
                new Vendor() { tuid = new Guid("gaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "GTSimulators", description = "gtsimulators.com" },
                new Vendor() { tuid = new Guid("haaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "Medline", description = "medline.com" }

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
                    new Room() { tuid = new Guid("ggaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "HE 110", description = "HE 110 Description" },
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
                new Cabinet() { tuid = new Guid("aabbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 1", description = "Cabinet 1", room = context.Rooms.First(x => x.name == "HE 110") },
                new Cabinet() { tuid = new Guid("aacccbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 1", description = "Cabinet 1", room = context.Rooms.First(x => x.name == "HE 111") },
                new Cabinet() { tuid = new Guid("aadddbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 2", description = "Cabinet 2", room = context.Rooms.First(x => x.name == "HE 110") },
                new Cabinet() { tuid = new Guid("aaeeebbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 2", description = "Cabinet 2", room = context.Rooms.First(x => x.name == "HE 111") },
                new Cabinet() { tuid = new Guid("aafffbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 3", description = "Cabinet 3", room = context.Rooms.First(x => x.name == "HE 110") },
                new Cabinet() { tuid = new Guid("aahhhbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 3", description = "Cabinet 3", room = context.Rooms.First(x => x.name == "HE 111") },
                new Cabinet() { tuid = new Guid("aaiiibbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 4", description = "Cabinet 4", room = context.Rooms.First(x => x.name == "HE 110") },
                new Cabinet() { tuid = new Guid("aajjjbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 4", description = "Cabinet 4", room = context.Rooms.First(x => x.name == "HE 111") },
                new Cabinet() { tuid = new Guid("aakkkbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 5", description = "Cabinet 5", room = context.Rooms.First(x => x.name == "HE 110") },
                new Cabinet() { tuid = new Guid("aalllbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 5", description = "Cabinet 5", room = context.Rooms.First(x => x.name == "HE 111") },
                new Cabinet() { tuid = new Guid("aammmbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 6", description = "Cabinet 6", room = context.Rooms.First(x => x.name == "HE 110") },
                new Cabinet() { tuid = new Guid("aannnbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 6", description = "Cabinet 6", room = context.Rooms.First(x => x.name == "HE 111") },
                new Cabinet() { tuid = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 1", description = "Cabinet 1", room = context.Rooms.First(x => x.name == "HE 230") },
                new Cabinet() { tuid = new Guid("bbcccbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 1", description = "Cabinet 1", room = context.Rooms.First(x => x.name == "HE 240") },
                new Cabinet() { tuid = new Guid("bbdddbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 2", description = "Cabinet 2", room = context.Rooms.First(x => x.name == "HE 230") },
                new Cabinet() { tuid = new Guid("bbeeebbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 2", description = "Cabinet 2", room = context.Rooms.First(x => x.name == "HE 240") },
                new Cabinet() { tuid = new Guid("bbfffbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 3", description = "Cabinet 3", room = context.Rooms.First(x => x.name == "HE 230") },
                new Cabinet() { tuid = new Guid("bbhhhbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 3", description = "Cabinet 3", room = context.Rooms.First(x => x.name == "HE 240") },
                new Cabinet() { tuid = new Guid("bbiiibbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 4", description = "Cabinet 4", room = context.Rooms.First(x => x.name == "HE 230") },
                new Cabinet() { tuid = new Guid("bbjjjbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 4", description = "Cabinet 4", room = context.Rooms.First(x => x.name == "HE 240") },
                new Cabinet() { tuid = new Guid("bbkkkbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 5", description = "Cabinet 5", room = context.Rooms.First(x => x.name == "HE 230") },
                new Cabinet() { tuid = new Guid("bblllbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 5", description = "Cabinet 5", room = context.Rooms.First(x => x.name == "HE 240") },
                new Cabinet() { tuid = new Guid("bbmmmbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 6", description = "Cabinet 6", room = context.Rooms.First(x => x.name == "HE 230") },
                new Cabinet() { tuid = new Guid("bbnnnbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 6", description = "Cabinet 6", room = context.Rooms.First(x => x.name == "HE 240") },
                new Cabinet() { tuid = new Guid("ccbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 1", description = "Cabinet 1", room = context.Rooms.First(x => x.name == "HE 314") },
                new Cabinet() { tuid = new Guid("cccccbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 1", description = "Cabinet 1", room = context.Rooms.First(x => x.name == "HE 327") },
                new Cabinet() { tuid = new Guid("ccdddbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 2", description = "Cabinet 2", room = context.Rooms.First(x => x.name == "HE 314") },
                new Cabinet() { tuid = new Guid("cceeebbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 2", description = "Cabinet 2", room = context.Rooms.First(x => x.name == "HE 327") },
                new Cabinet() { tuid = new Guid("ccfffbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 3", description = "Cabinet 3", room = context.Rooms.First(x => x.name == "HE 314") },
                new Cabinet() { tuid = new Guid("cchhhbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 3", description = "Cabinet 3", room = context.Rooms.First(x => x.name == "HE 327") },
                new Cabinet() { tuid = new Guid("cciiibbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 4", description = "Cabinet 4", room = context.Rooms.First(x => x.name == "HE 314") },
                new Cabinet() { tuid = new Guid("ccjjjbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 4", description = "Cabinet 4", room = context.Rooms.First(x => x.name == "HE 327") },
                new Cabinet() { tuid = new Guid("cckkkbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 5", description = "Cabinet 5", room = context.Rooms.First(x => x.name == "HE 314") },
                new Cabinet() { tuid = new Guid("cclllbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 5", description = "Cabinet 5", room = context.Rooms.First(x => x.name == "HE 327") },
                new Cabinet() { tuid = new Guid("ccmmmbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 6", description = "Cabinet 6", room = context.Rooms.First(x => x.name == "HE 314") },
                new Cabinet() { tuid = new Guid("ccnnnbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 6", description = "Cabinet 6", room = context.Rooms.First(x => x.name == "HE 327") },
                new Cabinet() { tuid = new Guid("ddbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 1", description = "Cabinet 1", room = context.Rooms.First(x => x.name == "HE 400") },
                new Cabinet() { tuid = new Guid("ddcccbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 1", description = "Cabinet 1", room = context.Rooms.First(x => x.name == "HE 402") },
                new Cabinet() { tuid = new Guid("dddddbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 2", description = "Cabinet 2", room = context.Rooms.First(x => x.name == "HE 400") },
                new Cabinet() { tuid = new Guid("ddeeebbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 2", description = "Cabinet 2", room = context.Rooms.First(x => x.name == "HE 402") },
                new Cabinet() { tuid = new Guid("ddfffbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 3", description = "Cabinet 3", room = context.Rooms.First(x => x.name == "HE 400") },
                new Cabinet() { tuid = new Guid("ddhhhbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 3", description = "Cabinet 3", room = context.Rooms.First(x => x.name == "HE 402") },
                new Cabinet() { tuid = new Guid("ddiiibbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 4", description = "Cabinet 4", room = context.Rooms.First(x => x.name == "HE 400") },
                new Cabinet() { tuid = new Guid("ddjjjbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 4", description = "Cabinet 4", room = context.Rooms.First(x => x.name == "HE 402") },
                new Cabinet() { tuid = new Guid("ddkkkbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 5", description = "Cabinet 5", room = context.Rooms.First(x => x.name == "HE 400") },
                new Cabinet() { tuid = new Guid("ddlllbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 5", description = "Cabinet 5", room = context.Rooms.First(x => x.name == "HE 402") },
                new Cabinet() { tuid = new Guid("ddmmmbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 6", description = "Cabinet 6", room = context.Rooms.First(x => x.name == "HE 400") },
                new Cabinet() { tuid = new Guid("ddnnnbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 6", description = "Cabinet 6", room = context.Rooms.First(x => x.name == "HE 402") },
                new Cabinet() { tuid = new Guid("eebbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 1", description = "Cabinet 1", room = context.Rooms.First(x => x.name == "HE 515") },
                new Cabinet() { tuid = new Guid("eecccbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 1", description = "Cabinet 1", room = context.Rooms.First(x => x.name == "HE 516") },
                new Cabinet() { tuid = new Guid("eedddbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 2", description = "Cabinet 2", room = context.Rooms.First(x => x.name == "HE 515") },
                new Cabinet() { tuid = new Guid("eeeeebbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 2", description = "Cabinet 2", room = context.Rooms.First(x => x.name == "HE 516") },
                new Cabinet() { tuid = new Guid("eefffbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 3", description = "Cabinet 3", room = context.Rooms.First(x => x.name == "HE 515") },
                new Cabinet() { tuid = new Guid("eehhhbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 3", description = "Cabinet 3", room = context.Rooms.First(x => x.name == "HE 516") },
                new Cabinet() { tuid = new Guid("eeiiibbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 4", description = "Cabinet 4", room = context.Rooms.First(x => x.name == "HE 515") },
                new Cabinet() { tuid = new Guid("eejjjbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 4", description = "Cabinet 4", room = context.Rooms.First(x => x.name == "HE 516") },
                new Cabinet() { tuid = new Guid("eekkkbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 5", description = "Cabinet 5", room = context.Rooms.First(x => x.name == "HE 515") },
                new Cabinet() { tuid = new Guid("eelllbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 5", description = "Cabinet 5", room = context.Rooms.First(x => x.name == "HE 516") },
                new Cabinet() { tuid = new Guid("eemmmbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 6", description = "Cabinet 6", room = context.Rooms.First(x => x.name == "HE 515") },
                new Cabinet() { tuid = new Guid("eennnbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), name = "Cabinet 6", description = "Cabinet 6", room = context.Rooms.First(x => x.name == "HE 516") }
            );

            //Create mock commodity data in the Commodities table
            context.Commodites.AddOrUpdate(
                new Commodity() { tuid = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "Non-Latex Gloves", description = "Non-Latex Gloves", alert_quantity = 50, category = context.Categories.First(x => x.name == "PPE") },
                new Commodity() { tuid = new Guid("abaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "Cotton Balls", description = "Cotton Balls", alert_quantity = 50, category = context.Categories.First(x => x.name == "Consumable") },
                new Commodity() { tuid = new Guid("acaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "Sterile Alchohol Prep Pad", description = "Sertile Alchohol Prep Pads", alert_quantity = 50, category = context.Categories.First(x => x.name == "Consumable") },
                new Commodity() { tuid = new Guid("adaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "Hypodermic Needles", description = "Hypodermic Needles", alert_quantity = 50, category = context.Categories.First(x => x.name == "Consumable") },
                new Commodity() { tuid = new Guid("aeaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "Lock Syringes", description = "Lock Syringes", alert_quantity = 50, category = context.Categories.First(x => x.name == "Consumable") },
                new Commodity() { tuid = new Guid("afaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "CPR Manikin and AED Kit", description = "CPR Manikin and AED Kit", alert_quantity = 1, category = context.Categories.First(x => x.name == "Asset") },
                new Commodity() { tuid = new Guid("agaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "IV Training Arm", description = "IV Training Arm", alert_quantity = 1, category = context.Categories.First(x => x.name == "Asset") },
                new Commodity() { tuid = new Guid("akaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "OLED Fingertip Pulse Oximeter", description = "OLED Fingertip Pulse Oximeter", alert_quantity = 1, category = context.Categories.First(x => x.name == "Asset") },
                new Commodity() { tuid = new Guid("ahaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "MedVision Adult Patient Simulator", description = "MedVision Adult Patient Simulator", alert_quantity = 1, category = context.Categories.First(x => x.name == "High Fidelity Simulator") },
                new Commodity() { tuid = new Guid("aiaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "MedVision Pediatric Patient Simulator", description = "MedVision Pediatric Patient Simulator", alert_quantity = 1, category = context.Categories.First(x => x.name == "High Fidelity Simulator") },
                new Commodity() { tuid = new Guid("ajaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "MedVision Infant Patient Simulator", description = "MedVision Infant Patient Simulator", alert_quantity = 1, category = context.Categories.First(x => x.name == "High Fidelity Simulator") },
                new Commodity() { tuid = new Guid("alaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "Venturi Oxygen Mask", description = "Venturi Oxygen Mask", alert_quantity = 1, category = context.Categories.First(x => x.name == "Asset") },
                new Commodity() { tuid = new Guid("amaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "Medline Nonskid Polypropylene Shoe Covers", description = "Medline Nonskid Polypropylene Shoe Covers", alert_quantity = 50, category = context.Categories.First(x => x.name == "PPE") },
                new Commodity() { tuid = new Guid("anaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "Lightweight Polypropylene Isolation Gowns", description = "Lightweight Polypropylene Isolation Gowns", alert_quantity = 15, category = context.Categories.First(x => x.name == "PPE") },
                new Commodity() { tuid = new Guid("afaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "N95 Particulate Respiratory and Surgical Mask", description = "N95 Particulate Respiratory and Surgical Mask", alert_quantity = 60, category = context.Categories.First(x => x.name == "PPE") },
                new Commodity() { tuid = new Guid("afaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), name = "Manual Exam Table", description = "Manual Exam Table", alert_quantity = 1, category = context.Categories.First(x => x.name == "Asset") }
                );

            //Create mock quantity data in the Quantities table
            //context.Quantities.AddOrUpdate(
            //    new Quantity() { tuid = new Guid("tttttttt-tttt-tttt-tttt-tttttttttttt"), quantity = 250, cabinet = context.Cabinets.First(x => x.name == "Cabinet 1"), commodity = context.Commodites.First(x => x.name == "Non-Latex Gloves"), nlevel = context.NLevels.First(x => x.name == "1")},
            //    new Quantity() { tuid = new Guid("sstttttt-tttt-tttt-tttt-tttttttttttt"), quantity = 200, cabinet = context.Cabinets.First(x => x.name == "Cabinet 1"), commodity = context.Commodites.First(x => x.name == "Cotton Balls"), nlevel = context.NLevels.First(x => x.name == "1")},
            //    new Quantity() { tuid = new Guid("rrtttttt-tttt-tttt-tttt-tttttttttttt"), quantity = 100, cabinet = context.Cabinets.First(x => x.name == "Cabinet 1"), commodity = context.Commodites.First(x => x.name == "Sterile Alchohol Prep Pad"), nlevel = context.NLevels.First(x => x.name == "1")},
            //    new Quantity() { tuid = new Guid("jjtttttt-tttt-tttt-tttt-tttttttttttt"), quantity = 100, cabinet = context.Cabinets.First(x => x.name == "Cabinet 1"), commodity = context.Commodites.First(x => x.name == "Hypodermic Needles"), nlevel = context.NLevels.First(x => x.name == "2")},
            //    new Quantity() { tuid = new Guid("eetttttt-tttt-tttt-tttt-tttttttttttt"), quantity = 100, cabinet = context.Cabinets.First(x => x.name == "Cabinet 1"), commodity = context.Commodites.First(x => x.name == "Lock Syringes"), nlevel = context.NLevels.First(x => x.name == "2")},
            //    new Quantity() { tuid = new Guid("qqtttttt-tttt-tttt-tttt-tttttttttttt"), quantity = 100, cabinet = context.Cabinets.First(x => x.name == "Cabinet 1"), commodity = context.Commodites.First(x => x.name == "CPR Manikin And AED Kit"), nlevel = context.NLevels.First(x => x.name == "1")},
            //    new Quantity() { tuid = new Guid("jjtttttt-tttt-tttt-tttt-tttttttttttt"), quantity = 100, cabinet = context.Cabinets.First(x => x.name == "Cabinet 1"), commodity = context.Commodites.First(x => x.name == "IV Training Arm"), nlevel = context.NLevels.First(x => x.name == "3")},
            //    new Quantity() { tuid = new Guid("jhtttttt-tttt-tttt-tttt-tttttttttttt"), quantity = 100, cabinet = context.Cabinets.First(x => x.name == "Cabinet 1"), commodity = context.Commodites.First(x => x.name == "OLED Fingertip Pulse Oximeter"), nlevel = context.NLevels.First(x => x.name == "3")},
            //    new Quantity() { tuid = new Guid("rytttttt-tttt-tttt-tttt-tttttttttttt"), quantity = 100, cabinet = context.Cabinets.First(x => x.name == "Cabinet 1"), commodity = context.Commodites.First(x => x.name == "MedVision Adult Patient Simulator"), nlevel = context.NLevels.First(x => x.name == "4")},
            //    new Quantity() { tuid = new Guid("astttttt-tttt-tttt-tttt-tttttttttttt"), quantity = 100, cabinet = context.Cabinets.First(x => x.name == "Cabinet 1"), commodity = context.Commodites.First(x => x.name == "MedVision Pediatric Patient Simulator"), nlevel = context.NLevels.First(x => x.name == "5")},
            //    new Quantity() { tuid = new Guid("wwtttttt-tttt-tttt-tttt-tttttttttttt"), quantity = 100, cabinet = context.Cabinets.First(x => x.name == "Cabinet 1"), commodity = context.Commodites.First(x => x.name == "MedVision Infant Patient Simulator"), nlevel = context.NLevels.First(x => x.name == "5")},
            //    new Quantity() { tuid = new Guid("rytttttt-tttt-tttt-tttt-tttttttttttt"), quantity = 100, cabinet = context.Cabinets.First(x => x.name == "Cabinet 1"), commodity = context.Commodites.First(x => x.name == "Venturi Oxygen Mask"), nlevel = context.NLevels.First(x => x.name == "3")},
            //    new Quantity() { tuid = new Guid("astttttt-tttt-tttt-tttt-tttttttttttt"), quantity = 100, cabinet = context.Cabinets.First(x => x.name == "Cabinet 1"), commodity = context.Commodites.First(x => x.name == "Medline Nonskid Polypropylene Shoe Covers"), nlevel = context.NLevels.First(x => x.name == "1")},
            //    new Quantity() { tuid = new Guid("wwtttttt-tttt-tttt-tttt-tttttttttttt"), quantity = 100, cabinet = context.Cabinets.First(x => x.name == "Cabinet 1"), commodity = context.Commodites.First(x => x.name == "Lightweight Polypropylene Isolation Gowns"), nlevel = context.NLevels.First(x => x.name == "1")},
            //    new Quantity() { tuid = new Guid("rytttttt-tttt-tttt-tttt-tttttttttttt"), quantity = 100, cabinet = context.Cabinets.First(x => x.name == "Cabinet 1"), commodity = context.Commodites.First(x => x.name == "N95 Particulate Respiratory and Surgical Mask"), nlevel = context.NLevels.First(x => x.name == "1")},
            //    new Quantity() { tuid = new Guid("astttttt-tttt-tttt-tttt-tttttttttttt"), quantity = 100, cabinet = context.Cabinets.First(x => x.name == "Cabinet 1"), commodity = context.Commodites.First(x => x.name == "Manual Exam Table"), nlevel = context.NLevels.First(x => x.name == "NP")}
            //    );

            //Create mock vendoritems data in the VendorItems table
            context.VendorItems.AddOrUpdate(
                new VendorItem() { tuid = new Guid("tttttttt-tttt-tttt-tttt-tttatttttttt"), costInCents = 25, commodity = context.Commodites.First(x => x.name == "Non-Latex Gloves"), vendor = context.Vendors.First(x => x.name == "Medline") },
                new VendorItem() { tuid = new Guid("sstttttt-tttt-tttt-tttt-tttbtttttttt"), costInCents = 25, commodity = context.Commodites.First(x => x.name == "Cotton Balls"), vendor = context.Vendors.First(x => x.name == "MedLine") },
                new VendorItem() { tuid = new Guid("rrtttttt-tttt-tttt-tttt-tttctttttttt"), costInCents = 40, commodity = context.Commodites.First(x => x.name == "Sterile Alchohol Prep Pad"), vendor = context.Vendors.First(x => x.name == "Medline") },
                new VendorItem() { tuid = new Guid("jjtttttt-tttt-tttt-tttt-tttdtttttttt"), costInCents = 75, commodity = context.Commodites.First(x => x.name == "Hypodermic Needles"), vendor = context.Vendors.First(x => x.name == "Mednline") },
                new VendorItem() { tuid = new Guid("eetttttt-tttt-tttt-tttt-tttetttttttt"), costInCents = 75, commodity = context.Commodites.First(x => x.name == "Lock Syringes"), vendor = context.Vendors.First(x => x.name == "Medline") },
                new VendorItem() { tuid = new Guid("qqtttttt-tttt-tttt-tttt-tttftttttttt"), costInCents = 900, commodity = context.Commodites.First(x => x.name == "CPR Manikin And AED Kit"), vendor = context.Vendors.First(x => x.name == "Medline") },
                new VendorItem() { tuid = new Guid("jjtttttt-tttt-tttt-tttt-tttgtttttttt"), costInCents = 600, commodity = context.Commodites.First(x => x.name == "IV Training Arm"), vendor = context.Vendors.First(x => x.name == "Medline") },
                new VendorItem() { tuid = new Guid("jhtttttt-tttt-tttt-tttt-ttthtttttttt"), costInCents = 150, commodity = context.Commodites.First(x => x.name == "OLED Fingertip Pulse Oximeter"), vendor = context.Vendors.First(x => x.name == "Medline") },
                new VendorItem() { tuid = new Guid("rytttttt-tttt-tttt-tttt-tttitttttttt"), costInCents = 8000, commodity = context.Commodites.First(x => x.name == "MedVision Adult Patient Simulator"), vendor = context.Vendors.First(x => x.name == "GTSimulators") },
                new VendorItem() { tuid = new Guid("astttttt-tttt-tttt-tttt-tttjtttttttt"), costInCents = 7500, commodity = context.Commodites.First(x => x.name == "MedVision Pediatric Patient Simulator"), vendor = context.Vendors.First(x => x.name == "GTSimulators") },
                new VendorItem() { tuid = new Guid("wwtttttt-tttt-tttt-tttt-tttktttttttt"), costInCents = 6000, commodity = context.Commodites.First(x => x.name == "MedVision Infant Patient Simulator"), vendor = context.Vendors.First(x => x.name == "GTSimulators") },
                new VendorItem() { tuid = new Guid("rytttttt-tttt-tttt-tttt-tttltttttttt"), costInCents = 40, commodity = context.Commodites.First(x => x.name == "Venturi Oxygen Mask"), vendor = context.Vendors.First(x => x.name == "Medline") },
                new VendorItem() { tuid = new Guid("astttttt-tttt-tttt-tttt-tttmtttttttt"), costInCents = 40, commodity = context.Commodites.First(x => x.name == "Medline Nonskid Polypropylene Shoe Covers"), vendor = context.Vendors.First(x => x.name == "Medline") },
                new VendorItem() { tuid = new Guid("wwtttttt-tttt-tttt-tttt-tttntttttttt"), costInCents = 40, commodity = context.Commodites.First(x => x.name == "Lightweight Polypropylene Isolation Gowns"), vendor = context.Vendors.First(x => x.name == "Medline") },
                new VendorItem() { tuid = new Guid("rytttttt-tttt-tttt-tttt-tttotttttttt"), costInCents = 30, commodity = context.Commodites.First(x => x.name == "N95 Particulate Respiratory and Surgical Mask"), vendor = context.Vendors.First(x => x.name == "Medline") },
                new VendorItem() { tuid = new Guid("astttttt-tttt-tttt-tttt-tttptttttttt"), costInCents = 15000, commodity = context.Commodites.First(x => x.name == "Manual Exam Table"), vendor = context.Vendors.First(x => x.name == "Medline") }
                );

            //Create mock logs data in the Logs table
            context.Logs.AddOrUpdate(
                new Log() { tuid = new Guid("bbbbbbbb-aaaa-aaaa-aaaaaaaaaaaa"), action = "Add Item", timestamp = "", notes = "Added 250 gloves", quantityChange = 250, commodity = context.Commodites.First(x => x.name == "Non-Latex Gloves"), user = context.Users.First(x => x.svsu_id == "500010") },
                new Log() { tuid = new Guid("cccccccc-cccc-cccc-cccccccccccd"), action = "Consumed Item", timestamp = "", notes = "Consumed 5 alchohol prep pads", quantityChange = 5, commodity = context.Commodites.First(x => x.name == "Sterile Alchohol Prep Pad"), user = context.Users.First(x => x.svsu_id == "500006") },
                new Log() { tuid = new Guid("dddddddd-dddd-dddd-ddgddddddddd"), action = "Checked Out Simulator", timestamp = "", notes = "Checked out MedVision Adult Patient Simulator", quantityChange = 1, commodity = context.Commodites.First(x => x.name == "MedVision Adult Patient Simulator"), user = context.Users.First(x => x.svsu_id == "500003") }

                );




        }
    }
}
