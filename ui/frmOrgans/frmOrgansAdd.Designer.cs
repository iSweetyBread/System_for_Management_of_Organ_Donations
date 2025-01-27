namespace ui
{
    partial class frmOrgansAdd
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
            this.tbOrganName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbOrganDonorID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbOrganPlaceID = new System.Windows.Forms.TextBox();
            this.dtpOrganDonationDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddOrganAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbOrganName
            // 
            this.tbOrganName.Location = new System.Drawing.Point(12, 29);
            this.tbOrganName.Name = "tbOrganName";
            this.tbOrganName.Size = new System.Drawing.Size(296, 20);
            this.tbOrganName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Organ Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Donor ID Number";
            // 
            // tbOrganDonorID
            // 
            this.tbOrganDonorID.Location = new System.Drawing.Point(12, 81);
            this.tbOrganDonorID.Name = "tbOrganDonorID";
            this.tbOrganDonorID.Size = new System.Drawing.Size(296, 20);
            this.tbOrganDonorID.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Donation Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Place ID Number";
            // 
            // tbOrganPlaceID
            // 
            this.tbOrganPlaceID.Location = new System.Drawing.Point(12, 130);
            this.tbOrganPlaceID.Name = "tbOrganPlaceID";
            this.tbOrganPlaceID.Size = new System.Drawing.Size(296, 20);
            this.tbOrganPlaceID.TabIndex = 4;
            // 
            // dtpOrganDonationDate
            // 
            this.dtpOrganDonationDate.Location = new System.Drawing.Point(12, 180);
            this.dtpOrganDonationDate.Name = "dtpOrganDonationDate";
            this.dtpOrganDonationDate.Size = new System.Drawing.Size(296, 20);
            this.dtpOrganDonationDate.TabIndex = 8;
            // 
            // btnAddOrganAdd
            // 
            this.btnAddOrganAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrganAdd.Location = new System.Drawing.Point(12, 254);
            this.btnAddOrganAdd.Name = "btnAddOrganAdd";
            this.btnAddOrganAdd.Size = new System.Drawing.Size(297, 83);
            this.btnAddOrganAdd.TabIndex = 9;
            this.btnAddOrganAdd.Text = "Add";
            this.btnAddOrganAdd.UseVisualStyleBackColor = true;
            this.btnAddOrganAdd.Click += new System.EventHandler(this.btnAddOrganAdd_Click);
            // 
            // frmOrgansAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 352);
            this.Controls.Add(this.btnAddOrganAdd);
            this.Controls.Add(this.dtpOrganDonationDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbOrganPlaceID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbOrganDonorID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbOrganName);
            this.Name = "frmOrgansAdd";
            this.Text = "frmOrgansAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbOrganName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbOrganDonorID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbOrganPlaceID;
        private System.Windows.Forms.DateTimePicker dtpOrganDonationDate;
        private System.Windows.Forms.Button btnAddOrganAdd;
    }
}