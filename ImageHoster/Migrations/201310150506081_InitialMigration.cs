namespace ImageHoster.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ImageInformation",
                c => new
                    {
                        ImageInformationId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        ImageDataId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ImageInformationId);
            
            CreateTable(
                "dbo.ImageData",
                c => new
                    {
                        ImageDataId = c.Int(nullable: false, identity: true),
                        Image = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.ImageDataId);
            
            CreateTable(
                "dbo.UserProfile",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserProfile");
            DropTable("dbo.ImageData");
            DropTable("dbo.ImageInformation");
        }
    }
}
