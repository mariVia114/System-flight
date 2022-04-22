using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace GUI_ver2
{
    public class FlightManager
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AirlineDatabase.mdf;Integrated Security=True");
        //private int maxFlights;
        private int numFlights;
        //private Flight[] flightList;
        List<Flight> flightList;

        public FlightManager()
        {
          
            numFlights = 0;
            flightList = new List<Flight>();
            addFlightsFtomDb();
            //getBookingsFromDb();
        }
        
        private void addFlightsFtomDb()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Flights";
            cmd.ExecuteNonQuery();
            DataTable dTable = new DataTable();
            SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
            dAdapter.Fill(dTable);
            for (int i = 0; i < dTable.Rows.Count; i++)
            {

                flightList.Add(new Flight(dTable.Rows[i]["FlightNumber"].ToString(), dTable.Rows[i]["Origin"].ToString(), dTable.Rows[i]["Destination"].ToString(),  Convert.ToInt32(dTable.Rows[i]["SeatsNumber"])));
                numFlights++;
            }
            conn.Close();
        }
        public bool addFlight(string fn, string origin, string destination, int maxSeats)
        {
            
            if (flightExists(fn)) 
            {
                Console.WriteLine("flight is already exists");
                return false; 
            }


            Flight f = new Flight(fn, origin, destination, maxSeats);
            flightList.Add(f);
            numFlights++;
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"INSERT INTO Flights VALUES ('{fn}','{origin}','{destination}',{maxSeats},{0});";
            cmd.ExecuteNonQuery();
            //Console.WriteLine(customerExists(passportNumber));
            conn.Close();
            return true;
        }

        public int findFlight(string fid)
        {
            for (int x = 0; x < numFlights; x++)
            {
                
                if (flightList[x].getFlightNumber() == fid)
                    return x;
            }
            return -1;
        }

        public bool flightExists(string fid)
        {
            int loc = findFlight(fid);
            if (loc == -1) { return false; }
            return true;
        }

        public Flight getFlight(string fid)
        {
            int loc = findFlight(fid);
            if (loc == -1) { return null; }
            return flightList[loc];
        }
        public List<Flight> getFlightList()
        {
            return flightList;
        }

        public bool deleteFlight(string fid)
        {
            int loc = findFlight(fid);
            if (loc == -1) 
            {
                Console.WriteLine("flight  not found");
                return false; 
            }
            if (flightList[loc].getNumPassengers() > 0) 
            { 
                Console.WriteLine("Cannot Delete the flight with passengers");
                return false;
            }
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"Delete FROM Flights WHERE FlightNumber='{fid}';";
            cmd.ExecuteNonQuery();
            Console.WriteLine("Deleted " + fid);
            conn.Close();
            flightList.Remove(getFlight(fid));
            
            numFlights--;
            return true;
        }

        
        public bool addPassenger(string fid, Customer c)
        {
            int loc = findFlight(fid);
            if (loc == -1) {
                Console.WriteLine("flight  not found");
                return false; }
            if (flightList[loc].addPassenger(c))
            {
                return true;
            } else
            {
                return false;
            }
            
            
            
        }
    }

}
