using logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ui
{
    public partial class frmOrgansUpdate : Form
    {
        public frmOrgansUpdate()
        {
            InitializeComponent();
        }

        private void btnUpddateOrganUpdate_Click(object sender, EventArgs e)
        {
            if (!logic.ValidationHelper.IsValidID(tbUpdateOrganID.Text))
            {
                MessageBox.Show("Invalid data in \"Organ ID Number\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbUpdateOrganID.Focus();
                return;
            }

            string attribute;
            if (rbtnOrganDonorID.Checked)
            {
                attribute = "Donor_id";
                if (!logic.ValidationHelper.IsValidID(tbOrganData.Text))
                {
                    MessageBox.Show("Invalid data in \"New Data\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbOrganData.Focus();
                    return;
                }
            }
            else if (rbtnOrganOrganName.Checked)
            {
                attribute = "Organ";
                if (!logic.ValidationHelper.IsValidName(tbOrganData.Text))
                {
                    MessageBox.Show("Invalid data in \"New Data\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbOrganData.Focus();
                    return;
                }
            }
            else if (rbtnOrganDonationDate.Checked)
            {
                attribute = "Extraction_date";
                if (!logic.ValidationHelper.IsValidDate(tbOrganData.Text))
                {
                    MessageBox.Show("Invalid data in \"New Data\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbOrganData.Focus();
                    return;
                }
            }
            else if (rbtnOrganPlaceID.Checked)
            {
                attribute = "Place_id";
                if (!logic.ValidationHelper.IsValidID(tbOrganData.Text))
                {
                    MessageBox.Show("Invalid data in \"New Data\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbOrganData.Focus();
                    return;
                }
            }
            else if (rbtnOrganStatus.Checked)
            {
                attribute = "Status";
                if (!logic.ValidationHelper.IsValidStatus(tbOrganData.Text))
                {
                    MessageBox.Show("Invalid data in \"New Data\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbOrganData.Focus();
                    return;
                }
            }
            else
            {
                attribute = "";
                MessageBox.Show("Choose an attribute to change", "Choice Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                gbUpdateOrgan.Focus();
                return;
            }

            try
            {
                logic.DatabaseManager.Update(5, int.Parse(tbUpdateOrganID.Text), attribute, tbOrganData.Text);
                if (attribute == "Extraction_date")
                {
                    logic.DatabaseManager.Update(5, int.Parse(tbUpdateOrganID.Text), "Status", "Dostepne");
                }
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
