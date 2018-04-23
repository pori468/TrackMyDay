namespace TrackMyDay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class df : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.JobModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        Position = c.String(),
                        Company = c.String(),
                        Address = c.String(),
                        Type = c.String(),
                        Weblink = c.String(),
                        Announcement = c.Boolean(nullable: false),
                        ContacInfo = c.String(),
                        ApplyThrough = c.Boolean(nullable: false),
                        Status = c.String(),
                        Date = c.DateTime(nullable: false),
                        Refferance = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.JobModels");
        }
    }
}
