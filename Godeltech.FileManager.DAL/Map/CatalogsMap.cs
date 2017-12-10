using System.Data.Entity.ModelConfiguration;
using Godeltech.FileManager.DAL.Entities;

namespace Godeltech.FileManager.DAL.Map
{
    internal class CatalogsMap:EntityTypeConfiguration<Catalogs>
    {
        internal CatalogsMap()
        {
            HasKey(c => c.CatalogId);
            Property(c => c.Name).HasMaxLength(250);
        }

    }
}
