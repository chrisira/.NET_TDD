namespace FlightTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var flight = new Flight(SeatCapacity: 3);
            flight.Book("chris@gmail.com", 1);

            flight.remainingNumberOfSeats.Should().Be(2);

        }
    }
}