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
    public partial class Form1 : Form
    {
        private Button currentButton;
        private string[] check;

        
        private Form activeForm;
        AirlineCoordinator ac = new AirlineCoordinator();
        public Form1()
        {
           
            InitializeComponent();
            
        }
     
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    
                    currentButton = (Button)btnSender;
                    
                    currentButton.ForeColor = Color.SlateGray;
                    //currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    
                    
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panel1.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    //previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.AliceBlue;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void formLoader(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.content.Controls.Add(childForm);
            this.content.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

 

     

        private void customers_Click(object sender, EventArgs e)
        {
            formLoader(new Customers(ac), sender);
        }

        private void flights_Click(object sender, EventArgs e)
        {
            formLoader(new Flights(ac), sender);
        }

        private void bookings_Click(object sender, EventArgs e)
        {
            formLoader(new Bookings(ac), sender);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Greeting_Click(object sender, EventArgs e)
        {

        }
    }
}
