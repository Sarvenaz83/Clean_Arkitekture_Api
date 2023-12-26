namespace Application.Exceptions.EntityNotFound
{
    public class BirdNotFoundException : BaseCustomException
    {
        public BirdNotFoundException(Guid id)
            : base($"Bird with Id of {id} was not found.")
        {
        }
    }
}
