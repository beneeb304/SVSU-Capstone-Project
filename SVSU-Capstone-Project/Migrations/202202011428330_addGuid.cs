﻿namespace SVSU_Capstone_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addGuid : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Quantities", "cabinet_tuid", "dbo.Cabinets");
            DropForeignKey("dbo.Quantities", "commodity_tuid", "dbo.Commodities");
            DropForeignKey("dbo.VendorItems", "commodity_tuid", "dbo.Commodities");
            DropForeignKey("dbo.Logs", "commodity_tuid", "dbo.Commodities");
            DropForeignKey("dbo.Commodities", "category_tuid", "dbo.Categories");
            DropForeignKey("dbo.VendorItems", "vendor_tuid", "dbo.Vendors");
            DropForeignKey("dbo.Quantities", "nlevel_tuid", "dbo.NLevels");
            DropForeignKey("dbo.Cabinets", "room_tuid", "dbo.Rooms");
            DropForeignKey("dbo.Logs", "user_tuid", "dbo.Users");
            DropIndex("dbo.Cabinets", new[] { "room_tuid" });
            DropIndex("dbo.Quantities", new[] { "cabinet_tuid" });
            DropIndex("dbo.Quantities", new[] { "commodity_tuid" });
            DropIndex("dbo.Quantities", new[] { "nlevel_tuid" });
            DropIndex("dbo.Commodities", new[] { "category_tuid" });
            DropIndex("dbo.VendorItems", new[] { "commodity_tuid" });
            DropIndex("dbo.VendorItems", new[] { "vendor_tuid" });
            DropIndex("dbo.Logs", new[] { "commodity_tuid" });
            DropIndex("dbo.Logs", new[] { "user_tuid" });
            DropPrimaryKey("dbo.Cabinets");
            DropPrimaryKey("dbo.Quantities");
            DropPrimaryKey("dbo.Commodities");
            DropPrimaryKey("dbo.Categories");
            DropPrimaryKey("dbo.VendorItems");
            DropPrimaryKey("dbo.Vendors");
            DropPrimaryKey("dbo.NLevels");
            DropPrimaryKey("dbo.Rooms");
            DropPrimaryKey("dbo.Logs");
            DropPrimaryKey("dbo.Users");
            AddColumn("dbo.Rooms", "name", c => c.String());
            AlterColumn("dbo.Cabinets", "tuid", c => c.Guid(nullable: false));
            AlterColumn("dbo.Cabinets", "room_tuid", c => c.Guid());
            AlterColumn("dbo.Quantities", "tuid", c => c.Guid(nullable: false));
            AlterColumn("dbo.Quantities", "cabinet_tuid", c => c.Guid());
            AlterColumn("dbo.Quantities", "commodity_tuid", c => c.Guid());
            AlterColumn("dbo.Quantities", "nlevel_tuid", c => c.Guid());
            AlterColumn("dbo.Commodities", "tuid", c => c.Guid(nullable: false));
            AlterColumn("dbo.Commodities", "category_tuid", c => c.Guid());
            AlterColumn("dbo.Categories", "tuid", c => c.Guid(nullable: false));
            AlterColumn("dbo.VendorItems", "tuid", c => c.Guid(nullable: false));
            AlterColumn("dbo.VendorItems", "commodity_tuid", c => c.Guid());
            AlterColumn("dbo.VendorItems", "vendor_tuid", c => c.Guid());
            AlterColumn("dbo.Vendors", "tuid", c => c.Guid(nullable: false));
            AlterColumn("dbo.NLevels", "tuid", c => c.Guid(nullable: false));
            AlterColumn("dbo.Rooms", "tuid", c => c.Guid(nullable: false));
            AlterColumn("dbo.Logs", "tuid", c => c.Guid(nullable: false));
            AlterColumn("dbo.Logs", "commodity_tuid", c => c.Guid());
            AlterColumn("dbo.Logs", "user_tuid", c => c.Guid());
            AlterColumn("dbo.Users", "tuid", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.Cabinets", "tuid");
            AddPrimaryKey("dbo.Quantities", "tuid");
            AddPrimaryKey("dbo.Commodities", "tuid");
            AddPrimaryKey("dbo.Categories", "tuid");
            AddPrimaryKey("dbo.VendorItems", "tuid");
            AddPrimaryKey("dbo.Vendors", "tuid");
            AddPrimaryKey("dbo.NLevels", "tuid");
            AddPrimaryKey("dbo.Rooms", "tuid");
            AddPrimaryKey("dbo.Logs", "tuid");
            AddPrimaryKey("dbo.Users", "tuid");
            CreateIndex("dbo.Cabinets", "room_tuid");
            CreateIndex("dbo.Quantities", "cabinet_tuid");
            CreateIndex("dbo.Quantities", "commodity_tuid");
            CreateIndex("dbo.Quantities", "nlevel_tuid");
            CreateIndex("dbo.Commodities", "category_tuid");
            CreateIndex("dbo.VendorItems", "commodity_tuid");
            CreateIndex("dbo.VendorItems", "vendor_tuid");
            CreateIndex("dbo.Logs", "commodity_tuid");
            CreateIndex("dbo.Logs", "user_tuid");
            AddForeignKey("dbo.Quantities", "cabinet_tuid", "dbo.Cabinets", "tuid");
            AddForeignKey("dbo.Quantities", "commodity_tuid", "dbo.Commodities", "tuid");
            AddForeignKey("dbo.VendorItems", "commodity_tuid", "dbo.Commodities", "tuid");
            AddForeignKey("dbo.Logs", "commodity_tuid", "dbo.Commodities", "tuid");
            AddForeignKey("dbo.Commodities", "category_tuid", "dbo.Categories", "tuid");
            AddForeignKey("dbo.VendorItems", "vendor_tuid", "dbo.Vendors", "tuid");
            AddForeignKey("dbo.Quantities", "nlevel_tuid", "dbo.NLevels", "tuid");
            AddForeignKey("dbo.Cabinets", "room_tuid", "dbo.Rooms", "tuid");
            AddForeignKey("dbo.Logs", "user_tuid", "dbo.Users", "tuid");
            DropColumn("dbo.Rooms", "room_name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rooms", "room_name", c => c.String());
            DropForeignKey("dbo.Logs", "user_tuid", "dbo.Users");
            DropForeignKey("dbo.Cabinets", "room_tuid", "dbo.Rooms");
            DropForeignKey("dbo.Quantities", "nlevel_tuid", "dbo.NLevels");
            DropForeignKey("dbo.VendorItems", "vendor_tuid", "dbo.Vendors");
            DropForeignKey("dbo.Commodities", "category_tuid", "dbo.Categories");
            DropForeignKey("dbo.Logs", "commodity_tuid", "dbo.Commodities");
            DropForeignKey("dbo.VendorItems", "commodity_tuid", "dbo.Commodities");
            DropForeignKey("dbo.Quantities", "commodity_tuid", "dbo.Commodities");
            DropForeignKey("dbo.Quantities", "cabinet_tuid", "dbo.Cabinets");
            DropIndex("dbo.Logs", new[] { "user_tuid" });
            DropIndex("dbo.Logs", new[] { "commodity_tuid" });
            DropIndex("dbo.VendorItems", new[] { "vendor_tuid" });
            DropIndex("dbo.VendorItems", new[] { "commodity_tuid" });
            DropIndex("dbo.Commodities", new[] { "category_tuid" });
            DropIndex("dbo.Quantities", new[] { "nlevel_tuid" });
            DropIndex("dbo.Quantities", new[] { "commodity_tuid" });
            DropIndex("dbo.Quantities", new[] { "cabinet_tuid" });
            DropIndex("dbo.Cabinets", new[] { "room_tuid" });
            DropPrimaryKey("dbo.Users");
            DropPrimaryKey("dbo.Logs");
            DropPrimaryKey("dbo.Rooms");
            DropPrimaryKey("dbo.NLevels");
            DropPrimaryKey("dbo.Vendors");
            DropPrimaryKey("dbo.VendorItems");
            DropPrimaryKey("dbo.Categories");
            DropPrimaryKey("dbo.Commodities");
            DropPrimaryKey("dbo.Quantities");
            DropPrimaryKey("dbo.Cabinets");
            AlterColumn("dbo.Users", "tuid", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Logs", "user_tuid", c => c.String(maxLength: 128));
            AlterColumn("dbo.Logs", "commodity_tuid", c => c.String(maxLength: 128));
            AlterColumn("dbo.Logs", "tuid", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Rooms", "tuid", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.NLevels", "tuid", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Vendors", "tuid", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.VendorItems", "vendor_tuid", c => c.String(maxLength: 128));
            AlterColumn("dbo.VendorItems", "commodity_tuid", c => c.String(maxLength: 128));
            AlterColumn("dbo.VendorItems", "tuid", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Categories", "tuid", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Commodities", "category_tuid", c => c.String(maxLength: 128));
            AlterColumn("dbo.Commodities", "tuid", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Quantities", "nlevel_tuid", c => c.String(maxLength: 128));
            AlterColumn("dbo.Quantities", "commodity_tuid", c => c.String(maxLength: 128));
            AlterColumn("dbo.Quantities", "cabinet_tuid", c => c.String(maxLength: 128));
            AlterColumn("dbo.Quantities", "tuid", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Cabinets", "room_tuid", c => c.String(maxLength: 128));
            AlterColumn("dbo.Cabinets", "tuid", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Rooms", "name");
            AddPrimaryKey("dbo.Users", "tuid");
            AddPrimaryKey("dbo.Logs", "tuid");
            AddPrimaryKey("dbo.Rooms", "tuid");
            AddPrimaryKey("dbo.NLevels", "tuid");
            AddPrimaryKey("dbo.Vendors", "tuid");
            AddPrimaryKey("dbo.VendorItems", "tuid");
            AddPrimaryKey("dbo.Categories", "tuid");
            AddPrimaryKey("dbo.Commodities", "tuid");
            AddPrimaryKey("dbo.Quantities", "tuid");
            AddPrimaryKey("dbo.Cabinets", "tuid");
            CreateIndex("dbo.Logs", "user_tuid");
            CreateIndex("dbo.Logs", "commodity_tuid");
            CreateIndex("dbo.VendorItems", "vendor_tuid");
            CreateIndex("dbo.VendorItems", "commodity_tuid");
            CreateIndex("dbo.Commodities", "category_tuid");
            CreateIndex("dbo.Quantities", "nlevel_tuid");
            CreateIndex("dbo.Quantities", "commodity_tuid");
            CreateIndex("dbo.Quantities", "cabinet_tuid");
            CreateIndex("dbo.Cabinets", "room_tuid");
            AddForeignKey("dbo.Logs", "user_tuid", "dbo.Users", "tuid");
            AddForeignKey("dbo.Cabinets", "room_tuid", "dbo.Rooms", "tuid");
            AddForeignKey("dbo.Quantities", "nlevel_tuid", "dbo.NLevels", "tuid");
            AddForeignKey("dbo.VendorItems", "vendor_tuid", "dbo.Vendors", "tuid");
            AddForeignKey("dbo.Commodities", "category_tuid", "dbo.Categories", "tuid");
            AddForeignKey("dbo.Logs", "commodity_tuid", "dbo.Commodities", "tuid");
            AddForeignKey("dbo.VendorItems", "commodity_tuid", "dbo.Commodities", "tuid");
            AddForeignKey("dbo.Quantities", "commodity_tuid", "dbo.Commodities", "tuid");
            AddForeignKey("dbo.Quantities", "cabinet_tuid", "dbo.Cabinets", "tuid");
        }
    }
}