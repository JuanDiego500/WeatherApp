using MediatR;
using WeatherApp.Domain.Abstractions;

namespace WeatherApp.Application.Abstractions;

public interface IQueryHandler<TQuery, TResponse> : IRequestHandler<TQuery, Result<TResponse>>
    where TQuery : IQuery<TResponse>
{
}