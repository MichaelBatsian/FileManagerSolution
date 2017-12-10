using System;
using System.Collections.Generic;
using System.Linq;
using Godeltech.FileManager.DAL.EF;
using Godeltech.FileManager.DAL.Entities;
using Godeltech.FileManager.DAL.Interfaces;

namespace Godeltech.FileManager.DAL.Repositories
{
    public class UsersRepository:IRepository<Users>
    {
        private readonly FileManagerContext _context;

        public UsersRepository(FileManagerContext context)
        {
            _context = context;
        }
        public IEnumerable<Users> GetAll()
        {
            return _context.Users;
        }

        public Users Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Users> Find(Func<Users, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public void Create(Users item)
        {
            throw new NotImplementedException();
        }

        public void Update(Users item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Users> IRepository<Users>.GetAll()
        {
            throw new NotImplementedException();
        }

        List<Users> IRepository<Users>.Find(Func<Users, bool> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
