using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockTrackPro.Domain.Entities;

namespace StockTrackPro.Infrastructure.Persistence.Configurations;

public class HoldingConfiguration : IEntityTypeConfiguration<Holding>
{
    public void Configure(EntityTypeBuilder<Holding> builder)
    {
        builder.HasKey(h => h.Id);
        builder.Property(h => h.Quantity).HasPrecision(18, 8);
        builder.Property(h => h.AverageCostPrice).HasPrecision(18, 4);

        builder.HasMany(h => h.Transactions)
            .WithOne(t => t.Holding)
            .HasForeignKey(t => t.HoldingId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}