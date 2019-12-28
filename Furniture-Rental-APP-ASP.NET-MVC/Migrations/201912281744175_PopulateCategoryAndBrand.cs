namespace Furniture_Rental_APP_ASP.NET_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryAndBrand : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Categories (Name) VALUES ('Bedroom')");
            Sql("INSERT INTO Categories (Name) VALUES ('Dining')");
            Sql("INSERT INTO Categories (Name) VALUES ('Office Chair')");
            Sql("INSERT INTO Categories (Name) VALUES ('Office Table')");

            Sql("INSERT INTO Brands (Name) VALUES ('Brothers')");
            Sql("INSERT INTO Brands (Name) VALUES ('Partex')");
            Sql("INSERT INTO Brands (Name) VALUES ('Otobi')");
            Sql("INSERT INTO Brands (Name) VALUES ('Nadia')");
        }
        
        public override void Down()
        {
        }
    }
}
