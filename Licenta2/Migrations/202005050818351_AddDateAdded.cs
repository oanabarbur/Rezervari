namespace Licenta2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDateAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Equipments", "DateAdded", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Equipments", "DateAdded");
        }
    }
}
