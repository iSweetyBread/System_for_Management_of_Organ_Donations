namespace ui
{
    partial class frmDonorsRemove
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
            this.tbRemoveDonorID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemoveDonorRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbRemoveDonorID
            // 
            this.tbRemoveDonorID.Location = new System.Drawing.Point(12, 25);
            this.tbRemoveDonorID.Name = "tbRemoveDonorID";
            this.tbRemoveDonorID.Size = new System.Drawing.Size(297, 20);
            this.tbRemoveDonorID.TabIndex = 15;
            this.tbRemoveDonorID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Donor ID Number";
            // 
            // btnRemoveDonorRemove
            // 
            this.btnRemoveDonorRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveDonorRemove.Location = new System.Drawing.Point(12, 72);
            this.btnRemoveDonorRemove.Name = "btnRemoveDonorRemove";
            this.btnRemoveDonorRemove.Size = new System.Drawing.Size(297, 83);
            this.btnRemoveDonorRemove.TabIndex = 13;
            this.btnRemoveDonorRemove.Text = "Remove";
            this.btnRemoveDonorRemove.UseVisualStyleBackColor = true;
            this.btnRemoveDonorRemove.Click += new System.EventHandler(this.btnRemoveDonorRemove_Click);
            // 
            // frmDonorsRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 167);
            this.Controls.Add(this.tbRemoveDonorID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveDonorRemove);
            this.Name = "frmDonorsRemove";
            this.Text = "frmDonorsRemove";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRemoveDonorID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemoveDonorRemove;
    }
}