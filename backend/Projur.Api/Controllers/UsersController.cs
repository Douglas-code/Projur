using Microsoft.AspNetCore.Mvc;
using Projur.Domain.Commands;
using Projur.Domain.Commands.Contracts;
using Projur.Domain.Entities;
using Projur.Domain.Handlers.Contracts;
using Projur.Domain.Repositories;
using System.Collections.Generic;

namespace Projur.Api.Controllers
{
    [Route("users")]
    [ApiController]
    public class UsersController : Controller
    {
        [HttpGet]
        [Route("")]
        public ICommandResult FindAllUsers([FromServices] IUserRepository userRepository)
        {
            IEnumerable<User> users = userRepository.FindAllUsers();
            return new GenericCommandResult<IEnumerable<User>>(true, "", users);
        }

        [HttpGet]
        [Route("{id}")]
        public ICommandResult FindUserById(int id, [FromServices] IUserRepository userRepository)
        {
            User user = userRepository.FindUserById(id);
            return new GenericCommandResult<User>(true, "", user);
        }

        [HttpPost]
        public ICommandResult CreateUser([FromBody] CreateUserCommand command, [FromServices] IHandler<CreateUserCommand> handler)
        {
            return handler.Handle(command);
        }

        [HttpPut]
        [Route("{id}")]
        public ICommandResult UpdateUser(int id, [FromBody] UpdateUserCommand command, [FromServices] IHandler<UpdateUserCommand> handler)
        {
            return handler.Handle(command);
        }

        [HttpDelete]
        [Route("{id}")]
        public ICommandResult DeleteUser(int id, [FromServices] IHandler<DeleteUserCommand> handler)
        {
            DeleteUserCommand command = new DeleteUserCommand(id);
            return handler.Handle(command);
        }
    }
}
