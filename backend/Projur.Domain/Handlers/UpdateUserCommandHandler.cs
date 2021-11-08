using Projur.Domain.Commands;
using Projur.Domain.Commands.Contracts;
using Projur.Domain.Entities;
using Projur.Domain.Handlers.Contracts;
using Projur.Domain.Repositories;

namespace Projur.Domain.Handlers
{
    public class UpdateUserCommandHandler : IHandler<UpdateUserCommand>
    {
        private readonly IUserRepository _userRepository;
        
        public UpdateUserCommandHandler(IUserRepository userRepository) 
        {
            this._userRepository = userRepository;
        }

        public ICommandResult Handle(UpdateUserCommand command)
        {
            User user = this._userRepository.FindUserById(command.Id);
            if(user == null) 
            {
                return new GenericCommandResult<UpdateUserCommand>(false, "falha ao atualizar registro", null);
            }

            user.UpdateName(command.Name)
                .UpdateSurname(command.Surname)
                .UpdateEmail(command.Email)
                .UpdateBirthDate(command.BirthDate)
                .UpdateSchooling(command.Schooling);

            this._userRepository.Update(user);

            return new GenericCommandResult<UpdateUserCommand>(true, "Usuário atualizado com sucesso", null);
        }
    }
}
