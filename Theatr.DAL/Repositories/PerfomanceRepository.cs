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
    class PerfomanceRepository : IRepository<Performance>
    {
        private DataContext db;

        public PerfomanceRepository(DataContext context)
        {
            this.db = context;
        }

        public IEnumerable<Performance> GetAll()
        {
            return db.Performances;
        }

        public Performance Get(int id)
        {
            return db.Performances.Find(id);
        }

        public void Create(Performance performance)
        {
            db.Performances.Add(performance);
        }

        public void Update(Performance performance)
        {
            db.Entry(performance).State = EntityState.Modified;
        }
        public IEnumerable<Performance> Find(Expression<Func<Performance, bool>> expression)
        {
            return db.Performances.Where(expression).ToList();
        }
        public void Delete(int id)
        {
            Performance performance = db.Performances.Find(id);
            if (performance != null)
                db.Performances.Remove(performance);
        }

        
    }
}
