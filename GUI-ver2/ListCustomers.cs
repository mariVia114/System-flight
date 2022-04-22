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
    public partial class ListCustomers : UserControl
    {
        AirlineCoordinator ac;
        public ListCustomers(AirlineCoordinator ac)
        {
            InitializeComponent();
            this.ac = ac;
        }
        private string _fullName;
        private string _passportNumber;
        private string _numOfBookings;

        //[Category("Customer Props")]
        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; lblName.Text = value; }
        }
        //[Category("Customer Props")]
        public string PassportNumber
        {
            get { return _passportNumber; }
            set { _passportNumber = value; lblPassport.Text = "Passport Number: " + value; }
        }
        //[Category("Customer Props")]
        public string NumOfBookings
        {
            get { return _numOfBookings; }
            set { _numOfBookings = value; lblNumOfBookings.Text = "Number Of Bookings: " + value; }
        }


        private void ListCustomers_Load(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (ac.deleteCustomer(Convert.ToInt32(this.PassportNumber)))
            {
                
                MessageBox.Show("Deleted");
            } else
            {
                MessageBox.Show("Customer has Bookings");
            }
        }
    }
}
