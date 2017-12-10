using System.Data.Entity.ModelConfiguration;
using Godeltech.FileManager.DAL.Entities;

namespace Godeltech.FileManager.DAL.Map
{
    internal class FilesMap:EntityTypeConfiguration<Files>
    {
        internal FilesMap()
        {
            HasKey(f =>new {f.FileId,f.Name});
            HasIndex(f => new { f.FileId, f.Name }).IsUnique(true);
            Property(f => f.Name).IsRequired().HasMaxLength(250);
            Property(f => f.Extension).IsRequired().HasMaxLength(20);
        }
    }
}
