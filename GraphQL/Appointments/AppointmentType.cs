using System.Linq;
using HotChocolate;
using HotChocolate.Types;
using NtemtemGQL.Data;
using NtemtemGQL.Models;

namespace NtemtemGQL.GraphQL.Appointments
{
    public class AppointmentType : ObjectType<Appointment>
    {
        protected override void Configure(IObjectTypeDescriptor<Appointment> descriptor)
        {
            descriptor.Description("Represent appointments made by user to an organization.");

            descriptor.Field(a => a.UpdatedAt).Ignore();
            descriptor.Field(a => a.CreatedAt).Ignore();

            descriptor
                .Field(a => a.Organization)
                .ResolveWith<Resolvers>(r => r.GetOrganization(default!, default!))
                .UseDbContext<AppDbContext>()
                .Description("This is a the organization of the appointment.");

        }

        private class Resolvers
        {
            public Organization GetOrganization(Appointment appointment, [ScopedService] AppDbContext context)
            {
                return context
                        .Organizations
                        .FirstOrDefault(o => o.Id == appointment.OrganizationId);
            }
        }
    }
}