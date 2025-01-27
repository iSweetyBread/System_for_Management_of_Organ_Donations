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
    public partial class frmBDonorsUpdate : Form
    {
        public frmBDonorsUpdate()
        {
            InitializeComponent();
        }

        private void btnUpdateBDonorUpdate_Click(object sender, EventArgs e)
        {
            if (!logic.ValidationHelper.IsValidID(tbUpdateBDonorID.Text))
            {
                MessageBox.Show("Invalid data in \"Blood Donor ID Number\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbUpdateBDonorID.Focus();
                return;
            }

            string attribute;
            if (rbtnBDonorFirstName.Checked)
            {
                attribute = "First_name";
                if (!logic.ValidationHelper.IsValidName(tbBDonorData.Text))
                {
                    MessageBox.Show("Invalid data in \"New Data\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbBDonorData.Focus();
                    return;
                }
            }
            else if (rbtnBDonorLastName.Checked)
            {
                attribute = "Last_name";
                if (!logic.ValidationHelper.IsValidName(tbBDonorData.Text))
                {
                    MessageBox.Show("Invalid data in \"New Data\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbBDonorData.Focus();
                    return;
                }
            }
            else if (rbtnBDonorBirthDate.Checked)
            {
                attribute = "Birth_date";
                if (!logic.ValidationHelper.IsValidDate(tbBDonorData.Text))
                {
                    MessageBox.Show("Invalid data in \"New Data\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbBDonorData.Focus();
                    return;
                }
            }
            else if (rbtnBDonorBloodType.Checked)
            {
                attribute = "Blood_type";
                if (!logic.ValidationHelper.IsValidType(tbBDonorData.Text))
                {
                    MessageBox.Show("Invalid data in \"New Data\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbBDonorData.Focus();
                    return;
                }
            }
            else
            {
                attribute = "";
                MessageBox.Show("Choose an attribute to change", "Choice Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                gbUpdateDonor.Focus();
                return;
            }

            try
            {
                logic.DatabaseManager.Update(2, int.Parse(tbUpdateBDonorID.Text), attribute, tbBDonorData.Text);
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
