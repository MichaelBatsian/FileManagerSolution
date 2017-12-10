namespace Godeltech.FileManager.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFilesMigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Files", new[] { "Catalogs_CatalogId", "Catalogs_Name" }, "dbo.Catalogs");
            DropIndex("dbo.Files", new[] { "Catalogs_CatalogId", "Catalogs_Name" });
            RenameColumn(table: "dbo.Files", name: "Catalogs_CatalogId", newName: "CatalogId");
            DropPrimaryKey("dbo.Catalogs");
            AlterColumn("dbo.Catalogs", "CatalogId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Catalogs", "CatalogId");
            CreateIndex("dbo.Catalogs", new[] { "CatalogId", "Name" }, unique: true);
            CreateIndex("dbo.Files", new[] { "FileId", "Name" }, unique: true);
            CreateIndex("dbo.Files", "CatalogId");
            AddForeignKey("dbo.Files", "CatalogId", "dbo.Catalogs", "CatalogId", cascadeDelete: true);
            DropColumn("dbo.Files", "Catalogs_Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Files", "Catalogs_Name", c => c.String(nullable: false, maxLength: 250));
            DropForeignKey("dbo.Files", "CatalogId", "dbo.Catalogs");
            DropIndex("dbo.Files", new[] { "CatalogId" });
            DropIndex("dbo.Files", new[] { "FileId", "Name" });
            DropIndex("dbo.Catalogs", new[] { "CatalogId", "Name" });
            DropPrimaryKey("dbo.Catalogs");
            AlterColumn("dbo.Catalogs", "CatalogId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Catalogs", new[] { "CatalogId", "Name" });
            RenameColumn(table: "dbo.Files", name: "CatalogId", newName: "Catalogs_CatalogId");
            CreateIndex("dbo.Files", new[] { "Catalogs_CatalogId", "Catalogs_Name" });
            AddForeignKey("dbo.Files", new[] { "Catalogs_CatalogId", "Catalogs_Name" }, "dbo.Catalogs", new[] { "CatalogId", "Name" }, cascadeDelete: true);
        }
    }
}
