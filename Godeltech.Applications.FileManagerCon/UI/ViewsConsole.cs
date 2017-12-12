using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Godeltech.Applications.FileManagerCon.UI
{
    public static class ViewsConsole
    {
        public static void AccessDenided()
        {
            Console.WriteLine("Password or login is incorrect");
        }

        public static void UserInterface()
        {
            var exit = true;
            while (exit)
            {
                var command = Console.ReadLine();
                switch (command)
                {
                    case ""
                }
            }

        }
    }
}
