using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Configuration;

namespace Lab2ClientServer
{
    class MyDbContext : DbContext
    {
        public DbSet<Airport> Airports { get; set; }
        public DbSet<AircraftType> AircraftTypes { get; set; }
        public DbSet<Aircraft> Aircrafts { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<TicketPurchase> TicketPurchases { get; set; }
        public DbSet<TicketReturn> TicketReturns { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<SeatCategory> SeatCategories { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Baggage> Baggages { get; set; }
        public DbSet<Agency> Agencies { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Payment> Payments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            }
        }
    }
}
