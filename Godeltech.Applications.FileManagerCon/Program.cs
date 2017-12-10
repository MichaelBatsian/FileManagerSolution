using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Godeltech.FileManager.DAL.EF;
using Godeltech.FileManager.DAL.Repositories;

namespace Godeltech.Applications.FileManagerCon
{
    class Program
    {
        static void Main(string[] args)
        {
            var rep = new UsersRepository(new FileManagerContext());
            var users = rep.GetAll();
            foreach (var item in users)
            {
                Console.WriteLine(item.Login);
            }
            Console.ReadKey();
        }
    }
}
