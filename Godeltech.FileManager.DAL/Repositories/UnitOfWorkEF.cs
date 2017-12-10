using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Godeltech.FileManager.DAL.Entities;
using Godeltech.FileManager.DAL.Interfaces;

namespace Godeltech.FileManager.DAL.Repositories
{
    public class UnitOfWorkEF:IUnitOfWork
    {
        private bool _disposed = false;
        

        public virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this._disposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public IRepository<Users> Users { get; }
        public IRepository<Catalogs> Catalogs { get; }
        public IRepository<Files> Files { get; }
        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
