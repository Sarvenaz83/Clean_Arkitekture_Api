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
    [Migration("20240104010036_updateDatabase")]
    partial class updateDatabase
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
                            Id = new Guid("1b2d0e12-a29f-4d8d-b295-5e55411e26f6"),
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
                            Id = new Guid("e12d6224-c380-45a6-ad78-1b830a37ef1e"),
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
                            Id = new Guid("9b72c5bb-9c57-497d-b507-aff7a41217f1"),
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
                            Id = new Guid("22af3256-6a59-4655-864a-984718224267"),
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
                            Id = new Guid("3cb6d2d7-b0a9-40b1-bb6f-24d4550f46d3"),
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
                            Id = new Guid("975fdae5-bb54-42ed-b47c-0dcdc126edef"),
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
                            Id = new Guid("df79a316-d621-49b0-a18b-2b8be83ded9b"),
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
                            Id = new Guid("da4c773e-1c02-4bb6-9f20-09a1be2d0349"),
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
                            Id = new Guid("9513316a-4d18-4860-9dbc-8b4cc29f791a"),
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
                            Id = new Guid("e24e9641-513a-4bfa-8685-0c9d3dadd2e9"),
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
                            Id = new Guid("f0b66ccd-0f3e-4ab2-b2f5-4c5cfa9313dd"),
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
                            Id = new Guid("7b6aa0ea-1ee0-4b07-bdc9-43eaeea997e3"),
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
