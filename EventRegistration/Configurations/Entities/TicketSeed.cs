using EventRegistration.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Threading.Tasks;

namespace EventRegistration.Configurations.Entities
{
    public class TicketSeed : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.HasData(
                new Ticket
                {
                    Id = 1,
                    Price = 0.00m,
                    Type = "Free Admission",
                    EventId = 1,   
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                // Event 2: Tech Talks 2026 Tickets
                new Ticket
                {
                    Id = 2,
                    Price = 75.00m,
                    Type = "General Admission",
                    EventId = 2,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Ticket
                {
                    Id = 3,
                    Price = 120.00m,
                    Type = "VIP Pass",
                    EventId = 2,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },

                // Event 3: Indie Film Festival Tickets
                new Ticket
                {
                    Id = 4,
                    Price = 35.00m,
                    Type = "Standard Pass",
                    EventId = 3,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Ticket
                {
                    Id = 5,
                    Price = 25.00m,
                    Type = "Student Pass",
                    EventId = 3,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },

                // Event 4: City Marathon 2026 Tickets
                new Ticket
                {
                    Id = 6,
                    Price = 50.00m,
                    Type = "Runner Registration",
                    EventId = 4,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },

                // Event 5: Summer Music Festival 2026 Tickets
                new Ticket
                {
                    Id = 7,
                    Price = 45.00m,
                    Type = "General Admission",
                    EventId = 5,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Ticket
                {
                    Id = 8,
                    Price = 80.00m,
                    Type = "VIP Experience",
                    EventId = 5,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Ticket
                {
                    Id = 9,
                    Price = 30.00m,
                    Type = "Early Bird",
                    EventId = 5,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },

                // Event 6: Modern Art Exhibition Tickets
                new Ticket
                {
                    Id = 10,
                    Price = 0.00m,
                    Type = "Free Admission",
                    EventId = 6,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
