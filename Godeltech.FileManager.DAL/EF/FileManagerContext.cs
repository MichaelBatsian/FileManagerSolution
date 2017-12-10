using System;
using System.Data.Entity;
using Godeltech.FileManager.DAL.Entities;
using Godeltech.FileManager.DAL.Map;

namespace Godeltech.FileManager.DAL.EF
{
   public class FileManagerContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Catalogs> Catalogs { get; set; }
        public DbSet<Files> Files { get; set; }
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
            modelBuilder.Configurations.Add(new FilesMap());
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

            context.Files.Add(new Files()
            {
                Name = "On the border the key is broken in half",
                CreationDate = DateTime.Now,
                DownloadsNumber = 0,
                Extension = ".mp3",
                Size = 5200,
                Catalogs = new Catalogs() { CatalogId = 2}
            });
            context.Files.Add(new Files()
            {
                Name = "The Ge of Thrones",
                CreationDate = DateTime.Now,
                DownloadsNumber = 0,
                Extension = ".avi",
                Size = 600000,
                Catalogs = new Catalogs() { CatalogId = 4 }
            });
        }
    }

}