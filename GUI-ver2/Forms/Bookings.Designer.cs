
namespace GUI_ver2
{
    partial class Bookings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bookings));
            this.addBooking = new System.Windows.Forms.Button();
            this.txtPassportNumber = new System.Windows.Forms.TextBox();
            this.txtFlightNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bookingList = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addBooking
            // 
            this.addBooking.BackColor = System.Drawing.Color.AliceBlue;
            this.addBooking.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addBooking.FlatAppearance.BorderSize = 2;
            this.addBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBooking.ForeColor = System.Drawing.Color.DarkBlue;
            this.addBooking.Location = new System.Drawing.Point(239, 89);
            this.addBooking.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.addBooking.Name = "addBooking";
            this.addBooking.Size = new System.Drawing.Size(233, 34);
            this.addBooking.TabIndex = 0;
            this.addBooking.Text = "Add Booking";
            this.addBooking.UseVisualStyleBackColor = false;
            this.addBooking.Click += new System.EventHandler(this.addBooking_Click);
            // 
            // txtPassportNumber
            // 
            this.txtPassportNumber.BackColor = System.Drawing.Color.AliceBlue;
            this.txtPassportNumber.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtPassportNumber.Location = new System.Drawing.Point(240, 21);
            this.txtPassportNumber.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.txtPassportNumber.Name = "txtPassportNumber";
            this.txtPassportNumber.Size = new System.Drawing.Size(232, 22);
            this.txtPassportNumber.TabIndex = 2;
            // 
            // txtFlightNumber
            // 
            this.txtFlightNumber.BackColor = System.Drawing.Color.AliceBlue;
            this.txtFlightNumber.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtFlightNumber.Location = new System.Drawing.Point(240, 56);
            this.txtFlightNumber.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.txtFlightNumber.Name = "txtFlightNumber";
            this.txtFlightNumber.Size = new System.Drawing.Size(232, 22);
            this.txtFlightNumber.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(38, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Passport Number:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(38, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Flight Number:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // bookingList
            // 
            this.bookingList.AutoScroll = true;
            this.bookingList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bookingList.BackgroundImage")));
            this.bookingList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bookingList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bookingList.Location = new System.Drawing.Point(29, 225);
            this.bookingList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookingList.Name = "bookingList";
            this.bookingList.Size = new System.Drawing.Size(1021, 474);
            this.bookingList.TabIndex = 19;
            this.bookingList.Paint += new System.Windows.Forms.PaintEventHandler(this.bookingList_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(76, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Name";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(385, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Flight Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(748, 202);
            this.label6.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Departure/Arrival";
            // 
            // Bookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1083, 732);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bookingList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFlightNumber);
            this.Controls.Add(this.txtPassportNumber);
            this.Controls.Add(this.addBooking);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Bookings";
            this.Text = "Bookings";
            this.Load += new System.EventHandler(this.Bookings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBooking;
        private System.Windows.Forms.TextBox txtPassportNumber;
        private System.Windows.Forms.TextBox txtFlightNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel bookingList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}