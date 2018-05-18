namespace TrackMyDay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatecalandermodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CalanderModels", "Event", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CalanderModels", "Event");
        }
    }
}
