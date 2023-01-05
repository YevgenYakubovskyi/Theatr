using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theatr.PL.Models
{
    public class PerformanceViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public IEnumerable<AuthorViewModel> Authors { get; set; }
        public IEnumerable<GenreViewModel> Genres { get; set; }
        public IEnumerable<TicketViewModel> Tickets { get; set; }
    }
}
