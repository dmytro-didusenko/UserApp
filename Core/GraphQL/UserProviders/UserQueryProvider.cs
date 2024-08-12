using Core.DataManager.Models;
using Core.Interfaces;

namespace Core.GraphQL.UserProviders
{
    public class UserQueryProvider
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public async Task<IEnumerable<User>> GetUsers([Service] IUserService userService) =>
            await userService.GetUsersAsync();

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public async Task<User?> GetUserById(int userId, [Service] IUserService userService) =>
            await userService.GetUserByIdAsync(userId);
    }
}
