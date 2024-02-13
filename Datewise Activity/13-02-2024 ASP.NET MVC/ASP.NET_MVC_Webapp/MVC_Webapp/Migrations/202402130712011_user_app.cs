namespace MVC_Webapp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class user_app : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UsersModels",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false),
                        PasswordHash = c.String(nullable: false),
                        RegistrationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UsersModels");
        }
    }
}
