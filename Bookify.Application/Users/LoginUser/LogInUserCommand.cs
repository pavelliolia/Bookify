using Bookify.Application.Abstrastions.Messaging;

namespace Bookify.Application.Users.LogInUser;

public sealed record LogInUserCommand(string Email, string Password)
    : ICommand<AccessTokenResponse>;