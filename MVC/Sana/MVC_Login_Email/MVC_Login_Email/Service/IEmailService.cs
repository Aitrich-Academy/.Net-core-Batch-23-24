using MVC_Login_Email.Helper;

namespace MVC_Login_Email.Service
{
    public interface IEmailService
    {
        void SendEmail(MailRequest mailRequest);
    }
}
