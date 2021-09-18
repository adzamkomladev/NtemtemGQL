﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NtemtemGQL.Data;

namespace NtemtemGQL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            CreatedAt = new DateTime(2021, 9, 18, 0, 7, 36, 291, DateTimeKind.Utc).AddTicks(9302),
                            Description = "Achimota Hospital is a government hospital built to serve the Achimota community.",
                            Email = "adzamkomla.dev@gmail.com",
                            Name = "Achimota Hospital",
                            Phone = "233553995074",
                            UpdatedAt = new DateTime(2021, 9, 18, 0, 7, 36, 291, DateTimeKind.Utc).AddTicks(9578)
                        },
                        new
                        {
                            Id = 2,
                            Address = "Arkesel, #1 Nii Oga Street",
                            CreatedAt = new DateTime(2021, 9, 18, 0, 7, 36, 291, DateTimeKind.Utc).AddTicks(9941),
                            Description = "Arkesel is a clouds communication company.",
                            Email = "adzamkomla@gmail.com",
                            Name = "Arkesel Company Limited",
                            Phone = "233202442452",
                            UpdatedAt = new DateTime(2021, 9, 18, 0, 7, 36, 291, DateTimeKind.Utc).AddTicks(9943)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
