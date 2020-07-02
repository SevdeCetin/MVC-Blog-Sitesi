namespace TravelTripProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMuzeIDColumnInYorumlarsTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Yorumlars", "MuzeID");
        }
        
        public override void Down()
        {
            
            AddColumn("dbo.Yorumlars", "MuzeID", c => c.Int(nullable: false));
        }
    }
}
