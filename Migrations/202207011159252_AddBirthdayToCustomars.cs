namespace Filmovi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthdayToCustomars : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = 01-02-1993 WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
