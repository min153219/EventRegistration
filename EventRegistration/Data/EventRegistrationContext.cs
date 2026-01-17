using EventRegistration.Configurations.Entities;
using EventRegistration.Data;
using EventRegistration.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace EventRegistration.Data
{
    public class EventRegistrationContext(DbContextOptions<EventRegistrationContext> options) : IdentityDbContext<EventRegistrationUser>(options)
    {
        public DbSet<EventRegistration.Domain.Event> Event { get; set; } = default!;
        public DbSet<EventRegistration.Domain.Ticket> Ticket { get; set; } = default!;
        public DbSet<EventRegistration.Domain.Registration> Registration { get; set; } = default!;
        public DbSet<EventRegistration.Domain.Payment> Payment { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new EventSeed());
            builder.ApplyConfiguration(new PaymentSeed());
            builder.ApplyConfiguration(new RegistrationSeed());
            builder.ApplyConfiguration(new TicketSeed());

            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserSeed());
            builder.ApplyConfiguration(new UserRoleSeed());
            builder.Entity<Registration>()
                .HasOne(r => r.Ticket)
                .WithMany()
                .HasForeignKey(r => r.TicketId)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
