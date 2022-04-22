
namespace GUI_ver2
{
    partial class Flights
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flights));
            this.txtFlightNumber = new System.Windows.Forms.TextBox();
            this.txtOrigin = new System.Windows.Forms.TextBox();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.txtSeatsNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flightList = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.addFlight = new System.Windows.Forms.Button();
            this.errorIndex = new System.Windows.Forms.Label();
            this.lblFlightNum = new System.Windows.Forms.Label();
            this.lblOrigin = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblBookings = new System.Windows.Forms.Label();
            this.lblPassengers = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFlightNumber
            // 
            this.txtFlightNumber.BackColor = System.Drawing.Color.AliceBlue;
            this.txtFlightNumber.Location = new System.Drawing.Point(202, 9);
            this.txtFlightNumber.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.txtFlightNumber.Name = "txtFlightNumber";
            this.txtFlightNumber.Size = new System.Drawing.Size(232, 22);
            this.txtFlightNumber.TabIndex = 1;
            // 
            // txtOrigin
            // 
            this.txtOrigin.BackColor = System.Drawing.Color.AliceBlue;
            this.txtOrigin.Location = new System.Drawing.Point(202, 41);
            this.txtOrigin.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Size = new System.Drawing.Size(232, 22);
            this.txtOrigin.TabIndex = 2;
            // 
            // txtDestination
            // 
            this.txtDestination.BackColor = System.Drawing.Color.AliceBlue;
            this.txtDestination.Location = new System.Drawing.Point(202, 77);
            this.txtDestination.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(232, 22);
            this.txtDestination.TabIndex = 3;
            // 
            // txtSeatsNumber
            // 
            this.txtSeatsNumber.BackColor = System.Drawing.Color.AliceBlue;
            this.txtSeatsNumber.Location = new System.Drawing.Point(202, 111);
            this.txtSeatsNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSeatsNumber.Name = "txtSeatsNumber";
            this.txtSeatsNumber.Size = new System.Drawing.Size(232, 22);
            this.txtSeatsNumber.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Flight Number:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(23, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Origin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(23, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Destination:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(23, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Seats Number:";
            // 
            // flightList
            // 
            this.flightList.AutoScroll = true;
            this.flightList.BackColor = System.Drawing.Color.LightSteelBlue;
            this.flightList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flightList.BackgroundImage")));
            this.flightList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flightList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flightList.Location = new System.Drawing.Point(27, 233);
            this.flightList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flightList.Name = "flightList";
            this.flightList.Size = new System.Drawing.Size(1021, 474);
            this.flightList.TabIndex = 11;
            this.flightList.Paint += new System.Windows.Forms.PaintEventHandler(this.flightList_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(49, 207);
            this.label6.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Flight Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(367, 207);
            this.label7.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Departure/Arrival";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(729, 207);
            this.label8.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Number of Seats";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.AliceBlue;
            this.txtSearch.Location = new System.Drawing.Point(690, 15);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(191, 22);
            this.txtSearch.TabIndex = 26;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSearch.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSearch.Location = new System.Drawing.Point(921, 10);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(127, 33);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.ForeColor = System.Drawing.Color.DarkBlue;
            this.label9.Location = new System.Drawing.Point(477, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "Search By Flight Number";
            // 
            // addFlight
            // 
            this.addFlight.BackColor = System.Drawing.Color.AliceBlue;
            this.addFlight.ForeColor = System.Drawing.Color.DarkBlue;
            this.addFlight.Location = new System.Drawing.Point(311, 147);
            this.addFlight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addFlight.Name = "addFlight";
            this.addFlight.Size = new System.Drawing.Size(123, 34);
            this.addFlight.TabIndex = 29;
            this.addFlight.Text = "Add Flight";
            this.addFlight.UseVisualStyleBackColor = false;
            this.addFlight.Click += new System.EventHandler(this.addFlight_Click);
            // 
            // errorIndex
            // 
            this.errorIndex.AutoSize = true;
            this.errorIndex.ForeColor = System.Drawing.Color.Red;
            this.errorIndex.Location = new System.Drawing.Point(24, 182);
            this.errorIndex.Name = "errorIndex";
            this.errorIndex.Size = new System.Drawing.Size(0, 17);
            this.errorIndex.TabIndex = 30;
            // 
            // lblFlightNum
            // 
            this.lblFlightNum.AutoSize = true;
            this.lblFlightNum.Location = new System.Drawing.Point(478, 55);
            this.lblFlightNum.Name = "lblFlightNum";
            this.lblFlightNum.Size = new System.Drawing.Size(0, 17);
            this.lblFlightNum.TabIndex = 31;
            // 
            // lblOrigin
            // 
            this.lblOrigin.AutoSize = true;
            this.lblOrigin.Location = new System.Drawing.Point(647, 55);
            this.lblOrigin.Name = "lblOrigin";
            this.lblOrigin.Size = new System.Drawing.Size(0, 17);
            this.lblOrigin.TabIndex = 32;
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(827, 55);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(0, 17);
            this.lblDestination.TabIndex = 33;
            // 
            // lblBookings
            // 
            this.lblBookings.AutoSize = true;
            this.lblBookings.Location = new System.Drawing.Point(994, 55);
            this.lblBookings.Name = "lblBookings";
            this.lblBookings.Size = new System.Drawing.Size(0, 17);
            this.lblBookings.TabIndex = 34;
            // 
            // lblPassengers
            // 
            this.lblPassengers.AutoSize = true;
            this.lblPassengers.Location = new System.Drawing.Point(478, 82);
            this.lblPassengers.Name = "lblPassengers";
            this.lblPassengers.Size = new System.Drawing.Size(0, 17);
            this.lblPassengers.TabIndex = 35;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.AliceBlue;
            this.btnRefresh.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnRefresh.Location = new System.Drawing.Point(935, 193);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(113, 34);
            this.btnRefresh.TabIndex = 36;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Flights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1083, 732);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblPassengers);
            this.Controls.Add(this.lblBookings);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.lblOrigin);
            this.Controls.Add(this.lblFlightNum);
            this.Controls.Add(this.errorIndex);
            this.Controls.Add(this.addFlight);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.flightList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSeatsNumber);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.txtOrigin);
            this.Controls.Add(this.txtFlightNumber);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Flights";
            this.Text = "Flights";
            this.Load += new System.EventHandler(this.Flights_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFlightNumber;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.TextBox txtSeatsNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flightList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button addFlight;
        private System.Windows.Forms.Label errorIndex;
        private System.Windows.Forms.Label lblFlightNum;
        private System.Windows.Forms.Label lblOrigin;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblBookings;
        private System.Windows.Forms.Label lblPassengers;
        private System.Windows.Forms.Button btnRefresh;
    }
}