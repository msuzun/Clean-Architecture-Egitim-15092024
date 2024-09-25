using CleanArchitecture.Application.Services;
using System.Net;
using System.Net.Mail;

namespace CleanArchitecture.Infrastructure.Services;

public sealed class MailService : IMailService
{
    public async Task SendMailService(string toEmail, string subject, string body)
    {
        var fromEmail = "";
        var fromPassword = "";

        var stmpClient = new SmtpClient("smtp.gmail.com")
        {
            Port = 587,
            Credentials = new NetworkCredential(fromEmail, fromPassword),
            EnableSsl = true,
        };
        var mailMessage = new MailMessage
        {
            From = new MailAddress(fromEmail),
            Subject = subject,
            Body = body,
            IsBodyHtml = true,
        };
        mailMessage.To.Add(toEmail);
        try
        {
            await stmpClient.SendMailAsync(mailMessage);
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }
}
