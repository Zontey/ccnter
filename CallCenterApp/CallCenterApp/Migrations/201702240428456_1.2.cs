namespace CallCenterApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _12 : DbMigration
    {
        public override void Up()
        {
            AddColumn("Contractor", "WhoCreatedName", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("Contractor", "WhoCreatedName");
        }
    }
}
