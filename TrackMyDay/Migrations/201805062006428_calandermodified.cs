namespace TrackMyDay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class calandermodified : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CalanderModels", "Repeat", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CalanderModels", "Repeat");
        }
    }
}
