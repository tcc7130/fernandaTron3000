namespace FernandaTron3000.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Criteria",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Attachment = c.String(),
                        WorkmanshipId = c.Int(nullable: false),
                        Criteria_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Criteria", t => t.Criteria_Id)
                .ForeignKey("dbo.Workmanships", t => t.WorkmanshipId, cascadeDelete: true)
                .Index(t => t.WorkmanshipId)
                .Index(t => t.Criteria_Id);
            
            CreateTable(
                "dbo.Workmanships",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Criteria", "WorkmanshipId", "dbo.Workmanships");
            DropForeignKey("dbo.Criteria", "Criteria_Id", "dbo.Criteria");
            DropIndex("dbo.Criteria", new[] { "Criteria_Id" });
            DropIndex("dbo.Criteria", new[] { "WorkmanshipId" });
            DropTable("dbo.Workmanships");
            DropTable("dbo.Criteria");
        }
    }
}
