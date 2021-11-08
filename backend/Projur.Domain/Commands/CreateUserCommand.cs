using Projur.Domain.Commands.Contracts;
using Projur.Domain.Enums;
using System;

namespace Projur.Domain.Commands
{
    public class CreateUserCommand : ICommand
    {
        public CreateUserCommand() { }

        public CreateUserCommand(string name, string surname, string email, DateTime birthDate, ESchooling schooling)
        {
            Name = name;
            Surname = surname;
            Email = email;
            BirthDate = birthDate;
            Schooling = schooling;
        }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public DateTime BirthDate { get; set; }

        public ESchooling Schooling { get; set; }
    }
}
