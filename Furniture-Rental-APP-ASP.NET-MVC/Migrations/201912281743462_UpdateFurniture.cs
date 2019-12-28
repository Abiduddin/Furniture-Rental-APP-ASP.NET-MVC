namespace Furniture_Rental_APP_ASP.NET_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateFurniture : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Furnitures", "BrandId");
            CreateIndex("dbo.Furnitures", "CategoryId");
            AddForeignKey("dbo.Furnitures", "BrandId", "dbo.Brands", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Furnitures", "CategoryId", "dbo.Categories", "Id", cascadeDelete: true);
            DropColumn("dbo.Furnitures", "Brand");
            DropColumn("dbo.Furnitures", "Category");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Furnitures", "Category", c => c.String());
            AddColumn("dbo.Furnitures", "Brand", c => c.String());
            DropForeignKey("dbo.Furnitures", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Furnitures", "BrandId", "dbo.Brands");
            DropIndex("dbo.Furnitures", new[] { "CategoryId" });
            DropIndex("dbo.Furnitures", new[] { "BrandId" });
        }
    }
}
