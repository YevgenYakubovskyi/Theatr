using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theatr.PL.Models
{
    public class AuthorViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<PerformanceViewModel> Performances { get; set; }
    }
}