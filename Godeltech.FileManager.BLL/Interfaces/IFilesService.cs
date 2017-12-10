using Godeltech.FileManager.BLL.DTO;

namespace Godeltech.FileManager.BLL.Interfaces
{
    public interface IFilesService
    {
        void Upload(string pathFile, string storagePath);
        void Download(string pathFile, string downloadPath);
        void Move(string pathFile, string destinationPath);
        void Remove(string pathFile);
        FilesDTO Get();
    }
}
