namespace TrackMyDay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JobModelModified : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.JobModels", "NextAction", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.JobModels", "NextAction");
        }
    }
}
