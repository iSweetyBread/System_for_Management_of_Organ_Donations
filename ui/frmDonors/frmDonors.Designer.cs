namespace ui
{
    partial class frmDonors
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
            this.dgvDonors = new System.Windows.Forms.DataGridView();
            this.btnUpdateDonor = new System.Windows.Forms.Button();
            this.btnRemoveDonor = new System.Windows.Forms.Button();
            this.btnAddDonor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonors)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDonors
            // 
            this.dgvDonors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonors.Location = new System.Drawing.Point(12, 12);
            this.dgvDonors.Name = "dgvDonors";
            this.dgvDonors.Size = new System.Drawing.Size(760, 260);
            this.dgvDonors.TabIndex = 1;
            // 
            // btnUpdateDonor
            // 
            this.btnUpdateDonor.Location = new System.Drawing.Point(606, 278);
            this.btnUpdateDonor.Name = "btnUpdateDonor";
            this.btnUpdateDonor.Size = new System.Drawing.Size(166, 59);
            this.btnUpdateDonor.TabIndex = 9;
            this.btnUpdateDonor.Text = "Update Entry";
            this.btnUpdateDonor.UseVisualStyleBackColor = true;
            this.btnUpdateDonor.Click += new System.EventHandler(this.btnUpdateDonor_Click);
            // 
            // btnRemoveDonor
            // 
            this.btnRemoveDonor.Location = new System.Drawing.Point(320, 278);
            this.btnRemoveDonor.Name = "btnRemoveDonor";
            this.btnRemoveDonor.Size = new System.Drawing.Size(166, 59);
            this.btnRemoveDonor.TabIndex = 8;
            this.btnRemoveDonor.Text = "Remove Entry";
            this.btnRemoveDonor.UseVisualStyleBackColor = true;
            this.btnRemoveDonor.Click += new System.EventHandler(this.btnRemoveDonor_Click);
            // 
            // btnAddDonor
            // 
            this.btnAddDonor.Location = new System.Drawing.Point(12, 278);
            this.btnAddDonor.Name = "btnAddDonor";
            this.btnAddDonor.Size = new System.Drawing.Size(166, 59);
            this.btnAddDonor.TabIndex = 7;
            this.btnAddDonor.Text = "Add Entry";
            this.btnAddDonor.UseVisualStyleBackColor = true;
            this.btnAddDonor.Click += new System.EventHandler(this.btnAddDonor_Click);
            // 
            // frmDonors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 349);
            this.Controls.Add(this.btnUpdateDonor);
            this.Controls.Add(this.btnRemoveDonor);
            this.Controls.Add(this.btnAddDonor);
            this.Controls.Add(this.dgvDonors);
            this.Name = "frmDonors";
            this.Text = "frmDonors";
            this.Load += new System.EventHandler(this.frmDonors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDonors;
        private System.Windows.Forms.Button btnUpdateDonor;
        private System.Windows.Forms.Button btnRemoveDonor;
        private System.Windows.Forms.Button btnAddDonor;
    }
}