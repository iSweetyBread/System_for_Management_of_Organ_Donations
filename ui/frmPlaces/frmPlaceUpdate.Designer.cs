namespace ui
{
    partial class frmPlaceUpdate
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
            this.gbUpdatePlace = new System.Windows.Forms.GroupBox();
            this.rbtnPlaceAddress = new System.Windows.Forms.RadioButton();
            this.rbtnPlaceCity = new System.Windows.Forms.RadioButton();
            this.rbtnPlaceContactInfo = new System.Windows.Forms.RadioButton();
            this.tbPlaceData = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUpdatePlaceID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdatePlaceUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gbPlaceType = new System.Windows.Forms.GroupBox();
            this.rbtnBank = new System.Windows.Forms.RadioButton();
            this.rbtnHospital = new System.Windows.Forms.RadioButton();
            this.gbUpdatePlace.SuspendLayout();
            this.gbPlaceType.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbUpdatePlace
            // 
            this.gbUpdatePlace.Controls.Add(this.rbtnPlaceAddress);
            this.gbUpdatePlace.Controls.Add(this.rbtnPlaceCity);
            this.gbUpdatePlace.Controls.Add(this.rbtnPlaceContactInfo);
            this.gbUpdatePlace.Location = new System.Drawing.Point(13, 94);
            this.gbUpdatePlace.Name = "gbUpdatePlace";
            this.gbUpdatePlace.Size = new System.Drawing.Size(296, 91);
            this.gbUpdatePlace.TabIndex = 29;
            this.gbUpdatePlace.TabStop = false;
            // 
            // rbtnPlaceAddress
            // 
            this.rbtnPlaceAddress.AutoSize = true;
            this.rbtnPlaceAddress.Location = new System.Drawing.Point(6, 61);
            this.rbtnPlaceAddress.Name = "rbtnPlaceAddress";
            this.rbtnPlaceAddress.Size = new System.Drawing.Size(63, 17);
            this.rbtnPlaceAddress.TabIndex = 2;
            this.rbtnPlaceAddress.TabStop = true;
            this.rbtnPlaceAddress.Text = "Address";
            this.rbtnPlaceAddress.UseVisualStyleBackColor = true;
            // 
            // rbtnPlaceCity
            // 
            this.rbtnPlaceCity.AutoSize = true;
            this.rbtnPlaceCity.Location = new System.Drawing.Point(6, 38);
            this.rbtnPlaceCity.Name = "rbtnPlaceCity";
            this.rbtnPlaceCity.Size = new System.Drawing.Size(42, 17);
            this.rbtnPlaceCity.TabIndex = 1;
            this.rbtnPlaceCity.TabStop = true;
            this.rbtnPlaceCity.Text = "City";
            this.rbtnPlaceCity.UseVisualStyleBackColor = true;
            // 
            // rbtnPlaceContactInfo
            // 
            this.rbtnPlaceContactInfo.AutoSize = true;
            this.rbtnPlaceContactInfo.Location = new System.Drawing.Point(6, 15);
            this.rbtnPlaceContactInfo.Name = "rbtnPlaceContactInfo";
            this.rbtnPlaceContactInfo.Size = new System.Drawing.Size(102, 17);
            this.rbtnPlaceContactInfo.TabIndex = 0;
            this.rbtnPlaceContactInfo.TabStop = true;
            this.rbtnPlaceContactInfo.Text = "Contact Number";
            this.rbtnPlaceContactInfo.UseVisualStyleBackColor = true;
            // 
            // tbPlaceData
            // 
            this.tbPlaceData.Location = new System.Drawing.Point(12, 67);
            this.tbPlaceData.Name = "tbPlaceData";
            this.tbPlaceData.Size = new System.Drawing.Size(297, 20);
            this.tbPlaceData.TabIndex = 28;
            this.tbPlaceData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "New Data";
            // 
            // tbUpdatePlaceID
            // 
            this.tbUpdatePlaceID.Location = new System.Drawing.Point(12, 26);
            this.tbUpdatePlaceID.Name = "tbUpdatePlaceID";
            this.tbUpdatePlaceID.Size = new System.Drawing.Size(297, 20);
            this.tbUpdatePlaceID.TabIndex = 26;
            this.tbUpdatePlaceID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Place ID Number";
            // 
            // btnUpdatePlaceUpdate
            // 
            this.btnUpdatePlaceUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePlaceUpdate.Location = new System.Drawing.Point(12, 263);
            this.btnUpdatePlaceUpdate.Name = "btnUpdatePlaceUpdate";
            this.btnUpdatePlaceUpdate.Size = new System.Drawing.Size(297, 83);
            this.btnUpdatePlaceUpdate.TabIndex = 24;
            this.btnUpdatePlaceUpdate.Text = "Update";
            this.btnUpdatePlaceUpdate.UseVisualStyleBackColor = true;
            this.btnUpdatePlaceUpdate.Click += new System.EventHandler(this.btnUpdatePlaceUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Type";
            // 
            // gbPlaceType
            // 
            this.gbPlaceType.Controls.Add(this.rbtnBank);
            this.gbPlaceType.Controls.Add(this.rbtnHospital);
            this.gbPlaceType.Location = new System.Drawing.Point(11, 191);
            this.gbPlaceType.Name = "gbPlaceType";
            this.gbPlaceType.Size = new System.Drawing.Size(298, 39);
            this.gbPlaceType.TabIndex = 33;
            this.gbPlaceType.TabStop = false;
            // 
            // rbtnBank
            // 
            this.rbtnBank.AutoSize = true;
            this.rbtnBank.Location = new System.Drawing.Point(212, 16);
            this.rbtnBank.Name = "rbtnBank";
            this.rbtnBank.Size = new System.Drawing.Size(80, 17);
            this.rbtnBank.TabIndex = 1;
            this.rbtnBank.TabStop = true;
            this.rbtnBank.Text = "Blood Bank";
            this.rbtnBank.UseVisualStyleBackColor = true;
            // 
            // rbtnHospital
            // 
            this.rbtnHospital.AutoSize = true;
            this.rbtnHospital.Location = new System.Drawing.Point(4, 16);
            this.rbtnHospital.Name = "rbtnHospital";
            this.rbtnHospital.Size = new System.Drawing.Size(63, 17);
            this.rbtnHospital.TabIndex = 0;
            this.rbtnHospital.TabStop = true;
            this.rbtnHospital.Text = "Hospital";
            this.rbtnHospital.UseVisualStyleBackColor = true;
            // 
            // frmPlaceUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 356);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbPlaceType);
            this.Controls.Add(this.gbUpdatePlace);
            this.Controls.Add(this.tbPlaceData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbUpdatePlaceID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdatePlaceUpdate);
            this.Name = "frmPlaceUpdate";
            this.Text = "frmPlaceUpdate";
            this.gbUpdatePlace.ResumeLayout(false);
            this.gbUpdatePlace.PerformLayout();
            this.gbPlaceType.ResumeLayout(false);
            this.gbPlaceType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUpdatePlace;
        private System.Windows.Forms.RadioButton rbtnPlaceAddress;
        private System.Windows.Forms.RadioButton rbtnPlaceCity;
        private System.Windows.Forms.RadioButton rbtnPlaceContactInfo;
        private System.Windows.Forms.TextBox tbPlaceData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUpdatePlaceID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdatePlaceUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbPlaceType;
        private System.Windows.Forms.RadioButton rbtnBank;
        private System.Windows.Forms.RadioButton rbtnHospital;
    }
}