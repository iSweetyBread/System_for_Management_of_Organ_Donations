using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ui
{
    public partial class frmAmountUpdate : Form
    {
        public frmAmountUpdate()
        {
            InitializeComponent();
        }

        private void btnUpddateOrganUpdate_Click(object sender, EventArgs e)
        {
            if (!logic.ValidationHelper.IsValidID(tbUpdateBankID.Text))
            {
                MessageBox.Show("Invalid data in \"Blood Bank ID Number\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbUpdateBankID.Focus();
                return;
            }
            if (!logic.ValidationHelper.IsValidNumber(tbBankAmount.Text))
            {
                MessageBox.Show("Invalid data in \"New Amount\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbBankAmount.Focus();
                return;
            }

            string attribute;
            if (rbtnAplus.Checked)
            {
                attribute = "A_plus";
            }
            else if (rbtnAminus.Checked)
            {
                attribute = "A_minus";
            }
            else if (rbtnBplus.Checked)
            {
                attribute = "B_plus";
            }
            else if (rbtnBminus.Checked)
            {
                attribute = "B_minus";
            }
            else if (rbtnABplus.Checked)
            {
                attribute = "AB_plus";
            }
            else if (rbtnABminus.Checked)
            {
                attribute = "AB_minus";
            }
            else if (rbtnOplus.Checked)
            {
                attribute = "O_plus";
            }
            else if (rbtnOminus.Checked)
            {
                attribute = "O_minus";
            }
            else
            {
                attribute = "";
                MessageBox.Show("Choose a blood type to change", "Choice Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                gbBloodType.Focus();
                return;
            }

            try
            {
                logic.DatabaseManager.Update(8, int.Parse(tbUpdateBankID.Text), attribute, tbBankAmount.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Entry updated successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
