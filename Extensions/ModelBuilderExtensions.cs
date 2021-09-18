using System;
using Microsoft.EntityFrameworkCore;
using NtemtemGQL.Models;

namespace NtemtemGQL.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Relationships(this ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Organization>()
                .HasMany(o => o.WorkPeriods)
                .WithOne(o => o.Organization)
                .HasForeignKey(o => o.OrganizationId);
        }

        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Organization>().HasData(
                new Organization
                {
                    Id = 1,
                    Name = "Achimota Hospital",
                    Description = "Achimota Hospital is a government hospital built to serve the Achimota community.",
                    Address = "Achimota Hospital, Aggrey Street, Achimota",
                    Phone = "233553995074",
                    Email = "adzamkomla.dev@gmail.com",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                },
                new Organization
                {
                    Id = 2,
                    Name = "Arkesel Company Limited",
                    Description = "Arkesel is a clouds communication company.",
                    Address = "Arkesel, #1 Nii Oga Street",
                    Phone = "233202442452",
                    Email = "adzamkomla@gmail.com",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                }
            );

        }
    }
}