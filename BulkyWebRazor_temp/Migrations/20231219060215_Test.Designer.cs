﻿// <auto-generated />
using BulkyWeb_Razor.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BulkyWebRazor_temp.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20231219060215_Test")]
    partial class Test
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BulkyWeb_Razor.Models.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            id = 1,
                            DisplayOrder = 1,
                            Name = "Action"
                        },
                        new
                        {
                            id = 2,
                            DisplayOrder = 2,
                            Name = "SciFi"
                        },
                        new
                        {
                            id = 3,
                            DisplayOrder = 3,
                            Name = "History"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}