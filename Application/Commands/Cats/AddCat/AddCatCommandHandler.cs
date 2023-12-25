﻿using Domain.Models.Animal.CatModel;
using Infrastructure.Database;
using MediatR;

namespace Application.Commands.Cats.AddCat
{
    public sealed class AddCatCommandHandler : IRequestHandler<AddCatCommand, Cat>
    {
        private readonly MockDatabase _mockDatabase;

        public AddCatCommandHandler(MockDatabase mockDatabase)
        {
            _mockDatabase = mockDatabase;
        }


        public Task<Cat> Handle(AddCatCommand request, CancellationToken cancellationToken)
        {
            Cat catToCreate = new()
            {
                Id = Guid.NewGuid(),
                Name = request.NewCat.Name
            };

            _mockDatabase.Cats.Add(catToCreate);

            return Task.FromResult(catToCreate);
        }
    }
}
