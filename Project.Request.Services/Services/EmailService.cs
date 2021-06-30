using Microsoft.Extensions.Options;
using Project.Request.Models.Settings;
using Project.Request.Services.Interfaces;
using System;
using System.Net;
using System.Net.Mail;

namespace Project.Request.Services.Services
{
    public class EmailService : IEmailService
    {
        private readonly IOptions<SmtpSettings> _smtpSettings;

        private SmtpClient SmtpClient { get; }

        public EmailService(IOptions<SmtpSettings> smtpSettings)
        {
            _smtpSettings = smtpSettings;
            // create a new SMTP client
            SmtpClient = new SmtpClient
            {
                // the Credentials is determined by smtpSettings' username and password
                Credentials = new NetworkCredential(_smtpSettings.Value.UserName, _smtpSettings.Value.Password),
                // host and port is also determined by smtpSetting
                Host = _smtpSettings.Value.Host,
                Port = _smtpSettings.Value.Port,
                EnableSsl = true
            };
        }
        public bool sendEmail(MailMessage mailMessage)
        {
            try
            {
                // if email is sent, return true
                SmtpClient.Send(mailMessage);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
