using Bookify.Domain.Abstractions;
using MediatR;

namespace Bookify.Application.Abstrastions.Messaging;

public interface ICommand : IRequest, IBaseCommand
{
}

public interface ICommand<TResponse> : IRequest<Result<TResponse>>, IBaseCommand
{
}

public interface IBaseCommand
{
}