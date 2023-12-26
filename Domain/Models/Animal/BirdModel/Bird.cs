using Domain.Models.Animal;

namespace Domain.Models.Animal.BirdModel
{
    public class Bird : AnimalModel
    {
        public bool CanFly { get; set; }
        public string Color { get; set; } = string.Empty;
    }
}
