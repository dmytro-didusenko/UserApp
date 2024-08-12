using Core.GraphQL.PositionProviders;
using Core.GraphQL.UserProviders;

namespace Core.GraphQL
{
    public class Query
    {
        public UserQueryProvider UserQueries { get; set; } = new UserQueryProvider();
        public PositionQueryProvider PositionQueries { get; set; } = new PositionQueryProvider();
    }
}
