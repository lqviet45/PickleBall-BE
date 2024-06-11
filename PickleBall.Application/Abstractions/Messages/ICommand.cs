using Ardalis.Result;
using MediatR;

namespace PickleBall.Application.Abstractions.Messages;

public interface ICommand : IRequest<Result> { }

public interface ICommand<TResponse> : IRequest<Result<TResponse>> { }
