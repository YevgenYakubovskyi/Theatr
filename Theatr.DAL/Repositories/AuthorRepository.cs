using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Theatr.DAL.Entities;
using Theatr.DAL.EF;
using Theatr.DAL.Interfaces;
using System.Data.Entity;

namespace Theatr.DAL.Repositories
{
    class AuthorRepository : IAuthorRepository
    {
        private DataContext db;

        public AuthorRepository(DataContext context)
        {
            this.db = context;
        }

        public IEnumerable<Author> GetAll()
        {
            return db.Authors;
        }

        public Author Get(int id)
        {
            return db.Authors.Find(id);
        }
        public Author GetByName(string name)
        {
            return db.Authors.Where(c => c.Name.Equals(name)).FirstOrDefault();
        }
    }
}
