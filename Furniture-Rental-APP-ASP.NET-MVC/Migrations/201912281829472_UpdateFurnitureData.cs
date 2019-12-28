namespace Furniture_Rental_APP_ASP.NET_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateFurnitureData : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Furnitures SET Stock = 5 ");
        }
        
        public override void Down()
        {
        }
    }
}
