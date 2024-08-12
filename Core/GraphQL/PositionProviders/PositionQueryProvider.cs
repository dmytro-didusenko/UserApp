using Core.DataManager.Models;
using Core.Interfaces;

namespace Core.GraphQL.PositionProviders
{
    public class PositionQueryProvider
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public async Task<IEnumerable<Position>> GetPositions([Service] IPositionService positionService) =>
            await positionService.GetPositionsAsync();

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public async Task<Position?> GetPositionById(int positionId, [Service] IPositionService positionService) =>
            await positionService.GetPositionByIdAsync(positionId);
    }
}
