using Projur.Domain.Commands.Contracts;

namespace Projur.Domain.Handlers.Contracts
{
    public interface IHandler<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}
