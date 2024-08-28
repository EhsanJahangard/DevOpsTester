using MediatR;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace IdentityApplication.Common.Behaviors;
//AOT
//Behavior Impelementation AOT(Aspect oriented programming) in Mediator
//DRY (Don't Repeat YourSelf)
public sealed class RequestPerformanceBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
where TRequest : IRequest<TResponse>
{
    private readonly ILogger<RequestPerformanceBehavior<TRequest, TResponse>> _logger;

    public RequestPerformanceBehavior(ILogger<RequestPerformanceBehavior<TRequest, TResponse>> logger)
    {
        _logger = logger;
    }

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {


        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        TResponse response = await next();

        stopwatch.Stop();
        if (stopwatch.ElapsedMilliseconds > TimeSpan.FromSeconds(5).Milliseconds)
        {
            // This method has taken a long time...
            //log TO ELK or Seq
            _logger.LogWarning($"---LOW SPEED API DETECTED---  {request} has taken {stopwatch.ElapsedMilliseconds} to run completely !");
        }
        return response;
    }
}
