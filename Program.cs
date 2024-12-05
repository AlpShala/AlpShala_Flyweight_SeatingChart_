using AlpShala_SeatingChart.Models;

namespace SeatingChart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            SeatFactory seatFactory = new SeatFactory();
            List<Seat> seats = new List<Seat>();

            // Define seat types
            SeatType regular = seatFactory.GetSeatType("Regular", 'R');
            SeatType premium = seatFactory.GetSeatType("Premium", 'P');
            SeatType accessible = seatFactory.GetSeatType("Accessible", 'A');

            // Seating chart (10 rows, 10 columns)
            for (int row = 0; row < 10; row++)
            {
                for (int col = 0; col < 10; col++)
                {
                    // Assigning the seat types
                    SeatType seatType = row < 2 ? premium :
                                        col == 0 || col == 9 ? accessible :
                                        regular;

                    seats.Add(new Seat(row, col, seatType));
                }
            }

            // Display seating chart and allow user interaction
            while (true)
            {
                DisplayChart(seats);
                Console.SetCursorPosition(0, 12);
                Console.WriteLine("Legend: R = Regular, P = Premium, A = Accessible, U = User Selected");
                Console.WriteLine("Enter seat coordinates (row,col) to select a seat or type 'exit' to quit:");

                string input = Console.ReadLine();
                if (input?.ToLower() == "exit")
                {
                    break;
                }

                if (TryParseInput(input, out int row, out int col))
                {
                    Seat selectedSeat = seats.Find(s => s.Row == row && s.Column == col);
                    if (selectedSeat != null)
                    {
                        selectedSeat.IsSelected = true;
                        Console.WriteLine($"Seat at Row {row}, Column {col} has been marked as selected.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid seat coordinates. Please try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input format. Please use 'row,col'.");
                }
            }
        }

        private static void DisplayChart(List<Seat> seats)
        {
            Console.Clear();
            Console.WriteLine("Seating Chart:");
            foreach (var seat in seats)
            {
                seat.Display();
            }
        }

        private static bool TryParseInput(string input, out int row, out int col)
        {
            row = -1;
            col = -1;

            string[] parts = input?.Split(',');
            if (parts?.Length == 2 &&
                int.TryParse(parts[0], out row) &&
                int.TryParse(parts[1], out col))
            {
                return row >= 0 && row < 10 && col >= 0 && col < 10;
            }
            return false;
        }
    }
}
