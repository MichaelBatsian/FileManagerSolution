using System;
using System.Collections.Generic;
using Godeltech.FileManager.DAL.EF;
using Godeltech.FileManager.DAL.Entities;
using Godeltech.FileManager.DAL.Interfaces;

namespace Godeltech.FileManager.DAL.Repositories
{
    public class FilesRepository:IRepository<Files>
    {
        private FileManagerContext _context;

        public FilesRepository(FileManagerContext context)
        {
            _context = context;
        }
        public IEnumerable<Files> GetAll()
        {
            return _context.Files;
        }

        public Files Get(Files item)
        {
            throw new NotImplementedException();
        }

        public List<Files> Find(Func<Files, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public void Create(Files item)
        {
            _context.Files.Add(item);
            _context.SaveChanges();
        }

        public void Update(Files item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Files id)
        {
            throw new NotImplementedException();
        }
    }
}
