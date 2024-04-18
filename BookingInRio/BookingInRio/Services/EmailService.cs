using System.Net.Mail;
using System.Net;
using Microsoft.Extensions.Options;

namespace BookingInRio.Services
{
    public class EmailService
    {
        private readonly EmailSettings _emailSettings;

        public EmailService(IOptions<EmailSettings> emailSettings)
        {
            _emailSettings = emailSettings.Value;
        }

        public void SendEmail(string toEmail, string subject, string body)
        {
            using (var smtp = new SmtpClient(_emailSettings.MailServer, _emailSettings.MailPort)
            {
                Credentials = new NetworkCredential(_emailSettings.Sender, _emailSettings.Password),
                EnableSsl = _emailSettings.UseSSL
            })
            {
                var mailMessage = new MailMessage
                {
                    From = new MailAddress(_emailSettings.Sender, _emailSettings.SenderName),
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true
                };
                mailMessage.To.Add(toEmail);
                smtp.Send(mailMessage);
            }
        }
    }

}
