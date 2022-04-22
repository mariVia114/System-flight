
namespace GUI_ver2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bookings = new System.Windows.Forms.Button();
            this.flights = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.customers = new System.Windows.Forms.Button();
            this.Greeting = new System.Windows.Forms.Label();
            this.content = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.content.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.bookings);
            this.panel1.Controls.Add(this.flights);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.customers);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 595);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bookings
            // 
            this.bookings.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bookings.FlatAppearance.BorderSize = 2;
            this.bookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookings.ForeColor = System.Drawing.Color.DarkBlue;
            this.bookings.Location = new System.Drawing.Point(21, 424);
            this.bookings.Margin = new System.Windows.Forms.Padding(2);
            this.bookings.Name = "bookings";
            this.bookings.Size = new System.Drawing.Size(150, 65);
            this.bookings.TabIndex = 4;
            this.bookings.Text = "Bookings";
            this.bookings.UseVisualStyleBackColor = false;
            this.bookings.Click += new System.EventHandler(this.bookings_Click);
            // 
            // flights
            // 
            this.flights.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.flights.FlatAppearance.BorderSize = 2;
            this.flights.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flights.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flights.ForeColor = System.Drawing.Color.DarkBlue;
            this.flights.Location = new System.Drawing.Point(21, 288);
            this.flights.Margin = new System.Windows.Forms.Padding(2);
            this.flights.Name = "flights";
            this.flights.Size = new System.Drawing.Size(150, 65);
            this.flights.TabIndex = 3;
            this.flights.Text = "Flights";
            this.flights.UseVisualStyleBackColor = false;
            this.flights.Click += new System.EventHandler(this.flights_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "ABC Airline";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // customers
            // 
            this.customers.BackColor = System.Drawing.Color.LightSteelBlue;
            this.customers.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.customers.FlatAppearance.BorderSize = 2;
            this.customers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customers.ForeColor = System.Drawing.Color.DarkBlue;
            this.customers.Location = new System.Drawing.Point(21, 159);
            this.customers.Margin = new System.Windows.Forms.Padding(2);
            this.customers.Name = "customers";
            this.customers.Size = new System.Drawing.Size(150, 65);
            this.customers.TabIndex = 0;
            this.customers.Text = "Customers";
            this.customers.UseVisualStyleBackColor = false;
            this.customers.Click += new System.EventHandler(this.customers_Click);
            // 
            // Greeting
            // 
            this.Greeting.AutoSize = true;
            this.Greeting.BackColor = System.Drawing.Color.Transparent;
            this.Greeting.Font = new System.Drawing.Font("Microsoft YaHei", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Greeting.Location = new System.Drawing.Point(290, 126);
            this.Greeting.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Greeting.Name = "Greeting";
            this.Greeting.Size = new System.Drawing.Size(195, 46);
            this.Greeting.TabIndex = 0;
            this.Greeting.Text = "Welcome!";
            this.Greeting.Click += new System.EventHandler(this.Greeting_Click);
            // 
            // content
            // 
            this.content.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("content.BackgroundImage")));
            this.content.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.content.Controls.Add(this.Greeting);
            this.content.Location = new System.Drawing.Point(190, 0);
            this.content.Margin = new System.Windows.Forms.Padding(2);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(805, 597);
            this.content.TabIndex = 1;
            this.content.Paint += new System.Windows.Forms.PaintEventHandler(this.content_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 595);
            this.Controls.Add(this.content);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "ABC Airline";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.content.ResumeLayout(false);
            this.content.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button customers;
        private System.Windows.Forms.Button flights;
        private System.Windows.Forms.Button bookings;
        private System.Windows.Forms.Label Greeting;
        private System.Windows.Forms.Panel content;
    }
}

