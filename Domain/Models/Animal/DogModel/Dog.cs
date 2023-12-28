using Domain.Models.Animal;

namespace Domain.Models.Animal.DogModel
{
    public class Dog : AnimalModel
    {
        public override string Breed { get; set; } = string.Empty;
        public override int Weight { get; set; }
        public static string Bark()
        {
            return "This animal barks";

        }
    }
}
