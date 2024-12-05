using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlpShala_SeatingChart.Models
{
    public class SeatType                               //Seat type class that's here to determine the type of seat
    {
        public string Name { get; }
        public char Symbol { get; }

        public SeatType(string name, char symbol)       //Constructor for initialisting SeatType
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
