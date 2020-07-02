namespace TravelTripProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateyorumsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.yorums",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        KullaniciAdi = c.String(),
                        Mail = c.String(),
                        Yorum = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.yorums");
        }
    }
}
