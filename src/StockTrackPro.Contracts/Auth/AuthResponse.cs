namespace StockTrackPro.Contracts.Auth;

public record AuthResponse(
    string AccessToken,
    string RefreshToken,
    DateTime ExpiresAt,
    string Email,
    string FirstName,
    string LastName
);