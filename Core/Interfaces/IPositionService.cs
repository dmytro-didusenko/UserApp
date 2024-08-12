using Core.DataManager.Models;

namespace Core.Interfaces
{
    public interface IPositionService
    {
        Task<Position> CreatePositionAsync(Position position);
        Task<IEnumerable<Position>> GetPositionsAsync();
        Task<Position?> GetPositionByIdAsync(int positionId);
        Task<Position> UpdatePositionAsync(Position position);
        Task<bool> DeletePositionAsync(int positionId);
    }
}
