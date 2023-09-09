namespace Domain.Tests
{
    public class Flight
    {
        public int remainingNumberOfSeats { get; set; }
        public Flight(int SeatCapacity)
        {
            remainingNumberOfSeats = SeatCapacity;

        }
        public void Book(string V1, int V2)
        {
            remainingNumberOfSeats -= V2;
        }

    }
}