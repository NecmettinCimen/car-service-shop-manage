using Microsoft.Extensions.Configuration;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace aracyonetim.services.Services
{
    public interface IMailService
    {
        public Task Send(string to, string subject, string body);
    }
    public class MailService : IMailService
    {
        private readonly IConfiguration configuration;

        public MailService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public async Task Send(string to, string subject, string body)
        {
            try
            {
                var mail = new MailMessage();
                var smtpServer = new SmtpClient(configuration["Mailinfo:Username"]);

                mail.From = new MailAddress(configuration["Mailinfo:Username"]);
                mail.To.Add(to);
                mail.Subject = subject;
                mail.Body = body;

                smtpServer.Port = int.Parse(configuration["Mailinfo:Port"]);
                smtpServer.Credentials = new NetworkCredential(configuration["Mailinfo:Username"], configuration["Mailinfo:Username"]);
                smtpServer.EnableSsl = true;

                await smtpServer.SendMailAsync(mail).ConfigureAwait(false);
            }
            catch (System.Exception ex)
            {
                // ignored
            }
        }
    }
}