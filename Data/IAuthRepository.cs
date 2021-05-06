using System.Threading.Tasks;
using myfirstapi.Models;

namespace myfirstapi.Data
{
    public interface IAuthRepository
    {
        Task<ServiceResponse<int>> Register(CharUser user, string password);
        Task<ServiceResponse<string>> Login(string username, string password);
        Task<bool> UserExists(string username);
    }
}