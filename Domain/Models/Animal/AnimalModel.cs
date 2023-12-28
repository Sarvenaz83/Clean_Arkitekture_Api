namespace Domain.Models.Animal
{
    public class AnimalModel
    {
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; } = string.Empty;
        public virtual bool LikesToPlay { get; set; }
        public virtual bool CanFly { get; set; }
        public virtual string Breed { get; set; } = string.Empty;
        public virtual int Weight { get; set; }
        public virtual string Color { get; set; } = string.Empty;
        public string OwnerUserName { get; set; } = string.Empty;


        //Navigation property for many-to-many relationship
        public virtual ICollection<UserAnimal> UserAnimals { get; set; } = new List<UserAnimal>();
    }
}
