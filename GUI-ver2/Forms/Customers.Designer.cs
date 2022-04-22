
namespace GUI_ver2
{
    partial class Customers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
            this.add = new System.Windows.Forms.Button();
            this.txtPassportNum = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.customerList = new System.Windows.Forms.FlowLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.errorIndex = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCustomerSearch = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.AliceBlue;
            this.add.ForeColor = System.Drawing.Color.DarkBlue;
            this.add.Location = new System.Drawing.Point(340, 177);
            this.add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(113, 34);
            this.add.TabIndex = 0;
            this.add.Text = "Add Customer";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // txtPassportNum
            // 
            this.txtPassportNum.BackColor = System.Drawing.Color.AliceBlue;
            this.txtPassportNum.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtPassportNum.Location = new System.Drawing.Point(221, 23);
            this.txtPassportNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassportNum.Name = "txtPassportNum";
            this.txtPassportNum.Size = new System.Drawing.Size(232, 22);
            this.txtPassportNum.TabIndex = 3;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.AliceBlue;
            this.txtFirstName.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtFirstName.Location = new System.Drawing.Point(221, 63);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(232, 22);
            this.txtFirstName.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.AliceBlue;
            this.txtLastName.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtLastName.Location = new System.Drawing.Point(221, 101);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(232, 22);
            this.txtLastName.TabIndex = 5;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.AliceBlue;
            this.txtPhone.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtPhone.Location = new System.Drawing.Point(221, 138);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(232, 22);
            this.txtPhone.TabIndex = 6;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(41, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Phone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(41, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Last Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(41, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "First Name: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(41, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Passport number: ";
            // 
            // customerList
            // 
            this.customerList.AutoScroll = true;
            this.customerList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("customerList.BackgroundImage")));
            this.customerList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.customerList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.customerList.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.customerList.Location = new System.Drawing.Point(31, 284);
            this.customerList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customerList.Name = "customerList";
            this.customerList.Size = new System.Drawing.Size(1021, 434);
            this.customerList.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.ForeColor = System.Drawing.Color.DarkBlue;
            this.label9.Location = new System.Drawing.Point(69, 260);
            this.label9.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Full Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.ForeColor = System.Drawing.Color.DarkBlue;
            this.label10.Location = new System.Drawing.Point(407, 260);
            this.label10.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Passport Number";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.ForeColor = System.Drawing.Color.DarkBlue;
            this.label11.Location = new System.Drawing.Point(716, 260);
            this.label11.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "Number of Booking";
            // 
            // errorIndex
            // 
            this.errorIndex.AutoSize = true;
            this.errorIndex.ForeColor = System.Drawing.Color.Red;
            this.errorIndex.Location = new System.Drawing.Point(218, 212);
            this.errorIndex.Name = "errorIndex";
            this.errorIndex.Size = new System.Drawing.Size(0, 17);
            this.errorIndex.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.ForeColor = System.Drawing.Color.DarkBlue;
            this.button1.Location = new System.Drawing.Point(939, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 34);
            this.button1.TabIndex = 27;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCustomerSearch
            // 
            this.txtCustomerSearch.BackColor = System.Drawing.Color.AliceBlue;
            this.txtCustomerSearch.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtCustomerSearch.Location = new System.Drawing.Point(701, 23);
            this.txtCustomerSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustomerSearch.Name = "txtCustomerSearch";
            this.txtCustomerSearch.Size = new System.Drawing.Size(232, 22);
            this.txtCustomerSearch.TabIndex = 28;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFullName.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblFullName.Location = new System.Drawing.Point(697, 65);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(0, 20);
            this.lblFullName.TabIndex = 29;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPhone.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblPhone.Location = new System.Drawing.Point(697, 101);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(0, 20);
            this.lblPhone.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(548, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Passport number: ";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.AliceBlue;
            this.btnRefresh.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnRefresh.Location = new System.Drawing.Point(939, 246);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(113, 34);
            this.btnRefresh.TabIndex = 32;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1083, 732);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.txtCustomerSearch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.errorIndex);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.customerList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtPassportNum);
            this.Controls.Add(this.add);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Customers";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox txtPassportNum;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FlowLayoutPanel customerList;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label errorIndex;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCustomerSearch;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
    }
}