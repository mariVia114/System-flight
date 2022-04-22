
namespace GUI_ver2
{
    partial class ListFlights
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.way = new System.Windows.Forms.Label();
            this.flightNumber = new System.Windows.Forms.Label();
            this.numberOfPassengers = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // way
            // 
            this.way.AutoSize = true;
            this.way.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.way.ForeColor = System.Drawing.Color.DarkBlue;
            this.way.Location = new System.Drawing.Point(277, 21);
            this.way.Name = "way";
            this.way.Size = new System.Drawing.Size(66, 18);
            this.way.TabIndex = 1;
            this.way.Text = "From/To";
            this.way.Click += new System.EventHandler(this.way_Click);
            // 
            // flightNumber
            // 
            this.flightNumber.AutoSize = true;
            this.flightNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.flightNumber.ForeColor = System.Drawing.Color.DarkBlue;
            this.flightNumber.Location = new System.Drawing.Point(24, 21);
            this.flightNumber.Name = "flightNumber";
            this.flightNumber.Size = new System.Drawing.Size(108, 18);
            this.flightNumber.TabIndex = 3;
            this.flightNumber.Text = "Flight Number: ";
            this.flightNumber.Click += new System.EventHandler(this.flightNumber_Click);
            // 
            // numberOfPassengers
            // 
            this.numberOfPassengers.AutoSize = true;
            this.numberOfPassengers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.numberOfPassengers.ForeColor = System.Drawing.Color.DarkBlue;
            this.numberOfPassengers.Location = new System.Drawing.Point(640, 21);
            this.numberOfPassengers.Name = "numberOfPassengers";
            this.numberOfPassengers.Size = new System.Drawing.Size(36, 18);
            this.numberOfPassengers.TabIndex = 4;
            this.numberOfPassengers.Text = "1/10";
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.AliceBlue;
            this.Delete.ForeColor = System.Drawing.Color.DarkBlue;
            this.Delete.Location = new System.Drawing.Point(865, 2);
            this.Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(115, 58);
            this.Delete.TabIndex = 5;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // ListFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.numberOfPassengers);
            this.Controls.Add(this.flightNumber);
            this.Controls.Add(this.way);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ListFlights";
            this.Size = new System.Drawing.Size(983, 62);
            this.Load += new System.EventHandler(this.ListFlights_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label way;
        private System.Windows.Forms.Label flightNumber;
        private System.Windows.Forms.Label numberOfPassengers;
        private System.Windows.Forms.Button Delete;
    }
}
