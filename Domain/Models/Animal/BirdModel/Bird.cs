using Domain.Models.Animal;

namespace Domain.Models.Animal.BirdModel
{
    public class Bird : AnimalModel
    {
        public override bool CanFly { get; set; }
        public override string Color { get; set; } = string.Empty;
    }
}
