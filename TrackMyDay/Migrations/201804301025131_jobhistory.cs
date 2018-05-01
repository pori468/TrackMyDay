namespace TrackMyDay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class jobhistory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.JobHistoryModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        JobId = c.String(),
                        UserId = c.String(),
                        ActionDate = c.DateTime(nullable: false),
                        NextActionDate = c.DateTime(nullable: false),
                        ActionDetails = c.String(nullable: false),
                        NextAction = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.JobHistoryModels");
        }
    }
}
