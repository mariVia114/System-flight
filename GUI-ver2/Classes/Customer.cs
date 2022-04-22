using System;
using System.Collections.Generic;
using System.Text;

namespace GUI_ver2
{
    public class Customer
    {
       
   
        private int passportNumber;
        private string firstName;
        private string lastName;
        private string phone;
        //private Booking[] bookings;
        List<Booking> bookings;
        private int numOfBookings;

       
        public Customer(int passportNumber, string fname, string lname, string phone)
        {
            this.passportNumber = passportNumber;
            this.firstName = fname;
            this.lastName = lname;
            this.phone = phone;
            this.numOfBookings = 0;
            bookings = new List<Booking>();
        }

        public bool addBooking(string flightNumber )
        {
            if (getBooking(flightNumber) == null)
            {
                bookings.Add(new Booking(passportNumber,  flightNumber));
                numOfBookings++;
                return true;
            }
            return false;
            

            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        }
        
        //!!!!!!!!!!!!!!!Geters and setters if needed
        public string getFirstName() { return firstName; }
        public string getLastName() { return lastName; }
        public int getNumOfBookings() { return numOfBookings; }
        public string getPhone() { return phone; }
        public int getPassportNumber() { return passportNumber; }
        //!!!!!!!!!!!!!!!!111
        private int findBooking(string flightNum)
        {
            for (int i = 0; i < numOfBookings; i++)
            {
                if (bookings[i].getFlightNum() == flightNum)
                {
                    return i;
                }
            }
            return -1;
        }
        public Booking getBooking(string flightNum)
        {
            if (findBooking(flightNum) >= 0)
            {
           
                return bookings[findBooking(flightNum)];
            }
            return null;
        }
        public List<Booking> getAllBookings()
        {
            return bookings;
        } 
        
        public string getBookingList()
        {
            if (numOfBookings == 0) { return "No Bookings for customer"; }
            string s = "";
            for(int i = 0; i<numOfBookings; i++)
            {
                s += "\nPassenger: " + firstName + " " + lastName;
                s += "\nPassporn Num: " + passportNumber;
                s += "\n" +bookings[i].toString();
                s += "\n";
            }
            return s;
        }
        public string toString()
        {
            string s = "\nFirst Name: " + firstName;
            s += "\nLast Name: " + lastName;
            s += "\nPhone: " + phone;
            s += "\nPassport Number: " + passportNumber;
            s += "\nNumber Of Bookings: " + numOfBookings;
            return s;
        }
    }
}
