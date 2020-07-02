namespace TravelTripProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateStarColumnInBlogsTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "Star", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blogs", "Star");
        }
    }
}
