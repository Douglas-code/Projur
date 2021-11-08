using Projur.Domain.Commands;
using Projur.Domain.Commands.Contracts;
using Projur.Domain.Entities;
using Projur.Domain.Handlers.Contracts;
using Projur.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projur.Domain.Handlers
{
    public class DeleteUserCommandHandler : IHandler<DeleteUserCommand>
    {
        private readonly IUserRepository _userRepository;

        public DeleteUserCommandHandler(IUserRepository userRepository) 
        {
            this._userRepository = userRepository;
        }

        public ICommandResult Handle(DeleteUserCommand command)
        {
            User user = this._userRepository.FindUserById(command.Id);

            if(user == null)
            {
                return new GenericCommandResult<DeleteUserCommand>(false, "Falha ao deletar usuário", null);
            }

            this._userRepository.Delete(command.Id);

            return new GenericCommandResult<DeleteUserCommand>(true, "Usuário deletado com sucesso", null);
        }
    }
}
