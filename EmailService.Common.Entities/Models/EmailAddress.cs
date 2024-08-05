namespace EmailService.Common.Entities.Models
{
    /// <summary>
    /// Представляет адрес электронной почты.
    /// </summary>
    public class EmailAddress
    {
        /// <summary>
        /// Конструктор создающий новый экземпляр объекта.
        /// </summary>
        /// <param name="address">Адрес электронной почты.</param>
        public EmailAddress(string address)
        {
            Address = address;
        }

        /// <summary>
        /// Адрес электронной почты.
        /// </summary>
        public string Address { get; set; }
    }
}
