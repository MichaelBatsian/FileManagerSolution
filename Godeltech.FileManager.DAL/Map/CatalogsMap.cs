using System.Data.Entity.ModelConfiguration;
using Godeltech.FileManager.DAL.Entities;

namespace Godeltech.FileManager.DAL.Map
{
    internal class CatalogsMap:EntityTypeConfiguration<Catalogs>
    {
        internal CatalogsMap()
        {
            HasKey(c =>  c.CatalogId);
            HasIndex(c => new {c.CatalogId, c.Name}).IsUnique(true);
            Property(c => c.Name).IsRequired().HasMaxLength(250);
            Property(c => c.ModificationDate).IsOptional();
            HasMany(c => c.Files)
                .WithRequired(f => f.Catalogs)
                .Map(f=>f.MapKey("CatalogId"));
        }
    }
}
