namespace Licenta2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategories : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Categories (Id, Name) VALUES (1, 'Schi')");
            Sql("INSERT INTO Categories (Id, Name) VALUES (2, 'Snowboard')");
            Sql("INSERT INTO Categories (Id, Name) VALUES (3, 'Sanie')");
        }
        
        public override void Down()
        {
        }
    }
}
