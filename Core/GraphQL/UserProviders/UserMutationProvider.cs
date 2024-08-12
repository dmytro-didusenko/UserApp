using Core.DataManager.Models;
using Core.Interfaces;

namespace Core.GraphQL.UserProviders
{
    public class UserMutationProvider
    {
        public async Task<User> AddUser(User user, [Service] IUserService userService) =>
            await userService.CreateUserAsync(user);

        public async Task<User> UpdateUser(User user, [Service] IUserService userService) =>
            await userService.UpdateUserAsync(user);

        public async Task<bool> RemoveUser(int userId, [Service] IUserService userService) =>
            await userService.DeleteUser(userId);
    }
}
