using Domain.Models.Animal.CatModel;
using MediatR;

namespace Application.Queries.Cats.GetCatsByWeight
{
    public class GetCatsByWeightQuery : IRequest<IEnumerable<Cat>>
    {
        public int Weight { get; set; }
        public GetCatsByWeightQuery(int weight)
        {
            Weight = weight;
        }
    }

}
