namespace ui
{
    partial class frmAmountUpdate
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
            this.btnUpddateOrganUpdate = new System.Windows.Forms.Button();
            this.tbUpdateBankID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBankAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbBloodType = new System.Windows.Forms.GroupBox();
            this.rbtnAplus = new System.Windows.Forms.RadioButton();
            this.rbtnAminus = new System.Windows.Forms.RadioButton();
            this.rbtnBplus = new System.Windows.Forms.RadioButton();
            this.rbtnBminus = new System.Windows.Forms.RadioButton();
            this.rbtnOminus = new System.Windows.Forms.RadioButton();
            this.rbtnOplus = new System.Windows.Forms.RadioButton();
            this.rbtnABminus = new System.Windows.Forms.RadioButton();
            this.rbtnABplus = new System.Windows.Forms.RadioButton();
            this.gbBloodType.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpddateOrganUpdate
            // 
            this.btnUpddateOrganUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpddateOrganUpdate.Location = new System.Drawing.Point(12, 237);
            this.btnUpddateOrganUpdate.Name = "btnUpddateOrganUpdate";
            this.btnUpddateOrganUpdate.Size = new System.Drawing.Size(209, 83);
            this.btnUpddateOrganUpdate.TabIndex = 19;
            this.btnUpddateOrganUpdate.Text = "Update";
            this.btnUpddateOrganUpdate.UseVisualStyleBackColor = true;
            this.btnUpddateOrganUpdate.Click += new System.EventHandler(this.btnUpddateOrganUpdate_Click);
            // 
            // tbUpdateBankID
            // 
            this.tbUpdateBankID.Location = new System.Drawing.Point(12, 22);
            this.tbUpdateBankID.Name = "tbUpdateBankID";
            this.tbUpdateBankID.Size = new System.Drawing.Size(209, 20);
            this.tbUpdateBankID.TabIndex = 22;
            this.tbUpdateBankID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Blood Bank ID Number";
            // 
            // tbBankAmount
            // 
            this.tbBankAmount.Location = new System.Drawing.Point(12, 66);
            this.tbBankAmount.Name = "tbBankAmount";
            this.tbBankAmount.Size = new System.Drawing.Size(209, 20);
            this.tbBankAmount.TabIndex = 24;
            this.tbBankAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "New Amount";
            // 
            // gbBloodType
            // 
            this.gbBloodType.Controls.Add(this.rbtnOminus);
            this.gbBloodType.Controls.Add(this.rbtnOplus);
            this.gbBloodType.Controls.Add(this.rbtnABminus);
            this.gbBloodType.Controls.Add(this.rbtnABplus);
            this.gbBloodType.Controls.Add(this.rbtnBminus);
            this.gbBloodType.Controls.Add(this.rbtnBplus);
            this.gbBloodType.Controls.Add(this.rbtnAminus);
            this.gbBloodType.Controls.Add(this.rbtnAplus);
            this.gbBloodType.Location = new System.Drawing.Point(13, 93);
            this.gbBloodType.Name = "gbBloodType";
            this.gbBloodType.Size = new System.Drawing.Size(208, 125);
            this.gbBloodType.TabIndex = 25;
            this.gbBloodType.TabStop = false;
            // 
            // rbtnAplus
            // 
            this.rbtnAplus.AutoSize = true;
            this.rbtnAplus.Location = new System.Drawing.Point(18, 20);
            this.rbtnAplus.Name = "rbtnAplus";
            this.rbtnAplus.Size = new System.Drawing.Size(38, 17);
            this.rbtnAplus.TabIndex = 0;
            this.rbtnAplus.TabStop = true;
            this.rbtnAplus.Text = "A+";
            this.rbtnAplus.UseVisualStyleBackColor = true;
            // 
            // rbtnAminus
            // 
            this.rbtnAminus.AutoSize = true;
            this.rbtnAminus.Location = new System.Drawing.Point(18, 43);
            this.rbtnAminus.Name = "rbtnAminus";
            this.rbtnAminus.Size = new System.Drawing.Size(35, 17);
            this.rbtnAminus.TabIndex = 1;
            this.rbtnAminus.TabStop = true;
            this.rbtnAminus.Text = "A-";
            this.rbtnAminus.UseVisualStyleBackColor = true;
            // 
            // rbtnBplus
            // 
            this.rbtnBplus.AutoSize = true;
            this.rbtnBplus.Location = new System.Drawing.Point(18, 66);
            this.rbtnBplus.Name = "rbtnBplus";
            this.rbtnBplus.Size = new System.Drawing.Size(38, 17);
            this.rbtnBplus.TabIndex = 2;
            this.rbtnBplus.TabStop = true;
            this.rbtnBplus.Text = "B+";
            this.rbtnBplus.UseVisualStyleBackColor = true;
            // 
            // rbtnBminus
            // 
            this.rbtnBminus.AutoSize = true;
            this.rbtnBminus.Location = new System.Drawing.Point(18, 89);
            this.rbtnBminus.Name = "rbtnBminus";
            this.rbtnBminus.Size = new System.Drawing.Size(35, 17);
            this.rbtnBminus.TabIndex = 3;
            this.rbtnBminus.TabStop = true;
            this.rbtnBminus.Text = "B-";
            this.rbtnBminus.UseVisualStyleBackColor = true;
            // 
            // rbtnOminus
            // 
            this.rbtnOminus.AutoSize = true;
            this.rbtnOminus.Location = new System.Drawing.Point(144, 89);
            this.rbtnOminus.Name = "rbtnOminus";
            this.rbtnOminus.Size = new System.Drawing.Size(36, 17);
            this.rbtnOminus.TabIndex = 7;
            this.rbtnOminus.TabStop = true;
            this.rbtnOminus.Text = "O-";
            this.rbtnOminus.UseVisualStyleBackColor = true;
            // 
            // rbtnOplus
            // 
            this.rbtnOplus.AutoSize = true;
            this.rbtnOplus.Location = new System.Drawing.Point(144, 66);
            this.rbtnOplus.Name = "rbtnOplus";
            this.rbtnOplus.Size = new System.Drawing.Size(39, 17);
            this.rbtnOplus.TabIndex = 6;
            this.rbtnOplus.TabStop = true;
            this.rbtnOplus.Text = "O+";
            this.rbtnOplus.UseVisualStyleBackColor = true;
            // 
            // rbtnABminus
            // 
            this.rbtnABminus.AutoSize = true;
            this.rbtnABminus.Location = new System.Drawing.Point(144, 43);
            this.rbtnABminus.Name = "rbtnABminus";
            this.rbtnABminus.Size = new System.Drawing.Size(42, 17);
            this.rbtnABminus.TabIndex = 5;
            this.rbtnABminus.TabStop = true;
            this.rbtnABminus.Text = "AB-";
            this.rbtnABminus.UseVisualStyleBackColor = true;
            // 
            // rbtnABplus
            // 
            this.rbtnABplus.AutoSize = true;
            this.rbtnABplus.Location = new System.Drawing.Point(144, 20);
            this.rbtnABplus.Name = "rbtnABplus";
            this.rbtnABplus.Size = new System.Drawing.Size(45, 17);
            this.rbtnABplus.TabIndex = 4;
            this.rbtnABplus.TabStop = true;
            this.rbtnABplus.Text = "AB+";
            this.rbtnABplus.UseVisualStyleBackColor = true;
            // 
            // frmAmountUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 337);
            this.Controls.Add(this.gbBloodType);
            this.Controls.Add(this.tbBankAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbUpdateBankID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpddateOrganUpdate);
            this.Name = "frmAmountUpdate";
            this.Text = "frmAmountUpdate";
            this.gbBloodType.ResumeLayout(false);
            this.gbBloodType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpddateOrganUpdate;
        private System.Windows.Forms.TextBox tbUpdateBankID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBankAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbBloodType;
        private System.Windows.Forms.RadioButton rbtnOminus;
        private System.Windows.Forms.RadioButton rbtnOplus;
        private System.Windows.Forms.RadioButton rbtnABminus;
        private System.Windows.Forms.RadioButton rbtnABplus;
        private System.Windows.Forms.RadioButton rbtnBminus;
        private System.Windows.Forms.RadioButton rbtnBplus;
        private System.Windows.Forms.RadioButton rbtnAminus;
        private System.Windows.Forms.RadioButton rbtnAplus;
    }
}