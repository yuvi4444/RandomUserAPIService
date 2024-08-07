using RandomUserAPIService.Models;
using System.Threading.Tasks;

namespace RandomUserAPIService.Services
{
    public interface IUserService
    {
        Task<User> GetRandomUserAsync();
    }
}
