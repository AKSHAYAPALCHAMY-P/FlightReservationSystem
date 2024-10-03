namespace FlightSeatReservation
{
    public class BookingSeats
    {
        const int nTotalSeats = 50;
        const int nRows = 10;
        const int nSeatsInRows = 5;

        public static bool[,] nSeats = new bool[nRows, nSeatsInRows];
        public static string[] nSeatLetters = { "A", "B", "C", "D", "E" };

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the name of the passenger:");
                string strName = Console.ReadLine();

                Console.WriteLine("Enter the gender of the passenger:");
                string strGender = Console.ReadLine();

                Console.WriteLine("Enter the age of the passenger");
                bool nAge = int.TryParse(Console.ReadLine(), out int Age);

                showSeats(strName, strGender, Age);

                Console.WriteLine("want to book more seats? (yes/no)");
                if (Console.ReadLine() == "no")
                {
                    break;
                }
            }
        }
        public static void showSeats(string strName, string strGender, int Age)
        {
            if (IsFlightFull())
            {
                Console.WriteLine("Flight Full!!!!Thanks for Visiting!!!!");
            }

            Console.WriteLine("Available Seats:");
            Console.WriteLine(" W   A   M   A   W");

            for (int i = 0; i < nRows; i++)
            {
                Console.WriteLine($"Row{i + 1}:");

                for (int j = 0; j < nSeatsInRows; j++)
                {
                    Console.Write(nSeats[i, j] ? "[XX]" : "[AA]");//update the entry details automatically
                }
                Console.WriteLine();
            }

            //Choose specific row for Booking

            Console.WriteLine("Enter the row You Want(0-9):");
            int nCustomerRow = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Seatnumber You want(0-4)");
            int nCustomerSeatNumber = int.Parse(Console.ReadLine());

            if (nCustomerRow < 0 || nCustomerRow >= nRows || nCustomerSeatNumber < 0 || nCustomerSeatNumber >= nSeatsInRows)
            {
                Console.WriteLine("Invalid Row or SeatNUmber");
                return;
            }


            if (BookSeat(nCustomerRow, nCustomerSeatNumber))
            {
                Console.WriteLine($"Seat Booked SuccessFully for {strName} in row {nCustomerRow},seat {nCustomerSeatNumber}");
            }

            else
            {
                Console.WriteLine("Sorry,the Selected seat is already Booking");

                bool bFoundNextAvailable = false;//for row Available

                for (int i = 0; i < nSeatsInRows; i++)
                {
                    if (!nSeats[nCustomerRow, i])
                    {
                        BookSeat(nCustomerRow, i);
                        Console.WriteLine($"Seat Booked SuccessFully for {strName} in row {nCustomerRow},seat {i}");
                        bFoundNextAvailable = true;
                        break;
                    }
                }
                if (!bFoundNextAvailable)
                {
                    Console.WriteLine("No seats in this row..select next row");
                }
            }

        }

        public static bool BookSeat(int nCustomerRow, int nSeatNumber)
        {
            if (!nSeats[nCustomerRow, nSeatNumber])  //check seat not booked
            {
                nSeats[nCustomerRow, nSeatNumber] = true;
                return true;
            }
            return false;
        }

        public static bool IsFlightFull()
        {
            for (int i = 0; i < nRows; i++)
            {
                for (int j = 0; j < nSeatsInRows; j++)
                {
                    if (!nSeats[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
