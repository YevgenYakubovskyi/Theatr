using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theatr.DAL.Entities
{
    public class Performance
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Author> Authors { get; set; }
        public virtual ICollection<Genre> Genres { get; set; }
        public DateTime Date { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}