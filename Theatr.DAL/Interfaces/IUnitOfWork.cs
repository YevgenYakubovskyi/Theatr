using System;
using Theatr.DAL.Entities;

namespace Theatr.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {

        IAuthorRepository Authors { get; }
        IRepository<Performance> Perfomances { get; }
        IGenreRepository Genres { get; }
        IRepository<Ticket> Tickets { get; }
        IRepository<User> Users { get; }
        void Save();
    }
}
