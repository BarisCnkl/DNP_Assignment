using System.Threading.Tasks;
using ApiContracts;

namespace BlazorApp.Services
{
    public interface IAuthService
    {
        Task<UserDTO> LoginAsync(string username, string password);
    }
}