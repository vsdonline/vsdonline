namespace VSDOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class chantings : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Chantings",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        MantraCount = c.Int(nullable: false),
                        Email = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        Approved = c.Boolean(),
                        CreateDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Chantings");
        }
    }
}
