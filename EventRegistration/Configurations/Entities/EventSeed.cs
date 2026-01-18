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
                        UpdatedBy = "System",
                        Category = "Educational",
                        Description = "Join us for Temasek Polytechnic's Open House! Explore our facilities, meet our faculty, and discover exciting courses.",
                        IsFeatured = true,
                        Status = "Approved",
                        ReviewedBy = "System",
                        ReviewedDate = DateTime.Now
                    },
                    // Event 2: Tech Talks 2026
                new Event
                {
                    Id = 2,
                    Title = "Tech Talks 2026",
                    Type = "Physical",
                    EventDate = new DateTime(2026, 2, 20),
                    Location = "Marina Bay Sands Convention Centre",
                    TotalCapacity = 300,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                    Category = "Professional",
                    Description = "Join industry leaders and tech innovators for an inspiring day of talks covering AI, cloud computing, cybersecurity, and the future of technology in Southeast Asia.",
                    IsFeatured = true,
                    Status = "Approved",
                    ReviewedBy = "System",
                    ReviewedDate = DateTime.Now
                },

                // Event 3: Indie Film Festival
                new Event
                {
                    Id = 3,
                    Title = "Indie Film Festival",
                    Type = "Physical",
                    EventDate = new DateTime(2026, 3, 10),
                    Location = "National Museum of Singapore",
                    TotalCapacity = 200,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                    Category = "Entertainment",
                    Description = "Experience the best of independent cinema from local and international filmmakers. Three days of screenings, Q&A sessions, and networking opportunities.",
                    IsFeatured = false,
                    Status = "Approved",
                    ReviewedBy = "System",
                    ReviewedDate = DateTime.Now
                },

                // Event 4: City Marathon 2026
                new Event
                {
                    Id = 4,
                    Title = "City Marathon 2026",
                    Type = "Physical",
                    EventDate = new DateTime(2026, 4, 5),
                    Location = "Marina Bay Area",
                    TotalCapacity = 1000,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                    Category = "Sports",
                    Description = "Challenge yourself in Singapore's premier marathon event! Choose from full marathon (42km), half marathon (21km), or 10km fun run. All fitness levels welcome.",
                    IsFeatured = true,
                    Status = "Approved",
                    ReviewedBy = "System",
                    ReviewedDate = DateTime.Now
                },

                // Event 5: Summer Music Festival 2026
                new Event
                {
                    Id = 5,
                    Title = "Summer Music Festival 2026",
                    Type = "Physical",
                    EventDate = new DateTime(2026, 6, 15),
                    Location = "Siloso Beach, Sentosa",
                    TotalCapacity = 5000,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                    Category = "Music",
                    Description = "Singapore's biggest beach music festival featuring international and local artists across multiple stages. Two days of sun, sand, and amazing music!",
                    IsFeatured = true,
                    Status = "Approved",
                    ReviewedBy = "System",
                    ReviewedDate = DateTime.Now
                },

                // Event 6: Modern Art Exhibition
                new Event
                {
                    Id = 6,
                    Title = "Modern Art Exhibition",
                    Type = "Physical",
                    EventDate = new DateTime(2026, 1, 20),
                    Location = "City Gallery",
                    TotalCapacity = 200,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                    Category = "Arts",
                    Description = "Exhibitions, theater, and cultural events celebrating modern and contemporary art from Southeast Asian artists. Free admission for all visitors.",
                    IsFeatured = false,
                    Status = "Approved",
                    ReviewedBy = "System",
                    ReviewedDate = DateTime.Now
                }
                );
            }
        }
    }