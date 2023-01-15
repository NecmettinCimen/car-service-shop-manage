using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace aracyonetim.services.Services
{
    public interface IMailService
    {
        public Task Send(string to, string subject, string body);
    }
    public class MailService : IMailService
    {
        public async Task Send(string to, string subject, string body)
        {
            try
            {
                var mail = new MailMessage();
                var smtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("necmettin.cimen22@gmail.com");
                mail.To.Add(to);
                mail.Subject = subject;
                mail.Body = body;

                smtpServer.Port = 587;
                smtpServer.Credentials = new NetworkCredential("necmettin.cimen22@gmail.com", "nebula21");
                smtpServer.EnableSsl = true;

                await smtpServer.SendMailAsync(mail).ConfigureAwait(false);
            }
            catch (System.Exception)
            {
                    // ignored
            }
        }
    }
}