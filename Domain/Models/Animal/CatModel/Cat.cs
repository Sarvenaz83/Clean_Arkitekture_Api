namespace Domain.Models.Animal.CatModel
{
    public class Cat : AnimalModel
    {
        public bool LikesToPlay { get; set; }
        public string Breed { get; set; } = string.Empty;
        public int Weight { get; set; }
    }
}
