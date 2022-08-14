using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotoApp.Domain.Models
{
    public class Draw
    {
        public int Id { get; set; }
        public IEnumerable<CombinationNumbers> DrawNumbers { get; set; } = new List<CombinationNumbers>();
        public User Admin { get; set; }     

        public void LottertNumbersSelected()
        {
            List<CombinationNumbers> drawNums = new List<CombinationNumbers>();

            Random random = new Random();
            var winningNums = Enumerable.Range(1, 37)
                                .OrderBy(x => random.Next())
                                .Take(8)
                                .ToList();
            for (int i = 0; i < 8; i++)
            {
                CombinationNumbers drawNumbers = new CombinationNumbers();

                drawNumbers.Id = i;
                drawNumbers.Number = winningNums[i];

                drawNums.Add(drawNumbers);
            }
            DrawNumbers = drawNums;

        }

        public Ticket WinningTicket { get; set; }
    }
}
