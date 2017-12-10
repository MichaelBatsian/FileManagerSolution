namespace Godeltech.FileManager.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCatalogMigration : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Catalogs", name: "Users_Login", newName: "Login");
            RenameIndex(table: "dbo.Catalogs", name: "IX_Users_Login", newName: "IX_Login");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Catalogs", name: "IX_Login", newName: "IX_Users_Login");
            RenameColumn(table: "dbo.Catalogs", name: "Login", newName: "Users_Login");
        }
    }
}
