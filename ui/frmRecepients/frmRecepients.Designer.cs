namespace ui
{
    partial class frmRecepients
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
            this.btnUpdateRecepients = new System.Windows.Forms.Button();
            this.btnRemoveRecepients = new System.Windows.Forms.Button();
            this.btnAddRecepients = new System.Windows.Forms.Button();
            this.dgvRecepients = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecepients)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateRecepients
            // 
            this.btnUpdateRecepients.Location = new System.Drawing.Point(729, 278);
            this.btnUpdateRecepients.Name = "btnUpdateRecepients";
            this.btnUpdateRecepients.Size = new System.Drawing.Size(244, 59);
            this.btnUpdateRecepients.TabIndex = 13;
            this.btnUpdateRecepients.Text = "Update Entry";
            this.btnUpdateRecepients.UseVisualStyleBackColor = true;
            this.btnUpdateRecepients.Click += new System.EventHandler(this.btnUpdateRecepients_Click);
            // 
            // btnRemoveRecepients
            // 
            this.btnRemoveRecepients.Location = new System.Drawing.Point(384, 278);
            this.btnRemoveRecepients.Name = "btnRemoveRecepients";
            this.btnRemoveRecepients.Size = new System.Drawing.Size(244, 59);
            this.btnRemoveRecepients.TabIndex = 12;
            this.btnRemoveRecepients.Text = "Remove Entry";
            this.btnRemoveRecepients.UseVisualStyleBackColor = true;
            this.btnRemoveRecepients.Click += new System.EventHandler(this.btnRemoveRecepients_Click);
            // 
            // btnAddRecepients
            // 
            this.btnAddRecepients.Location = new System.Drawing.Point(12, 278);
            this.btnAddRecepients.Name = "btnAddRecepients";
            this.btnAddRecepients.Size = new System.Drawing.Size(244, 59);
            this.btnAddRecepients.TabIndex = 11;
            this.btnAddRecepients.Text = "Add Entry";
            this.btnAddRecepients.UseVisualStyleBackColor = true;
            this.btnAddRecepients.Click += new System.EventHandler(this.btnAddRecepients_Click);
            // 
            // dgvRecepients
            // 
            this.dgvRecepients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecepients.Location = new System.Drawing.Point(12, 12);
            this.dgvRecepients.Name = "dgvRecepients";
            this.dgvRecepients.Size = new System.Drawing.Size(961, 260);
            this.dgvRecepients.TabIndex = 10;
            // 
            // frmRecepients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 349);
            this.Controls.Add(this.btnUpdateRecepients);
            this.Controls.Add(this.btnRemoveRecepients);
            this.Controls.Add(this.btnAddRecepients);
            this.Controls.Add(this.dgvRecepients);
            this.Name = "frmRecepients";
            this.Text = "frmRecepients";
            this.Load += new System.EventHandler(this.frmRecepients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecepients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateRecepients;
        private System.Windows.Forms.Button btnRemoveRecepients;
        private System.Windows.Forms.Button btnAddRecepients;
        private System.Windows.Forms.DataGridView dgvRecepients;
    }
}