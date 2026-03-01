using MediatR;
using StockTrackPro.Contracts.Auth;

namespace StockTrackPro.Application.Auth.Commands;

public record RegisterCommand(
    string FirstName,
    string LastName,
    string Email,
    string Password
) : IRequest<AuthResponse>;