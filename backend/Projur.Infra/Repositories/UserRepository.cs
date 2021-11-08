using Microsoft.EntityFrameworkCore;
using Projur.Domain.Entities;
using Projur.Domain.Queries;
using Projur.Domain.Repositories;
using Projur.Infra.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projur.Infra.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            this._context = context;
        }

        public void Delete(int id)
        {
            User user = this._context.Users.FirstOrDefault(x => x.Id == id);
            this._context.Users.Remove(user);
            this._context.SaveChanges();
        }

        public User FindUserById(int id)
        {
            User user = this._context.Users.AsNoTracking().FirstOrDefault(UserQueries.FindUserById(id));
            return user;
        }

        public void Save(User user)
        {
            this._context.Users.Add(user);
            this._context.SaveChanges();
        }

        public void Update(User user)
        {
            this._context.Entry(user).State = EntityState.Modified;
            this._context.SaveChanges();
        }

        public IEnumerable<User> FindAllUsers()
        {
            return this._context.Users.AsNoTracking().ToList();
        }
    }
}
