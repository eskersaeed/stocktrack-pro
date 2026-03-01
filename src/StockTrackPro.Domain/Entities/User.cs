using StockTrackPro.Domain.Common;

namespace StockTrackPro.Domain.Entities;

public class User : BaseEntity
{
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string? RefreshToken { get; set; }
    public DateTime? RefreshTokenExpiry { get; set; }

    public ICollection<Portfolio> Portfolios { get; set; } = new List<Portfolio>();
    public ICollection<Alert> Alerts { get; set; } = new List<Alert>();
}