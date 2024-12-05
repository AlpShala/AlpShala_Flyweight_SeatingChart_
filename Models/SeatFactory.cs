using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlpShala_SeatingChart.Models
{
    public class SeatFactory
    {
        private readonly Dictionary<string, SeatType> _seatTypes = new();

        public SeatType GetSeatType(string name, char symbol)
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
