namespace XYZ_Airlines
{
    partial class FlightAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightAddForm));
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOrigin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaxSeats = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFlightNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errFlNum = new System.Windows.Forms.Label();
            this.lblEseats = new System.Windows.Forms.Label();
            this.lblEorigin = new System.Windows.Forms.Label();
            this.lblEdest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(291, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 19);
            this.label6.TabIndex = 23;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(411, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 37);
            this.button2.TabIndex = 22;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(291, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 37);
            this.button1.TabIndex = 21;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDest
            // 
            this.txtDest.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDest.Location = new System.Drawing.Point(339, 284);
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(225, 27);
            this.txtDest.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(176, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "Port of Destination:";
            // 
            // txtOrigin
            // 
            this.txtOrigin.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrigin.Location = new System.Drawing.Point(339, 245);
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Size = new System.Drawing.Size(225, 27);
            this.txtOrigin.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(216, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "Port of Origin:";
            // 
            // txtMaxSeats
            // 
            this.txtMaxSeats.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxSeats.Location = new System.Drawing.Point(339, 206);
            this.txtMaxSeats.Name = "txtMaxSeats";
            this.txtMaxSeats.Size = new System.Drawing.Size(225, 27);
            this.txtMaxSeats.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Max Number of Seats:";
            // 
            // txtFlightNum
            // 
            this.txtFlightNum.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlightNum.Location = new System.Drawing.Point(339, 165);
            this.txtFlightNum.Name = "txtFlightNum";
            this.txtFlightNum.Size = new System.Drawing.Size(225, 27);
            this.txtFlightNum.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(207, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Flight Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 58);
            this.label1.TabIndex = 12;
            this.label1.Text = "Add Flight";
            // 
            // errFlNum
            // 
            this.errFlNum.AutoSize = true;
            this.errFlNum.BackColor = System.Drawing.Color.Transparent;
            this.errFlNum.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errFlNum.Location = new System.Drawing.Point(570, 169);
            this.errFlNum.Name = "errFlNum";
            this.errFlNum.Size = new System.Drawing.Size(0, 23);
            this.errFlNum.TabIndex = 24;
            // 
            // lblEseats
            // 
            this.lblEseats.AutoSize = true;
            this.lblEseats.BackColor = System.Drawing.Color.Transparent;
            this.lblEseats.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEseats.Location = new System.Drawing.Point(570, 210);
            this.lblEseats.Name = "lblEseats";
            this.lblEseats.Size = new System.Drawing.Size(0, 23);
            this.lblEseats.TabIndex = 25;
            // 
            // lblEorigin
            // 
            this.lblEorigin.AutoSize = true;
            this.lblEorigin.BackColor = System.Drawing.Color.Transparent;
            this.lblEorigin.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEorigin.Location = new System.Drawing.Point(570, 249);
            this.lblEorigin.Name = "lblEorigin";
            this.lblEorigin.Size = new System.Drawing.Size(0, 23);
            this.lblEorigin.TabIndex = 26;
            // 
            // lblEdest
            // 
            this.lblEdest.AutoSize = true;
            this.lblEdest.BackColor = System.Drawing.Color.Transparent;
            this.lblEdest.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdest.Location = new System.Drawing.Point(570, 288);
            this.lblEdest.Name = "lblEdest";
            this.lblEdest.Size = new System.Drawing.Size(0, 23);
            this.lblEdest.TabIndex = 27;
            // 
            // FlightAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEdest);
            this.Controls.Add(this.lblEorigin);
            this.Controls.Add(this.lblEseats);
            this.Controls.Add(this.errFlNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDest);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtOrigin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaxSeats);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFlightNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FlightAddForm";
            this.Text = "Add Flight";
            this.Load += new System.EventHandler(this.FlightAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaxSeats;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFlightNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label errFlNum;
        private System.Windows.Forms.Label lblEseats;
        private System.Windows.Forms.Label lblEorigin;
        private System.Windows.Forms.Label lblEdest;
    }
}