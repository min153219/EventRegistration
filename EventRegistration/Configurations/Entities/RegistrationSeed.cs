using EventRegistration.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventRegistration.Configurations.Entities
{
    public class RegistrationSeed : IEntityTypeConfiguration<Registration>
    {
        public void Configure(EntityTypeBuilder<Registration> builder)
        {
            builder.HasData(
                 new Registration
                 {
                     Id = 1,
                     RegistrationDate = new DateTime(2026, 1, 15),
                     EventId = 1,     
                     TicketId = 1,    
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 }
             );
        }
    }
}
