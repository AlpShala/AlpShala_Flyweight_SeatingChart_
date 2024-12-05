using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlpShala_SeatingChart.Models
{
    public class SeatType
    {
        public string Name { get; }
        public char Symbol { get; }

        public SeatType(string name, char symbol)
        {
            Name = name;
            Symbol = symbol;
        }

        public void Display(int row, int col)
        {
            Console.SetCursorPosition(col * 2, row);
            Console.Write(Symbol);
        }
    }
}
