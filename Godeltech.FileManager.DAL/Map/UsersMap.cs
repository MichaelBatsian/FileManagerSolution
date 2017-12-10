using System.Data.Entity.ModelConfiguration;
using Godeltech.FileManager.DAL.Entities;

namespace Godeltech.FileManager.DAL.Map
{
    internal class UsersMap: EntityTypeConfiguration<Users>
    {
        internal UsersMap()
        {
            HasKey(u => u.Login).Property(u => u.Login).HasMaxLength(30);
            Property(u => u.Password).IsRequired();
            Property(u => u.CreationDate).IsRequired();
            HasMany(u => u.Catalogs).WithRequired(u => u.Users);
        }
    }
}
