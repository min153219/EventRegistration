namespace EventRegistration.Domain
{
    public class Event : BaseDomainModel
    {
        public string? Title { get; set; }
        public string? Type { get; set; }
        public DateTime EventDate { get; set; } 
        public string? Location { get; set; }
        public int TotalCapacity { get; set; }
        public string? Category { get; set; }          
        public string? Description { get; set; }       
        public string? ImageUrl { get; set; }         
        public bool IsFeatured { get; set; }

        public virtual ICollection<Ticket>? Tickets { get; set; }
    }
}