using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theatr.PL.Models
{
    public class TicketViewModel
    {
        public int Id { get; set; }
        public int PerfomanceId { get; set; }
        public string TicketCategory { get; set; }
        public float Price { get; set; }
        public string TicketState { get; set; }
        public int UserId { get; set; }
    }
}
