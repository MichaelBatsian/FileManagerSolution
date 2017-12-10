using System;

namespace Godeltech.FileManager.DAL.Entities
{
    public class Catalogs
    {
        public int CatalogId { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }=DateTime.Now;
        public DateTime ModificationDate { get; set; }=DateTime.Now;
        public int ParentId { get; set; }

        public virtual Users Users { get; set; }
    }
}
