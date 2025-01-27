namespace ui
{
    partial class frmOrgansRemove
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
            this.btnRemoveOrganRemove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRemoveOrganID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRemoveOrganRemove
            // 
            this.btnRemoveOrganRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveOrganRemove.Location = new System.Drawing.Point(12, 72);
            this.btnRemoveOrganRemove.Name = "btnRemoveOrganRemove";
            this.btnRemoveOrganRemove.Size = new System.Drawing.Size(297, 83);
            this.btnRemoveOrganRemove.TabIndex = 10;
            this.btnRemoveOrganRemove.Text = "Remove";
            this.btnRemoveOrganRemove.UseVisualStyleBackColor = true;
            this.btnRemoveOrganRemove.Click += new System.EventHandler(this.btnRemoveOrganRemove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Organ ID Number";
            // 
            // tbRemoveOrganID
            // 
            this.tbRemoveOrganID.Location = new System.Drawing.Point(12, 25);
            this.tbRemoveOrganID.Name = "tbRemoveOrganID";
            this.tbRemoveOrganID.Size = new System.Drawing.Size(297, 20);
            this.tbRemoveOrganID.TabIndex = 12;
            this.tbRemoveOrganID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmOrgansRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 167);
            this.Controls.Add(this.tbRemoveOrganID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveOrganRemove);
            this.Name = "frmOrgansRemove";
            this.Text = "frmOrgansRemove";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveOrganRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRemoveOrganID;
    }
}