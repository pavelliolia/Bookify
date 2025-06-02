using Bookify.Application.Abstrastions.Messaging;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Bookify.Application.Behaviors;

public class LoggingBehavior<TRequest, TResponse>(
    ILogger<TRequest> logger) : IPipelineBehavior<TRequest, TResponse> where TRequest : IBaseCommand
{
    public async Task<TResponse> Handle(
        TRequest request,
        RequestHandlerDelegate<TResponse> next,
        CancellationToken cancellationToken)
    {
        var typeName = request.GetType().Name;

        try
        {
            logger.LogInformation("Executing command {Command}", typeName);
            var result = await next();
            logger.LogInformation("Executing command {Command}", typeName);
            return result;
        }
        catch (Exception e)
        {
            logger.LogError(e, "Error executing command {Command}", typeName);;
            throw;
        }
    }
}