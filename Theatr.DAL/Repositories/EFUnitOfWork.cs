using System;
using Theatr.DAL.EF;
using Theatr.DAL.Interfaces;
using Theatr.DAL.Entities;

namespace Theatr.DAL.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private DataContext db;
        private  AuthorRepository authorRepository;
        private PerfomanceRepository perfomanceRepository;
        private GenreRepository genreRepository;
        private TicketRepository ticketRepository;
        private UserRepository userRepository;

        public EFUnitOfWork()
        {
            db = new DataContext();
        }
        public IAuthorRepository Authors
        {
            get
            {
                if (authorRepository == null)
                    authorRepository = new AuthorRepository(db);
                return authorRepository;
            }
        }

        public IRepository<Performance> Perfomances
        {
            get
            {
                if (perfomanceRepository == null)
                    perfomanceRepository = new PerfomanceRepository(db);
                return perfomanceRepository;
            }
        }

        public IGenreRepository Genres
        {
            get
            {
                if (genreRepository == null)
                    genreRepository = new GenreRepository(db);
                return genreRepository;
            }
        }
        public IRepository<Ticket> Tickets
        {
            get
            {
                if (ticketRepository == null)
                    ticketRepository = new TicketRepository(db);
                return ticketRepository;
            }
        }

        public IRepository<User> Users
        {
            get
            {
                if (userRepository == null)
                    userRepository = new UserRepository(db);
                return userRepository;
            }
        }    

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}