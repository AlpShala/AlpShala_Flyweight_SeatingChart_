using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlpShala_SeatingChart.Models                                 //Creates and manages seattype instances
{
    public class SeatFactory
    {
        private readonly Dictionary<string, SeatType> _seatTypes = new();

        public SeatType GetSeatType(string name, char symbol)            //Checks if a seat type exists and either creates it or stores it
        {
            if (!_seatTypes.ContainsKey(name))
            {
                Console.WriteLine($"Creating new SeatType: {name}");
                _seatTypes[name] = new SeatType(name, symbol);
            }

            return _seatTypes[name];
        }
    }
}
