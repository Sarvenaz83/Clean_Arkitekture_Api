using Domain.Models.Animal.BirdModel;
using MediatR;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Application.Queries.Birds.GetAll
{
    public class GetAllBirdsQuery : IRequest<List<Bird>>
    {

    }
}
