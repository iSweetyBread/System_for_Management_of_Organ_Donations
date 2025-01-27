namespace ui
{
    partial class frmBDonors
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
            this.btnUpdateBDonor = new System.Windows.Forms.Button();
            this.btnRemoveBDonor = new System.Windows.Forms.Button();
            this.btnAddBDonor = new System.Windows.Forms.Button();
            this.dgvBDonors = new System.Windows.Forms.DataGridView();
            this.btnBDonorsAddDonation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBDonors)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateBDonor
            // 
            this.btnUpdateBDonor.Location = new System.Drawing.Point(492, 278);
            this.btnUpdateBDonor.Name = "btnUpdateBDonor";
            this.btnUpdateBDonor.Size = new System.Drawing.Size(166, 59);
            this.btnUpdateBDonor.TabIndex = 13;
            this.btnUpdateBDonor.Text = "Update Entry";
            this.btnUpdateBDonor.UseVisualStyleBackColor = true;
            this.btnUpdateBDonor.Click += new System.EventHandler(this.btnUpdateBDonor_Click);
            // 
            // btnRemoveBDonor
            // 
            this.btnRemoveBDonor.Location = new System.Drawing.Point(251, 278);
            this.btnRemoveBDonor.Name = "btnRemoveBDonor";
            this.btnRemoveBDonor.Size = new System.Drawing.Size(166, 59);
            this.btnRemoveBDonor.TabIndex = 12;
            this.btnRemoveBDonor.Text = "Remove Entry";
            this.btnRemoveBDonor.UseVisualStyleBackColor = true;
            this.btnRemoveBDonor.Click += new System.EventHandler(this.btnRemoveBDonor_Click);
            // 
            // btnAddBDonor
            // 
            this.btnAddBDonor.Location = new System.Drawing.Point(11, 278);
            this.btnAddBDonor.Name = "btnAddBDonor";
            this.btnAddBDonor.Size = new System.Drawing.Size(166, 59);
            this.btnAddBDonor.TabIndex = 11;
            this.btnAddBDonor.Text = "Add Entry";
            this.btnAddBDonor.UseVisualStyleBackColor = true;
            this.btnAddBDonor.Click += new System.EventHandler(this.btnAddBDonor_Click);
            // 
            // dgvBDonors
            // 
            this.dgvBDonors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBDonors.Location = new System.Drawing.Point(11, 12);
            this.dgvBDonors.Name = "dgvBDonors";
            this.dgvBDonors.Size = new System.Drawing.Size(647, 260);
            this.dgvBDonors.TabIndex = 10;
            // 
            // btnBDonorsAddDonation
            // 
            this.btnBDonorsAddDonation.Location = new System.Drawing.Point(251, 351);
            this.btnBDonorsAddDonation.Name = "btnBDonorsAddDonation";
            this.btnBDonorsAddDonation.Size = new System.Drawing.Size(166, 59);
            this.btnBDonorsAddDonation.TabIndex = 14;
            this.btnBDonorsAddDonation.Text = "Add Donation";
            this.btnBDonorsAddDonation.UseVisualStyleBackColor = true;
            this.btnBDonorsAddDonation.Click += new System.EventHandler(this.btnBDonorsAddDonation_Click);
            // 
            // frmBDonors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 422);
            this.Controls.Add(this.btnBDonorsAddDonation);
            this.Controls.Add(this.btnUpdateBDonor);
            this.Controls.Add(this.btnRemoveBDonor);
            this.Controls.Add(this.btnAddBDonor);
            this.Controls.Add(this.dgvBDonors);
            this.Name = "frmBDonors";
            this.Text = "frmBDonors";
            this.Load += new System.EventHandler(this.frmBDonors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBDonors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateBDonor;
        private System.Windows.Forms.Button btnRemoveBDonor;
        private System.Windows.Forms.Button btnAddBDonor;
        private System.Windows.Forms.DataGridView dgvBDonors;
        private System.Windows.Forms.Button btnBDonorsAddDonation;
    }
}