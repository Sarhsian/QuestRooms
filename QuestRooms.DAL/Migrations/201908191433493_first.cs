namespace QuestRooms.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adresses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        City_ID = c.Int(nullable: false),
                        Country_ID = c.Int(nullable: false),
                        Street_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Cities", t => t.City_ID, cascadeDelete: true)
                .ForeignKey("dbo.Countries", t => t.Country_ID, cascadeDelete: true)
                .ForeignKey("dbo.Streets", t => t.Street_ID, cascadeDelete: true)
                .Index(t => t.City_ID)
                .Index(t => t.Country_ID)
                .Index(t => t.Street_ID);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        TimeOfCompliting = c.Time(nullable: false, precision: 7),
                        MinCountOfPlayers = c.Int(nullable: false),
                        MaxCountOfPlayers = c.Int(nullable: false),
                        MinAgeOfPlayers = c.Int(nullable: false),
                        PhoneNumber = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Rating = c.Double(nullable: false),
                        LvlOfFear = c.Int(nullable: false),
                        LvlOfDifficulty = c.Int(nullable: false),
                        Logo = c.String(nullable: false),
                        Adress_ID = c.Int(),
                        Images_ID = c.Int(),
                        Company_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Adresses", t => t.Adress_ID)
                .ForeignKey("dbo.Images", t => t.Images_ID)
                .ForeignKey("dbo.Companies", t => t.Company_ID)
                .Index(t => t.Adress_ID)
                .Index(t => t.Images_ID)
                .Index(t => t.Company_ID);
            
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Path = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Streets",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rooms", "Company_ID", "dbo.Companies");
            DropForeignKey("dbo.Adresses", "Street_ID", "dbo.Streets");
            DropForeignKey("dbo.Rooms", "Images_ID", "dbo.Images");
            DropForeignKey("dbo.Rooms", "Adress_ID", "dbo.Adresses");
            DropForeignKey("dbo.Adresses", "Country_ID", "dbo.Countries");
            DropForeignKey("dbo.Adresses", "City_ID", "dbo.Cities");
            DropIndex("dbo.Rooms", new[] { "Company_ID" });
            DropIndex("dbo.Rooms", new[] { "Images_ID" });
            DropIndex("dbo.Rooms", new[] { "Adress_ID" });
            DropIndex("dbo.Adresses", new[] { "Street_ID" });
            DropIndex("dbo.Adresses", new[] { "Country_ID" });
            DropIndex("dbo.Adresses", new[] { "City_ID" });
            DropTable("dbo.Companies");
            DropTable("dbo.Streets");
            DropTable("dbo.Images");
            DropTable("dbo.Rooms");
            DropTable("dbo.Countries");
            DropTable("dbo.Cities");
            DropTable("dbo.Adresses");
        }
    }
}
