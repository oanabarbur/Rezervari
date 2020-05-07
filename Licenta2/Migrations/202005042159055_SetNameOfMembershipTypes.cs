namespace Licenta2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetNameOfMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = 'Pay as You Go' WHERE Id = 1");
            Sql("UPDATE MembershipTypes SET Name = 'Weekly' WHERE Id = 2");
            Sql("UPDATE MembershipTypes SET Name = 'Monthly' WHERE Id = 3");


        }

        public override void Down()
        {
        }
    }
}
