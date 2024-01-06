namespace Domain.Models.Animal.DogModel
{
    public class Dog : AnimalModel
    {
        public string Breed { get; set; } = string.Empty;
        public int Weight { get; set; }

    }
}
