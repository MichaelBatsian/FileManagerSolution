using System;

namespace Godeltech.FileManager.BLL.DTO
{
    public class CatalogsDTO
    {
        public string Name { get; set; } 
        public string Path { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
        public double Size { get; set; }
        public string Login { get; set; }
    }
}
