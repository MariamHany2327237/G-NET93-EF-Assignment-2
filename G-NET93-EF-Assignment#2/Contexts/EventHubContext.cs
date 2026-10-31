using G_NET93_EF_Assignment_2.configrations;
using G_NET93_EF_Assignment_2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET93_EF_Assignment_2.Contexts
{
    internal class EventHubContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;DataBase=EventHubDB;Trusted_Connection=true;TrustServerCertificate=true");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrganizerProfile>(P =>
            {
                P.HasKey(p => p.OrganizerProfileId);

                P.HasOne(p => p.OwnerOrganizer)
                .WithOne(o => o.OrganizerProfile)
                .HasForeignKey<OrganizerProfile>(p => p.OwnerOrganizerId)
                .IsRequired();
            });


            modelBuilder.ApplyConfiguration(new EventConfiguration());
            modelBuilder.ApplyConfiguration(new BadgeConfiguration());

        }

        DbSet<Attendee> Attendees { get; set; }
        DbSet<Badge> Badges { get; set; }
        DbSet<Event> Events { get; set; }
        DbSet<Organizer> Organizers { get; set; }
    }
}
