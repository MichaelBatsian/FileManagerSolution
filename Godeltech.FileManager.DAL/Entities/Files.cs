using System;

namespace Godeltech.FileManager.DAL.Entities
{
    public class Files
    {
        public int FileId { get; set; }
        public string Name { get; set; }
        public string Extension { get; set; }
        public int Size { get; set; } 
        public DateTime  CreationDate { get; set; }
        public int DownloadsNumber { get; set; }

        public virtual Catalogs Catalogs { get; set; }

    }
}
