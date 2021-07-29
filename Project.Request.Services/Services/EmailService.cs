using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Project.Request.Models.DataModels;
using Project.Request.Models.Settings;
using Project.Request.Services.Helpers;
using Project.Request.Services.Interfaces;

namespace Project.Request.Services.Services
{
    public class EmailService : IEmailService
    {
        private readonly HtmlTemplate _htmlTemplate;
        private readonly IOptions<MailAddressSettings> _mailAddressSettings;
        private readonly IOptions<SmtpSettings> _smtpSettings;

        public EmailService(IOptions<SmtpSettings> smtpSettings, IOptions<MailAddressSettings> mailAddressSettings,
            HtmlTemplate htmlTemplate)
        {
            _htmlTemplate = htmlTemplate;
            _mailAddressSettings = mailAddressSettings;
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

        private SmtpClient SmtpClient { get; }

        public bool SendEmail(MailMessage mailMessage)
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

        public async Task<bool> CreateEmail(ProjectRequest projectRequest)
        {
            if (projectRequest.Id == 0) return false;
            // format message body
            // use htmlTemplate helper class and dictionary to map the variable names with keys and return a string html template
            var messageBody = _htmlTemplate.GetFullTemplate("Template/MessageBody.html", new Dictionary<string, string>
            {
                {"projectName", projectRequest.ProjectName},
                {"requestorName", projectRequest.RequestorName},
                {"completionDate", projectRequest.DesiredCompletionDate.ToLongDateString()},
                {"description", projectRequest.RequestDescription},
                {"changes", projectRequest.RequestChanges},
                {"reason", projectRequest.RequestReason},
                {"effects", projectRequest.RequestEffectsOnOrganization},
                {"departments", projectRequest.Departments},
                {"priority", projectRequest.PriorityLevel},
                {"businessJustification", projectRequest.BusinessJustification.Replace(",", " and ")}
            });

            if (messageBody == "") throw new Exception();
            // create a new mail message object with from, subject, body fields
            var mailMessage = new MailMessage
            {
                From = new MailAddress(_mailAddressSettings.Value.FromAddress, _mailAddressSettings.Value.FromName),
                Subject = "New Project Request Created",
                Body = messageBody,
                IsBodyHtml = true
            };
            // retrieve a list of ToAdresses if there are more than one 
            var mailToAddresses = _mailAddressSettings.Value.GetMailAddresses();
            foreach (var mailToAddress in mailToAddresses)
                // if there are multiple to addresses, add them to the 'To' field as well
                mailMessage.To.Add(mailToAddress);

            return SendEmail(mailMessage);
        }
    }
}