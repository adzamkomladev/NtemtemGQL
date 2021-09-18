using System.Linq;
using HotChocolate;
using HotChocolate.Data;
using NtemtemGQL.Data;
using NtemtemGQL.Models;

namespace NtemtemGQL.GraphQL
{
    public class Query
    {

        [UseDbContext(typeof(AppDbContext))]
        [UseProjection]
        public IQueryable<Organization> GetOrganizations([ScopedService] AppDbContext context)
        {
            return context.Organizations;
        }
    }
}