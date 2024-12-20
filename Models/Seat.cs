﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlpShala_SeatingChart.Models
{
    public class Seat                               //Represents a single seat in the seating chart (flyweight object)
    {
        private readonly SeatType _seatType;
        public int Row { get; }
        public int Column { get; }
        public bool IsSelected { get; set; } // To mark the seat as selected by the user

        public Seat(int row, int column, SeatType seatType)
        {
            Row = row;
            Column = column;
            _seatType = seatType;
            IsSelected = false;
        }

        public void Display()                       //Method for displaying the seat in the console
        {
            Console.SetCursorPosition(Column * 2, Row);
            Console.Write(IsSelected ? 'U' : _seatType.Symbol);
        }
    }
}
