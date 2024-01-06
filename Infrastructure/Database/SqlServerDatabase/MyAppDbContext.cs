using Domain;
using Domain.Models;
using Domain.Models.Animal;
using Domain.Models.Animal.BirdModel;
using Domain.Models.Animal.CatModel;
using Domain.Models.Animal.DogModel;
using Infrastructure.Database.DatabaseSeedAnimal;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Database.Database
{
    public class MyAppDbContext : DbContext
    {
        public MyAppDbContext()
        {

        }

        public MyAppDbContext(DbContextOptions<MyAppDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Dog> Dogs { get; set; }
        public virtual DbSet<Cat> Cats { get; set; }
        public virtual DbSet<Bird> Birds { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<AnimalModel> AnimalModel { get; set; }
        public virtual DbSet<UserAnimal> UserAnimals { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=MINAZ\\SQLEXPRESS; Database=CleanArkitektureAPI; Trusted_Connection=true; TrustServerCertificate=true;";
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Set primary key for AnimalModel
            modelBuilder.Entity<AnimalModel>().HasKey(animal => animal.AnimalId);

            //Configuration many-to-many relationship
            modelBuilder.Entity<UserAnimal>().HasKey(_userAnimal => new { _userAnimal.UserId, _userAnimal.AnimalId });

            modelBuilder.Entity<UserAnimal>()
                .HasOne(_userAnimal => _userAnimal.User)
                .WithMany(_user => _user.UserAnimals)
                .HasForeignKey(_userAnimal => _userAnimal.UserId);

            modelBuilder.Entity<UserAnimal>()
                .HasOne(_userAnimal => _userAnimal.Animal)
                .WithMany(_animal => _animal.UserAnimals)
                .HasForeignKey(_userAnimal => _userAnimal.AnimalId);

            //Configure Dog entity
            modelBuilder.Entity<Dog>()
                .Property(dog => dog.AnimalName);
            modelBuilder.Entity<Dog>()
                .Property(dog => dog.Breed);
            modelBuilder.Entity<Dog>()
                .Property(dog => dog.Weight);

            //Configure Bird entity
            modelBuilder.Entity<Bird>()
                .Property(bird => bird.AnimalName);
            modelBuilder.Entity<Bird>()
                .Property(bird => bird.Color);
            modelBuilder.Entity<Bird>()
                .Property(bird => bird.CanFly);

            //Configure Cat entity
            modelBuilder.Entity<Cat>()
                .Property(cat => cat.AnimalName);
            modelBuilder.Entity<Cat>()
                .Property(cat => cat.LikesToPlay);
            modelBuilder.Entity<Cat>()
                .Property(cat => cat.Breed);
            modelBuilder.Entity<Cat>()
                .Property(cat => cat.Weight);

            AnimalSeeder.SeedAnimals(modelBuilder);


        }
    }
}
