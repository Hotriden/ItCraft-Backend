﻿// <auto-generated />
using ItCraftTest.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ItCraftTest.Migrations
{
    [DbContext(typeof(UserDbContext))]
    [Migration("20210208173318_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("ItCraftTest.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Active = false,
                            Name = "Vasya"
                        },
                        new
                        {
                            Id = 2,
                            Active = false,
                            Name = "Petya"
                        },
                        new
                        {
                            Id = 3,
                            Active = false,
                            Name = "Katya"
                        },
                        new
                        {
                            Id = 4,
                            Active = false,
                            Name = "Olya"
                        },
                        new
                        {
                            Id = 5,
                            Active = false,
                            Name = "Masha"
                        },
                        new
                        {
                            Id = 6,
                            Active = false,
                            Name = "Grisha"
                        },
                        new
                        {
                            Id = 7,
                            Active = false,
                            Name = "John"
                        },
                        new
                        {
                            Id = 8,
                            Active = false,
                            Name = "Pavel"
                        },
                        new
                        {
                            Id = 9,
                            Active = false,
                            Name = "Rita"
                        },
                        new
                        {
                            Id = 10,
                            Active = false,
                            Name = "Sveta"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}