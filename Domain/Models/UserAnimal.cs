
using Domain.Models.Animal;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class UserAnimal
    {
        [Key]
        public Guid Key { get; set; }
        public Guid AnimalId { get; set; }
        public AnimalModel? Animal { get; set; }
        public Guid UserId { get; set; }
        public User? User { get; set; }
        public int TogetherIndex { get; set; }

    }
}
