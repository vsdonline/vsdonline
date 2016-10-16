namespace VSDOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SiteConfig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SiteConfigs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Value = c.String(),
                        Description = c.String(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SiteConfigs");
        }
    }
}
