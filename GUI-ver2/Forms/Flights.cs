using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_ver2

{
    public partial class Flights : Form
    {

        AirlineCoordinator ac;
        public Flights(AirlineCoordinator ac )
        {
            this.ac = ac;
            InitializeComponent();
           
        }


       


        private void Flights_Load(object sender, EventArgs e)
        {
            populateItems();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void populateItems()
        {
            flightList.Controls.Clear();
            List<Flight> flights = ac.getFlightList();
            ListFlights[] listItems = new ListFlights[flights.Count];
            for (int i = 0; i < listItems.Length; i++)
            {
                listItems[i] = new ListFlights(ac);
                listItems[i].FlightNumber = flights[i].getFlightNumber();
                listItems[i].Way = "From: "+flights[i].getOrigin() + " To: " + flights[i].getDestination() ;
                listItems[i].NumberOfPassengers = flights[i].getNumPassengers() + "/" + flights[i].getMaxSeats();
                //listItems[i].Click += (s, e) => { MessageBox.Show(""); };

                flightList.Controls.Add(listItems[i]);
            }

        }

     
    

        private void flightList_Paint(object sender, PaintEventArgs e)
        {
            //populateItems();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void addFlight_Click(object sender, EventArgs e)
        {
            bool valid = true;
            errorIndex.Text = "";
            string s = "invalid: ";
            if (!validator(txtFlightNumber.Text))
            {
                valid = false;
                s += "Passport Number ";
            }
            if (!validator(txtOrigin.Text))
            {

                valid = false;
                s += "First Name ";
            }
            if (!validator(txtDestination.Text))
            {
                valid = false;
                s += "Last Name ";
            }
            if (!validator(txtSeatsNumber.Text, true))
            {
                valid = false;
                s += "Phone ";
            }
            if (valid)
            {
                //int passportNum = Convert.ToInt32(txtPassportNum.Text);
                string fNum = txtFlightNumber.Text;
                string origin = txtOrigin.Text;
                string destination = txtDestination.Text;
               
                int seatsNum = Convert.ToInt32(txtSeatsNumber.Text);

                if (ac.addFlight(fNum,origin,destination,seatsNum))
                {

                }
                else
                {

                    MessageBox.Show("Flight Already Exists");
                }

            }
            else
            {
                errorIndex.Text = s;
            }
            populateItems();
        }
        private bool validator(string txt, bool number = false)
        {
            int i = 0;
            if (number)
            {
                if (int.TryParse(txt, out i))
                {
                    return true;
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(txt))
                {
                    return true;
                }
            }
            return false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string flightNum = txtSearch.Text;
            Flight flight = ac.getFlight(flightNum);
            if(flight == null)
            {
                MessageBox.Show("Flight Not Found");
            } else
            {
                lblFlightNum.Text = "Flight Number: " +flight.getFlightNumber();
                lblOrigin.Text = "From " + flight.getOrigin();
                lblDestination.Text = "To " + flight.getDestination();
                lblBookings.Text = flight.getNumPassengers() + "/" + flight.getMaxSeats();

                lblPassengers.Text = flight.getPassengerList() ;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            populateItems();
        }
    }
}
