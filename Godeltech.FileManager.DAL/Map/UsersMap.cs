using System.Data.Entity.ModelConfiguration;
using Godeltech.FileManager.DAL.Entities;

namespace Godeltech.FileManager.DAL.Map
{
    internal class UsersMap: EntityTypeConfiguration<Users>
    {
        internal UsersMap()
        {
            HasKey(u => u.Login).Property(u => u.Login).HasMaxLength(30);
            Property(u => u.Password).IsRequired().HasMaxLength(120);
            Property(u => u.CreationDate).IsRequired();
            HasMany(u => u.Catalogs)
                .WithRequired(c => c.Users)
                .Map(c=>c.MapKey("Login"));
        }
    }
}
