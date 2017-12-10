using System;

namespace Godeltech.FileManager.BLL.DTO
{
    public class FilesDTO
    {
        public string Name { get; set; }
        public string Extension { get; set; }
        public string Path { get; set; }
        public string FileSize { get; set; }
        public DateTime CreationDate { get; set; }
        public string Login { get; set; }
    }
}
