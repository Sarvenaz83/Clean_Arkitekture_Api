using Application.Exceptions.BadRequestException;
using Application.Validators;
using MediatR;

namespace Application.Commands.Users.Delete
{
    public class DeletUserByIdCommand : IRequest<bool>, Ivalidate
    {
        public DeletUserByIdCommand(Guid id)
        {
            UserId = id;
        }
        public Guid UserId { get; }

        public void Validate()
        {
            var validator = new GuidValidator();

            var result = validator.Validate(UserId);
            if (!result.IsValid)
            {
                throw new BadRequestException("Validation failed", result.Errors.Select(error => error.ErrorMessage).ToList());
            }
        }
    }
}
