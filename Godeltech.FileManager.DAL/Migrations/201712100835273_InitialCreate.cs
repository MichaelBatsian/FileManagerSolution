namespace Godeltech.FileManager.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Login = c.String(nullable: false, maxLength: 30),
                        Password = c.String(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Login);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
