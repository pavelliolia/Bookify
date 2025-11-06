using Bookify.Domain.Abstractions;
using MediatR;

namespace Bookify.Application.Abstrastions.Messaging;

public interface IQuery<TResult> : IRequest<Result<TResult>>
{
}