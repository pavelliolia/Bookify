using Bookify.Application.Abstrastions.Messaging;

namespace Bookify.Application.Users.GetLoggedInUser;

public sealed record GetLoggedInUserQuery : IQuery<UserResponse>;