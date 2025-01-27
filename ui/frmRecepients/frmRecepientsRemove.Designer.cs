namespace ui
{
    partial class frmRecepientsRemove
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
            this.tbRemoveRecepientID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemoveRecepientRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbRemoveRecepientID
            // 
            this.tbRemoveRecepientID.Location = new System.Drawing.Point(12, 26);
            this.tbRemoveRecepientID.Name = "tbRemoveRecepientID";
            this.tbRemoveRecepientID.Size = new System.Drawing.Size(297, 20);
            this.tbRemoveRecepientID.TabIndex = 18;
            this.tbRemoveRecepientID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Recepient ID Number";
            // 
            // btnRemoveRecepientRemove
            // 
            this.btnRemoveRecepientRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveRecepientRemove.Location = new System.Drawing.Point(12, 73);
            this.btnRemoveRecepientRemove.Name = "btnRemoveRecepientRemove";
            this.btnRemoveRecepientRemove.Size = new System.Drawing.Size(297, 83);
            this.btnRemoveRecepientRemove.TabIndex = 16;
            this.btnRemoveRecepientRemove.Text = "Remove";
            this.btnRemoveRecepientRemove.UseVisualStyleBackColor = true;
            this.btnRemoveRecepientRemove.Click += new System.EventHandler(this.btnRemoveRecepientRemove_Click);
            // 
            // frmRecepientsRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 167);
            this.Controls.Add(this.tbRemoveRecepientID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveRecepientRemove);
            this.Name = "frmRecepientsRemove";
            this.Text = "frmRecepientsRemove";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRemoveRecepientID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemoveRecepientRemove;
    }
}