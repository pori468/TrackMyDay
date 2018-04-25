namespace TrackMyDay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class job3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.JobModels", "ApplyDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.JobModels", "Announcement", c => c.String());
            AlterColumn("dbo.JobModels", "ApplyThrough", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.JobModels", "ApplyThrough", c => c.Boolean(nullable: false));
            AlterColumn("dbo.JobModels", "Announcement", c => c.Boolean(nullable: false));
            DropColumn("dbo.JobModels", "ApplyDate");
        }
    }
}
