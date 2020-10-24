using System.Security.Claims;

namespace CoreNg.Graphql
{
    public class GraphQLUserContext
    {
        public ClaimsPrincipal User { get; set; }
    }
}
