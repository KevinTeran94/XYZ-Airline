namespace XYZ_Airlines
{
    partial class AddBookingForm
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
            this.txtCustomerList = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFlightList = new System.Windows.Forms.RichTextBox();
            this.txtCustomerNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFlightNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEcustNum = new System.Windows.Forms.Label();
            this.lblEfNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCustomerList
            // 
            this.txtCustomerList.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerList.Location = new System.Drawing.Point(82, 129);
            this.txtCustomerList.Name = "txtCustomerList";
            this.txtCustomerList.Size = new System.Drawing.Size(327, 145);
            this.txtCustomerList.TabIndex = 36;
            this.txtCustomerList.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 58);
            this.label1.TabIndex = 35;
            this.label1.Text = "Make Booking";
            // 
            // txtFlightList
            // 
            this.txtFlightList.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlightList.Location = new System.Drawing.Point(440, 129);
            this.txtFlightList.Name = "txtFlightList";
            this.txtFlightList.Size = new System.Drawing.Size(327, 145);
            this.txtFlightList.TabIndex = 37;
            this.txtFlightList.Text = "";
            // 
            // txtCustomerNum
            // 
            this.txtCustomerNum.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerNum.Location = new System.Drawing.Point(348, 298);
            this.txtCustomerNum.Name = "txtCustomerNum";
            this.txtCustomerNum.Size = new System.Drawing.Size(225, 27);
            this.txtCustomerNum.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 23);
            this.label2.TabIndex = 38;
            this.label2.Text = "Enter Custumer\'s Number:";
            // 
            // txtFlightNum
            // 
            this.txtFlightNum.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlightNum.Location = new System.Drawing.Point(348, 333);
            this.txtFlightNum.Name = "txtFlightNum";
            this.txtFlightNum.Size = new System.Drawing.Size(225, 27);
            this.txtFlightNum.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(182, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 23);
            this.label3.TabIndex = 40;
            this.label3.Text = "Enter Flight Number:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(440, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 37);
            this.button2.TabIndex = 43;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(320, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 37);
            this.button1.TabIndex = 42;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 23);
            this.label4.TabIndex = 44;
            this.label4.Text = "Customer List:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(436, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 23);
            this.label5.TabIndex = 45;
            this.label5.Text = "Flight List:";
            // 
            // lblEcustNum
            // 
            this.lblEcustNum.AutoSize = true;
            this.lblEcustNum.BackColor = System.Drawing.Color.Transparent;
            this.lblEcustNum.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEcustNum.Location = new System.Drawing.Point(579, 302);
            this.lblEcustNum.Name = "lblEcustNum";
            this.lblEcustNum.Size = new System.Drawing.Size(0, 23);
            this.lblEcustNum.TabIndex = 46;
            // 
            // lblEfNo
            // 
            this.lblEfNo.AutoSize = true;
            this.lblEfNo.BackColor = System.Drawing.Color.Transparent;
            this.lblEfNo.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEfNo.Location = new System.Drawing.Point(579, 337);
            this.lblEfNo.Name = "lblEfNo";
            this.lblEfNo.Size = new System.Drawing.Size(0, 23);
            this.lblEfNo.TabIndex = 47;
            // 
            // AddBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::XYZ_Airlines.Properties.Resources.Untitled_124;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEfNo);
            this.Controls.Add(this.lblEcustNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtFlightNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCustomerNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFlightList);
            this.Controls.Add(this.txtCustomerList);
            this.Controls.Add(this.label1);
            this.Name = "AddBookingForm";
            this.Text = "Make Booking";
            this.Load += new System.EventHandler(this.AddBookingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtCustomerList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtFlightList;
        private System.Windows.Forms.TextBox txtCustomerNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFlightNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEcustNum;
        private System.Windows.Forms.Label lblEfNo;
    }
}