using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theatr.BLL.DTO
{
    public class AuthorDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual IEnumerable<PerformanceDTO> PerfomanceDTOs { get; set; }
    }
}
