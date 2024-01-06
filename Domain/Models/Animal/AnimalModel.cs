using System.ComponentModel.DataAnnotations;


namespace Domain.Models.Animal
{
    public class AnimalModel
    {
        public Guid AnimalId { get; set; }
        public string AnimalName { get; set; } = string.Empty;



        //Navigation property for many-to-many relationship
        public virtual ICollection<UserAnimal> UserAnimals { get; set; } = new List<UserAnimal>();

    }
}
