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
        [UseFiltering]
        [UseSorting]
        public IQueryable<Organization> GetOrganizations([ScopedService] AppDbContext context) => context.Organizations;

        [UseDbContext(typeof(AppDbContext))]
        [UseFirstOrDefault]
        public IQueryable<Organization> GetOrganization([ScopedService] AppDbContext context, int id) => context.Organizations.Where(o => o.Id == id);

        [UseDbContext(typeof(AppDbContext))]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Appointment> GetAppointments([ScopedService] AppDbContext context) => context.Appointments;

        [UseDbContext(typeof(AppDbContext))]
        [UseFirstOrDefault]
        public IQueryable<Appointment> GetAppointment([ScopedService] AppDbContext context, int id) => context.Appointments.Where(a => a.Id == id);
    }
}