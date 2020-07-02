namespace TravelTripProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateKonumColumnInBlog : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "Konum", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blogs", "Konum");
        }
    }
}
