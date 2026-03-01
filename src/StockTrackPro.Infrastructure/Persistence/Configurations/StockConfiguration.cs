using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockTrackPro.Domain.Entities;

namespace StockTrackPro.Infrastructure.Persistence.Configurations;

public class StockConfiguration : IEntityTypeConfiguration<Stock>
{
    public void Configure(EntityTypeBuilder<Stock> builder)
    {
        builder.HasKey(s => s.Id);
        builder.Property(s => s.Ticker).IsRequired().HasMaxLength(10);
        builder.HasIndex(s => s.Ticker).IsUnique();
        builder.Property(s => s.Name).IsRequired().HasMaxLength(200);
        builder.Property(s => s.CurrentPrice).HasPrecision(18, 4);
    }
}