namespace ui
{
    partial class frmBDonorsRemove
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
            this.tbRemoveBDonorID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemoveBDonorRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbRemoveBDonorID
            // 
            this.tbRemoveBDonorID.Location = new System.Drawing.Point(12, 26);
            this.tbRemoveBDonorID.Name = "tbRemoveBDonorID";
            this.tbRemoveBDonorID.Size = new System.Drawing.Size(297, 20);
            this.tbRemoveBDonorID.TabIndex = 18;
            this.tbRemoveBDonorID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Blood Donor ID Number";
            // 
            // btnRemoveBDonorRemove
            // 
            this.btnRemoveBDonorRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveBDonorRemove.Location = new System.Drawing.Point(12, 73);
            this.btnRemoveBDonorRemove.Name = "btnRemoveBDonorRemove";
            this.btnRemoveBDonorRemove.Size = new System.Drawing.Size(297, 83);
            this.btnRemoveBDonorRemove.TabIndex = 16;
            this.btnRemoveBDonorRemove.Text = "Remove";
            this.btnRemoveBDonorRemove.UseVisualStyleBackColor = true;
            this.btnRemoveBDonorRemove.Click += new System.EventHandler(this.btnRemoveBDonorRemove_Click);
            // 
            // frmBDonorsRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 167);
            this.Controls.Add(this.tbRemoveBDonorID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveBDonorRemove);
            this.Name = "frmBDonorsRemove";
            this.Text = "frmBDonorsRemove";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRemoveBDonorID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemoveBDonorRemove;
    }
}