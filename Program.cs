using SendEmail.EmailBody;
using SendEmail.EmailConnection;
using System.Net.Mail;
using System.Net.Mime;

namespace SendEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create body from e-mail;
            var body = Body.Message();

            //Create Add to Alternative view
            AlternateView htmlView = AlternateView.CreateAlternateViewFromString(body, null, "text/html");

            //Define ImageId and ADD to Alternative View
            LinkedResource image = new LinkedResource("Caminho Imagem", MediaTypeNames.Image.Jpeg)
            {
                ContentId = "ImageID"
            };
            htmlView.LinkedResources.Add(image);

            //Setting Data to Email
            MailMessage email = SettingEmail.Building(htmlView);

            //Create client Gmail for send Email
            SmtpClient mailClient = new SmtpClient("smtp.gmail.com", 587)
            {
                EnableSsl = true,
                Credentials = new System.Net.NetworkCredential("Email Gmail", "Senha")
            };

            mailClient.Send(email);
        }
    }
}
