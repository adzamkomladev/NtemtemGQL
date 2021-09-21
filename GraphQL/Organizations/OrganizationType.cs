using System.Linq;
using HotChocolate;
using HotChocolate.Types;
using NtemtemGQL.Data;
using NtemtemGQL.Models;

namespace NtemtemGQL.GraphQL.Organizations
{
    public class OrganizationType : ObjectType<Organization>
    {
        protected override void Configure(IObjectTypeDescriptor<Organization> descriptor)
        {
            descriptor.Description("Represent any organization that users can make appointments at.");

            descriptor.Field(o => o.UpdatedAt).Ignore();
            descriptor.Field(o => o.CreatedAt).Ignore();

            descriptor
                .Field(o => o.WorkPeriods)
                .ResolveWith<Resolvers>(r => r.GetWorkPeriods(default!, default!))
                .UseDbContext<AppDbContext>()
                .Description("This is a list of all the work period of the organization.");

            descriptor
                .Field(o => o.Appointments)
                .ResolveWith<Resolvers>(r => r.GetAppointments(default!, default!))
                .UseDbContext<AppDbContext>()
                .Description("This is a list of all the appointments of the organization.");
        }

        private class Resolvers
        {
            public IQueryable<WorkPeriod> GetWorkPeriods(Organization organization, [ScopedService] AppDbContext context)
            {
                return context
                        .WorkPeriods
                        .Where(wp => wp.OrganizationId == organization.Id);
            }

            public IQueryable<Appointment> GetAppointments(Organization organization, [ScopedService] AppDbContext context)
            {
                return context
                        .Appointments
                        .Where(a => a.OrganizationId == organization.Id)
                        .OrderBy(a => a.StartTime);
            }
        }
    }
}