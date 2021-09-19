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

            modelBuilder
                .Entity<Organization>()
                .HasMany(o => o.Appointments)
                .WithOne(o => o.Organization)
                .HasForeignKey(o => o.OrganizationId);

            modelBuilder
                .Entity<Appointment>()
                .HasOne(o => o.Organization)
                .WithMany(o => o.Appointments)
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

            modelBuilder.Entity<WorkPeriod>().HasData(
                new WorkPeriod
                {
                    Id = 1,
                    OrganizationId = 1,
                    Day = "Monday",
                    StartTime = "02:00",
                    EndTime = "23:00"
                },
                new WorkPeriod
                {
                    Id = 2,
                    OrganizationId = 1,
                    Day = "Tuesday",
                    StartTime = "02:00",
                    EndTime = "23:00"
                },
                new WorkPeriod
                {
                    Id = 3,
                    OrganizationId = 1,
                    Day = "Wednesday",
                    StartTime = "02:00",
                    EndTime = "23:00"
                },
                new WorkPeriod
                {
                    Id = 4,
                    OrganizationId = 1,
                    Day = "Thursday",
                    StartTime = "02:00",
                    EndTime = "23:00"
                },
                new WorkPeriod
                {
                    Id = 5,
                    OrganizationId = 1,
                    Day = "Friday",
                    StartTime = "02:00",
                    EndTime = "23:00"
                },
                new WorkPeriod
                {
                    Id = 6,
                    OrganizationId = 2,
                    Day = "Monday",
                    StartTime = "09:00",
                    EndTime = "17:00"
                },
                new WorkPeriod
                {
                    Id = 7,
                    OrganizationId = 2,
                    Day = "Tuesday",
                    StartTime = "09:00",
                    EndTime = "17:00"
                },
                new WorkPeriod
                {
                    Id = 8,
                    OrganizationId = 2,
                    Day = "Wednesday",
                    StartTime = "09:00",
                    EndTime = "17:00"
                },
                new WorkPeriod
                {
                    Id = 9,
                    OrganizationId = 2,
                    Day = "Thursday",
                    StartTime = "09:00",
                    EndTime = "14:00"
                }
            );
        }
    }
}