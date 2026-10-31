using G_NET93_EF_Assignment_2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET93_EF_Assignment_2.configrations
{
    internal class BadgeConfiguration : IEntityTypeConfiguration<Badge>
    {
        public void Configure(EntityTypeBuilder<Badge> builder)
        {
            builder.HasKey(b => b.BadgeNumber);

            builder.HasOne(b => b.OwnerAttendee)
                .WithOne(a => a.Badge)
                .HasForeignKey<Badge>(b => b.OwnerAttendeeId)
                .IsRequired();
        }
    }
}
