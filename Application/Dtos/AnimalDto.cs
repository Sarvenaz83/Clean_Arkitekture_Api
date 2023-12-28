namespace Application.Dtos
{
    public class AnimalDto
    {
        public virtual string Name { get; set; } = string.Empty;
        public virtual bool LikesToPlay { get; set; }
        public virtual bool CanFly { get; set; }
        public virtual string Color { get; set; } = string.Empty;
        public virtual string Breed { get; set; } = string.Empty;
        public virtual int Weight { get; set; }
        public virtual string OwnerUserName { get; set; } = string.Empty;
    }
}
