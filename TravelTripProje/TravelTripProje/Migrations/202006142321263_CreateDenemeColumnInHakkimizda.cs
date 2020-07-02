namespace TravelTripProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDenemeColumnInHakkimizda : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Hakkimizdas", "Deneme", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Hakkimizdas", "Deneme");
        }
    }
}
