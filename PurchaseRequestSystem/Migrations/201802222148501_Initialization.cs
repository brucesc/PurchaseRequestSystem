namespace PurchaseRequestSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialization : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "DateCreated", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Products", "DateUpdated", c => c.DateTime());
            AlterColumn("dbo.PurchaseRequests", "DateUpdated", c => c.DateTime());
            AlterColumn("dbo.Users", "DateUpdated", c => c.DateTime());
            AlterColumn("dbo.Vendors", "DateUpdated", c => c.DateTime());
            CreateIndex("dbo.Products", "VendorId");
            CreateIndex("dbo.PurchaseRequests", "UserId");
            CreateIndex("dbo.PurchaseRequestLineItems", "PurchaseRequestId");
            CreateIndex("dbo.PurchaseRequestLineItems", "ProductId");
            AddForeignKey("dbo.Products", "VendorId", "dbo.Vendors", "Id", cascadeDelete: true);
            AddForeignKey("dbo.PurchaseRequests", "UserId", "dbo.Users", "Id", cascadeDelete: true);
            AddForeignKey("dbo.PurchaseRequestLineItems", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
            AddForeignKey("dbo.PurchaseRequestLineItems", "PurchaseRequestId", "dbo.PurchaseRequests", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PurchaseRequestLineItems", "PurchaseRequestId", "dbo.PurchaseRequests");
            DropForeignKey("dbo.PurchaseRequestLineItems", "ProductId", "dbo.Products");
            DropForeignKey("dbo.PurchaseRequests", "UserId", "dbo.Users");
            DropForeignKey("dbo.Products", "VendorId", "dbo.Vendors");
            DropIndex("dbo.PurchaseRequestLineItems", new[] { "ProductId" });
            DropIndex("dbo.PurchaseRequestLineItems", new[] { "PurchaseRequestId" });
            DropIndex("dbo.PurchaseRequests", new[] { "UserId" });
            DropIndex("dbo.Products", new[] { "VendorId" });
            AlterColumn("dbo.Vendors", "DateUpdated", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Users", "DateUpdated", c => c.DateTime(nullable: false));
            AlterColumn("dbo.PurchaseRequests", "DateUpdated", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Products", "DateUpdated", c => c.DateTime(nullable: false));
            DropColumn("dbo.Users", "DateCreated");
        }
    }
}
