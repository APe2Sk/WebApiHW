using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotoApp.Domain.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public IEnumerable<CombinationNumbers> Numbers { get; set; } = new List<CombinationNumbers>();
        public User Player { get; set; }

    }
}
