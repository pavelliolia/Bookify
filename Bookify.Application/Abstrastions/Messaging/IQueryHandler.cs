using Bookify.Domain.Abstractions;
using MediatR;

namespace Bookify.Application.Abstrastions.Messaging;

public interface IQueryHandler<TQuery, TResult> : IRequestHandler<TQuery, Result<TResult>>
    where TQuery : IQuery<TResult>
{
}