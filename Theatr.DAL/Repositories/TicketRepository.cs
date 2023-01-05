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

    class TicketRepository : IRepository<Ticket>
    {
        private DataContext db;

        public TicketRepository(DataContext context)
        {
            this.db = context;
        }

        public IEnumerable<Ticket> GetAll()
        {
            return db.Tickets;
        }

        public Ticket Get(int id)
        {
            return db.Tickets.Find(id);
        }

        public void Create(Ticket ticket)
        {
            db.Tickets.Add(ticket);
        }

        public void Update(Ticket ticket)
        {
            db.Entry(ticket).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Ticket ticket = db.Tickets.Find(id);
            if (ticket != null)
                db.Tickets.Remove(ticket);
        }

        public IEnumerable<Ticket> Find(Expression<Func<Ticket, bool>> expression)
        {
            return db.Tickets.Where(expression).ToList();
        }
    }
}

