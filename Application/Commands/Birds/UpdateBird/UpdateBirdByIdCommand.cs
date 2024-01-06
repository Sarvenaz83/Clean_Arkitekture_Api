using Application.Dtos;
using Domain.Models.Animal.BirdModel;
using MediatR;

namespace Application.Commands.Birds.UpdateBird
{
    public class UpdateBirdByIdCommand : IRequest<Bird>
    {
        public UpdateBirdByIdCommand(BirdDto updatedBird, Guid id)
        {

            Id = id;
            BirdToUpdate = updatedBird;

        }

        public BirdDto BirdToUpdate { get; }
        public Guid Id { get; }
    }
}
