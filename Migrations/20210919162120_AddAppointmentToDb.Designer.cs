﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NtemtemGQL.Data;

namespace NtemtemGQL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210919162120_AddAppointmentToDb")]
    partial class AddAppointmentToDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("NtemtemGQL.Models.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClientEmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClientName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ClientPhone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("ExtraInfo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Reason")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("NtemtemGQL.Models.Organization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Organizations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Achimota Hospital, Aggrey Street, Achimota",
                            CreatedAt = new DateTime(2021, 9, 19, 16, 21, 19, 721, DateTimeKind.Utc).AddTicks(6275),
                            Description = "Achimota Hospital is a government hospital built to serve the Achimota community.",
                            Email = "adzamkomla.dev@gmail.com",
                            Name = "Achimota Hospital",
                            Phone = "233553995074",
                            UpdatedAt = new DateTime(2021, 9, 19, 16, 21, 19, 721, DateTimeKind.Utc).AddTicks(6542)
                        },
                        new
                        {
                            Id = 2,
                            Address = "Arkesel, #1 Nii Oga Street",
                            CreatedAt = new DateTime(2021, 9, 19, 16, 21, 19, 721, DateTimeKind.Utc).AddTicks(6783),
                            Description = "Arkesel is a clouds communication company.",
                            Email = "adzamkomla@gmail.com",
                            Name = "Arkesel Company Limited",
                            Phone = "233202442452",
                            UpdatedAt = new DateTime(2021, 9, 19, 16, 21, 19, 721, DateTimeKind.Utc).AddTicks(6786)
                        });
                });

            modelBuilder.Entity("NtemtemGQL.Models.WorkPeriod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Day")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EndTime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StartTime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.ToTable("WorkPeriods");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Day = "Monday",
                            EndTime = "23:00",
                            OrganizationId = 1,
                            StartTime = "02:00"
                        },
                        new
                        {
                            Id = 2,
                            Day = "Tuesday",
                            EndTime = "23:00",
                            OrganizationId = 1,
                            StartTime = "02:00"
                        },
                        new
                        {
                            Id = 3,
                            Day = "Wednesday",
                            EndTime = "23:00",
                            OrganizationId = 1,
                            StartTime = "02:00"
                        },
                        new
                        {
                            Id = 4,
                            Day = "Thursday",
                            EndTime = "23:00",
                            OrganizationId = 1,
                            StartTime = "02:00"
                        },
                        new
                        {
                            Id = 5,
                            Day = "Friday",
                            EndTime = "23:00",
                            OrganizationId = 1,
                            StartTime = "02:00"
                        },
                        new
                        {
                            Id = 6,
                            Day = "Monday",
                            EndTime = "17:00",
                            OrganizationId = 2,
                            StartTime = "09:00"
                        },
                        new
                        {
                            Id = 7,
                            Day = "Tuesday",
                            EndTime = "17:00",
                            OrganizationId = 2,
                            StartTime = "09:00"
                        },
                        new
                        {
                            Id = 8,
                            Day = "Wednesday",
                            EndTime = "17:00",
                            OrganizationId = 2,
                            StartTime = "09:00"
                        },
                        new
                        {
                            Id = 9,
                            Day = "Thursday",
                            EndTime = "14:00",
                            OrganizationId = 2,
                            StartTime = "09:00"
                        });
                });

            modelBuilder.Entity("NtemtemGQL.Models.Appointment", b =>
                {
                    b.HasOne("NtemtemGQL.Models.Organization", "Organization")
                        .WithMany("Appointments")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("NtemtemGQL.Models.WorkPeriod", b =>
                {
                    b.HasOne("NtemtemGQL.Models.Organization", "Organization")
                        .WithMany("WorkPeriods")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("NtemtemGQL.Models.Organization", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("WorkPeriods");
                });
#pragma warning restore 612, 618
        }
    }
}
