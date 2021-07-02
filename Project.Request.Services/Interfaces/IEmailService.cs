using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Project.Request.Services.Interfaces
{
    public interface IEmailService
    {
        bool sendEmail(MailMessage mailMessage);
        Task<bool> CreateEmail(ProjectRequest projectRequest);
    }
}
