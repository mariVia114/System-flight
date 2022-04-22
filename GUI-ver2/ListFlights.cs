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
    public partial class ListFlights : UserControl
    {
        AirlineCoordinator ac;
        public ListFlights(AirlineCoordinator ac)
        {
            InitializeComponent();
            this.ac = ac;
        }
        private string _flightNumber;
        private string _way;
        private string _numberOfPassengers;

        [Category("Customer Props")]
        public string FlightNumber
        {
            get { return _flightNumber; }
            set { _flightNumber = value; flightNumber.Text = value; }
        }
        [Category("Customer Props")]
        public string Way
        {
            get { return _way; }
            set { _way = value; way.Text = "" + value; }
        }
        [Category("Customer Props")]
        public string NumberOfPassengers
        {
            get { return _numberOfPassengers; }
            set { _numberOfPassengers = value; numberOfPassengers.Text = "Number Of Bookings: " + value; }
        }


        private void ListFlights_Load(object sender, EventArgs e)
        {

        }

        private void flightNumber_Click(object sender, EventArgs e)
        {

        }

        private void way_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (ac.deleteFlight(FlightNumber))
            {
                MessageBox.Show("Flight deleted");
            } else
            {
                MessageBox.Show("Cannot Delete the Flight");
            }
        }
    }
}
