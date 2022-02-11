namespace SVSU_Capstone_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class QuanityToStorage : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Quantities", newName: "Storages");
            RenameColumn(table: "dbo.Logs", name: "objCommodity_uidTuid", newName: "Commodity_uidTuid");
            RenameIndex(table: "dbo.Logs", name: "IX_objCommodity_uidTuid", newName: "IX_Commodity_uidTuid");
            AddColumn("dbo.Logs", "objStorage_uidTuid", c => c.Guid());
            CreateIndex("dbo.Logs", "objStorage_uidTuid");
            AddForeignKey("dbo.Logs", "objStorage_uidTuid", "dbo.Storages", "tuid");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Logs", "objStorage_uidTuid", "dbo.Storages");
            DropIndex("dbo.Logs", new[] { "objStorage_uidTuid" });
            DropColumn("dbo.Logs", "objStorage_uidTuid");
            RenameIndex(table: "dbo.Logs", name: "IX_Commodity_uidTuid", newName: "IX_objCommodity_uidTuid");
            RenameColumn(table: "dbo.Logs", name: "Commodity_uidTuid", newName: "objCommodity_uidTuid");
            RenameTable(name: "dbo.Storages", newName: "Quantities");
        }
    }
}
