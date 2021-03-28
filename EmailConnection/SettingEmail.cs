using System.Net.Mail;

namespace SendEmail.EmailConnection
{
    public class SettingEmail
    {
       public static MailMessage Building(AlternateView htmlView)
        {
            var email = new MailMessage();
            email.From = new MailAddress("Remetente", "Nome remetente");
            email.To.Add(new MailAddress("Destinatário"));

            email.Subject = "Título E-mail";

            email.IsBodyHtml = true;
            email.AlternateViews.Add(htmlView);
            email.Priority = MailPriority.High;
            return email;
        }
    }
}
