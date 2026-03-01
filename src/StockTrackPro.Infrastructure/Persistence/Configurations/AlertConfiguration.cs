using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockTrackPro.Domain.Entities;

namespace StockTrackPro.Infrastructure.Persistence.Configurations;

public class AlertConfiguration : IEntityTypeConfiguration<Alert>
{
    public void Configure(EntityTypeBuilder<Alert> builder)
    {
        builder.HasKey(a => a.Id);
        builder.Property(a => a.TargetPrice).HasPrecision(18, 4);
        builder.Property(a => a.Status).HasConversion<string>();
    }
}