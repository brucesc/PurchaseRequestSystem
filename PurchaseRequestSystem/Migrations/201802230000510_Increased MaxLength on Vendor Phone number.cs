namespace PurchaseRequestSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IncreasedMaxLengthonVendorPhonenumber : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Vendors", "Phone", c => c.String(nullable: false, maxLength: 18));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vendors", "Phone", c => c.String(nullable: false, maxLength: 12));
        }
    }
}
