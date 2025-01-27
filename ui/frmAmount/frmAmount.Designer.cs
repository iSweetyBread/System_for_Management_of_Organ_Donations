namespace ui
{
    partial class frmAmount
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
            this.dgvAmount = new System.Windows.Forms.DataGridView();
            this.btnAmountUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAmount
            // 
            this.dgvAmount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAmount.Location = new System.Drawing.Point(13, 13);
            this.dgvAmount.Name = "dgvAmount";
            this.dgvAmount.Size = new System.Drawing.Size(947, 284);
            this.dgvAmount.TabIndex = 0;
            // 
            // btnAmountUpdate
            // 
            this.btnAmountUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmountUpdate.Location = new System.Drawing.Point(322, 343);
            this.btnAmountUpdate.Name = "btnAmountUpdate";
            this.btnAmountUpdate.Size = new System.Drawing.Size(322, 95);
            this.btnAmountUpdate.TabIndex = 1;
            this.btnAmountUpdate.Text = "Update Amount";
            this.btnAmountUpdate.UseVisualStyleBackColor = true;
            this.btnAmountUpdate.Click += new System.EventHandler(this.btnAmountUpdate_Click);
            // 
            // frmAmount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 450);
            this.Controls.Add(this.btnAmountUpdate);
            this.Controls.Add(this.dgvAmount);
            this.Name = "frmAmount";
            this.Text = "frmAmount";
            this.Load += new System.EventHandler(this.frmAmount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAmount;
        private System.Windows.Forms.Button btnAmountUpdate;
    }
}