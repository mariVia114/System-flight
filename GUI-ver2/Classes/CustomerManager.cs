using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace GUI_ver2
{
    public class CustomerManager
    {
        private int numOfCustomers;
        
        //private Customer[] customers;
        List<Customer> customers;
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AirlineDatabase.mdf;Integrated Security=True");

        public CustomerManager()
        {
            numOfCustomers = 0;
            
            customers = new List<Customer>();
            //customers = new Customer[maxCustomers];
            getCustomersFromDb();
            //getBookingsFromDb();

        }
        
        private void getCustomersFromDb()
        {
            
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Customer";
            cmd.ExecuteNonQuery();
            DataTable dTable = new DataTable();
            SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
            dAdapter.Fill(dTable);
            for (int i = 0; i < dTable.Rows.Count; i++)
            {
               
               customers.Add(new Customer(Convert.ToInt32(dTable.Rows[i]["PassportNumber"]), dTable.Rows[i]["FirstName"].ToString(), dTable.Rows[i]["LastName"].ToString(), dTable.Rows[i]["Phone"].ToString()));
                numOfCustomers++;
            }
            conn.Close();
        }
        public bool addCustomer(int passportNumber, string fname, string lname, string phone, int numOfBookings = 0)
        {
            if (!customerExists(passportNumber))
            {
                customers.Add(new Customer(passportNumber, fname, lname, phone));
                numOfCustomers++;
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"INSERT Customer(PassportNumber, FirstName,LastName,Phone,NumberOfBookings) VALUES ({passportNumber},'{fname}','{lname}','{phone}',{numOfBookings});";
                cmd.ExecuteNonQuery();
                //Console.WriteLine(customerExists(passportNumber));
                conn.Close();
                return true;

            } 
            return false;
        }
        private bool customerExists(int passportNumber)
        {
            for (int i = 0; i < numOfCustomers; i++)
            {
                if (customers[i].getPassportNumber() == passportNumber)
                {
                    return true;
                }

            }
            return false;
        }
        public List<Customer> getCustomerList()
        {
            return customers;
        }
        public bool addBooking(int passportNumber,  string flightNumber)
        {
            for (int i = 0; i<numOfCustomers;i++)
            {
                if (customers[i].getPassportNumber() == passportNumber)
                {
                    customers[i].addBooking(flightNumber);
                    return true;
                }
                
            }
            return false;
        }
        
        public bool createBooking(int passportNumber, string flightNumber)
        {
            if (getCustomer(passportNumber) == null) { return false; }
            if (getCustomer(passportNumber).addBooking(flightNumber) != false)
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"INSERT INTO Bookings VALUES ({passportNumber},'{flightNumber}');";
                cmd.ExecuteNonQuery();
                //Console.WriteLine(customerExists(passportNumber));
                conn.Close();

                return true;
            }
            return false;
        }
        public Customer getCustomer(int passportNumber)
        {
            for (int i = 0; i < numOfCustomers; i++)
            {
                if (customers[i].getPassportNumber() == passportNumber)
                {
                    return customers[i];
                }

            }
            return null;
        }
        public List<Booking> getBookingList()
        {
            List<Booking> bookings = new List<Booking>();
            
            for (int i = 0; i < numOfCustomers; i++)
            {
                bookings.AddRange(customers[i].getAllBookings());
                

            }
            return bookings;
        }
        public int getNumOfCustomers()
        {
            return numOfCustomers;
        }
        public string customerList()
        {
            string s = "";
            for(int i = 0; i < numOfCustomers; i++)
            {
                s += customers[i].toString();
                s += "\n";
            }
            return s;
        }
        public bool deleteCustomer(int passportNumber)
        {
            for (int i = 0; i < numOfCustomers; i++)
            {
                if (customers[i].getPassportNumber() == passportNumber)
                {
                    if (customers[i].getNumOfBookings() >0 )
                    {
                        return false;
                    } else
                    {
                        conn.Open();
                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = $"Delete FROM Customer WHERE PassportNumber='{passportNumber}';";
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Deleted "+ passportNumber);
                        conn.Close();
                        customers.Remove(getCustomer(passportNumber));
                        numOfCustomers--;
                        return true;
                    }
                }

            }
            return false;
        }
        
    }
}
