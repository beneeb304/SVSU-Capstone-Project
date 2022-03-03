namespace SVSU_Capstone_Project.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using SVSU_Capstone_Project.Model;

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
            context.dsUsers.AddOrUpdate(
                new User() { uidTuid = new Guid("abaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strSvsu_id = "500001", strFirst_name = "Alexander", strLast_name = "Buckstiegel", strEmail = "awbuckst@svsu.edu", strPhone = "", strHash = "Capstone424", blnIsAdmin = true },
                new User() { uidTuid = new Guid("baaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strSvsu_id = "500002", strFirst_name = "Ann", strLast_name = "Krause", strEmail = "aekrause@svsu.edu", strPhone = "", strHash = "Capstone424", blnIsAdmin = true },
                new User() { uidTuid = new Guid("caaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strSvsu_id = "500003", strFirst_name = "Ariel", strLast_name = "Taylor", strEmail = "aataylo3@svsu.edu", strPhone = "", strHash = "Capstone424", blnIsAdmin = true },
                new User() { uidTuid = new Guid("daaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strSvsu_id = "500004", strFirst_name = "Benjamin", strLast_name = "Neeb", strEmail = "brneeb@svsu.edu", strPhone = "", strHash = "Capstone424", blnIsAdmin = true },
                new User() { uidTuid = new Guid("eaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strSvsu_id = "500005", strFirst_name = "Brett", strLast_name = "Previdi", strEmail = "bcprevid@svsu.edu", strPhone = "", strHash = "Capstone424", blnIsAdmin = true },
                new User() { uidTuid = new Guid("ddaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strSvsu_id = "500006", strFirst_name = "Devin", strLast_name = "Campbell", strEmail = "dscampbe@svsu.edu", strPhone = "", strHash = "Capstone424", blnIsAdmin = true },
                new User() { uidTuid = new Guid("fcfaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strSvsu_id = "500007", strFirst_name = "Durrell", strLast_name = "Pigee", strEmail = "depigee@svsu.edu", strPhone = "", strHash = "Capstone424", blnIsAdmin = true },
                new User() { uidTuid = new Guid("cfcaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strSvsu_id = "500008", strFirst_name = "Hunter", strLast_name = "Clipper", strEmail = "hmclippe@svsu.edu", strPhone = "", strHash = "Capstone424", blnIsAdmin = true },
                new User() { uidTuid = new Guid("fafaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strSvsu_id = "500009", strFirst_name = "James", strLast_name = "Hax", strEmail = "jhax@svsu.edu", strPhone = "", strHash = "Capstone424", blnIsAdmin = true },
                new User() { uidTuid = new Guid("fffaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strSvsu_id = "500010", strFirst_name = "Lamar", strLast_name = "Scott", strEmail = "ldscott2@svsu.edu", strPhone = "", strHash = "Capstone424", blnIsAdmin = true },
                new User() { uidTuid = new Guid("bbbaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strSvsu_id = "500011", strFirst_name = "Maxwell", strLast_name = "Grevais", strEmail = "mtgrevai@svsu.edu", strPhone = "", strHash = "Capstone424", blnIsAdmin = true },
                new User() { uidTuid = new Guid("cccaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strSvsu_id = "500012", strFirst_name = "Michael", strLast_name = "Cardinalli", strEmail = "macardin@svsu.edu", strPhone = "", strHash = "Capstone424", blnIsAdmin = true },
                new User() { uidTuid = new Guid("cbaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strSvsu_id = "500013", strFirst_name = "Michael", strLast_name = "Simon", strEmail = "mjsimon1@svsu.edu", strPhone = "", strHash = "Capstone424", blnIsAdmin = true },
                new User() { uidTuid = new Guid("bcaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strSvsu_id = "500014", strFirst_name = "Omar", strLast_name = "Salih", strEmail = "osalih@svsu.edu", strPhone = "", strHash = "Capstone424", blnIsAdmin = true },
                new User() { uidTuid = new Guid("ccaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strSvsu_id = "000001", strFirst_name = "Scott", strLast_name = "James", strEmail = "james@svsu.edu", strPhone = "", strHash = "Capstone424", blnIsAdmin = true },
                new User() { uidTuid = new Guid("bbaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strSvsu_id = "500016", strFirst_name = "Taylor", strLast_name = "Debolt", strEmail = "tsdebolt@svsu.edu", strPhone = "", strHash = "Capstone424", blnIsAdmin = true },
                new User() { uidTuid = new Guid("baaaabaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strSvsu_id = "500017", strFirst_name = "Trevor", strLast_name = "Eurich", strEmail = "taeurich@svsu.edu", strPhone = "", strHash = "Capstone424", blnIsAdmin = true }
            );

            //Create mock objCategory data in the dsCategories table
            context.dsCategories.AddOrUpdate(
                new Category() { uidTuid = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strName = "Asset", strDescription = "Asset" },
                new Category() { uidTuid = new Guid("baaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strName = "Consumable", strDescription = "Consumable" },
                new Category() { uidTuid = new Guid("caaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strName = "Low Fidelity Simulator", strDescription = "Low Fidelity Simulator" },
                new Category() { uidTuid = new Guid("daaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strName = "High Fidelity Simulator", strDescription = "High Fidelity Simulator" },
                new Category() { uidTuid = new Guid("eaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strName = "PPE", strDescription = "PPE" }
            );

            //Create mock Vendor data in the dsVendors table
            context.dsVendors.AddOrUpdate(
                new Vendor() { uidTuid = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strName = "Amazon", strDescription = "www.amazon.com" },
                new Vendor() { uidTuid = new Guid("baaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strName = "Binsons", strDescription = "www.binsons.com" },
                new Vendor() { uidTuid = new Guid("caaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strName = "McKesson", strDescription = "www.mckesson.com" },
                new Vendor() { uidTuid = new Guid("daaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strName = "SafeChain", strDescription = "www.safechain.com" },
                new Vendor() { uidTuid = new Guid("bbaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strName = "Walgreens", strDescription = "www.walgreens.com" },
                new Vendor() { uidTuid = new Guid("faaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strName = "Walmart", strDescription = "www.walmart.com" },
                new Vendor() { uidTuid = new Guid("aababaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strName = "GTSimulators", strDescription = "gtsimulators.com" },
                new Vendor() { uidTuid = new Guid("accaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strName = "Medline", strDescription = "medline.com" }
            );

            //Create mock NLevel data in the dsNLevels table
            context.dsNLevels.AddOrUpdate(
                new NLevel() { uidTuid = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strName = "1", strDescription = "1" },
                new NLevel() { uidTuid = new Guid("baaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strName = "2", strDescription = "2" },
                new NLevel() { uidTuid = new Guid("caaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strName = "3", strDescription = "3" },
                new NLevel() { uidTuid = new Guid("daaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strName = "4", strDescription = "4" },
                new NLevel() { uidTuid = new Guid("eaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strName = "5", strDescription = "5" },
                new NLevel() { uidTuid = new Guid("faaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strName = "NP", strDescription = "NP" }
            );


            //Create mock Room data in the dsRooms table
            context.dsRooms.AddOrUpdate(
                new Room() { uidTuid = new Guid("ccaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strName = "HE 110", strDescription = "HE 110 Description" },
                new Room() { uidTuid = new Guid("bcaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strName = "HE 111", strDescription = "HE 111 Description" },
                new Room() { uidTuid = new Guid("ccaabaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strName = "HE 230", strDescription = "HE 230 Description" },
                new Room() { uidTuid = new Guid("daaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strName = "HE 240", strDescription = "HE 240 Description" },
                new Room() { uidTuid = new Guid("eaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strName = "HE 314", strDescription = "HE 314 Description" },
                new Room() { uidTuid = new Guid("faaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strName = "HE 327", strDescription = "HE 327 Description" },
                new Room() { uidTuid = new Guid("aaaadaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strName = "HE 400", strDescription = "HE 400 Description" },
                new Room() { uidTuid = new Guid("daabaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strName = "HE 402", strDescription = "HE 402 Description" },
                new Room() { uidTuid = new Guid("acaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strName = "HE 515", strDescription = "HE 515 Description" },
                new Room() { uidTuid = new Guid("caaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strName = "HE 516", strDescription = "HE 516 Description" }
            );
            context.SaveChanges();

            //Create mock objCabinet data in the dsCabinets table
            context.dsCabinets.AddOrUpdate(
                new Cabinet() { uidTuid = new Guid("aaaaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 1", strDescription = "Cabinet 1", objRoom = context.dsRooms.First(x => x.strName == "HE 110") },
                new Cabinet() { uidTuid = new Guid("abaaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 1", strDescription = "Cabinet 1", objRoom = context.dsRooms.First(x => x.strName == "HE 111") },
                new Cabinet() { uidTuid = new Guid("acaaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 2", strDescription = "Cabinet 2", objRoom = context.dsRooms.First(x => x.strName == "HE 110") },
                new Cabinet() { uidTuid = new Guid("adaaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 2", strDescription = "Cabinet 2", objRoom = context.dsRooms.First(x => x.strName == "HE 111") },
                new Cabinet() { uidTuid = new Guid("aeaaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 3", strDescription = "Cabinet 3", objRoom = context.dsRooms.First(x => x.strName == "HE 110") },
                new Cabinet() { uidTuid = new Guid("afaaaaaa-aaaa-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 3", strDescription = "Cabinet 3", objRoom = context.dsRooms.First(x => x.strName == "HE 111") },
                new Cabinet() { uidTuid = new Guid("aabaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 4", strDescription = "Cabinet 4", objRoom = context.dsRooms.First(x => x.strName == "HE 110") },
                new Cabinet() { uidTuid = new Guid("aacaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 4", strDescription = "Cabinet 4", objRoom = context.dsRooms.First(x => x.strName == "HE 111") },
                new Cabinet() { uidTuid = new Guid("aadaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 5", strDescription = "Cabinet 5", objRoom = context.dsRooms.First(x => x.strName == "HE 110") },
                new Cabinet() { uidTuid = new Guid("aaeaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 5", strDescription = "Cabinet 5", objRoom = context.dsRooms.First(x => x.strName == "HE 111") },
                new Cabinet() { uidTuid = new Guid("aafaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 6", strDescription = "Cabinet 6", objRoom = context.dsRooms.First(x => x.strName == "HE 110") },
                new Cabinet() { uidTuid = new Guid("aaabaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 6", strDescription = "Cabinet 6", objRoom = context.dsRooms.First(x => x.strName == "HE 111") },
                new Cabinet() { uidTuid = new Guid("aaacaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 1", strDescription = "Cabinet 1", objRoom = context.dsRooms.First(x => x.strName == "HE 230") },
                new Cabinet() { uidTuid = new Guid("aaadaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 1", strDescription = "Cabinet 1", objRoom = context.dsRooms.First(x => x.strName == "HE 240") },
                new Cabinet() { uidTuid = new Guid("aaaeaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 2", strDescription = "Cabinet 2", objRoom = context.dsRooms.First(x => x.strName == "HE 230") },
                new Cabinet() { uidTuid = new Guid("aaafaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 2", strDescription = "Cabinet 2", objRoom = context.dsRooms.First(x => x.strName == "HE 240") },
                new Cabinet() { uidTuid = new Guid("aaaabaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 3", strDescription = "Cabinet 3", objRoom = context.dsRooms.First(x => x.strName == "HE 230") },
                new Cabinet() { uidTuid = new Guid("aaaacaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 3", strDescription = "Cabinet 3", objRoom = context.dsRooms.First(x => x.strName == "HE 240") },
                new Cabinet() { uidTuid = new Guid("aaaadaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 4", strDescription = "Cabinet 4", objRoom = context.dsRooms.First(x => x.strName == "HE 230") },
                new Cabinet() { uidTuid = new Guid("aaaaeaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 4", strDescription = "Cabinet 4", objRoom = context.dsRooms.First(x => x.strName == "HE 240") },
                new Cabinet() { uidTuid = new Guid("aaaafaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 5", strDescription = "Cabinet 5", objRoom = context.dsRooms.First(x => x.strName == "HE 230") },
                new Cabinet() { uidTuid = new Guid("aaaaabaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 5", strDescription = "Cabinet 5", objRoom = context.dsRooms.First(x => x.strName == "HE 240") },
                new Cabinet() { uidTuid = new Guid("aaaaacaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 6", strDescription = "Cabinet 6", objRoom = context.dsRooms.First(x => x.strName == "HE 230") },
                new Cabinet() { uidTuid = new Guid("aaaaadaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 6", strDescription = "Cabinet 6", objRoom = context.dsRooms.First(x => x.strName == "HE 240") },
                new Cabinet() { uidTuid = new Guid("aaaaaeaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 1", strDescription = "Cabinet 1", objRoom = context.dsRooms.First(x => x.strName == "HE 314") },
                new Cabinet() { uidTuid = new Guid("aaaaafaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 1", strDescription = "Cabinet 1", objRoom = context.dsRooms.First(x => x.strName == "HE 327") },
                new Cabinet() { uidTuid = new Guid("aaaaaaba-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 2", strDescription = "Cabinet 2", objRoom = context.dsRooms.First(x => x.strName == "HE 314") },
                new Cabinet() { uidTuid = new Guid("aaaaaaca-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 2", strDescription = "Cabinet 2", objRoom = context.dsRooms.First(x => x.strName == "HE 327") },
                new Cabinet() { uidTuid = new Guid("aaaaaada-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 3", strDescription = "Cabinet 3", objRoom = context.dsRooms.First(x => x.strName == "HE 314") },
                new Cabinet() { uidTuid = new Guid("aaaaaaea-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 3", strDescription = "Cabinet 3", objRoom = context.dsRooms.First(x => x.strName == "HE 327") },
                new Cabinet() { uidTuid = new Guid("aaaaaafa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 4", strDescription = "Cabinet 4", objRoom = context.dsRooms.First(x => x.strName == "HE 314") },
                new Cabinet() { uidTuid = new Guid("aaaaaaab-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 4", strDescription = "Cabinet 4", objRoom = context.dsRooms.First(x => x.strName == "HE 327") },
                new Cabinet() { uidTuid = new Guid("aaaaaaac-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 5", strDescription = "Cabinet 5", objRoom = context.dsRooms.First(x => x.strName == "HE 314") },
                new Cabinet() { uidTuid = new Guid("aaaaaaad-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 5", strDescription = "Cabinet 5", objRoom = context.dsRooms.First(x => x.strName == "HE 327") },
                new Cabinet() { uidTuid = new Guid("aaaaaaae-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 6", strDescription = "Cabinet 6", objRoom = context.dsRooms.First(x => x.strName == "HE 314") },
                new Cabinet() { uidTuid = new Guid("aaaaaaaf-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 6", strDescription = "Cabinet 6", objRoom = context.dsRooms.First(x => x.strName == "HE 327") },
                new Cabinet() { uidTuid = new Guid("abbaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 1", strDescription = "Cabinet 1", objRoom = context.dsRooms.First(x => x.strName == "HE 400") },
                new Cabinet() { uidTuid = new Guid("abcaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 1", strDescription = "Cabinet 1", objRoom = context.dsRooms.First(x => x.strName == "HE 402") },
                new Cabinet() { uidTuid = new Guid("abdaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 2", strDescription = "Cabinet 2", objRoom = context.dsRooms.First(x => x.strName == "HE 400") },
                new Cabinet() { uidTuid = new Guid("abeaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 2", strDescription = "Cabinet 2", objRoom = context.dsRooms.First(x => x.strName == "HE 402") },
                new Cabinet() { uidTuid = new Guid("abfaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 3", strDescription = "Cabinet 3", objRoom = context.dsRooms.First(x => x.strName == "HE 400") },
                new Cabinet() { uidTuid = new Guid("acbaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 3", strDescription = "Cabinet 3", objRoom = context.dsRooms.First(x => x.strName == "HE 402") },
                new Cabinet() { uidTuid = new Guid("accaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 4", strDescription = "Cabinet 4", objRoom = context.dsRooms.First(x => x.strName == "HE 400") },
                new Cabinet() { uidTuid = new Guid("acdaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 4", strDescription = "Cabinet 4", objRoom = context.dsRooms.First(x => x.strName == "HE 402") },
                new Cabinet() { uidTuid = new Guid("acfaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 5", strDescription = "Cabinet 5", objRoom = context.dsRooms.First(x => x.strName == "HE 400") },
                new Cabinet() { uidTuid = new Guid("adbaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 5", strDescription = "Cabinet 5", objRoom = context.dsRooms.First(x => x.strName == "HE 402") },
                new Cabinet() { uidTuid = new Guid("adcaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 6", strDescription = "Cabinet 6", objRoom = context.dsRooms.First(x => x.strName == "HE 400") },
                new Cabinet() { uidTuid = new Guid("addaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 6", strDescription = "Cabinet 6", objRoom = context.dsRooms.First(x => x.strName == "HE 402") },
                new Cabinet() { uidTuid = new Guid("adeaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 1", strDescription = "Cabinet 1", objRoom = context.dsRooms.First(x => x.strName == "HE 515") },
                new Cabinet() { uidTuid = new Guid("adfaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 1", strDescription = "Cabinet 1", objRoom = context.dsRooms.First(x => x.strName == "HE 516") },
                new Cabinet() { uidTuid = new Guid("aebaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 2", strDescription = "Cabinet 2", objRoom = context.dsRooms.First(x => x.strName == "HE 515") },
                new Cabinet() { uidTuid = new Guid("aecaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 2", strDescription = "Cabinet 2", objRoom = context.dsRooms.First(x => x.strName == "HE 516") },
                new Cabinet() { uidTuid = new Guid("aedaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 3", strDescription = "Cabinet 3", objRoom = context.dsRooms.First(x => x.strName == "HE 515") },
                new Cabinet() { uidTuid = new Guid("aeeaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 3", strDescription = "Cabinet 3", objRoom = context.dsRooms.First(x => x.strName == "HE 516") },
                new Cabinet() { uidTuid = new Guid("aefaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 4", strDescription = "Cabinet 4", objRoom = context.dsRooms.First(x => x.strName == "HE 515") },
                new Cabinet() { uidTuid = new Guid("afbaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 4", strDescription = "Cabinet 4", objRoom = context.dsRooms.First(x => x.strName == "HE 516") },
                new Cabinet() { uidTuid = new Guid("afcaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 5", strDescription = "Cabinet 5", objRoom = context.dsRooms.First(x => x.strName == "HE 515") },
                new Cabinet() { uidTuid = new Guid("afdaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 5", strDescription = "Cabinet 5", objRoom = context.dsRooms.First(x => x.strName == "HE 516") },
                new Cabinet() { uidTuid = new Guid("afeaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 6", strDescription = "Cabinet 6", objRoom = context.dsRooms.First(x => x.strName == "HE 515") },
                new Cabinet() { uidTuid = new Guid("affaaaaa-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Cabinet 6", strDescription = "Cabinet 6", objRoom = context.dsRooms.First(x => x.strName == "HE 516") },
                new Cabinet() { uidTuid = new Guid("aafcaaaa-bbba-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Floor Item", strDescription = "Floor Item", objRoom = context.dsRooms.First(x => x.strName == "HE 110") },
                new Cabinet() { uidTuid = new Guid("aaabcaaa-bbbc-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Floor Item", strDescription = "Floor Item", objRoom = context.dsRooms.First(x => x.strName == "HE 111") },
                new Cabinet() { uidTuid = new Guid("aafcaaaa-bcbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Floor Item", strDescription = "Floor Item", objRoom = context.dsRooms.First(x => x.strName == "HE 230") },
                new Cabinet() { uidTuid = new Guid("aaabcaaa-babb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Floor Item", strDescription = "Floor Item", objRoom = context.dsRooms.First(x => x.strName == "HE 240") },
                new Cabinet() { uidTuid = new Guid("aafcaaaa-bfbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Floor Item", strDescription = "Floor Item", objRoom = context.dsRooms.First(x => x.strName == "HE 314") },
                new Cabinet() { uidTuid = new Guid("aaabcaaa-bebb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Floor Item", strDescription = "Floor Item", objRoom = context.dsRooms.First(x => x.strName == "HE 327") },
                new Cabinet() { uidTuid = new Guid("aafcaaaa-ebbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Floor Item", strDescription = "Floor Item", objRoom = context.dsRooms.First(x => x.strName == "HE 400") },
                new Cabinet() { uidTuid = new Guid("aaabcaaa-dbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Floor Item", strDescription = "Floor Item", objRoom = context.dsRooms.First(x => x.strName == "HE 402") },
                new Cabinet() { uidTuid = new Guid("aafcaaaa-cbbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Floor Item", strDescription = "Floor Item", objRoom = context.dsRooms.First(x => x.strName == "HE 515") },
                new Cabinet() { uidTuid = new Guid("aaabcaaa-abbb-bbbb-bbbb-bbbbbbbbbbbb"), strName = "Floor Item", strDescription = "Floor Item", objRoom = context.dsRooms.First(x => x.strName == "HE 516") }
            );

            //Create mock objCommodity data in the Commodities table
            context.dsCommodities.AddOrUpdate(
                new Commodity() { uidTuid = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strName = "Non-Latex Gloves", strDescription = "Non-Latex Gloves", intAlert_quantity = 50, objCategory = context.dsCategories.First(x => x.strName == "PPE") },
                new Commodity() { uidTuid = new Guid("abaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strName = "Cotton Balls", strDescription = "Cotton Balls", intAlert_quantity = 50, objCategory = context.dsCategories.First(x => x.strName == "Consumable") },
                new Commodity() { uidTuid = new Guid("acaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strName = "Sterile Alchohol Prep Pad", strDescription = "Sertile Alchohol Prep Pads", intAlert_quantity = 50, objCategory = context.dsCategories.First(x => x.strName == "Consumable") },
                new Commodity() { uidTuid = new Guid("adaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strName = "Hypodermic Needles", strDescription = "Hypodermic Needles", intAlert_quantity = 50, objCategory = context.dsCategories.First(x => x.strName == "Consumable") },
                new Commodity() { uidTuid = new Guid("aeaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strName = "Lock Syringes", strDescription = "Lock Syringes", intAlert_quantity = 50, objCategory = context.dsCategories.First(x => x.strName == "Consumable") },
                new Commodity() { uidTuid = new Guid("afaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strName = "CPR Manikin and AED Kit", strDescription = "CPR Manikin and AED Kit", intAlert_quantity = 1, objCategory = context.dsCategories.First(x => x.strName == "Asset") },
                new Commodity() { uidTuid = new Guid("abbaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strName = "IV Training Arm", strDescription = "IV Training Arm", intAlert_quantity = 1, objCategory = context.dsCategories.First(x => x.strName == "Asset") },
                new Commodity() { uidTuid = new Guid("abcaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strName = "OLED Fingertip Pulse Oximeter", strDescription = "OLED Fingertip Pulse Oximeter", intAlert_quantity = 1, objCategory = context.dsCategories.First(x => x.strName == "Asset") },
                new Commodity() { uidTuid = new Guid("abdaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strName = "MedVision Adult Patient Simulator", strDescription = "MedVision Adult Patient Simulator", intAlert_quantity = 1, objCategory = context.dsCategories.First(x => x.strName == "High Fidelity Simulator") },
                new Commodity() { uidTuid = new Guid("abeaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strName = "MedVision Pediatric Patient Simulator", strDescription = "MedVision Pediatric Patient Simulator", intAlert_quantity = 1, objCategory = context.dsCategories.First(x => x.strName == "High Fidelity Simulator") },
                new Commodity() { uidTuid = new Guid("abfaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strName = "MedVision Infant Patient Simulator", strDescription = "MedVision Infant Patient Simulator", intAlert_quantity = 1, objCategory = context.dsCategories.First(x => x.strName == "High Fidelity Simulator") },
                new Commodity() { uidTuid = new Guid("acbaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strName = "Venturi Oxygen Mask", strDescription = "Venturi Oxygen Mask", intAlert_quantity = 1, objCategory = context.dsCategories.First(x => x.strName == "Asset") },
                new Commodity() { uidTuid = new Guid("accaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strName = "Medline Nonskid Polypropylene Shoe Covers", strDescription = "Medline Nonskid Polypropylene Shoe Covers", intAlert_quantity = 50, objCategory = context.dsCategories.First(x => x.strName == "PPE") },
                new Commodity() { uidTuid = new Guid("acdaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strName = "Lightweight Polypropylene Isolation Gowns", strDescription = "Lightweight Polypropylene Isolation Gowns", intAlert_quantity = 15, objCategory = context.dsCategories.First(x => x.strName == "PPE") },
                new Commodity() { uidTuid = new Guid("aceaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strName = "N95 Particulate Respiratory and Surgical Mask", strDescription = "N95 Particulate Respiratory and Surgical Mask", intAlert_quantity = 60, objCategory = context.dsCategories.First(x => x.strName == "PPE") },
                new Commodity() { uidTuid = new Guid("acfaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), strName = "Manual Exam Table", strDescription = "Manual Exam Table", intAlert_quantity = 1, objCategory = context.dsCategories.First(x => x.strName == "Asset") }
            );
            context.SaveChanges();
            //Create mock intQuantity data in the Quantities table
            context.dsStorage.AddOrUpdate(
                new Storage() { uidTuid = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), intQuantity = 300, objCabinet = context.dsCabinets.First(x => x.strName == "Cabinet 1" && x.objRoom.strName == "HE 110"), objCommodity = context.dsCommodities.First(x => x.strName == "Non-Latex Gloves"), objNLevel = context.dsNLevels.First(x => x.strName == "1") },
                new Storage() { uidTuid = new Guid("baaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), intQuantity = 500, objCabinet = context.dsCabinets.First(x => x.strName == "Cabinet 3" && x.objRoom.strName == "HE 111"), objCommodity = context.dsCommodities.First(x => x.strName == "Cotton Balls"), objNLevel = context.dsNLevels.First(x => x.strName == "1") },
                new Storage() { uidTuid = new Guid("caaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), intQuantity = 500, objCabinet = context.dsCabinets.First(x => x.strName == "Cabinet 3" && x.objRoom.strName == "HE 110"), objCommodity = context.dsCommodities.First(x => x.strName == "Sterile Alchohol Prep Pad"), objNLevel = context.dsNLevels.First(x => x.strName == "1") },
                new Storage() { uidTuid = new Guid("daaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), intQuantity = 80, objCabinet = context.dsCabinets.First(x => x.strName == "Cabinet 4" && x.objRoom.strName == "HE 230"), objCommodity = context.dsCommodities.First(x => x.strName == "Hypodermic Needles"), objNLevel = context.dsNLevels.First(x => x.strName == "2") },
                new Storage() { uidTuid = new Guid("eaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), intQuantity = 80, objCabinet = context.dsCabinets.First(x => x.strName == "Cabinet 2" && x.objRoom.strName == "HE 240"), objCommodity = context.dsCommodities.First(x => x.strName == "Lock Syringes"), objNLevel = context.dsNLevels.First(x => x.strName == "2") },
                new Storage() { uidTuid = new Guid("faaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), intQuantity = 2, objCabinet = context.dsCabinets.First(x => x.strName == "Cabinet 6" && x.objRoom.strName == "HE 110"), objCommodity = context.dsCommodities.First(x => x.strName == "CPR Manikin And AED Kit"), objNLevel = context.dsNLevels.First(x => x.strName == "1") },
                new Storage() { uidTuid = new Guid("abaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), intQuantity = 4, objCabinet = context.dsCabinets.First(x => x.strName == "Cabinet 1" && x.objRoom.strName == "HE 314"), objCommodity = context.dsCommodities.First(x => x.strName == "IV Training Arm"), objNLevel = context.dsNLevels.First(x => x.strName == "3") },
                new Storage() { uidTuid = new Guid("acaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), intQuantity = 5, objCabinet = context.dsCabinets.First(x => x.strName == "Cabinet 6" && x.objRoom.strName == "HE 327"), objCommodity = context.dsCommodities.First(x => x.strName == "OLED Fingertip Pulse Oximeter"), objNLevel = context.dsNLevels.First(x => x.strName == "3") },
                new Storage() { uidTuid = new Guid("adaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), intQuantity = 3, objCabinet = context.dsCabinets.First(x => x.strName == "Floor Item" && x.objRoom.strName == "HE 400"), objCommodity = context.dsCommodities.First(x => x.strName == "MedVision Adult Patient Simulator"), objNLevel = context.dsNLevels.First(x => x.strName == "4") },
                new Storage() { uidTuid = new Guid("aeaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), intQuantity = 3, objCabinet = context.dsCabinets.First(x => x.strName == "Floor Item" && x.objRoom.strName == "HE 515"), objCommodity = context.dsCommodities.First(x => x.strName == "MedVision Pediatric Patient Simulator"), objNLevel = context.dsNLevels.First(x => x.strName == "5") },
                new Storage() { uidTuid = new Guid("afaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), intQuantity = 3, objCabinet = context.dsCabinets.First(x => x.strName == "Floor Item" && x.objRoom.strName == "HE 516"), objCommodity = context.dsCommodities.First(x => x.strName == "MedVision Infant Patient Simulator"), objNLevel = context.dsNLevels.First(x => x.strName == "5") },
                new Storage() { uidTuid = new Guid("aabaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), intQuantity = 200, objCabinet = context.dsCabinets.First(x => x.strName == "Cabinet 2" && x.objRoom.strName == "HE 327"), objCommodity = context.dsCommodities.First(x => x.strName == "Venturi Oxygen Mask"), objNLevel = context.dsNLevels.First(x => x.strName == "3") },
                new Storage() { uidTuid = new Guid("aacaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), intQuantity = 75, objCabinet = context.dsCabinets.First(x => x.strName == "Cabinet 2" && x.objRoom.strName == "HE 111"), objCommodity = context.dsCommodities.First(x => x.strName == "Medline Nonskid Polypropylene Shoe Covers"), objNLevel = context.dsNLevels.First(x => x.strName == "1") },
                new Storage() { uidTuid = new Guid("aadaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), intQuantity = 200, objCabinet = context.dsCabinets.First(x => x.strName == "Cabinet 3" && x.objRoom.strName == "HE 111"), objCommodity = context.dsCommodities.First(x => x.strName == "Lightweight Polypropylene Isolation Gowns"), objNLevel = context.dsNLevels.First(x => x.strName == "1") },
                new Storage() { uidTuid = new Guid("aaeaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), intQuantity = 300, objCabinet = context.dsCabinets.First(x => x.strName == "Cabinet 5" && x.objRoom.strName == "HE 110"), objCommodity = context.dsCommodities.First(x => x.strName == "N95 Particulate Respiratory and Surgical Mask"), objNLevel = context.dsNLevels.First(x => x.strName == "1") },
                new Storage() { uidTuid = new Guid("aafaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), intQuantity = 3, objCabinet = context.dsCabinets.First(x => x.strName == "Floor Item" && x.objRoom.strName == "HE 516"), objCommodity = context.dsCommodities.First(x => x.strName == "Manual Exam Table"), objNLevel = context.dsNLevels.First(x => x.strName == "NP") }
            );
            //Create mock vendoritems data in the VendorItems table
            /*
            context.dsVendorItems.AddOrUpdate(
                new VendorItem() { uidTuid = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), intCostInCents = 25, objCommodity = context.dsCommodities.First(x => x.strName == "Non-Latex Gloves"), objVendor = context.dsVendors.First(x => x.strName == "Medline") },
                new VendorItem() { uidTuid = new Guid("baaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), intCostInCents = 25, objCommodity = context.dsCommodities.First(x => x.strName == "Cotton Balls"), objVendor = context.dsVendors.First(x => x.strName == "Medline") },
                new VendorItem() { uidTuid = new Guid("caaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), intCostInCents = 40, objCommodity = context.dsCommodities.First(x => x.strName == "Sterile Alchohol Prep Pad"), objVendor = context.dsVendors.First(x => x.strName == "Medline") },
                new VendorItem() { uidTuid = new Guid("daaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), intCostInCents = 75, objCommodity = context.dsCommodities.First(x => x.strName == "Hypodermic Needles"), objVendor = context.dsVendors.First(x => x.strName == "Medline") },
                new VendorItem() { uidTuid = new Guid("eaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), intCostInCents = 75, objCommodity = context.dsCommodities.First(x => x.strName == "Lock Syringes"), objVendor = context.dsVendors.First(x => x.strName == "Medline") },
                new VendorItem() { uidTuid = new Guid("faaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), intCostInCents = 900, objCommodity = context.dsCommodities.First(x => x.strName == "CPR Manikin And AED Kit"), objVendor = context.dsVendors.First(x => x.strName == "Medline") },
                new VendorItem() { uidTuid = new Guid("abaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), intCostInCents = 600, objCommodity = context.dsCommodities.First(x => x.strName == "IV Training Arm"), objVendor = context.dsVendors.First(x => x.strName == "Medline") },
                new VendorItem() { uidTuid = new Guid("acaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), intCostInCents = 150, objCommodity = context.dsCommodities.First(x => x.strName == "OLED Fingertip Pulse Oximeter"), objVendor = context.dsVendors.First(x => x.strName == "Medline") },
                new VendorItem() { uidTuid = new Guid("adaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), intCostInCents = 8000, objCommodity = context.dsCommodities.First(x => x.strName == "MedVision Adult Patient Simulator"), objVendor = context.dsVendors.First(x => x.strName == "GTSimulators") },
                new VendorItem() { uidTuid = new Guid("aeaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), intCostInCents = 7500, objCommodity = context.dsCommodities.First(x => x.strName == "MedVision Pediatric Patient Simulator"), objVendor = context.dsVendors.First(x => x.strName == "GTSimulators") },
                new VendorItem() { uidTuid = new Guid("afaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), intCostInCents = 6000, objCommodity = context.dsCommodities.First(x => x.strName == "MedVision Infant Patient Simulator"), objVendor = context.dsVendors.First(x => x.strName == "GTSimulators") },
                new VendorItem() { uidTuid = new Guid("aabaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), intCostInCents = 40, objCommodity = context.dsCommodities.First(x => x.strName == "Venturi Oxygen Mask"), objVendor = context.dsVendors.First(x => x.strName == "Medline") },
                new VendorItem() { uidTuid = new Guid("aacaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), intCostInCents = 40, objCommodity = context.dsCommodities.First(x => x.strName == "Medline Nonskid Polypropylene Shoe Covers"), objVendor = context.dsVendors.First(x => x.strName == "Medline") },
                new VendorItem() { uidTuid = new Guid("aadaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), intCostInCents = 40, objCommodity = context.dsCommodities.First(x => x.strName == "Lightweight Polypropylene Isolation Gowns"), objVendor = context.dsVendors.First(x => x.strName == "Medline") },
                new VendorItem() { uidTuid = new Guid("aaeaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), intCostInCents = 30, objCommodity = context.dsCommodities.First(x => x.strName == "N95 Particulate Respiratory and Surgical Mask"), objVendor = context.dsVendors.First(x => x.strName == "Medline") },
                new VendorItem() { uidTuid = new Guid("aafaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), intCostInCents = 15000, objCommodity = context.dsCommodities.First(x => x.strName == "Manual Exam Table"), objVendor = context.dsVendors.First(x => x.strName == "Medline") }
            );
            */
            context.SaveChanges();
            //Create mock logs data in the Logs table
            context.dsLogs.AddOrUpdate(
                new Log() { uidTuid = new Guid("bbbbbbbb-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), enuAction = ItemAction.Added, dtTimestamp = DateTime.Now, strNotes = "Added 250 gloves", intQuantityChange = 250, objStorage = context.dsStorage.First(x => x.uidTuid.ToString() == "aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), objUser = context.dsUsers.First(x => x.strSvsu_id == "500010") },
                new Log() { uidTuid = new Guid("cccccccc-cccc-cccc-cccc-cccccccccccd"), enuAction = ItemAction.Moved, dtTimestamp = DateTime.Now, strNotes = "Consumed 5 alchohol prep pads", intQuantityChange = 5, objStorage = context.dsStorage.First(x => x.uidTuid.ToString() == "caaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa" ), objUser = context.dsUsers.First(x => x.strSvsu_id == "500006") },
                new Log() { uidTuid = new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"), enuAction = ItemAction.CheckedOut, dtTimestamp = DateTime.Now, strNotes = "Checked out MedVision Adult Patient Simulator", intQuantityChange = 1, objStorage = context.dsStorage.First(x => x.uidTuid.ToString() == "adaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), objUser = context.dsUsers.First(x => x.strSvsu_id == "500003") }
            );
        }
    }
}
