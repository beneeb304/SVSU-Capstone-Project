namespace SVSU_Capstone_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class foreignKeyFix : DbMigration
    {
        public override void Up()
        {
            AddForeignKey("dbo.Commodities", "objVendor_uidTuid", "dbo.Vendors", "tuid");
        }
        
        public override void Down()
        {

            DropForeignKey("dbo.Commodities", "objVendor_uidTuid", "dbo.Vendors");
        }
    }
}
