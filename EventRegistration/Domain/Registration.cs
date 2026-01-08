namespace EventRegistration.Domain
{
    public class Registration : BaseDomainModel
    {
        public DateTime RegistrationDate { get; set; }

        // Foreign Keys
        public int EventId { get; set; }
        public int TicketId { get; set; }
    }
}
