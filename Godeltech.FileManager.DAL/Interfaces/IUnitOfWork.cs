using System;
using Godeltech.FileManager.DAL.Entities;

namespace Godeltech.FileManager.DAL.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {
        IRepository<Users> Users { get; }
        IRepository<Catalogs> Catalogs { get; }
        IRepository<Files> Files { get; }
        void Save();
    }
}
