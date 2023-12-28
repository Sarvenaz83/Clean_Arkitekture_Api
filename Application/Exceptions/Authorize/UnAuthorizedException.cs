namespace Application.Exceptions.Authorize
{
    public class UnAuthorizedException : BaseCustomException
    {
        public UnAuthorizedException(string message) : base(message)
        {
        }
    }
}
