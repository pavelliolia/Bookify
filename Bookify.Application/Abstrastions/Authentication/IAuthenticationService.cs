using Bookify.Domain.Users;

namespace Bookify.Application.Abstrastions.Authentication;

public interface IAuthenticationService
{
    Task<string> RegisterAsync(
        User user,
        string password,
        CancellationToken cancellationToken = default);
}