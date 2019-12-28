namespace Furniture_Rental_APP_ASP.NET_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotationsToClasses : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Furnitures", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Furnitures", "Brand", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Furnitures", "Brand", c => c.String());
            AlterColumn("dbo.Furnitures", "Name", c => c.String());
            AlterColumn("dbo.Customers", "Name", c => c.String());
        }
    }
}
