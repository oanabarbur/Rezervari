namespace Licenta2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Equipments", "CategoryId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Equipments", "CategoryId");
            AddForeignKey("dbo.Equipments", "CategoryId", "dbo.Categories", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Equipments", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Equipments", new[] { "CategoryId" });
            DropColumn("dbo.Equipments", "CategoryId");
            DropTable("dbo.Categories");
        }
    }
}
