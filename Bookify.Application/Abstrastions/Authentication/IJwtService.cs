using Bookify.Domain.Abstractions;

namespace Bookify.Application.Abstrastions.Authentication;

public interface IJwtService
{
    Task<Result<string>> GetAccessTokenAsync(
        string email,
        string password,
        CancellationToken cancellationToken = default);
}