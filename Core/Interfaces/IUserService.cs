using Core.DataManager.Models;

namespace Core.Interfaces
{
    public interface IUserService
    {
        Task<User> CreateUserAsync(User user);
        Task<IEnumerable<User>> GetUsersAsync();
        Task<User?> GetUserByIdAsync(int userId);
        Task<User> UpdateUserAsync(User user);
        Task<bool> DeleteUser(int userId);
    }
}
