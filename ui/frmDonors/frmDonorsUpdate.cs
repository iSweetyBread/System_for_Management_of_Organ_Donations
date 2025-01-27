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
    public partial class frmDonorsUpdate : Form
    {
        public frmDonorsUpdate()
        {
            InitializeComponent();
        }

        private void btnUpddateOrganUpdate_Click(object sender, EventArgs e)
        {
            if (!logic.ValidationHelper.IsValidID(tbUpdateDonorID.Text))
            {
                MessageBox.Show("Invalid data in \"Organ Donor ID Number\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbUpdateDonorID.Focus();
                return;
            }

            string attribute;
            if (rbtnDonorFirstName.Checked)
            {
                attribute = "First_name";
                if (!logic.ValidationHelper.IsValidName(tbDonorData.Text))
                {
                    MessageBox.Show("Invalid data in \"New Data\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbDonorData.Focus();
                    return;
                }
            }
            else if (rbtnDonorLastName.Checked)
            {
                attribute = "Last_name";
                if (!logic.ValidationHelper.IsValidName(tbDonorData.Text))
                {
                    MessageBox.Show("Invalid data in \"New Data\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbDonorData.Focus();
                    return;
                }
            }
            else if (rbtnDonorBirthDate.Checked)
            {
                attribute = "Birth_date";
                if (!logic.ValidationHelper.IsValidDate(tbDonorData.Text))
                {
                    MessageBox.Show("Invalid data in \"New Data\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbDonorData.Focus();
                    return;
                }
            }
            else if (rbtnDonorBloodType.Checked)
            {
                attribute = "Blood_type";
                if (!logic.ValidationHelper.IsValidType(tbDonorData.Text))
                {
                    MessageBox.Show("Invalid data in \"New Data\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbDonorData.Focus();
                    return;
                }
            }
            else if (rbtnDonorCity.Checked)
            {
                attribute = "City";
                if (!logic.ValidationHelper.IsValidName(tbDonorData.Text))
                {
                    MessageBox.Show("Invalid data in \"New Data\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbDonorData.Focus();
                    return;
                }
            }
            else if (rbtnDonorAddress.Checked)
            {
                attribute = "Address";
                if (!logic.ValidationHelper.IsValidName(tbDonorData.Text))
                {
                    MessageBox.Show("Invalid data in \"New Data\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbDonorData.Focus();
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
                logic.DatabaseManager.Update(1, int.Parse(tbUpdateDonorID.Text), attribute, tbDonorData.Text);
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
