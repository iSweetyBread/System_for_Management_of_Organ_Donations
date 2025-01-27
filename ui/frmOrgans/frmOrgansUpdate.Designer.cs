namespace ui
{
    partial class frmOrgansUpdate
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
            this.btnUpddateOrganUpdate = new System.Windows.Forms.Button();
            this.tbUpdateOrganID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbOrganData = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbUpdateOrgan = new System.Windows.Forms.GroupBox();
            this.rbtnOrganDonorID = new System.Windows.Forms.RadioButton();
            this.rbtnOrganOrganName = new System.Windows.Forms.RadioButton();
            this.rbtnOrganDonationDate = new System.Windows.Forms.RadioButton();
            this.rbtnOrganPlaceID = new System.Windows.Forms.RadioButton();
            this.rbtnOrganStatus = new System.Windows.Forms.RadioButton();
            this.gbUpdateOrgan.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpddateOrganUpdate
            // 
            this.btnUpddateOrganUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpddateOrganUpdate.Location = new System.Drawing.Point(12, 245);
            this.btnUpddateOrganUpdate.Name = "btnUpddateOrganUpdate";
            this.btnUpddateOrganUpdate.Size = new System.Drawing.Size(297, 83);
            this.btnUpddateOrganUpdate.TabIndex = 11;
            this.btnUpddateOrganUpdate.Text = "Update";
            this.btnUpddateOrganUpdate.UseVisualStyleBackColor = true;
            this.btnUpddateOrganUpdate.Click += new System.EventHandler(this.btnUpddateOrganUpdate_Click);
            // 
            // tbUpdateOrganID
            // 
            this.tbUpdateOrganID.Location = new System.Drawing.Point(12, 24);
            this.tbUpdateOrganID.Name = "tbUpdateOrganID";
            this.tbUpdateOrganID.Size = new System.Drawing.Size(297, 20);
            this.tbUpdateOrganID.TabIndex = 14;
            this.tbUpdateOrganID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Organ ID Number";
            // 
            // tbOrganData
            // 
            this.tbOrganData.Location = new System.Drawing.Point(12, 65);
            this.tbOrganData.Name = "tbOrganData";
            this.tbOrganData.Size = new System.Drawing.Size(297, 20);
            this.tbOrganData.TabIndex = 16;
            this.tbOrganData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "New Data";
            // 
            // gbUpdateOrgan
            // 
            this.gbUpdateOrgan.Controls.Add(this.rbtnOrganStatus);
            this.gbUpdateOrgan.Controls.Add(this.rbtnOrganPlaceID);
            this.gbUpdateOrgan.Controls.Add(this.rbtnOrganDonationDate);
            this.gbUpdateOrgan.Controls.Add(this.rbtnOrganOrganName);
            this.gbUpdateOrgan.Controls.Add(this.rbtnOrganDonorID);
            this.gbUpdateOrgan.Location = new System.Drawing.Point(13, 92);
            this.gbUpdateOrgan.Name = "gbUpdateOrgan";
            this.gbUpdateOrgan.Size = new System.Drawing.Size(296, 147);
            this.gbUpdateOrgan.TabIndex = 17;
            this.gbUpdateOrgan.TabStop = false;
            // 
            // rbtnOrganDonorID
            // 
            this.rbtnOrganDonorID.AutoSize = true;
            this.rbtnOrganDonorID.Location = new System.Drawing.Point(7, 20);
            this.rbtnOrganDonorID.Name = "rbtnOrganDonorID";
            this.rbtnOrganDonorID.Size = new System.Drawing.Size(108, 17);
            this.rbtnOrganDonorID.TabIndex = 0;
            this.rbtnOrganDonorID.TabStop = true;
            this.rbtnOrganDonorID.Text = "Donor ID Number";
            this.rbtnOrganDonorID.UseVisualStyleBackColor = true;
            // 
            // rbtnOrganOrganName
            // 
            this.rbtnOrganOrganName.AutoSize = true;
            this.rbtnOrganOrganName.Location = new System.Drawing.Point(7, 43);
            this.rbtnOrganOrganName.Name = "rbtnOrganOrganName";
            this.rbtnOrganOrganName.Size = new System.Drawing.Size(85, 17);
            this.rbtnOrganOrganName.TabIndex = 1;
            this.rbtnOrganOrganName.TabStop = true;
            this.rbtnOrganOrganName.Text = "Organ Name";
            this.rbtnOrganOrganName.UseVisualStyleBackColor = true;
            // 
            // rbtnOrganDonationDate
            // 
            this.rbtnOrganDonationDate.AutoSize = true;
            this.rbtnOrganDonationDate.Location = new System.Drawing.Point(7, 66);
            this.rbtnOrganDonationDate.Name = "rbtnOrganDonationDate";
            this.rbtnOrganDonationDate.Size = new System.Drawing.Size(94, 17);
            this.rbtnOrganDonationDate.TabIndex = 2;
            this.rbtnOrganDonationDate.TabStop = true;
            this.rbtnOrganDonationDate.Text = "Donation Date";
            this.rbtnOrganDonationDate.UseVisualStyleBackColor = true;
            // 
            // rbtnOrganPlaceID
            // 
            this.rbtnOrganPlaceID.AutoSize = true;
            this.rbtnOrganPlaceID.Location = new System.Drawing.Point(7, 89);
            this.rbtnOrganPlaceID.Name = "rbtnOrganPlaceID";
            this.rbtnOrganPlaceID.Size = new System.Drawing.Size(106, 17);
            this.rbtnOrganPlaceID.TabIndex = 3;
            this.rbtnOrganPlaceID.TabStop = true;
            this.rbtnOrganPlaceID.Text = "Place ID Number";
            this.rbtnOrganPlaceID.UseVisualStyleBackColor = true;
            // 
            // rbtnOrganStatus
            // 
            this.rbtnOrganStatus.AutoSize = true;
            this.rbtnOrganStatus.Location = new System.Drawing.Point(7, 112);
            this.rbtnOrganStatus.Name = "rbtnOrganStatus";
            this.rbtnOrganStatus.Size = new System.Drawing.Size(87, 17);
            this.rbtnOrganStatus.TabIndex = 4;
            this.rbtnOrganStatus.TabStop = true;
            this.rbtnOrganStatus.Text = "Organ Status";
            this.rbtnOrganStatus.UseVisualStyleBackColor = true;
            // 
            // frmOrgansUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 340);
            this.Controls.Add(this.gbUpdateOrgan);
            this.Controls.Add(this.tbOrganData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbUpdateOrganID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpddateOrganUpdate);
            this.Name = "frmOrgansUpdate";
            this.Text = "frmOrgansUpdate";
            this.gbUpdateOrgan.ResumeLayout(false);
            this.gbUpdateOrgan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpddateOrganUpdate;
        private System.Windows.Forms.TextBox tbUpdateOrganID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbOrganData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbUpdateOrgan;
        private System.Windows.Forms.RadioButton rbtnOrganStatus;
        private System.Windows.Forms.RadioButton rbtnOrganPlaceID;
        private System.Windows.Forms.RadioButton rbtnOrganDonationDate;
        private System.Windows.Forms.RadioButton rbtnOrganOrganName;
        private System.Windows.Forms.RadioButton rbtnOrganDonorID;
    }
}