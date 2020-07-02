namespace TravelTripProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateStarColumnInOtellersTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Otellers", "Star", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Otellers", "Star");
        }
    }
}
