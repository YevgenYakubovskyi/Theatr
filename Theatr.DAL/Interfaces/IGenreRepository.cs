using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Theatr.DAL.Entities;

namespace Theatr.DAL.Interfaces
{
    public interface IGenreRepository
    {
        IEnumerable<Genre> GetAll();
        IEnumerable<Genre> GetByNamePerformance(string name);
        Genre GetById(int id);
        Genre GetByName(string name);
    }
}