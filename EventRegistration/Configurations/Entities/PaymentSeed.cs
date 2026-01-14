using EventRegistration.Domain;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventRegistration.Configurations.Entities
{
    public class PaymentSeed : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.HasData(
                 new Payment
                 {
                     Id = 1,
                     Amount = 0.00m,
                     PaymentMethod = "Free",
                     Currency = "SGD",
                     PaymentDate = new DateTime(2026, 1, 15),
                     RegistrationId = 1,
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 }



             );
        }
    }
}
