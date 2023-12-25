﻿using Application.Commands.Cats.AddCat;
using Domain.Models.Animal.BirdModel;
using Infrastructure.Database;
using MediatR;

namespace Application.Commands.Birds.AddBird
{
    public class AddBirdCommandHandler : IRequestHandler<AddBirdCommand, Bird>
    {
        private readonly MockDatabase _mockDatabase;

        public AddBirdCommandHandler(MockDatabase mockDatabase)
        {
            _mockDatabase = mockDatabase;
        }

        public Task<Bird> Handle(AddBirdCommand request, CancellationToken cancellationToken)
        {
            Bird birdToCreate = new()
            {
                Id = Guid.NewGuid(),
                Name = request.NewBird.Name
            };

            _mockDatabase.Birds.Add(birdToCreate);

            return Task.FromResult(birdToCreate);
        }
    }
}
