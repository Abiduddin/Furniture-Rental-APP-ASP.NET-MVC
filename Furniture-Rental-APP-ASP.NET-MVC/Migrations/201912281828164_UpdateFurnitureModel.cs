namespace Furniture_Rental_APP_ASP.NET_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateFurnitureModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Furnitures", "Stock", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Furnitures", "Stock");
        }
    }
}
