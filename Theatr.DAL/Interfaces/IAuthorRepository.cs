using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Theatr.DAL.Entities;

namespace Theatr.DAL.Interfaces
{
    public interface IAuthorRepository
    {
        IEnumerable<Author> GetAll();
        Author Get(int id);

        Author GetByName(string name);
    }
}