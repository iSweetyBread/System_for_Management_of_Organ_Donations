namespace ui
{
    partial class frmPlaceRemove
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
            this.tbRemovePlaceID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemovePlaceRemove = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gbPlaceType = new System.Windows.Forms.GroupBox();
            this.rbtnBank = new System.Windows.Forms.RadioButton();
            this.rbtnHospital = new System.Windows.Forms.RadioButton();
            this.gbPlaceType.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbRemovePlaceID
            // 
            this.tbRemovePlaceID.Location = new System.Drawing.Point(12, 26);
            this.tbRemovePlaceID.Name = "tbRemovePlaceID";
            this.tbRemovePlaceID.Size = new System.Drawing.Size(297, 20);
            this.tbRemovePlaceID.TabIndex = 18;
            this.tbRemovePlaceID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Place ID Number";
            // 
            // btnRemovePlaceRemove
            // 
            this.btnRemovePlaceRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovePlaceRemove.Location = new System.Drawing.Point(12, 114);
            this.btnRemovePlaceRemove.Name = "btnRemovePlaceRemove";
            this.btnRemovePlaceRemove.Size = new System.Drawing.Size(297, 83);
            this.btnRemovePlaceRemove.TabIndex = 16;
            this.btnRemovePlaceRemove.Text = "Remove";
            this.btnRemovePlaceRemove.UseVisualStyleBackColor = true;
            this.btnRemovePlaceRemove.Click += new System.EventHandler(this.btnRemovePlaceRemove_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Type";
            // 
            // gbPlaceType
            // 
            this.gbPlaceType.Controls.Add(this.rbtnBank);
            this.gbPlaceType.Controls.Add(this.rbtnHospital);
            this.gbPlaceType.Location = new System.Drawing.Point(11, 52);
            this.gbPlaceType.Name = "gbPlaceType";
            this.gbPlaceType.Size = new System.Drawing.Size(298, 39);
            this.gbPlaceType.TabIndex = 31;
            this.gbPlaceType.TabStop = false;
            // 
            // rbtnBank
            // 
            this.rbtnBank.AutoSize = true;
            this.rbtnBank.Location = new System.Drawing.Point(212, 16);
            this.rbtnBank.Name = "rbtnBank";
            this.rbtnBank.Size = new System.Drawing.Size(80, 17);
            this.rbtnBank.TabIndex = 1;
            this.rbtnBank.TabStop = true;
            this.rbtnBank.Text = "Blood Bank";
            this.rbtnBank.UseVisualStyleBackColor = true;
            // 
            // rbtnHospital
            // 
            this.rbtnHospital.AutoSize = true;
            this.rbtnHospital.Location = new System.Drawing.Point(4, 16);
            this.rbtnHospital.Name = "rbtnHospital";
            this.rbtnHospital.Size = new System.Drawing.Size(63, 17);
            this.rbtnHospital.TabIndex = 0;
            this.rbtnHospital.TabStop = true;
            this.rbtnHospital.Text = "Hospital";
            this.rbtnHospital.UseVisualStyleBackColor = true;
            // 
            // frmPlaceRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 209);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbPlaceType);
            this.Controls.Add(this.tbRemovePlaceID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemovePlaceRemove);
            this.Name = "frmPlaceRemove";
            this.Text = "frmPlaceRemove";
            this.gbPlaceType.ResumeLayout(false);
            this.gbPlaceType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRemovePlaceID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemovePlaceRemove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbPlaceType;
        private System.Windows.Forms.RadioButton rbtnBank;
        private System.Windows.Forms.RadioButton rbtnHospital;
    }
}