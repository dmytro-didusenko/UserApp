using Core.DataManager;
using Core.DataManager.Models;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Core.Services
{
    public class PositionService : IPositionService
    {
        private readonly UserDbContext _userDbContext;

        public PositionService(UserDbContext userDbContext)
        {
            _userDbContext = userDbContext;
        }

        public async Task<Position> CreatePositionAsync(Position position)
        {
            await _userDbContext.Positions.AddAsync(position);
            await _userDbContext.SaveChangesAsync();

            return position;
        }

        public async Task<IEnumerable<Position>> GetPositionsAsync()
        {
            return await _userDbContext.Positions.ToListAsync();
        }

        public async Task<Position?> GetPositionByIdAsync(int positionId)
        {
            return await _userDbContext.Positions.FirstOrDefaultAsync(x => x.PositionId == positionId);
        }

        public async Task<Position> UpdatePositionAsync(Position position)
        {
            _userDbContext.Positions.Update(position);
            await _userDbContext.SaveChangesAsync();

            return position;
        }

        public async Task<bool> DeletePositionAsync(int positionId)
        {
            try
            {
                var user = await _userDbContext.Positions.FirstOrDefaultAsync(x => x.PositionId == positionId);

                if (user is null)
                    throw new Exception($"User with ID={positionId} doesn't exists");

                _userDbContext.Positions.Remove(user);
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
