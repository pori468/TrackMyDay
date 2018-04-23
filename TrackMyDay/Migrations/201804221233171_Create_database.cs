namespace TrackMyDay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_database : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CalanderModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        Titel = c.String(),
                        Description = c.String(),
                        Date = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CalanderModels");
        }
    }
}
