using System;
using System.Collections.Generic;
using System.Text;

namespace GUI_ver2
{
    public class Booking
    {
        private int customerPassportNumber;
        private string flightNumber;

        public Booking( int passportNumber, string flightNumber)
        {            
            this.customerPassportNumber = passportNumber;
            this.flightNumber = flightNumber;
   
        }


        public string getFlightNum() { return flightNumber; }
        
        public int getPassportNum() { return customerPassportNumber; }

        public string toString()
        {
            string s = "customer Passport Number: " + customerPassportNumber;
            s += "\nFlight Number: " + flightNumber;
   
            return s;
        }

    }
}
