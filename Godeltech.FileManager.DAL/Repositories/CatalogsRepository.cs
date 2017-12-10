using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Godeltech.FileManager.DAL.EF;
using Godeltech.FileManager.DAL.Entities;
using Godeltech.FileManager.DAL.Interfaces;

namespace Godeltech.FileManager.DAL.Repositories
{
    public class CatalogsRepository:IRepository<Catalogs>
    {
        private FileManagerContext _context;

        public CatalogsRepository(FileManagerContext context)
        {
            _context = context;
        }
        public IEnumerable<Catalogs> GetAll()
        {
            throw new NotImplementedException();
        }

        public Catalogs Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Catalogs> Find(Func<Catalogs, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public void Create(Catalogs item)
        {
            throw new NotImplementedException();
        }

        public void Update(Catalogs item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
