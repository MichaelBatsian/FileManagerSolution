
namespace Godeltech.FileManager.BLL.Interfaces
{
    public interface IAuthentication
    {
        bool IsUser(string login, string password);
    }
}
