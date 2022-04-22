using System;
using System.Collections.Generic;
using System.Text;

namespace GUI_ver2
{
    public class Flight
    {
        private string flightNumber;
        private string origin;
        private string destination;
        private int maxSeats;
      
        private int numPassengers;
        private Customer[] passengers;

        public Flight(string fn, string or, string dest,  int mSeats)
        {
            maxSeats = mSeats;
            flightNumber = fn;
            origin = or;
            destination = dest;
           
            numPassengers = 0;
            passengers = new Customer[maxSeats];
        }

        public string getFlightNumber() { return flightNumber; }
        public string getOrigin() { return origin; }
        public string getDestination() { return destination; }
        public int getMaxSeats() { return maxSeats; }
  
        public int getNumPassengers() { return numPassengers; }

        public bool addPassenger(Customer c)
        {
            if (numPassengers >= maxSeats) { return false; }
            for (int i = 0; i< numPassengers;i++)
            {
                if (passengers[i].getPassportNumber() == c.getPassportNumber())
                {
                    return false;
                }
            }
            passengers[numPassengers] = c;
            numPassengers++;
            
            return true;
        }

        public int findPassenger(int passportNumber)
        {
            for (int x = 0; x < maxSeats; x++)
            {
                if (passengers[x].getPassportNumber() == passportNumber)
                    return x;
            }
            return -1;
        }

        public bool removePassenger(int custId)
        {
            int loc = findPassenger(custId);
            if (loc == -1) return false;
            passengers[loc] = passengers[numPassengers - 1];
            numPassengers--;
            return true;
        }

        public string getPassengerList()
        {
            string s = "Passengers on flight " + flightNumber + ":";
            for (int x = 0; x < numPassengers; x++)
            {
                s = s + passengers[x].getFirstName() + " " + passengers[x].getLastName() + "     ";
            } 
            return s;
        }

        public string toString()
        {
            string s = "Flight Number: " + flightNumber;
            s = s + "\nOrigin: " + origin;
            s = s + "\nDestination:" + destination;
            s = s + "\nNumber of Passengers:" + numPassengers;
            s = s + "\nAvailable seats:" + (maxSeats - numPassengers);
            s = s + getPassengerList();
            return s;
        }
    }

}
