namespace FlightSeatReservation
{
    public class BookingSeats
    {
        const int nTotalSeats = 50;
        const int nRows = 10;
        const int nSeatsInRows = 5;
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
            string strText = "AA";
            string nAvailableSeats = " ";
            int nSeatNumber = 0;
            for (int i = 0; i < nRows; i++)
            {
                for (int j = nSeatsInRows; j < nRows; j++)
                {
                    //nAvailableSeats = 
                    Console.Write(' '+strText);
                }
                Console.WriteLine();
            }

            //Choose specific row for Booking

            Console.WriteLine("Enter the row You Want:");
            int nCustomerRow = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Seatnumber You want");
            int nCustomerSeatNumber = int.Parse(Console.ReadLine());

            BookingAvailableSeats(nCustomerRow, nCustomerSeatNumber);


        }

        public static bool BookingAvailableSeats(int nCustomerRow,int nCustomerNumber)
        {
            if()
        }
    }
}
