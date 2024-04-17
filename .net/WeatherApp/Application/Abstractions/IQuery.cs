using MediatR;
using WeatherApp.Domain.Abstractions;

namespace WeatherApp.Application.Abstractions;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{
}