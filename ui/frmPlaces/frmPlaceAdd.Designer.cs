namespace ui
{
    partial class frmPlaceAdd
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
            this.btnAddOrganAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPlaceAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPlaceCity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPlaceContactInfo = new System.Windows.Forms.TextBox();
            this.gbPlaceType = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnHospital = new System.Windows.Forms.RadioButton();
            this.rbtnBank = new System.Windows.Forms.RadioButton();
            this.gbPlaceType.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddOrganAdd
            // 
            this.btnAddOrganAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrganAdd.Location = new System.Drawing.Point(11, 259);
            this.btnAddOrganAdd.Name = "btnAddOrganAdd";
            this.btnAddOrganAdd.Size = new System.Drawing.Size(297, 83);
            this.btnAddOrganAdd.TabIndex = 19;
            this.btnAddOrganAdd.Text = "Add";
            this.btnAddOrganAdd.UseVisualStyleBackColor = true;
            this.btnAddOrganAdd.Click += new System.EventHandler(this.btnAddOrganAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Address";
            // 
            // tbPlaceAddress
            // 
            this.tbPlaceAddress.Location = new System.Drawing.Point(12, 134);
            this.tbPlaceAddress.Name = "tbPlaceAddress";
            this.tbPlaceAddress.Size = new System.Drawing.Size(296, 20);
            this.tbPlaceAddress.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "City";
            // 
            // tbPlaceCity
            // 
            this.tbPlaceCity.Location = new System.Drawing.Point(12, 82);
            this.tbPlaceCity.Name = "tbPlaceCity";
            this.tbPlaceCity.Size = new System.Drawing.Size(296, 20);
            this.tbPlaceCity.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Contact Number";
            // 
            // tbPlaceContactInfo
            // 
            this.tbPlaceContactInfo.Location = new System.Drawing.Point(12, 32);
            this.tbPlaceContactInfo.Name = "tbPlaceContactInfo";
            this.tbPlaceContactInfo.Size = new System.Drawing.Size(296, 20);
            this.tbPlaceContactInfo.TabIndex = 23;
            // 
            // gbPlaceType
            // 
            this.gbPlaceType.Controls.Add(this.rbtnBank);
            this.gbPlaceType.Controls.Add(this.rbtnHospital);
            this.gbPlaceType.Location = new System.Drawing.Point(11, 179);
            this.gbPlaceType.Name = "gbPlaceType";
            this.gbPlaceType.Size = new System.Drawing.Size(298, 39);
            this.gbPlaceType.TabIndex = 29;
            this.gbPlaceType.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Type";
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
            // frmPlaceAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 354);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbPlaceType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPlaceAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPlaceCity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPlaceContactInfo);
            this.Controls.Add(this.btnAddOrganAdd);
            this.Name = "frmPlaceAdd";
            this.Text = "frmPlaceAdd";
            this.gbPlaceType.ResumeLayout(false);
            this.gbPlaceType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddOrganAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPlaceAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPlaceCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPlaceContactInfo;
        private System.Windows.Forms.GroupBox gbPlaceType;
        private System.Windows.Forms.RadioButton rbtnBank;
        private System.Windows.Forms.RadioButton rbtnHospital;
        private System.Windows.Forms.Label label1;
    }
}