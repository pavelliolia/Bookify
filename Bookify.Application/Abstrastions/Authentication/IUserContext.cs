namespace Bookify.Application.Abstrastions.Authentication;

public interface IUserContext
{
    Guid UserId { get; }

    string IdentityId { get; }
}