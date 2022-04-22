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
    
    public partial class Customers : Form
    {
        AirlineCoordinator ac;
        public Customers(AirlineCoordinator ac)

        {
            this.ac = ac;
            InitializeComponent();
            
        }

        private void add_Click(object sender, EventArgs e)
        {
            bool valid = true;
            errorIndex.Text = "";
            string s = "invalid: ";
            if (!validator(txtPassportNum.Text, true))
            {
                valid = false;
                s += "Passport Number ";
            }
            if (!validator(txtFirstName.Text))
            {

                valid = false;
                s += "First Name ";
            }
            if (!validator(txtLastName.Text))
            {
                valid = false;
                s += "Last Name ";
            }
            if (!validator(txtPhone.Text, true))
            {
                valid = false;
                s += "Phone ";
            }
            if (valid)
            {
                int passportNum = Convert.ToInt32(txtPassportNum.Text);
                string fname = txtFirstName.Text;
                string lname = txtLastName.Text;
                string phone = txtPhone.Text;
                if(ac.addCustomer(passportNum, fname, lname, phone))
                {
                    txtFirstName.Text = txtLastName.Text = txtPassportNum.Text = txtPhone.Text = "";
                } else
                {

                    MessageBox.Show("Customer Already Exists");
                }
                
            } else
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

        private void labelPhone_Click(object sender, EventArgs e)
        {

        }

        private void Customers_Load(object sender, EventArgs e)
        {
            populateItems();
        }

    

        private void customerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void customerList_Paint(object sender, PaintEventArgs e)
        {

        }
        private void populateItems()
        {

            customerList.Controls.Clear();
            List<Customer> customers = ac.getCustomerList();
            ListCustomers[] listItems = new ListCustomers[customers.Count];
            for (int i = 0; i < listItems.Length; i++)
            {

                listItems[i] = new ListCustomers(ac);
                listItems[i].FullName = customers[i].getFirstName()+ " " + customers[i].getLastName();
                listItems[i].PassportNumber = customers[i].getPassportNumber() + " ";
                listItems[i].NumOfBookings = customers[i].getNumOfBookings() + " ";

                //listItems[i].Click += (s, e) => { MessageBox.Show("") ; };

                customerList.Controls.Add(listItems[i]);
            }

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            
           if (int.TryParse(txtCustomerSearch.Text, out i))
            {
                if(ac.getCustomer(i)!= null)
                {
                    lblFullName.Text = ac.getCustomer(i).getFirstName() + " " + ac.getCustomer(i).getLastName();
                    lblPhone.Text = ac.getCustomer(i).getPhone();
                }   
            }
            


        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            populateItems();
        }
    }
}
