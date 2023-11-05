using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Lab2ClientServer
{
    public partial class Form1 : Form
    {
        private int tabIndex = 0;
        private List<Action<MyDbContext>> showFunctions;
        private List<Action<MyDbContext, int>> removeFunctions;
        private List<Action<MyDbContext, int>> updateFunctions;
        private List<Action<MyDbContext, int>> getFunctions;
        private List<Action<MyDbContext>> addFunctions;
        private int selectedRowIndex;

        public Form1()
        {
            InitializeComponent();
            CreateDatabase();
            showFunctions = new List<Action<MyDbContext>> { ShowAirport, ShowAircraftType, ShowAircraft, ShowFlight, ShowPassenger, ShowTicketPurchase, ShowTicketReturn, ShowRoute, ShowSeatCategory, ShowSeat, ShowBaggage, ShowAgency, ShowBooking, ShowPayment };
            removeFunctions = new List<Action<MyDbContext, int>> { RemoveAirport, RemoveAircraftType, RemoveAircraft, RemoveFlight, RemovePassenger, RemoveTicketPurchase, RemoveTicketReturn, RemoveRoute, RemoveSeatCategory, RemoveSeat, RemoveBaggage, RemoveAgency, RemoveBooking, RemovePayment };
            updateFunctions = new List<Action<MyDbContext, int>> { UpdateAirport, UpdateAircraftType, UpdateAircraft, UpdateFlight, UpdatePassenger, UpdateTicketPurchase, UpdateTicketReturn, UpdateRoute, UpdateSeatCategory, UpdateSeat, UpdateBaggage, UpdateAgency, UpdateBooking, UpdatePayment };
            getFunctions = new List<Action<MyDbContext, int>> { GetAirport, GetAircraftType, GetAircraft, GetFlight, GetPassenger, GetTicketPurchase, GetTicketReturn, GetRoute, GetSeatCategory, GetSeat, GetBaggage, GetAgency, GetBooking, GetPayment };
            addFunctions = new List<Action<MyDbContext>> { AddAirport, AddAircraftType, AddAircraft, AddFlight, AddPassenger, AddTicketPurchase, AddTicketReturn, AddRoute, AddSeatCategory, AddSeat, AddBaggage, AddAgency, AddBooking, AddPayment };
            ShowTable();
        }

        public void CreateDatabase()
        {
            using (var context = new MyDbContext())
            {
                context.Database.EnsureCreated();
                context.SaveChanges();
            }
        }
        private void GetRowIndex(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                selectedRowIndex = e.RowIndex;
            }
            else selectedRowIndex = -1;
            GetInformation();
        }

        private void ChangeTable(object sender, EventArgs e)
        {
            tabIndex = tabs.SelectedIndex;
            ShowTable();
        }

        private void ShowTable()
        {
            using (var context = new MyDbContext())
            {
                showFunctions[tabIndex](context);
            }
        }

        private void ShowAirport(MyDbContext context)
        {
            tableData.DataSource = context.Airports.ToList();
        }
        private void ShowAircraftType(MyDbContext context)
        {
            tableData.DataSource = context.AircraftTypes.ToList();
        }
        private void ShowAircraft(MyDbContext context)
        {
            tableData.DataSource = context.Aircrafts.ToList();
        }
        private void ShowFlight(MyDbContext context)
        {
            tableData.DataSource = context.Flights.ToList();
        }
        private void ShowPassenger(MyDbContext context)
        {
            tableData.DataSource = context.Passengers.ToList();
        }
        private void ShowTicketPurchase(MyDbContext context)
        {
            tableData.DataSource = context.TicketPurchases.ToList();
        }
        private void ShowTicketReturn(MyDbContext context)
        {
            tableData.DataSource = context.TicketReturns.ToList();
        }

        private void ShowRoute(MyDbContext context)
        {
            tableData.DataSource = context.Routes.ToList();
        }

        private void ShowSeatCategory(MyDbContext context)
        {
            tableData.DataSource = context.SeatCategories.ToList();
        }

        private void ShowSeat(MyDbContext context)
        {
            tableData.DataSource = context.Seats.ToList();
        }

        private void ShowBaggage(MyDbContext context)
        {
            tableData.DataSource = context.Baggages.ToList();
        }

        private void ShowAgency(MyDbContext context)
        {
            tableData.DataSource = context.Agencies.ToList();
        }

        private void ShowBooking(MyDbContext context)
        {
            tableData.DataSource = context.Bookings.ToList();
        }

        private void ShowPayment(MyDbContext context)
        {
            tableData.DataSource = context.Payments.ToList();
        }

        private void GetInformation()
        {
            using (var context = new MyDbContext())
            {
                if (selectedRowIndex < 0) return;
                getFunctions[tabIndex](context, selectedRowIndex);
            }
        }

        private void GetAirport(MyDbContext context, int index)
        {
            Airport airport = context.Airports.ToList()[index];
            modelValue1Input.Text = airport.City;
            modelValue2Input.Text = airport.Country;
        }
        private void GetAircraftType(MyDbContext context, int index)
        {
            AircraftType aircraftType = context.AircraftTypes.ToList()[index];
            modelValue1Input.Text = aircraftType.TypeName;
        }
        private void GetAircraft(MyDbContext context, int index)
        {
            Aircraft aircraft = context.Aircrafts.ToList()[index];
            modelValue1Input.Text = aircraft.AircraftRegistrationNumber;
        }
        private void GetFlight(MyDbContext context, int index)
        {
            Flight flight = context.Flights.ToList()[index];
            modelValue1Input.Text = flight.FlightNumber;
            modelValue2Input.Text = flight.AircraftTypeId.ToString();
            modelValue3Input.Text = flight.DepartureAirportId.ToString();
            modelValue4Input.Text = flight.ArrivalAirportId.ToString();
            modelDate1Input.Value = flight.DepartureDate;
            modelValue5Input.Text = flight.FlightDuration.ToString();
            modelValue6Input.Text = flight.TicketPrice.ToString();
        }

        private void AddInformation(object sender, EventArgs e)
        {
            using (var context = new MyDbContext())
            {
                addFunctions[tabIndex](context);
            }
            ShowTable();
        }

        private void AddAirport(MyDbContext context)
        {
            string city = modelValue1Input.Text;
            string country = modelValue1Input.Text;
            if (string.IsNullOrEmpty(city) || string.IsNullOrEmpty(city))
            {
                MessageBox.Show("Будь ласка, заповніть усі поля.");
                return;
            }
            Airport item = new Airport()
            {
                City = city,
                Country = country
            };
            context.Airports.Add(item);
            context.SaveChanges();
        }
        private void AddAircraftType(MyDbContext context)
        {
            string typeName = modelValue1Input.Text;
            int maxPassengerCapacity = Convert.ToInt32(modelValue1Input.Text);

            if (string.IsNullOrEmpty(typeName) || maxPassengerCapacity <= 0)
            {
                MessageBox.Show("Будь ласка, заповніть всі поля коректно.");
                return;
            }

            AircraftType aircraftType = new AircraftType()
            {
                TypeName = typeName,
                MaxPassengerCapacity = maxPassengerCapacity
            };

            context.AircraftTypes.Add(aircraftType);
            context.SaveChanges();
        }
        private void AddAircraft(MyDbContext context)
        {
            string aircraftRegistrationNumber = modelValue1Input.Text;

            if (string.IsNullOrEmpty(aircraftRegistrationNumber))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля коректно.");
                return;
            }
            Aircraft aircraft = new Aircraft()
            {
                AircraftRegistrationNumber = aircraftRegistrationNumber
            };
            context.Aircrafts.Add(aircraft);
            context.SaveChanges();
        }
        private void AddFlight(MyDbContext context)
        {
            string flightNumber = modelValue1Input.Text;
            long aircraftTypeId = Convert.ToInt64(modelValue2Input.Text);
            long departureAirportId = Convert.ToInt64(modelValue3Input.Text);
            long arrivalAirportId = Convert.ToInt64(modelValue4Input.Text);
            DateTime departureDate = modelDate1Input.Value;
            int flightDuration = Convert.ToInt32(modelValue5Input.Text);
            double ticketPrice = Convert.ToDouble(modelValue6Input.Text);

            Flight flight = new Flight()
            {
                FlightNumber = flightNumber,
                AircraftTypeId = aircraftTypeId,
                DepartureAirportId = departureAirportId,
                ArrivalAirportId = arrivalAirportId,
                DepartureDate = departureDate,
                FlightDuration = flightDuration,
                TicketPrice = ticketPrice
            };

            context.Flights.Add(flight);

            context.SaveChanges();
        }


        private void UpdateInformation(object sender, EventArgs e)
        {
            using (var context = new MyDbContext())
            {
                if (selectedRowIndex < 0)
                {
                    MessageBox.Show("������ ����� ���� ������ �������");
                    return;
                }
                updateFunctions[tabIndex](context, selectedRowIndex);
                context.SaveChanges();
            }
            ShowTable();
        }

        private void UpdateAirport(MyDbContext context, int index)
        {
            string city = modelValue1Input.Text;
            string country = modelValue1Input.Text;

            Airport airport = context.Airports.ToList()[index];
            if (string.IsNullOrWhiteSpace(city) || string.IsNullOrWhiteSpace(country))
            {
                MessageBox.Show("�������� ���� Value1");
                return;
            }
            airport.City = city;
            airport.Country = country;
            context.SaveChanges();
        }
        private void UpdateAircraftType(MyDbContext context, int index)
        {
            string typeName = modelValue1Input.Text;
            int maxPassengerCapacity = Convert.ToInt32(modelValue2Input.Text);
            AircraftType aircraftType = context.AircraftTypes.ToList()[index];

            if (string.IsNullOrEmpty(typeName) || maxPassengerCapacity <= 0)
            {
                MessageBox.Show("Будь ласка, заповніть всі поля коректно.");
                return;
            }

            aircraftType.TypeName = typeName;
            aircraftType.MaxPassengerCapacity = maxPassengerCapacity;
            context.SaveChanges();
        }
        private void UpdateAircraft(MyDbContext context, int index)
        {
            Aircraft aircraft = context.Aircrafts.ToList()[index];
            context.SaveChanges();
        }


        private void RemoveInformation(object sender, EventArgs e)
        {
            using (var context = new MyDbContext())
            {
                if (selectedRowIndex < 0)
                {
                    MessageBox.Show("������ ����� ���� ������ ��������");
                    return;
                }
                removeFunctions[tabIndex](context, selectedRowIndex);
                context.SaveChanges();
            }
            ShowTable();
        }

        private void RemoveAirport(MyDbContext context, int index)
        {
            context.Airports.Remove(context.Airports.ToList()[index]);
            context.SaveChanges();
        }
        private void RemoveAircraftType(MyDbContext context, int index)
        {
            context.AircraftTypes.Remove(context.AircraftTypes.ToList()[index]);
        }
        private void RemoveAircraft(MyDbContext context, int index)
        {
            context.Aircrafts.Remove(context.Aircrafts.ToList()[index]);
        }
        private void RemoveFlight(MyDbContext context, int index)
        {
            context.Flights.Remove(context.Flights.ToList()[index]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
