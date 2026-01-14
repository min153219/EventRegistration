using EventRegistration.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace EventRegistration.Configurations.Entities
{
    public class UserSeed : IEntityTypeConfiguration<EventRegistrationUser>
    {
        public void Configure(EntityTypeBuilder<EventRegistrationUser> builder)
        {
            var hasher = new PasswordHasher<EventRegistrationUser>();
            builder.HasData(
            new EventRegistrationUser
            {
                Id = "1",
                Email = "admin@localhost.com",
                NormalizedEmail = "ADMIN@LOCALHOST.COM",
                FirstName = "Admin",
                LastName = "User",
                UserName = "admin@localhost.com",
                NormalizedUserName = "ADMIN@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true // Set to true, otherwise you won't be able to login
            }
            );
        }
    }
}
