namespace SVSU_Capstone_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialize : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cabinets",
                c => new
                    {
                        tuid = c.String(nullable: false, maxLength: 128),
                        name = c.String(),
                        description = c.String(),
                        room_tuid = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.tuid)
                .ForeignKey("dbo.Rooms", t => t.room_tuid)
                .Index(t => t.room_tuid);
            
            CreateTable(
                "dbo.Quantities",
                c => new
                    {
                        tuid = c.String(nullable: false, maxLength: 128),
                        quantity = c.Int(nullable: false),
                        cabinet_tuid = c.String(maxLength: 128),
                        commodity_tuid = c.String(maxLength: 128),
                        nlevel_tuid = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.tuid)
                .ForeignKey("dbo.Cabinets", t => t.cabinet_tuid)
                .ForeignKey("dbo.Commodities", t => t.commodity_tuid)
                .ForeignKey("dbo.NLevels", t => t.nlevel_tuid)
                .Index(t => t.cabinet_tuid)
                .Index(t => t.commodity_tuid)
                .Index(t => t.nlevel_tuid);
            
            CreateTable(
                "dbo.Commodities",
                c => new
                    {
                        tuid = c.String(nullable: false, maxLength: 128),
                        name = c.String(),
                        description = c.String(),
                        features = c.String(),
                        alert_quantity = c.Int(nullable: false),
                        category_tuid = c.String(maxLength: 128),
                        Vendor_tuid = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.tuid)
                .ForeignKey("dbo.Categories", t => t.category_tuid)
                .ForeignKey("dbo.Vendors", t => t.Vendor_tuid)
                .Index(t => t.category_tuid)
                .Index(t => t.Vendor_tuid);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        tuid = c.String(nullable: false, maxLength: 128),
                        name = c.String(),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.tuid);
            
            CreateTable(
                "dbo.VendorItems",
                c => new
                    {
                        tuid = c.String(nullable: false, maxLength: 128),
                        costInCents = c.Int(nullable: false),
                        commodity_tuid = c.String(maxLength: 128),
                        vendor_tuid = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.tuid)
                .ForeignKey("dbo.Commodities", t => t.commodity_tuid)
                .ForeignKey("dbo.Vendors", t => t.vendor_tuid)
                .Index(t => t.commodity_tuid)
                .Index(t => t.vendor_tuid);
            
            CreateTable(
                "dbo.Vendors",
                c => new
                    {
                        tuid = c.String(nullable: false, maxLength: 128),
                        name = c.String(),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.tuid);
            
            CreateTable(
                "dbo.NLevels",
                c => new
                    {
                        tuid = c.String(nullable: false, maxLength: 128),
                        name = c.String(),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.tuid);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        tuid = c.String(nullable: false, maxLength: 128),
                        room_name = c.String(),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.tuid);
            
            CreateTable(
                "dbo.Logs",
                c => new
                    {
                        tuid = c.String(nullable: false, maxLength: 128),
                        action = c.String(),
                        timestamp = c.String(),
                        notes = c.String(),
                        quantityChange = c.Int(nullable: false),
                        commodity_tuid = c.String(maxLength: 128),
                        user_tuid = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.tuid)
                .ForeignKey("dbo.Commodities", t => t.commodity_tuid)
                .ForeignKey("dbo.Users", t => t.user_tuid)
                .Index(t => t.commodity_tuid)
                .Index(t => t.user_tuid);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        tuid = c.String(nullable: false, maxLength: 128),
                        svsu_id = c.String(),
                        first_name = c.String(),
                        last_name = c.String(),
                        email = c.String(),
                        phone = c.String(),
                        password = c.String(),
                        isAdmin = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.tuid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Logs", "user_tuid", "dbo.Users");
            DropForeignKey("dbo.Logs", "commodity_tuid", "dbo.Commodities");
            DropForeignKey("dbo.Cabinets", "room_tuid", "dbo.Rooms");
            DropForeignKey("dbo.Quantities", "nlevel_tuid", "dbo.NLevels");
            DropForeignKey("dbo.VendorItems", "vendor_tuid", "dbo.Vendors");
            DropForeignKey("dbo.Commodities", "Vendor_tuid", "dbo.Vendors");
            DropForeignKey("dbo.VendorItems", "commodity_tuid", "dbo.Commodities");
            DropForeignKey("dbo.Quantities", "commodity_tuid", "dbo.Commodities");
            DropForeignKey("dbo.Commodities", "category_tuid", "dbo.Categories");
            DropForeignKey("dbo.Quantities", "cabinet_tuid", "dbo.Cabinets");
            DropIndex("dbo.Logs", new[] { "user_tuid" });
            DropIndex("dbo.Logs", new[] { "commodity_tuid" });
            DropIndex("dbo.VendorItems", new[] { "vendor_tuid" });
            DropIndex("dbo.VendorItems", new[] { "commodity_tuid" });
            DropIndex("dbo.Commodities", new[] { "Vendor_tuid" });
            DropIndex("dbo.Commodities", new[] { "category_tuid" });
            DropIndex("dbo.Quantities", new[] { "nlevel_tuid" });
            DropIndex("dbo.Quantities", new[] { "commodity_tuid" });
            DropIndex("dbo.Quantities", new[] { "cabinet_tuid" });
            DropIndex("dbo.Cabinets", new[] { "room_tuid" });
            DropTable("dbo.Users");
            DropTable("dbo.Logs");
            DropTable("dbo.Rooms");
            DropTable("dbo.NLevels");
            DropTable("dbo.Vendors");
            DropTable("dbo.VendorItems");
            DropTable("dbo.Categories");
            DropTable("dbo.Commodities");
            DropTable("dbo.Quantities");
            DropTable("dbo.Cabinets");
        }
    }
}
