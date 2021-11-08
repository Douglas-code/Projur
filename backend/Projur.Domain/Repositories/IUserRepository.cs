using Projur.Domain.Entities;
using System.Collections;
using System.Collections.Generic;

namespace Projur.Domain.Repositories
{
    public interface IUserRepository
    {
        void Save(User user);

        void Update(User user);

        void Delete(int id);

        User FindUserById(int id);

        IEnumerable<User> FindAllUsers();
    }
}
