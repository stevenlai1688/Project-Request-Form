using System.Net.Mail;
using System.Threading.Tasks;
using Project.Request.Models.DataModels;

namespace Project.Request.Services.Interfaces
{
    public interface IEmailService
    {
        bool SendEmail(MailMessage mailMessage);
        Task<bool> CreateEmail(ProjectRequest projectRequest);
    }
}