
namespace GUI_ver2
{
    partial class ListBookings
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblFlightNumber = new System.Windows.Forms.Label();
            this.lblWay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblName.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblName.Location = new System.Drawing.Point(28, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 18);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "label1";
            // 
            // lblFlightNumber
            // 
            this.lblFlightNumber.AutoSize = true;
            this.lblFlightNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblFlightNumber.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblFlightNumber.Location = new System.Drawing.Point(379, 21);
            this.lblFlightNumber.Name = "lblFlightNumber";
            this.lblFlightNumber.Size = new System.Drawing.Size(46, 18);
            this.lblFlightNumber.TabIndex = 1;
            this.lblFlightNumber.Text = "label1";
            // 
            // lblWay
            // 
            this.lblWay.AutoSize = true;
            this.lblWay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblWay.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblWay.Location = new System.Drawing.Point(695, 21);
            this.lblWay.Name = "lblWay";
            this.lblWay.Size = new System.Drawing.Size(46, 18);
            this.lblWay.TabIndex = 3;
            this.lblWay.Text = "label1";
            // 
            // ListBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.lblWay);
            this.Controls.Add(this.lblFlightNumber);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ListBookings";
            this.Size = new System.Drawing.Size(983, 62);
            this.Load += new System.EventHandler(this.ListBookings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFlightNumber;
        private System.Windows.Forms.Label lblWay;
    }
}
