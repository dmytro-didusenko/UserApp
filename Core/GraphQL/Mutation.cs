using Core.GraphQL.PositionProviders;
using Core.GraphQL.UserProviders;

namespace Core.GraphQL
{
    public class Mutation
    {
        public UserMutationProvider UserMutations { get; set; } = new UserMutationProvider();
        public PositionMutationProvider PositionMutations { get; set; } = new PositionMutationProvider();
    }
}
