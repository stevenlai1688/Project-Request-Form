using Microsoft.Extensions.Options;
using Project.Models;
using Project.Request.Models.Settings;
using Project.Request.Services.Interfaces;
using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Project.Request.Services.Services
{
    public class EmailService : IEmailService
    {
        private readonly IOptions<SmtpSettings> _smtpSettings;
        private readonly IOptions<MailAddressSettings> _mailAddressSettings;
        
        private SmtpClient SmtpClient { get; }

        public EmailService(IOptions<SmtpSettings> smtpSettings, IOptions<MailAddressSettings> mailAddressSettings)
        {
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
        public async Task<bool> CreateEmail(ProjectRequest projectRequest)
        {
            if (projectRequest.Id == 0) return false;
            // format message body
            string messageBody = "<h1>Project Request</h1>" +
                $"<p><h4>Project Name:</h4> {projectRequest.ProjectName}</p>" +
                $"<p><h4>Requestor Name:</h4> {projectRequest.RequestorName}</p>" +
                $"<p><h4>Desired Completion Date:</h4> {projectRequest.DesiredCompletionDate}</p>" +

                $"<p><h4>Request Description:</h4> {projectRequest.RequestDescription}</p>" +
                $"<p><h4>Request Changes:</h4> {projectRequest.RequestChanges}</p>" +
                $"<p><h4>Request Reason:</h4> {projectRequest.RequestReason}</p>" +
                $"<p><h4>Request Effects On Organization:</h4> {projectRequest.RequestEffectsOnOrganization}</p>" +


                $"<p><h4>Departments Affected:</h4> {projectRequest.Departments}</p>" +
                $"<p><h4>Estimated Timeframe:</h4> {projectRequest.EstimateTimeFrame}</p>" +
                $"<p><h4>PriorityLevel:</h4> {projectRequest.PriorityLevel}</p>" +
                $"<p><h4>Business Justification:</h4> {projectRequest.BusinessJustification.Replace(",", " and")}";


            var mailMessage = new MailMessage
            {
                From = new MailAddress(_mailAddressSettings.Value.FromAddress, _mailAddressSettings.Value.FromName),
                Subject = "New Project Request Created",
                Body = messageBody,
                IsBodyHtml = true
            };
            // retrieve a list of ToAdresses
            var mailToAddresses = _mailAddressSettings.Value.GetMailAddresses();
            foreach (var mailToAddress in mailToAddresses)
            {
                // if there are multiple to addresses, add them to the To
                mailMessage.To.Add(mailToAddress);
            }
            return sendEmail(mailMessage);
        }

    }
}
