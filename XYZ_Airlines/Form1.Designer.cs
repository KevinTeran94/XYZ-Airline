namespace XYZ_Airlines
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
            this.btnAddFlight = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnViewCustomers = new System.Windows.Forms.Button();
            this.btnDelCustomer = new System.Windows.Forms.Button();
            this.btnDelFlight = new System.Windows.Forms.Button();
            this.btnAddBooking = new System.Windows.Forms.Button();
            this.btnViewBooking = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddFlight
            // 
            this.btnAddFlight.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddFlight.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFlight.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddFlight.Location = new System.Drawing.Point(67, 80);
            this.btnAddFlight.Name = "btnAddFlight";
            this.btnAddFlight.Size = new System.Drawing.Size(146, 41);
            this.btnAddFlight.TabIndex = 0;
            this.btnAddFlight.Text = "Add Flight";
            this.btnAddFlight.UseVisualStyleBackColor = false;
            this.btnAddFlight.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddCustomer.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddCustomer.Location = new System.Drawing.Point(243, 80);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(146, 41);
            this.btnAddCustomer.TabIndex = 1;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RoyalBlue;
            this.button3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(400, 80);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 41);
            this.button3.TabIndex = 2;
            this.button3.Text = "View Flights";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnViewCustomers
            // 
            this.btnViewCustomers.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnViewCustomers.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCustomers.ForeColor = System.Drawing.Color.Transparent;
            this.btnViewCustomers.Location = new System.Drawing.Point(560, 80);
            this.btnViewCustomers.Name = "btnViewCustomers";
            this.btnViewCustomers.Size = new System.Drawing.Size(146, 41);
            this.btnViewCustomers.TabIndex = 3;
            this.btnViewCustomers.Text = "View Customers";
            this.btnViewCustomers.UseVisualStyleBackColor = false;
            this.btnViewCustomers.Click += new System.EventHandler(this.btnViewCustomers_Click);
            // 
            // btnDelCustomer
            // 
            this.btnDelCustomer.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDelCustomer.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelCustomer.ForeColor = System.Drawing.Color.Transparent;
            this.btnDelCustomer.Location = new System.Drawing.Point(67, 187);
            this.btnDelCustomer.Name = "btnDelCustomer";
            this.btnDelCustomer.Size = new System.Drawing.Size(146, 41);
            this.btnDelCustomer.TabIndex = 4;
            this.btnDelCustomer.Text = "Delete Customer ";
            this.btnDelCustomer.UseVisualStyleBackColor = false;
            this.btnDelCustomer.Click += new System.EventHandler(this.btnDelCustomer_Click);
            // 
            // btnDelFlight
            // 
            this.btnDelFlight.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDelFlight.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelFlight.ForeColor = System.Drawing.Color.Transparent;
            this.btnDelFlight.Location = new System.Drawing.Point(243, 187);
            this.btnDelFlight.Name = "btnDelFlight";
            this.btnDelFlight.Size = new System.Drawing.Size(146, 41);
            this.btnDelFlight.TabIndex = 5;
            this.btnDelFlight.Text = "Delete Flight";
            this.btnDelFlight.UseVisualStyleBackColor = false;
            this.btnDelFlight.Click += new System.EventHandler(this.btnDelFlight_Click);
            // 
            // btnAddBooking
            // 
            this.btnAddBooking.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddBooking.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBooking.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddBooking.Location = new System.Drawing.Point(400, 187);
            this.btnAddBooking.Name = "btnAddBooking";
            this.btnAddBooking.Size = new System.Drawing.Size(146, 41);
            this.btnAddBooking.TabIndex = 6;
            this.btnAddBooking.Text = "Make Booking";
            this.btnAddBooking.UseVisualStyleBackColor = false;
            this.btnAddBooking.Click += new System.EventHandler(this.btnAddBooking_Click);
            // 
            // btnViewBooking
            // 
            this.btnViewBooking.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnViewBooking.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewBooking.ForeColor = System.Drawing.Color.Transparent;
            this.btnViewBooking.Location = new System.Drawing.Point(560, 187);
            this.btnViewBooking.Name = "btnViewBooking";
            this.btnViewBooking.Size = new System.Drawing.Size(146, 41);
            this.btnViewBooking.TabIndex = 7;
            this.btnViewBooking.Text = "View Bookings";
            this.btnViewBooking.UseVisualStyleBackColor = false;
            this.btnViewBooking.Click += new System.EventHandler(this.btnViewBooking_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.RoyalBlue;
            this.button9.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Transparent;
            this.button9.Location = new System.Drawing.Point(243, 287);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(146, 41);
            this.button9.TabIndex = 8;
            this.button9.Text = "Search Flight";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.RoyalBlue;
            this.button10.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.Transparent;
            this.button10.Location = new System.Drawing.Point(400, 287);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(146, 41);
            this.button10.TabIndex = 9;
            this.button10.Text = "Exit";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::XYZ_Airlines.Properties.Resources.Untitled_124;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.btnViewBooking);
            this.Controls.Add(this.btnAddBooking);
            this.Controls.Add(this.btnDelFlight);
            this.Controls.Add(this.btnDelCustomer);
            this.Controls.Add(this.btnViewCustomers);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.btnAddFlight);
            this.Name = "Form1";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddFlight;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnViewCustomers;
        private System.Windows.Forms.Button btnDelCustomer;
        private System.Windows.Forms.Button btnDelFlight;
        private System.Windows.Forms.Button btnAddBooking;
        private System.Windows.Forms.Button btnViewBooking;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}

