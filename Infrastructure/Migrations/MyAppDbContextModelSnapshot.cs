﻿// <auto-generated />
using System;
using Infrastructure.Database.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(MyAppDbContext))]
    partial class MyAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Models.Animal.AnimalModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("CanFly")
                        .HasColumnType("bit");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LikesToPlay")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OwnerUserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("AnimalModel");

                    b.HasDiscriminator<string>("Discriminator").HasValue("AnimalModel");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Domain.Models.UserAnimal", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AnimalId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "AnimalId");

                    b.HasIndex("AnimalId");

                    b.ToTable("UserAnimals");
                });

            modelBuilder.Entity("Domain.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Domain.Models.Animal.BirdModel.Bird", b =>
                {
                    b.HasBaseType("Domain.Models.Animal.AnimalModel");

                    b.HasDiscriminator().HasValue("Bird");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9aa11e08-b1b5-4053-9e60-28808fb39593"),
                            Breed = "",
                            CanFly = false,
                            Color = "",
                            LikesToPlay = false,
                            Name = "Bird1",
                            OwnerUserName = "",
                            Weight = 0
                        },
                        new
                        {
                            Id = new Guid("3a3a8aea-1563-465a-aa47-0e5fb85b47d8"),
                            Breed = "",
                            CanFly = false,
                            Color = "",
                            LikesToPlay = false,
                            Name = "Bird2",
                            OwnerUserName = "",
                            Weight = 0
                        },
                        new
                        {
                            Id = new Guid("7bb91beb-3c0f-4138-930e-3b3d7acf90bb"),
                            Breed = "",
                            CanFly = false,
                            Color = "",
                            LikesToPlay = false,
                            Name = "Bird3",
                            OwnerUserName = "",
                            Weight = 0
                        },
                        new
                        {
                            Id = new Guid("a247aca7-45b9-4e9c-849b-198728a50094"),
                            Breed = "",
                            CanFly = false,
                            Color = "",
                            LikesToPlay = false,
                            Name = "Bird4",
                            OwnerUserName = "",
                            Weight = 0
                        });
                });

            modelBuilder.Entity("Domain.Models.Animal.CatModel.Cat", b =>
                {
                    b.HasBaseType("Domain.Models.Animal.AnimalModel");

                    b.HasDiscriminator().HasValue("Cat");

                    b.HasData(
                        new
                        {
                            Id = new Guid("dad978e2-ead6-4928-9974-2a64e8423ee6"),
                            Breed = "",
                            CanFly = false,
                            Color = "",
                            LikesToPlay = false,
                            Name = "Cat1",
                            OwnerUserName = "",
                            Weight = 0
                        },
                        new
                        {
                            Id = new Guid("5ad694f5-6d90-4b7f-92bb-b9b55206e6ab"),
                            Breed = "",
                            CanFly = false,
                            Color = "",
                            LikesToPlay = false,
                            Name = "Cat2",
                            OwnerUserName = "",
                            Weight = 0
                        },
                        new
                        {
                            Id = new Guid("eb0a850f-4c05-4411-882a-66b13313c37f"),
                            Breed = "",
                            CanFly = false,
                            Color = "",
                            LikesToPlay = false,
                            Name = "Cat3",
                            OwnerUserName = "",
                            Weight = 0
                        },
                        new
                        {
                            Id = new Guid("b63c75e1-d91f-4b85-b19b-6339333fb319"),
                            Breed = "",
                            CanFly = false,
                            Color = "",
                            LikesToPlay = false,
                            Name = "Cat4",
                            OwnerUserName = "",
                            Weight = 0
                        });
                });

            modelBuilder.Entity("Domain.Models.Animal.DogModel.Dog", b =>
                {
                    b.HasBaseType("Domain.Models.Animal.AnimalModel");

                    b.HasDiscriminator().HasValue("Dog");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0bb5ca00-7e72-45fa-b990-ca00260adcce"),
                            Breed = "",
                            CanFly = false,
                            Color = "",
                            LikesToPlay = false,
                            Name = "Dog1",
                            OwnerUserName = "",
                            Weight = 0
                        },
                        new
                        {
                            Id = new Guid("030b83d6-c6b0-4886-a347-4dc1c2e3aa7b"),
                            Breed = "",
                            CanFly = false,
                            Color = "",
                            LikesToPlay = false,
                            Name = "Dog2",
                            OwnerUserName = "",
                            Weight = 0
                        },
                        new
                        {
                            Id = new Guid("a4728230-6bcc-4bca-9002-149ed61c00f4"),
                            Breed = "",
                            CanFly = false,
                            Color = "",
                            LikesToPlay = false,
                            Name = "Dog3",
                            OwnerUserName = "",
                            Weight = 0
                        },
                        new
                        {
                            Id = new Guid("30837b20-09ca-4085-a350-0e4f87860279"),
                            Breed = "",
                            CanFly = false,
                            Color = "",
                            LikesToPlay = false,
                            Name = "Dog4",
                            OwnerUserName = "",
                            Weight = 0
                        });
                });

            modelBuilder.Entity("Domain.Models.UserAnimal", b =>
                {
                    b.HasOne("Domain.Models.Animal.AnimalModel", "Animal")
                        .WithMany("UserAnimals")
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.User", "User")
                        .WithMany("UserAnimals")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animal");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Models.Animal.AnimalModel", b =>
                {
                    b.Navigation("UserAnimals");
                });

            modelBuilder.Entity("Domain.User", b =>
                {
                    b.Navigation("UserAnimals");
                });
#pragma warning restore 612, 618
        }
    }
}
