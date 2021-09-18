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
    [Migration("20210918025437_AddWorkPeriodToDb")]
    partial class AddWorkPeriodToDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.10");

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
                            CreatedAt = new DateTime(2021, 9, 18, 2, 54, 36, 896, DateTimeKind.Utc).AddTicks(7051),
                            Description = "Achimota Hospital is a government hospital built to serve the Achimota community.",
                            Email = "adzamkomla.dev@gmail.com",
                            Name = "Achimota Hospital",
                            Phone = "233553995074",
                            UpdatedAt = new DateTime(2021, 9, 18, 2, 54, 36, 896, DateTimeKind.Utc).AddTicks(7317)
                        },
                        new
                        {
                            Id = 2,
                            Address = "Arkesel, #1 Nii Oga Street",
                            CreatedAt = new DateTime(2021, 9, 18, 2, 54, 36, 896, DateTimeKind.Utc).AddTicks(7675),
                            Description = "Arkesel is a clouds communication company.",
                            Email = "adzamkomla@gmail.com",
                            Name = "Arkesel Company Limited",
                            Phone = "233202442452",
                            UpdatedAt = new DateTime(2021, 9, 18, 2, 54, 36, 896, DateTimeKind.Utc).AddTicks(7677)
                        });
                });

            modelBuilder.Entity("NtemtemGQL.Models.WorkPeriod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("EndTime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StartTime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.ToTable("WorkPeriod");
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
                    b.Navigation("WorkPeriods");
                });
#pragma warning restore 612, 618
        }
    }
}