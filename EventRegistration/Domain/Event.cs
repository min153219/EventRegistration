namespace EventRegistration.Domain
{
    public class Event : BaseDomainModel
    {
        public string? Title { get; set; }
        public string? Type { get; set; }
        public DateTime DateTime { get; set; }
        public string? Location { get; set; }
        public int TotalCapacity { get; set; }

    }
}
