﻿// <auto-generated />
using System;
using Infrastructure.Database.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(MyAppDbContext))]
    [Migration("20231228142538_TheRestOgChangesAndCreatings")]
    partial class TheRestOgChangesAndCreatings
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            Id = new Guid("3b42c83f-cb2a-4dee-9842-9ef9fa4fdabc"),
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
                            Id = new Guid("3a36b97f-77aa-4d8e-9d36-291333549f54"),
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
                            Id = new Guid("b6917754-f169-48ca-bbf4-0ce8e405c7d6"),
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
                            Id = new Guid("4a13a5c5-cd7d-4e34-b279-ea589005a5be"),
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
                            Id = new Guid("976e4f1f-7c5f-4996-8ec6-53477c9979dd"),
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
                            Id = new Guid("4d6b6906-38d2-46c2-98fb-f38f51d2d181"),
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
                            Id = new Guid("8043c9f5-cae6-42f3-a7a4-3f10065ef84d"),
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
                            Id = new Guid("6c489eef-b0c2-4fb5-bbc2-f4b99b7b8913"),
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
                            Id = new Guid("5458be4e-ad9d-48e2-981d-bc48e3a2dadc"),
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
                            Id = new Guid("1555d866-1afa-45a2-a274-b30f684d9006"),
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
                            Id = new Guid("b62a91e7-d729-4ead-b9d6-77e24a4d3f94"),
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
                            Id = new Guid("2f046260-fc5e-4944-b156-730d13d52057"),
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
