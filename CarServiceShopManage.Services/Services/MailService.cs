using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace CarServiceShopManage.Services.Services
{
    public interface IMailService
    {
        public Task Send(string to, string subject, string body);
    }
    public class MailService(IConfiguration configuration) : IMailService
    {
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