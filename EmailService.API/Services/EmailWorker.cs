using EmailService.BLL.Logic.Contracts;
using EmailService.Common.Contracts;
using SwiftMailer.Common.Entities.Models;

namespace EmailService.API.Services
{
    public class EmailWorker : BaseKafkaWorker<EmailMessage>
    {
        private readonly IEmailSender _emailService;

        public EmailWorker(IEmailSender emailService) => _emailService = emailService;

        protected override string GetTopicName() => "email.service.topic";

        protected override Task ProccesMessage(EmailMessage msg)
        {
            throw new NotImplementedException();
        }
    }
}
