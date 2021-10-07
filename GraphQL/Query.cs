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
        public IQueryable<Organization> GetOrganizations([ScopedService] AppDbContext context)
        {
            return context.Organizations;
        }

        [UseDbContext(typeof(AppDbContext))]
        public Organization GetOrganization([ScopedService] AppDbContext context, int id)
        {
            return context.Organizations.FirstOrDefault(o => o.Id == id);
        }

        [UseDbContext(typeof(AppDbContext))]
        public IQueryable<Appointment> GetAppointments([ScopedService] AppDbContext context)
        {
            return context.Appointments;
        }

        [UseDbContext(typeof(AppDbContext))]
        public Appointment GetAppointment([ScopedService] AppDbContext context, int id)
        {
            return context.Appointments.FirstOrDefault(a => a.Id == id);
        }
    }
}