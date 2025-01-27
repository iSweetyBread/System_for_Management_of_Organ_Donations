namespace ui
{
    partial class frmPlaces
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
            this.dgvHospitals = new System.Windows.Forms.DataGridView();
            this.dgvBanks = new System.Windows.Forms.DataGridView();
            this.btnPlaceAdd = new System.Windows.Forms.Button();
            this.btnPlaceUpdate = new System.Windows.Forms.Button();
            this.btnPlaceRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHospitals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanks)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHospitals
            // 
            this.dgvHospitals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHospitals.Location = new System.Drawing.Point(13, 13);
            this.dgvHospitals.Name = "dgvHospitals";
            this.dgvHospitals.Size = new System.Drawing.Size(454, 282);
            this.dgvHospitals.TabIndex = 0;
            // 
            // dgvBanks
            // 
            this.dgvBanks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBanks.Location = new System.Drawing.Point(473, 13);
            this.dgvBanks.Name = "dgvBanks";
            this.dgvBanks.Size = new System.Drawing.Size(454, 282);
            this.dgvBanks.TabIndex = 1;
            // 
            // btnPlaceAdd
            // 
            this.btnPlaceAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceAdd.Location = new System.Drawing.Point(12, 326);
            this.btnPlaceAdd.Name = "btnPlaceAdd";
            this.btnPlaceAdd.Size = new System.Drawing.Size(231, 78);
            this.btnPlaceAdd.TabIndex = 2;
            this.btnPlaceAdd.Text = "Add Facility";
            this.btnPlaceAdd.UseVisualStyleBackColor = true;
            this.btnPlaceAdd.Click += new System.EventHandler(this.btnPlaceAdd_Click);
            // 
            // btnPlaceUpdate
            // 
            this.btnPlaceUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceUpdate.Location = new System.Drawing.Point(696, 326);
            this.btnPlaceUpdate.Name = "btnPlaceUpdate";
            this.btnPlaceUpdate.Size = new System.Drawing.Size(231, 78);
            this.btnPlaceUpdate.TabIndex = 3;
            this.btnPlaceUpdate.Text = "Update Facility";
            this.btnPlaceUpdate.UseVisualStyleBackColor = true;
            this.btnPlaceUpdate.Click += new System.EventHandler(this.btnPlaceUpdate_Click);
            // 
            // btnPlaceRemove
            // 
            this.btnPlaceRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceRemove.Location = new System.Drawing.Point(355, 326);
            this.btnPlaceRemove.Name = "btnPlaceRemove";
            this.btnPlaceRemove.Size = new System.Drawing.Size(231, 78);
            this.btnPlaceRemove.TabIndex = 4;
            this.btnPlaceRemove.Text = "Remove Facility";
            this.btnPlaceRemove.UseVisualStyleBackColor = true;
            this.btnPlaceRemove.Click += new System.EventHandler(this.btnPlaceRemove_Click);
            // 
            // frmPlaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 416);
            this.Controls.Add(this.btnPlaceRemove);
            this.Controls.Add(this.btnPlaceUpdate);
            this.Controls.Add(this.btnPlaceAdd);
            this.Controls.Add(this.dgvBanks);
            this.Controls.Add(this.dgvHospitals);
            this.Name = "frmPlaces";
            this.Text = "frmPlaces";
            this.Load += new System.EventHandler(this.frmPlaces_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHospitals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHospitals;
        private System.Windows.Forms.DataGridView dgvBanks;
        private System.Windows.Forms.Button btnPlaceAdd;
        private System.Windows.Forms.Button btnPlaceUpdate;
        private System.Windows.Forms.Button btnPlaceRemove;
    }
}