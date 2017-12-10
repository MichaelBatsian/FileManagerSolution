namespace Godeltech.FileManager.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCatalogMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Catalogs",
                c => new
                    {
                        CatalogId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 250),
                        CreationDate = c.DateTime(nullable: false),
                        ModificationDate = c.DateTime(nullable: false),
                        ParentId = c.Int(nullable: false),
                        Users_Login = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.CatalogId)
                .ForeignKey("dbo.Users", t => t.Users_Login, cascadeDelete: true)
                .Index(t => t.Users_Login);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Catalogs", "Users_Login", "dbo.Users");
            DropIndex("dbo.Catalogs", new[] { "Users_Login" });
            DropTable("dbo.Catalogs");
        }
    }
}
