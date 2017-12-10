using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;

namespace Godeltech.FileManager.DAL.Entities
{
    public class Users
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual ICollection<Catalogs> Catalogs { get; set; } = new List<Catalogs>();

    }
}
