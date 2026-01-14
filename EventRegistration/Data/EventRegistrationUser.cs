using Microsoft.AspNetCore.Identity;

namespace EventRegistration.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class EventRegistrationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
