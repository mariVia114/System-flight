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
    public partial class ListBookings : UserControl
    {
        public ListBookings()
        {
            InitializeComponent();
        }

        private void ListBookings_Load(object sender, EventArgs e)
        {

        }
        private string _flightNumber;
        private string _customerName;
     
        private string _way;

        //[Category("Customer Props")]
        public string FullName
        {
            get { return _customerName; }
            set { _customerName = value; lblName.Text = value; }
        }
        //[Category("Customer Props")]
        public string FlightNumber
        {
            get { return _flightNumber; }
            set { _flightNumber = value; lblFlightNumber.Text = "Flight Number: " + value; }
        }
        //[Category("Customer Props")]

        public string Way
        {
            get { return _way; }
            set { _way = value; lblWay.Text = "From/Where: " + value; }
        }
    }
}
