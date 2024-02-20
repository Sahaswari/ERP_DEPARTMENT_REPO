﻿// <auto-generated />
using ERP.Repository.PgSql;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ERP.Repository.PgSql.Migrations
{
    [DbContext(typeof(PgSqlDbContext))]
    [Migration("20231209035941_seed")]
    partial class seed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ERP.Domain.Core.Entity.Module", b =>
                {
                    b.Property<int>("ModuleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ModuleId"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Credits")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ModuleId");

                    b.ToTable("Modules");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("StudentId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RegistrationNum")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("StudentId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1001,
                            Address = "929 Ayana Pike",
                            Email = "",
                            FirstName = "Misael",
                            LastName = "O'Conner",
                            Phone = "413.882.4342 x155",
                            RegistrationNum = ""
                        },
                        new
                        {
                            StudentId = 1002,
                            Address = "6297 Feil Coves",
                            Email = "",
                            FirstName = "Lucy",
                            LastName = "Kovacek",
                            Phone = "005.734.0378 x8516",
                            RegistrationNum = ""
                        },
                        new
                        {
                            StudentId = 1003,
                            Address = "67891 Pasquale Underpass",
                            Email = "",
                            FirstName = "Leanna",
                            LastName = "Robel",
                            Phone = "201.823.8239 x40277",
                            RegistrationNum = ""
                        },
                        new
                        {
                            StudentId = 1004,
                            Address = "3771 Gerhold Expressway",
                            Email = "",
                            FirstName = "Monserrate",
                            LastName = "Tremblay",
                            Phone = "314-242-2158",
                            RegistrationNum = ""
                        },
                        new
                        {
                            StudentId = 1005,
                            Address = "5669 Lizeth Cliff",
                            Email = "",
                            FirstName = "Lorenz",
                            LastName = "Borer",
                            Phone = "(043)768-6615 x488",
                            RegistrationNum = ""
                        },
                        new
                        {
                            StudentId = 1006,
                            Address = "157 Jacky Harbor",
                            Email = "",
                            FirstName = "Abner",
                            LastName = "Leannon",
                            Phone = "593.205.8972 x22785",
                            RegistrationNum = ""
                        },
                        new
                        {
                            StudentId = 1007,
                            Address = "189 Donnelly Extensions",
                            Email = "",
                            FirstName = "Howell",
                            LastName = "Franecki",
                            Phone = "351-923-9527",
                            RegistrationNum = ""
                        },
                        new
                        {
                            StudentId = 1008,
                            Address = "74645 Michele Garden",
                            Email = "",
                            FirstName = "Aliza",
                            LastName = "Goyette",
                            Phone = "(121)161-1563 x30650",
                            RegistrationNum = ""
                        },
                        new
                        {
                            StudentId = 1009,
                            Address = "430 Gutmann Landing",
                            Email = "",
                            FirstName = "Dortha",
                            LastName = "Stokes",
                            Phone = "012.511.0410",
                            RegistrationNum = ""
                        },
                        new
                        {
                            StudentId = 1010,
                            Address = "8763 Lolita Motorway",
                            Email = "",
                            FirstName = "Zula",
                            LastName = "Abernathy",
                            Phone = "954-944-3265",
                            RegistrationNum = ""
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
