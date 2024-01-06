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
    [Migration("20240106042942_Felhantering")]
    partial class Felhantering
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
                    b.Property<Guid>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AnimalName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AnimalId");

                    b.ToTable("AnimalModels");

                    b.HasDiscriminator<string>("Discriminator").HasValue("AnimalModel");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Domain.Models.UserAnimal", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AnimalId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Key")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TogetherIndex")
                        .HasColumnType("int");

                    b.HasKey("UserId", "AnimalId");

                    b.HasIndex("AnimalId");

                    b.ToTable("UserAnimals");
                });

            modelBuilder.Entity("Domain.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Domain.Models.Animal.BirdModel.Bird", b =>
                {
                    b.HasBaseType("Domain.Models.Animal.AnimalModel");

                    b.Property<bool>("CanFly")
                        .HasColumnType("bit");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Bird");

                    b.HasData(
                        new
                        {
                            AnimalId = new Guid("702023ef-3bf5-4be8-9b2b-4c343ef3e5db"),
                            AnimalName = "Bird1",
                            CanFly = true,
                            Color = "Red"
                        },
                        new
                        {
                            AnimalId = new Guid("b4fd2ec6-2ace-47e6-84b8-ca309e596034"),
                            AnimalName = "Bird2",
                            CanFly = false,
                            Color = "Blue"
                        },
                        new
                        {
                            AnimalId = new Guid("18dd5587-9fa5-4a9b-9ae2-b52ed2b57666"),
                            AnimalName = "Bird3",
                            CanFly = true,
                            Color = "Green"
                        },
                        new
                        {
                            AnimalId = new Guid("fdff8274-91cb-4d7d-9add-06f42753eae5"),
                            AnimalName = "Bird4",
                            CanFly = false,
                            Color = "Yellow"
                        });
                });

            modelBuilder.Entity("Domain.Models.Animal.CatModel.Cat", b =>
                {
                    b.HasBaseType("Domain.Models.Animal.AnimalModel");

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LikesToPlay")
                        .HasColumnType("bit");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Cat");

                    b.HasData(
                        new
                        {
                            AnimalId = new Guid("58b34ec0-f03c-45de-b78d-217b1320d446"),
                            AnimalName = "Cat1",
                            Breed = "Breed1",
                            LikesToPlay = true,
                            Weight = 1
                        },
                        new
                        {
                            AnimalId = new Guid("a31e2635-50f5-4862-b0b1-4a52ad40e132"),
                            AnimalName = "Cat2",
                            Breed = "Breed2",
                            LikesToPlay = false,
                            Weight = 2
                        },
                        new
                        {
                            AnimalId = new Guid("83ad5af3-f482-4655-a70d-0c7e1041f2df"),
                            AnimalName = "Cat3",
                            Breed = "Breed3",
                            LikesToPlay = true,
                            Weight = 3
                        },
                        new
                        {
                            AnimalId = new Guid("3e1ff01a-de09-4084-b0a1-4de4cea7938b"),
                            AnimalName = "Cat4",
                            Breed = "Breed4",
                            LikesToPlay = false,
                            Weight = 4
                        });
                });

            modelBuilder.Entity("Domain.Models.Animal.DogModel.Dog", b =>
                {
                    b.HasBaseType("Domain.Models.Animal.AnimalModel");

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.ToTable("AnimalModels", t =>
                        {
                            t.Property("Breed")
                                .HasColumnName("Dog_Breed");

                            t.Property("Weight")
                                .HasColumnName("Dog_Weight");
                        });

                    b.HasDiscriminator().HasValue("Dog");

                    b.HasData(
                        new
                        {
                            AnimalId = new Guid("085db9b8-07bf-48ac-9c4e-4a118c1969a8"),
                            AnimalName = "Dog1",
                            Breed = "Breed1",
                            Weight = 1
                        },
                        new
                        {
                            AnimalId = new Guid("3f06942c-e5cd-4597-82cb-1c7c91ae6cdd"),
                            AnimalName = "Dog2",
                            Breed = "Breed2",
                            Weight = 2
                        },
                        new
                        {
                            AnimalId = new Guid("47a89ef6-3192-4793-963d-f10fc87a8941"),
                            AnimalName = "Dog3",
                            Breed = "Breed3",
                            Weight = 3
                        },
                        new
                        {
                            AnimalId = new Guid("96e096d6-0cd6-4c45-9abb-4e73417b07c4"),
                            AnimalName = "Dog4",
                            Breed = "Breed4",
                            Weight = 4
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
