namespace SVSU_Capstone_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class uniqueIndexed : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Storages", newName: "Storage");
            RenameTable(name: "dbo.NLevels", newName: "NLevel");
            DropForeignKey("dbo.VendorItems", "objCommodity_uidTuid", "dbo.Commodities");
            DropIndex("dbo.VendorItems", new[] { "objCommodity_uidTuid" });
            DropIndex("dbo.VendorItems", new[] { "objVendor_uidTuid" });
            AddColumn("dbo.Commodities", "costInCents", c => c.Int(nullable: false));
            AddColumn("dbo.Commodities", "itemUrl", c => c.String());
            AddColumn("dbo.Commodities", "objVendor_uidTuid", c => c.Guid());
            AlterColumn("dbo.Cabinets", "name", c => c.String(maxLength: 255));
            AlterColumn("dbo.Commodities", "name", c => c.String(maxLength: 255));
            AlterColumn("dbo.Vendors", "name", c => c.String(maxLength: 255));
            AlterColumn("dbo.Categories", "name", c => c.String(maxLength: 255));
            AlterColumn("dbo.NLevel", "name", c => c.String(maxLength: 255));
            AlterColumn("dbo.Rooms", "name", c => c.String(maxLength: 255));
            CreateIndex("dbo.Commodities", "name", unique: true);
            CreateIndex("dbo.Commodities", "objVendor_uidTuid");
            CreateIndex("dbo.Categories", "name", unique: true);
            CreateIndex("dbo.Vendors", "name", unique: true);
            CreateIndex("dbo.NLevel", "name", unique: true);
            CreateIndex("dbo.Rooms", "name", unique: true);
            DropTable("dbo.VendorItems");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.VendorItems",
                c => new
                    {
                        tuid = c.Guid(nullable: false),
                        costInCents = c.Int(nullable: false),
                        itemUrl = c.String(),
                        objCommodity_uidTuid = c.Guid(),
                        objVendor_uidTuid = c.Guid(),
                    })
                .PrimaryKey(t => t.tuid);
            
            DropIndex("dbo.Rooms", new[] { "name" });
            DropIndex("dbo.NLevel", new[] { "name" });
            DropIndex("dbo.Vendors", new[] { "name" });
            DropIndex("dbo.Categories", new[] { "name" });
            DropIndex("dbo.Commodities", new[] { "objVendor_uidTuid" });
            DropIndex("dbo.Commodities", new[] { "name" });
            AlterColumn("dbo.Rooms", "name", c => c.String());
            AlterColumn("dbo.NLevel", "name", c => c.String());
            AlterColumn("dbo.Categories", "name", c => c.String());
            AlterColumn("dbo.Vendors", "name", c => c.String());
            AlterColumn("dbo.Commodities", "name", c => c.String());
            AlterColumn("dbo.Cabinets", "name", c => c.String());
            DropColumn("dbo.Commodities", "objVendor_uidTuid");
            DropColumn("dbo.Commodities", "itemUrl");
            DropColumn("dbo.Commodities", "costInCents");
            CreateIndex("dbo.VendorItems", "objVendor_uidTuid");
            CreateIndex("dbo.VendorItems", "objCommodity_uidTuid");
            AddForeignKey("dbo.VendorItems", "objCommodity_uidTuid", "dbo.Commodities", "tuid");
            RenameTable(name: "dbo.NLevel", newName: "NLevels");
            RenameTable(name: "dbo.Storage", newName: "Storages");
        }
    }
}
