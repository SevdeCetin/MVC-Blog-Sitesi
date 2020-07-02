namespace TravelTripProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMyorumsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Myorums",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        KullaniciAdi = c.String(),
                        Mail = c.String(),
                        Yorum = c.String(),
                        MuzeID = c.Int(nullable: false),
                        Muzeler_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Muzelers", t => t.Muzeler_ID)
                .Index(t => t.Muzeler_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Myorums", "Muzeler_ID", "dbo.Muzelers");
            DropIndex("dbo.Myorums", new[] { "Muzeler_ID" });
            DropTable("dbo.Myorums");
        }
    }
}
