namespace MVC_HireMeNow_Workshop.Exceptions
{
    public class ServiceException:Exception
    {
        public ServiceException()
        {

        }
        public ServiceException(string message) : base(message)
        {

        }
    }
}
