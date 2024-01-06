using Application.Validators;
using MediatR;
using FluentValidation;

namespace Application.Commands.AnimalUser.DeleteAnimalUserByKey
{
    public class DeleteAnimalUserByKeyCommand : IRequest<bool>, Ivalidate
    {
        public DeleteAnimalUserByKeyCommand(Guid deletedAnimalUserKey)
        {
            DeleteAnimalUserByKey = deletedAnimalUserKey;
        }
        public Guid DeleteAnimalUserByKey { get; }
        public void Validate()
        {
            var validator = new GuidValidator();
            var result = validator.Validate(DeleteAnimalUserByKey);

            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
