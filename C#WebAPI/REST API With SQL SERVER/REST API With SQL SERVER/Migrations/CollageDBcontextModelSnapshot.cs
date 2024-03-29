﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using REST_API_With_SQL_SERVER.Data;

#nullable disable

namespace REST_API_With_SQL_SERVER.Migrations
{
    [DbContext(typeof(CollageDBcontext))]
    partial class CollageDBcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("REST_API_With_SQL_SERVER.Data.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "Mihirkumargupta2@gmail.com",
                            Name = "Mihir Gupta"
                        },
                        new
                        {
                            Id = 2,
                            Email = "Khushigupta2@gmail.com",
                            Name = "Khushi Gupta"
                        },
                        new
                        {
                            Id = 3,
                            Email = "Anjalishaw4@gmail.com",
                            Name = "Anjali Shaw"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
