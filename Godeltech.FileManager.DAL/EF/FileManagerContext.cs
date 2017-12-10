using Godeltech.FileManager.DAL.Entities;
using Godeltech.FileManager.DAL.Map;

namespace Godeltech.FileManager.DAL.EF
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class FileManagerContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Catalogs> Catalogs { get; set; }
        static FileManagerContext()
        {
           Database.SetInitializer(new FileMangerDbInitializer());
        }

        public FileManagerContext()
            : base("name=FileManagerContext")
        {
           
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UsersMap());
            modelBuilder.Configurations.Add(new CatalogsMap());
            base.OnModelCreating(modelBuilder);
        }
    }

    public class FileMangerDbInitializer : DropCreateDatabaseIfModelChanges<FileManagerContext>
    {
        protected override void Seed(FileManagerContext context)
        {
            context.Users.Add(new Users() {Login = "Misha",Password = "123",CreationDate = DateTime.Now});
            context.Users.Add(new Users() { Login = "Nastya", Password = "123", CreationDate = DateTime.Now });
          
            context.Catalogs.Add(new Catalogs() { Users = new Users() {Login="Msiha"},Name = "Music"});
            context.Catalogs.Add(new Catalogs() { Users = new Users() { Login = "Misha"}, Name = "Rock", ParentId = 1});
            context.Catalogs.Add(new Catalogs() { Users = new Users() { Login = "Nastya"}, Name = "Films" });
            context.Catalogs.Add(new Catalogs() { Users = new Users() { Login = "Nastya" }, Name = "Serials", ParentId = 4});
        }
    }

}