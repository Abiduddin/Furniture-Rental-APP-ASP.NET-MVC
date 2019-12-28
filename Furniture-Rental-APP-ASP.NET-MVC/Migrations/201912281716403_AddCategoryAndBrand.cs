namespace Furniture_Rental_APP_ASP.NET_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoryAndBrand : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Furnitures", "BrandId", c => c.Int(nullable: false));
            AddColumn("dbo.Furnitures", "Category", c => c.String());
            AddColumn("dbo.Furnitures", "CategoryId", c => c.Int(nullable: false));
            AlterColumn("dbo.Furnitures", "Brand", c => c.String());
            DropColumn("dbo.Furnitures", "Type");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Furnitures", "Type", c => c.String());
            AlterColumn("dbo.Furnitures", "Brand", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.Furnitures", "CategoryId");
            DropColumn("dbo.Furnitures", "Category");
            DropColumn("dbo.Furnitures", "BrandId");
            DropTable("dbo.Categories");
            DropTable("dbo.Brands");
        }
    }
}
