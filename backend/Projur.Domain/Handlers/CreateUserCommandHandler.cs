using Projur.Domain.Commands;
using Projur.Domain.Commands.Contracts;
using Projur.Domain.Entities;
using Projur.Domain.Handlers.Contracts;
using Projur.Domain.Repositories;
using System;

namespace Projur.Domain.Handlers
{
    public class CreateUserCommandHandler : IHandler<CreateUserCommand>
    {
        private readonly IUserRepository _userRepository;

        public CreateUserCommandHandler(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }

        public ICommandResult Handle(CreateUserCommand command)
        {
            User user = new User(command.Name, command.Surname, command.Email, command.BirthDate, command.Schooling);
            try
            {
                this._userRepository.Save(user);
                return new GenericCommandResult<CreateUserCommand>(true, "Usuário criado com sucesso", null);
            }
            catch(Exception e)
            {
                return new GenericCommandResult<string>(false, "Falha ao criar usuário", e.Message);
            }
        }
    }
}
