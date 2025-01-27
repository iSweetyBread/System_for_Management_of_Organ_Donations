namespace ui
{
    partial class frmBDonorAddDonation
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
            this.tbBDonorIDDonation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddBDonorAmount = new System.Windows.Forms.Button();
            this.tbBDonorAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBDonationPlaceID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpBDonationDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbBDonorIDDonation
            // 
            this.tbBDonorIDDonation.Location = new System.Drawing.Point(12, 26);
            this.tbBDonorIDDonation.Name = "tbBDonorIDDonation";
            this.tbBDonorIDDonation.Size = new System.Drawing.Size(297, 20);
            this.tbBDonorIDDonation.TabIndex = 18;
            this.tbBDonorIDDonation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Blood Donor ID Number";
            // 
            // btnAddBDonorAmount
            // 
            this.btnAddBDonorAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBDonorAmount.Location = new System.Drawing.Point(12, 253);
            this.btnAddBDonorAmount.Name = "btnAddBDonorAmount";
            this.btnAddBDonorAmount.Size = new System.Drawing.Size(297, 83);
            this.btnAddBDonorAmount.TabIndex = 16;
            this.btnAddBDonorAmount.Text = "Add";
            this.btnAddBDonorAmount.UseVisualStyleBackColor = true;
            this.btnAddBDonorAmount.Click += new System.EventHandler(this.btnAddBDonorAmount_Click);
            // 
            // tbBDonorAmount
            // 
            this.tbBDonorAmount.Location = new System.Drawing.Point(12, 75);
            this.tbBDonorAmount.Name = "tbBDonorAmount";
            this.tbBDonorAmount.Size = new System.Drawing.Size(297, 20);
            this.tbBDonorAmount.TabIndex = 20;
            this.tbBDonorAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Amount (ml)";
            // 
            // tbBDonationPlaceID
            // 
            this.tbBDonationPlaceID.Location = new System.Drawing.Point(12, 122);
            this.tbBDonationPlaceID.Name = "tbBDonationPlaceID";
            this.tbBDonationPlaceID.Size = new System.Drawing.Size(297, 20);
            this.tbBDonationPlaceID.TabIndex = 22;
            this.tbBDonationPlaceID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Donation Place ID Number";
            // 
            // dtpBDonationDate
            // 
            this.dtpBDonationDate.Location = new System.Drawing.Point(12, 171);
            this.dtpBDonationDate.Name = "dtpBDonationDate";
            this.dtpBDonationDate.Size = new System.Drawing.Size(296, 20);
            this.dtpBDonationDate.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Donation Date";
            // 
            // frmBDonorAddDonation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 348);
            this.Controls.Add(this.dtpBDonationDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbBDonationPlaceID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbBDonorAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbBDonorIDDonation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddBDonorAmount);
            this.Name = "frmBDonorAddDonation";
            this.Text = "frmBDonorAddDonation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbBDonorIDDonation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddBDonorAmount;
        private System.Windows.Forms.TextBox tbBDonorAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBDonationPlaceID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpBDonationDate;
        private System.Windows.Forms.Label label4;
    }
}