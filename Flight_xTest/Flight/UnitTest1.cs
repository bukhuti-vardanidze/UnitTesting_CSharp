
using Domain;
using FluentAssertions;
using Xunit;

namespace FlightSpecipications
{
    public class UnitTest1
    {
        [Fact]
        public void Booking_reduces_the_number_of_seats()
        {

            var flight = new Flight(seatCapacity: 3);
            flight.Book("buta@gmail.com", 1);
            flight.RemainingNumberOfSeats.Should().Be(2);

        }

        [Fact]
        public void Avoids_OverBooking()
        {
            // Give
            var flight = new Flight(seatCapacity: 3);

            //When
            var error = flight.Book("Buteqsa@gmail.com", 4);

            //Then
            error.Should().BeOfType<OverBookingError>();
        }
    }
}