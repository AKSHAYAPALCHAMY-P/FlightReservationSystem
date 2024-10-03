namespace FlightSeatReservation
{
    public class BookingSeats
    {
        const int nTotalSeats = 50;
        const int nRows = 10;
        const int nSeatsInRows = 5;

        private static bool[,] seats= new bool[nRows, nSeatsInRows];
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of the passenger:");
            string strName = Console.ReadLine();

            Console.WriteLine("Enter the gender of the passenger:");
            string strGender = Console.ReadLine();

            Console.WriteLine("Enter the age of the passenger");
            bool nAge = int.TryParse(Console.ReadLine(), out int Age);

            showSeats(strName, strGender, Age);
        }
        public static void showSeats(string strName, string strGender, int Age)
        {
            //int[] nArray = new int[nTotalSeats];
            //int[] nRowsInFlight = new int[nRows];
            //int[] nSeatsinEachRow = new int[nTotalSeats];
            //int[,] twoDimensionalArray = new int[3, 4];
            //string[,] nSeats = new string[nRows, nSeatsInRows];
            //string strText = "AA";
            //string nAvailableSeats = " ";
            //int nSeatNumber = 0;

            Console.WriteLine("Available Seats:");

            for (int i = 0; i < nRows; i++)
            {
                Console.WriteLine($"Row{i}:");

                for (int j = 0; j < nSeatsInRows; j++)
                {
                    Console.Write(seats[i,j] ? "[BB]" : "[AA]");
                }
                Console.WriteLine();
            }

            //Choose specific row for Booking

            Console.WriteLine("Enter the row You Want(0-9):");
            int nCustomerRow = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Seatnumber You want(0-4)");
            int nCustomerSeatNumber = int.Parse(Console.ReadLine());

            if(nCustomerRow < 0 || nCustomerRow >= nRows || nCustomerSeatNumber < 0 || nCustomerSeatNumber >= nSeatsInRows)
            {
                Console.WriteLine("Invalid Row or SeatNUmber");
                return;
            }

            if(BookSeat(nCustomerRow, nCustomerSeatNumber))
            {
                Console.WriteLine($"Seat Booked SuccessFully for{strName} in row {nCustomerRow},seat{nCustomerSeatNumber}");
            }

            else
            {
                Console.WriteLine("Sorry,the Selected seat is already Booking");
            }

        }

        public static bool BookSeat(int nCustomerRow, int nSeatNumber)
        {
            if()
        }
    }
}
