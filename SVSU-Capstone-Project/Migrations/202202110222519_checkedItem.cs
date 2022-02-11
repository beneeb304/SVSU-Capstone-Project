namespace SVSU_Capstone_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class checkedItem : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Categories", name: "strName", newName: "name");
            CreateTable(
                "dbo.CheckedItems",
                c => new
                    {
                        tuid = c.Guid(nullable: false),
                        objCommodities_uidTuid = c.Guid(),
                        objUser_uidTuid = c.Guid(),
                        objLog_uidTuid = c.Guid(),
                    })
                .PrimaryKey(t => t.tuid)
                .ForeignKey("dbo.Commodities", t => t.objCommodities_uidTuid)
                .ForeignKey("dbo.Users", t => t.objUser_uidTuid)
                .ForeignKey("dbo.Logs", t => t.objLog_uidTuid)
                .Index(t => t.objCommodities_uidTuid)
                .Index(t => t.objUser_uidTuid)
                .Index(t => t.objLog_uidTuid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CheckedItems", "objLog_uidTuid", "dbo.Logs");
            DropForeignKey("dbo.CheckedItems", "objUser_uidTuid", "dbo.Users");
            DropForeignKey("dbo.CheckedItems", "objCommodities_uidTuid", "dbo.Commodities");
            DropIndex("dbo.CheckedItems", new[] { "objLog_uidTuid" });
            DropIndex("dbo.CheckedItems", new[] { "objUser_uidTuid" });
            DropIndex("dbo.CheckedItems", new[] { "objCommodities_uidTuid" });
            DropTable("dbo.CheckedItems");
            RenameColumn(table: "dbo.Categories", name: "name", newName: "strName");
        }
    }
}
