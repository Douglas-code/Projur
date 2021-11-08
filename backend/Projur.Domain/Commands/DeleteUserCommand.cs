using Projur.Domain.Commands.Contracts;

namespace Projur.Domain.Commands
{
    public class DeleteUserCommand : ICommand
    {
        public DeleteUserCommand(int id)
        {
            this.Id = id;
        }

        public int Id { get; set; }
    }
}
