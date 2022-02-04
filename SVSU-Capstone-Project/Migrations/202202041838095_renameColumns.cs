namespace SVSU_Capstone_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class renameColumns : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cabinets",
                c => new
                    {
                        tuid = c.Guid(nullable: false),
                        name = c.String(),
                        description = c.String(),
                        objRoom_uidTuid = c.Guid(),
                    })
                .PrimaryKey(t => t.tuid)
                .ForeignKey("dbo.Rooms", t => t.objRoom_uidTuid)
                .Index(t => t.objRoom_uidTuid);
            
            CreateTable(
                "dbo.Quantities",
                c => new
                    {
                        tuid = c.Guid(nullable: false),
                        quantity = c.Int(nullable: false),
                        objCabinet_uidTuid = c.Guid(),
                        objCommodity_uidTuid = c.Guid(),
                        objNLevel_uidTuid = c.Guid(),
                    })
                .PrimaryKey(t => t.tuid)
                .ForeignKey("dbo.Cabinets", t => t.objCabinet_uidTuid)
                .ForeignKey("dbo.Commodities", t => t.objCommodity_uidTuid)
                .ForeignKey("dbo.NLevels", t => t.objNLevel_uidTuid)
                .Index(t => t.objCabinet_uidTuid)
                .Index(t => t.objCommodity_uidTuid)
                .Index(t => t.objNLevel_uidTuid);
            
            CreateTable(
                "dbo.Commodities",
                c => new
                    {
                        uidTuid = c.Guid(nullable: false),
                        name = c.String(),
                        description = c.String(),
                        features = c.String(),
                        alert_quantity = c.Int(nullable: false),
                        objCategory_uidTuid = c.Guid(),
                    })
                .PrimaryKey(t => t.uidTuid)
                .ForeignKey("dbo.Categories", t => t.objCategory_uidTuid)
                .Index(t => t.objCategory_uidTuid);
            
            CreateTable(
                "dbo.Logs",
                c => new
                    {
                        tuid = c.Guid(nullable: false),
                        action = c.String(),
                        timestamp = c.DateTime(nullable: false),
                        notes = c.String(),
                        quantityChange = c.Int(nullable: false),
                        objCommodity_uidTuid = c.Guid(),
                        objUser_uidTuid = c.Guid(),
                    })
                .PrimaryKey(t => t.tuid)
                .ForeignKey("dbo.Commodities", t => t.objCommodity_uidTuid)
                .ForeignKey("dbo.Users", t => t.objUser_uidTuid)
                .Index(t => t.objCommodity_uidTuid)
                .Index(t => t.objUser_uidTuid);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        tuid = c.Guid(nullable: false),
                        svsu_id = c.String(),
                        first_name = c.String(),
                        last_name = c.String(),
                        email = c.String(),
                        phone = c.String(),
                        hash = c.String(),
                        isAdmin = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.tuid);
            
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
                .PrimaryKey(t => t.tuid)
                .ForeignKey("dbo.Commodities", t => t.objCommodity_uidTuid)
                .ForeignKey("dbo.Vendors", t => t.objVendor_uidTuid)
                .Index(t => t.objCommodity_uidTuid)
                .Index(t => t.objVendor_uidTuid);
            
            CreateTable(
                "dbo.Vendors",
                c => new
                    {
                        tuid = c.Guid(nullable: false),
                        name = c.String(),
                        homepage = c.String(),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.tuid);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        tuid = c.Guid(nullable: false),
                        name = c.String(),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.tuid);
            
            CreateTable(
                "dbo.NLevels",
                c => new
                    {
                        tuid = c.Guid(nullable: false),
                        name = c.String(),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.tuid);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        tuid = c.Guid(nullable: false),
                        name = c.String(),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.tuid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cabinets", "objRoom_uidTuid", "dbo.Rooms");
            DropForeignKey("dbo.Quantities", "objNLevel_uidTuid", "dbo.NLevels");
            DropForeignKey("dbo.Commodities", "objCategory_uidTuid", "dbo.Categories");
            DropForeignKey("dbo.VendorItems", "objVendor_uidTuid", "dbo.Vendors");
            DropForeignKey("dbo.VendorItems", "objCommodity_uidTuid", "dbo.Commodities");
            DropForeignKey("dbo.Quantities", "objCommodity_uidTuid", "dbo.Commodities");
            DropForeignKey("dbo.Logs", "objUser_uidTuid", "dbo.Users");
            DropForeignKey("dbo.Logs", "objCommodity_uidTuid", "dbo.Commodities");
            DropForeignKey("dbo.Quantities", "objCabinet_uidTuid", "dbo.Cabinets");
            DropIndex("dbo.VendorItems", new[] { "objVendor_uidTuid" });
            DropIndex("dbo.VendorItems", new[] { "objCommodity_uidTuid" });
            DropIndex("dbo.Logs", new[] { "objUser_uidTuid" });
            DropIndex("dbo.Logs", new[] { "objCommodity_uidTuid" });
            DropIndex("dbo.Commodities", new[] { "objCategory_uidTuid" });
            DropIndex("dbo.Quantities", new[] { "objNLevel_uidTuid" });
            DropIndex("dbo.Quantities", new[] { "objCommodity_uidTuid" });
            DropIndex("dbo.Quantities", new[] { "objCabinet_uidTuid" });
            DropIndex("dbo.Cabinets", new[] { "objRoom_uidTuid" });
            DropTable("dbo.Rooms");
            DropTable("dbo.NLevels");
            DropTable("dbo.Categories");
            DropTable("dbo.Vendors");
            DropTable("dbo.VendorItems");
            DropTable("dbo.Users");
            DropTable("dbo.Logs");
            DropTable("dbo.Commodities");
            DropTable("dbo.Quantities");
            DropTable("dbo.Cabinets");
        }
    }
}
