using Projur.Domain.Entities;
using System;
using System.Linq.Expressions;

namespace Projur.Domain.Queries
{
    public static class UserQueries
    {
        public static Expression<Func<User, bool>> FindUserById(int id)
        {
            return x => x.Id == id;
        }
    }
}
