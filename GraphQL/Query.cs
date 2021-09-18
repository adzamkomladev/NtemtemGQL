using System.Linq;
using HotChocolate;
using NtemtemGQL.Data;
using NtemtemGQL.Models;

namespace NtemtemGQL.GraphQL
{
    public class Query
    {
        public IQueryable<Organization> GetOrganization([Service] AppDbContext context)
        {
            return context.Organizations;
        }
    }
}