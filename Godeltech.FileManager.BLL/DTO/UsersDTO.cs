using System;

namespace Godeltech.FileManager.BLL.DTO
{
    public class UsersDTO
    {
        public string Login { get; set; }
        public DateTime CreationDate { get; set; }
        public double UsedStorage { get; set; }
    }
}
