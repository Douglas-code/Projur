using Projur.Domain.Commands.Contracts;
using Projur.Domain.Enums;
using System;

namespace Projur.Domain.Commands
{
    public class UpdateUserCommand : ICommand
    {
        public UpdateUserCommand(int id, string name, string surname, string email, DateTime birthDate, ESchooling schooling)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Email = email;
            BirthDate = birthDate;
            Schooling = schooling;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public DateTime BirthDate { get; set; }

        public ESchooling Schooling { get; set; }
    }
}
