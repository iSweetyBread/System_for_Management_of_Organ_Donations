namespace ui
{
    partial class frmOrgans
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
            this.dgvOrgans = new System.Windows.Forms.DataGridView();
            this.btnAvailable = new System.Windows.Forms.Button();
            this.btnUsed = new System.Windows.Forms.Button();
            this.btnAwaited = new System.Windows.Forms.Button();
            this.btnAddOrgan = new System.Windows.Forms.Button();
            this.btnRemoveOrgan = new System.Windows.Forms.Button();
            this.btnUpdateOrgan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrgans)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrgans
            // 
            this.dgvOrgans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrgans.Location = new System.Drawing.Point(13, 13);
            this.dgvOrgans.Name = "dgvOrgans";
            this.dgvOrgans.Size = new System.Drawing.Size(653, 260);
            this.dgvOrgans.TabIndex = 0;
            // 
            // btnAvailable
            // 
            this.btnAvailable.Location = new System.Drawing.Point(13, 280);
            this.btnAvailable.Name = "btnAvailable";
            this.btnAvailable.Size = new System.Drawing.Size(166, 68);
            this.btnAvailable.TabIndex = 1;
            this.btnAvailable.Text = "Available Organs";
            this.btnAvailable.UseVisualStyleBackColor = true;
            this.btnAvailable.Click += new System.EventHandler(this.btnAvailable_Click);
            // 
            // btnUsed
            // 
            this.btnUsed.Location = new System.Drawing.Point(259, 280);
            this.btnUsed.Name = "btnUsed";
            this.btnUsed.Size = new System.Drawing.Size(166, 68);
            this.btnUsed.TabIndex = 2;
            this.btnUsed.Text = "Used Organs";
            this.btnUsed.UseVisualStyleBackColor = true;
            this.btnUsed.Click += new System.EventHandler(this.btnUsed_Click);
            // 
            // btnAwaited
            // 
            this.btnAwaited.Location = new System.Drawing.Point(500, 279);
            this.btnAwaited.Name = "btnAwaited";
            this.btnAwaited.Size = new System.Drawing.Size(166, 68);
            this.btnAwaited.TabIndex = 3;
            this.btnAwaited.Text = "Awaited Organs";
            this.btnAwaited.UseVisualStyleBackColor = true;
            this.btnAwaited.Click += new System.EventHandler(this.btnAwaited_Click);
            // 
            // btnAddOrgan
            // 
            this.btnAddOrgan.Location = new System.Drawing.Point(13, 379);
            this.btnAddOrgan.Name = "btnAddOrgan";
            this.btnAddOrgan.Size = new System.Drawing.Size(166, 59);
            this.btnAddOrgan.TabIndex = 4;
            this.btnAddOrgan.Text = "Add Entry";
            this.btnAddOrgan.UseVisualStyleBackColor = true;
            this.btnAddOrgan.Click += new System.EventHandler(this.btnAddOrgan_Click);
            // 
            // btnRemoveOrgan
            // 
            this.btnRemoveOrgan.Location = new System.Drawing.Point(259, 379);
            this.btnRemoveOrgan.Name = "btnRemoveOrgan";
            this.btnRemoveOrgan.Size = new System.Drawing.Size(166, 59);
            this.btnRemoveOrgan.TabIndex = 5;
            this.btnRemoveOrgan.Text = "Remove Entry";
            this.btnRemoveOrgan.UseVisualStyleBackColor = true;
            this.btnRemoveOrgan.Click += new System.EventHandler(this.btnRemoveOrgan_Click);
            // 
            // btnUpdateOrgan
            // 
            this.btnUpdateOrgan.Location = new System.Drawing.Point(500, 379);
            this.btnUpdateOrgan.Name = "btnUpdateOrgan";
            this.btnUpdateOrgan.Size = new System.Drawing.Size(166, 59);
            this.btnUpdateOrgan.TabIndex = 6;
            this.btnUpdateOrgan.Text = "Update Entry";
            this.btnUpdateOrgan.UseVisualStyleBackColor = true;
            this.btnUpdateOrgan.Click += new System.EventHandler(this.btnUpdateOrgan_Click);
            // 
            // frmOrgans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 450);
            this.Controls.Add(this.btnUpdateOrgan);
            this.Controls.Add(this.btnRemoveOrgan);
            this.Controls.Add(this.btnAddOrgan);
            this.Controls.Add(this.btnAwaited);
            this.Controls.Add(this.btnUsed);
            this.Controls.Add(this.btnAvailable);
            this.Controls.Add(this.dgvOrgans);
            this.Name = "frmOrgans";
            this.Text = "frmOrgans";
            this.Load += new System.EventHandler(this.frmOrgans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrgans)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrgans;
        private System.Windows.Forms.Button btnAvailable;
        private System.Windows.Forms.Button btnUsed;
        private System.Windows.Forms.Button btnAwaited;
        private System.Windows.Forms.Button btnAddOrgan;
        private System.Windows.Forms.Button btnRemoveOrgan;
        private System.Windows.Forms.Button btnUpdateOrgan;
    }
}