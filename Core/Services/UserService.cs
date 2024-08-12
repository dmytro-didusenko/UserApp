using Core.DataManager;
using Core.DataManager.Models;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Core.Services
{
    public class UserService : IUserService
    {
        private readonly UserDbContext _userDbContext;

        public UserService(UserDbContext userDbContext)
        {
            _userDbContext = userDbContext;
        }

        public async Task<User> CreateUserAsync(User user)
        {
            await _userDbContext.Users.AddAsync(user);
            await _userDbContext.SaveChangesAsync();

            return user;
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await _userDbContext.Users
                .Include(x => x.Position)
                .ToListAsync();
        }

        public async Task<User?> GetUserByIdAsync(int userId)
        {
            return await _userDbContext.Users
                .Include(x => x.Position)
                .FirstOrDefaultAsync(x => x.UserId == userId);
        }

        public async Task<User> UpdateUserAsync(User user)
        {
            _userDbContext.Users.Update(user);
            await _userDbContext.SaveChangesAsync();

            return user;
        }

        public async Task<bool> DeleteUser(int userId)
        {
            try
            {
                var user = await _userDbContext.Users.FirstOrDefaultAsync(x => x.UserId == userId);

                if (user is null)
                    throw new Exception($"User with ID={userId} doesn't exists");

                _userDbContext.Users.Remove(user);
                await _userDbContext.SaveChangesAsync();

                return true;
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
