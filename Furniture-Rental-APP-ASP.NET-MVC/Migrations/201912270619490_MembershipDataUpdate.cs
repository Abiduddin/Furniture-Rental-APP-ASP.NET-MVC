namespace Furniture_Rental_APP_ASP.NET_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MembershipDataUpdate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Name = 'Kalim Amzad' WHERE Id = 1 ");
            Sql("UPDATE Customers SET Name = 'Asif Bin' WHERE Id = 2 ");
            Sql("UPDATE Customers SET Name = 'Salman Kha' WHERE Id = 3 ");
            Sql("UPDATE Customers SET Name = 'Tuhin Hasan' WHERE Id = 4 ");

            Sql("UPDATE MembershipTypes SET Name = 'Pay as You Go' WHERE Id = 1 ");
            Sql("UPDATE MembershipTypes SET Name = 'Monthly' WHERE Id = 2 ");
            Sql("UPDATE MembershipTypes SET Name = 'Quarterly' WHERE Id = 3 ");
            Sql("UPDATE MembershipTypes SET Name = 'Yearly' WHERE Id = 4 ");

        }
        
        public override void Down()
        {
        }
    }
}
