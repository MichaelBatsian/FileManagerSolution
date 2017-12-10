using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Godeltech.FileManager.BLL.DTO;

namespace Godeltech.FileManager.BLL.Interfaces
{
    public interface ICatalogsService
    {
        CatalogsDTO Get(string path);
        void Create(string name, string path);
        void Move(string oldPath, string newPath);
        void Remove(string path);
        List<CatalogsDTO> GetSubCatalogs(string parentPath);
        CatalogsDTO Find(string path);
    }
}
