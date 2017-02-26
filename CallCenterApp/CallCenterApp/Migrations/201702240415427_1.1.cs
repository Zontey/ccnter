namespace CallCenterApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _11 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Contractor",
                c => new
                    {
                        ContractorID = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(unicode: false),
                        NIP = c.String(unicode: false),
                        DateOfContract = c.DateTime(nullable: false, precision: 0),
                        DateOfAppointment = c.DateTime(nullable: false, precision: 0),
                        OthersInfo = c.String(unicode: false),
                        WhoCreatedUserID = c.Int(),
                        TelNumber = c.String(unicode: false),
                        Voivodeship = c.String(unicode: false),
                        Tariff = c.String(unicode: false),
                        Adress = c.String(unicode: false),
                        Contact = c.DateTime(nullable: false, precision: 0),
                        LaunchDate = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.ContractorID)                
                .ForeignKey("User", t => t.WhoCreatedUserID)
                .Index(t => t.WhoCreatedUserID);
            
            CreateTable(
                "User",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        Password = c.String(unicode: false),
                        Description = c.String(unicode: false),
                        IsAdmin = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UserID)                ;
            
        }
        
        public override void Down()
        {
            DropForeignKey("Contractor", "WhoCreatedUserID", "User");
            DropIndex("Contractor", new[] { "WhoCreatedUserID" });
            DropTable("User");
            DropTable("Contractor");
        }
    }
}
