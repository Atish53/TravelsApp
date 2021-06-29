namespace TravelsApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmailNotRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Quotes", "EmailAddress", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Quotes", "EmailAddress", c => c.String(nullable: false));
        }
    }
}
