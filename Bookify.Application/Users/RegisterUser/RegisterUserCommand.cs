using Bookify.Application.Abstrastions.Messaging;

namespace Bookify.Application.Users.RegisterUser;

public sealed record RegisterUserCommand(
    string FirstName,
    string LastName,
    string Email,
    string Password) : ICommand<Guid>;