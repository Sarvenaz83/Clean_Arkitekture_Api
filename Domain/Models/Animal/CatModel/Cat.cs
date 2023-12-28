namespace Domain.Models.Animal.CatModel
{
    public class Cat : AnimalModel
    {
        public override bool LikesToPlay { get; set; }
        public override string Breed { get; set; } = string.Empty;
        public override int Weight { get; set; }
    }
}
