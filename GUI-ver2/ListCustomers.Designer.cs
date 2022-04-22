
namespace GUI_ver2
{
    partial class ListCustomers
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
            this.lblPassport = new System.Windows.Forms.Label();
            this.lblNumOfBookings = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblName.Location = new System.Drawing.Point(40, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "label1";
            // 
            // lblPassport
            // 
            this.lblPassport.AutoSize = true;
            this.lblPassport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblPassport.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblPassport.Location = new System.Drawing.Point(352, 21);
            this.lblPassport.Name = "lblPassport";
            this.lblPassport.Size = new System.Drawing.Size(46, 18);
            this.lblPassport.TabIndex = 1;
            this.lblPassport.Text = "label2";
            // 
            // lblNumOfBookings
            // 
            this.lblNumOfBookings.AutoSize = true;
            this.lblNumOfBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblNumOfBookings.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblNumOfBookings.Location = new System.Drawing.Point(678, 21);
            this.lblNumOfBookings.Name = "lblNumOfBookings";
            this.lblNumOfBookings.Size = new System.Drawing.Size(46, 18);
            this.lblNumOfBookings.TabIndex = 2;
            this.lblNumOfBookings.Text = "label3";
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.AliceBlue;
            this.Delete.ForeColor = System.Drawing.Color.DarkBlue;
            this.Delete.Location = new System.Drawing.Point(867, 2);
            this.Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(115, 60);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // ListCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.lblNumOfBookings);
            this.Controls.Add(this.lblPassport);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ListCustomers";
            this.Size = new System.Drawing.Size(985, 64);
            this.Load += new System.EventHandler(this.ListCustomers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPassport;
        private System.Windows.Forms.Label lblNumOfBookings;
        private System.Windows.Forms.Button Delete;
    }
}
