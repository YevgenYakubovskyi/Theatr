using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Theatr.DAL.Entities;
using Theatr.DAL.EF;
using Theatr.DAL.Interfaces;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Theatr.DAL.Repositories
{
    class UserRepository : IRepository<User>
    {
        private DataContext db;

        public UserRepository(DataContext context)
        {
            this.db = context;
        }

        public IEnumerable<User> GetAll()
        {
            return db.Users;
        }

        public User Get(int id)
        {
            return db.Users.Find(id);
        }

        public void Create(User user)
        {
            db.Users.Add(user);
        }

        public void Update(User user)
        {
            db.Entry(user).State = EntityState.Modified;
        }
        public IEnumerable<User> Find(Expression<Func<User, bool>> expression)
        {
            return db.Users.Where(expression).ToList();
        }
        public void Delete(int id)
        {
            User user = db.Users.Find(id);
            if (user != null)
                db.Users.Remove(user);
        }


    }
}
