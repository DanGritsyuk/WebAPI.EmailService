using Microsoft.AspNetCore.Mvc;
using EmailService.Common.Contracts;
using EmailService.BLL.Logic.Contracts;
using EmailService.BLL.Logic;
using SwiftMailer.Common.Entities.Models;
using EmailService.Common.Entities.Enums;

namespace EmailService.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmailSendController : ControllerBase
    {
        private readonly ILogger<EmailSendController> _logger;
        //private readonly DbContext _context;
        private readonly IEmailSender _emailSender;

        public EmailSendController(ILogger<EmailSendController> logger)
        {
            _logger = logger;
            //_context = new();
            _emailSender = new EmailSender("host", 4444, "Name@User.mail", "Password");
        }

        // POST: api/emails/
        [HttpPost]
        [Route("send")]
        public void Index([FromBody] EmailServiceMessage email)
        {
            var message = new EmailMessage(email.Subject, email.Content, email.Recipients);
            var mailStatus = _emailSender.SendEmail(message);

            if (mailStatus.Result == EmailStatus.Ok)
                _logger.LogInformation($"Email was sended to: {email.Recipients.FirstOrDefault()}, with text {email.Subject}");
            else
                _logger.LogError($"Failed to send email to: {email.Recipients.FirstOrDefault()} with subject: {email.Subject}. " +
                     $"Mail status: {mailStatus.Result}. " +
                     $"Timestamp: {DateTime.UtcNow}");

            //var mailInfo = new DbMailInfo(message.Subject, message.Body, string.Join(", ", message.Recipients), message.Status, message.StatusMessage, thisEmailSender);

            //_context.Add(mailInfo);
            //_context.SaveChanges();
        }

    }
}

