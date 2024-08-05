namespace EmailService.Common.Contracts
{
    /// <summary>
    /// Модель получения
    /// </summary>
    public class EmailServiceMessage
    {
        /// <summary>
        /// Конструктор создающий новый экземпляр объекта.
        /// </summary>
        /// <param name="subject">Тема письма.</param>
        /// <param name="content">Содержание письма.</param>
        /// <param name="recipients">Список адресов получателей.</param>
        public EmailServiceMessage(string subject, string content, string recipient) : this(subject, content, new List<string>() { recipient })
        { }

        /// <summary>
        /// Конструктор создающий новый экземпляр объекта.
        /// </summary>
        /// <param name="subject">Тема письма.</param>
        /// <param name="content">Содержание письма.</param>
        /// <param name="recipients">Список адресов получателей.</param>
        public EmailServiceMessage(string subject, string content, IEnumerable<string> recipients)
        {
            Recipients = new List<string>();
            Recipients.AddRange(recipients.Select(x => x));
            Subject = subject;
            Content = content;
        }

        /// <summary>
        /// Список адресов получателей.
        /// </summary>
        public List<string> Recipients { get; set; }

        /// <summary>
        /// Тема письма.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Содержание письма.
        /// </summary>
        public string Content { get; set; }
    }
}
