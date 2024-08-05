using EmailService.Common.Entities.Enums;
using SwiftMailer.Common.Entities.Models;

namespace EmailService.BLL.Logic.Contracts
{
    public interface IEmailSender
    {
        Task<EmailStatus> SendEmail(EmailMessage message);
    }
}