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
    public partial class Bookings : Form
    {
        AirlineCoordinator ac; 
        public Bookings(AirlineCoordinator ac)
        {
            this.ac = ac;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void addBooking_Click(object sender, EventArgs e)
        {
            //this.label1 = new System.Windows.Forms.Label();
            if (txtFlightNumber.Text == "")
            {

            }
            string flightNum = txtFlightNumber.Text;
            int passportNum = Convert.ToInt32(txtPassportNumber.Text);

            if (ac.getCustomer(passportNum) == null) { MessageBox.Show("Customer Does not exist"); }
            else if (ac.getFlight(flightNum) == null) { MessageBox.Show("Flight does not exist"); }
            
            else
            {
                if (ac.addBooking(passportNum, flightNum)) { } else
                {
                    MessageBox.Show("Cannot add the booking");
                }
            }
            populateItems();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Bookings_Load(object sender, EventArgs e)
        {
            populateItems();
        }
        private void populateItems()
        {

            bookingList.Controls.Clear();
            List<Booking> bookings = ac.getBookingList();
            ListBookings[] listItems = new ListBookings[bookings.Count];
            for (int i = 0; i < listItems.Length; i++)
            {

                listItems[i] = new ListBookings();
                
                listItems[i].FullName = ac.getCustomer(bookings[i].getPassportNum()).getFirstName() + " " + ac.getCustomer(bookings[i].getPassportNum()).getLastName();
                listItems[i].FlightNumber = bookings[i].getFlightNum();
                listItems[i].Way = "From "+ ac.getFlight(bookings[i].getFlightNum()).getOrigin() + " To " + ac.getFlight(bookings[i].getFlightNum()).getDestination();

                //listItems[i].Click += (s, e) => { MessageBox.Show("") ; };

                bookingList.Controls.Add(listItems[i]);
            }

        }

        private void bookingList_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
