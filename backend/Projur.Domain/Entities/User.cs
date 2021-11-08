using Projur.Domain.Enums;
using System;

namespace Projur.Domain.Entities
{
    public class User : Entity
    {
        public User() { }

        public User(string name, string surname, string email, DateTime birthDate, ESchooling schooling)
        {
            Name = name;
            Surname = surname;
            Email = email;
            BirthDate = birthDate;
            Schooling = schooling;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public string Email { get; private set; }

        public DateTime BirthDate { get; private set; }

        public ESchooling Schooling { get; private set; }

        public User UpdateName(string name)
        {
            this.Name = name;
            return this;
        }

        public User UpdateSurname(string surname)
        {
            this.Surname = surname;
            return this;
        }

        public User UpdateEmail(string email)
        {
            this.Email = email;
            return this;
        }

        public User UpdateBirthDate(DateTime birthDate)
        {
            this.BirthDate = birthDate;
            return this;
        }

        public User UpdateSchooling(ESchooling schooling)
        {
            this.Schooling = schooling;
            return this;
        }
    }
}
