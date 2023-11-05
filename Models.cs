using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Airport
{
    public long IdAirport { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
}

public class AircraftType
{
    public long IdAircraftType { get; set; }
    public string TypeName { get; set; }
    public int MaxPassengerCapacity { get; set; }
}

public class Aircraft
{
    public long IdAircraft { get; set; }
    public long AircraftTypeId { get; set; }
    public string AircraftRegistrationNumber { get; set; }

    public virtual AircraftType AircraftType { get; set; }
}

public class Flight
{
    public long IdFlight { get; set; }
    public string FlightNumber { get; set; }
    public long AircraftTypeId { get; set; }
    public long DepartureAirportId { get; set; }
    public long ArrivalAirportId { get; set; }
    public DateTime DepartureDate { get; set; }
    public int FlightDuration { get; set; }
    public double TicketPrice { get; set; }

    public virtual AircraftType AircraftType { get; set; }
    public virtual Airport DepartureAirport { get; set; }
    public virtual Airport ArrivalAirport { get; set; }
}

public class Passenger
{
    public long IdPassenger { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string DocumentType { get; set; }
    public string DocumentSeries { get; set; }
    public string DocumentNumber { get; set; }

    public long FlightId { get; set; }
    public virtual Flight Flight { get; set; }
}

public class TicketPurchase
{
    public long IdPurchase { get; set; }
    public long PassengerId { get; set; }
    public long FlightId { get; set; }
    public DateTime PurchaseDate { get; set; }

    public virtual Passenger Passenger { get; set; }
    public virtual Flight Flight { get; set; }
}

public class TicketReturn
{
    public long IdReturn { get; set; }
    public long PurchaseId { get; set; }
    public DateTime ReturnDate { get; set; }

    public virtual TicketPurchase TicketPurchase { get; set; }
}

public class Route
{
    public long IdRoute { get; set; }
    public string DepartureCity { get; set; }
    public string ArrivalCity { get; set; }

    public virtual Airport DepartureAirport { get; set; }
    public virtual Airport ArrivalAirport { get; set; }
}
public class SeatCategory
{
    public long IdCategory { get; set; }
    public string CategoryName { get; set; }
    public string Description { get; set; }
}

public class Seat
{
    public long IdSeat { get; set; }
    public long FlightId { get; set; }
    public long CategoryId { get; set; }
    public string SeatNumber { get; set; }
    public bool IsAvailable { get; set; }

    public virtual Flight Flight { get; set; }
    public virtual SeatCategory SeatCategory { get; set; }
}

public class Baggage
{
    public long IdBaggage { get; set; }
    public long PassengerId { get; set; }
    public float WeightKg { get; set; }

    public virtual Passenger Passenger { get; set; }
}

public class Agency
{
    public long IdAgency { get; set; }
    public string AgencyName { get; set; }
    public string ContactEmail { get; set; }
    public string ContactPhone { get; set; }
}

public class Booking
{
    public long IdBooking { get; set; }
    public long FlightId { get; set; }
    public long PassengerId { get; set; }
    public DateTime BookingDate { get; set; }
    public long AgencyId { get; set; }

    public virtual Flight Flight { get; set; }
    public virtual Passenger Passenger { get; set; }
    public virtual Agency Agency { get; set; }
}

public class Payment
{
    public long IdPayment { get; set; }
    public long BookingId { get; set; }
    public DateTime PaymentDate { get; set; }
    public double PaymentAmount { get; set; }

    public virtual Booking Booking { get; set; }
}
