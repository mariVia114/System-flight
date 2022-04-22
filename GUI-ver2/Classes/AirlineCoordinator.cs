using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace GUI_ver2
{
    public class AirlineCoordinator
    {
        CustomerManager customerManager;
        FlightManager flightManager;
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AirlineDatabase.mdf;Integrated Security=True");
        public AirlineCoordinator()
        {
            flightManager = new FlightManager();
            customerManager = new CustomerManager();
            getBookingsFromDb();
        }
        private void getBookingsFromDb()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Bookings";
            cmd.ExecuteNonQuery();
            DataTable dTable = new DataTable();
            SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
            dAdapter.Fill(dTable);
            for (int i = 0; i < dTable.Rows.Count; i++)
            {
                customerManager.addBooking(Convert.ToInt32(dTable.Rows[i]["PassportNumber"]), dTable.Rows[i]["FlightNumber"].ToString());
                flightManager.addPassenger(dTable.Rows[i]["FlightNumber"].ToString(), getCustomer(Convert.ToInt32(dTable.Rows[i]["PassportNumber"]))) ;
            }
            conn.Close();
        }

        public bool addFlight(string flightNo, string origin, string destination, int maxSeats)
        {
            return flightManager.addFlight(flightNo, origin, destination, maxSeats);
        }

        public Flight getFlight(string fid)
        {
            return flightManager.getFlight(fid);
        }
        public Customer getCustomer(int passportNum)
        {
            return customerManager.getCustomer(passportNum);
        }
     



        public bool deleteFlight(string fid)
        {
            return flightManager.deleteFlight(fid);
        }
        public bool addCustomer(int passportNumber, string fname, string lname, string phone)
        {
            return customerManager.addCustomer(passportNumber, fname, lname,phone);
        }
        public bool addBooking(int customerId, string flightNumber)
        {
            
            if(flightManager.addPassenger(flightNumber, customerManager.getCustomer(customerId)))
            {

                
                customerManager.createBooking(customerId, flightNumber);
                
                return true;
            } 
            //customerManager.addBooking(customerId, bookingId, date, flightNumber, origin, destination);
            //flightManager.addPassenger(flightNumber, customerManager.getCustomer(customerId));
            return false;
        }
       
        public List<Customer> getCustomerList()
        {
            return customerManager.getCustomerList();
        }
        public List<Flight> getFlightList()
        {
            return flightManager.getFlightList();
        }
        public List<Booking> getBookingList()
        {
            return customerManager.getBookingList();
        }
        public string viewAllCustomers()
        {
            return customerManager.customerList();
        }
        public bool deleteCustomer(int cusid)
        {
            return customerManager.deleteCustomer(cusid);
        }


    }
}
