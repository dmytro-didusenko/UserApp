using Core.DataManager.Models;
using Core.Interfaces;

namespace Core.GraphQL.PositionProviders
{
    public class PositionMutationProvider
    {
        public async Task<Position> AddPosition(Position position, [Service] IPositionService positionService) =>
    await positionService.CreatePositionAsync(position);

        public async Task<Position> UpdatePosition(Position position, [Service] IPositionService positionService) =>
            await positionService.UpdatePositionAsync(position);

        public async Task<bool> RemovePosition(int positionId, [Service] IPositionService positionService) =>
            await positionService.DeletePositionAsync(positionId);
    }
}
