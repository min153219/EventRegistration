    using EventRegistration.Domain;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    namespace EventRegistration.Configurations.Entities
    {
        public class EventSeed : IEntityTypeConfiguration<Event>
        {
            public void Configure(EntityTypeBuilder<Event> builder)
            {
                builder.HasData(
                    new Event
                    {
                        Id = 1,
                        Title = "TP Open House",
                        Type = "Physical",
                        EventDate = new DateTime(2026, 1, 15), 
                        Location = "Temasek Polytechnic, Convention Centre",
                        TotalCapacity = 500,
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        CreatedBy = "System",
                        UpdatedBy = "System"
                    }
                );
            }
        }
    }