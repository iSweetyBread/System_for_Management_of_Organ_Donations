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
    public partial class frmRecepientsUpdate : Form
    {
        public frmRecepientsUpdate()
        {
            InitializeComponent();
        }

        private void btnUpddateOrganUpdate_Click(object sender, EventArgs e)
        {
            if (!logic.ValidationHelper.IsValidID(tbUpdateRecepientID.Text))
            {
                MessageBox.Show("Invalid data in \"Organ Recepient ID Number\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbUpdateRecepientID.Focus();
                return;
            }

            string attribute;
            if (rbtnRecepientFirstName.Checked)
            {
                attribute = "First_name";
                if (!logic.ValidationHelper.IsValidName(tbRecepientData.Text))
                {
                    MessageBox.Show("Invalid data in \"New Data\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbRecepientData.Focus();
                    return;
                }
            }
            else if (rbtnRecepientLastName.Checked)
            {
                attribute = "Last_name";
                if (!logic.ValidationHelper.IsValidName(tbRecepientData.Text))
                {
                    MessageBox.Show("Invalid data in \"New Data\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbRecepientData.Focus();
                    return;
                }
            }
            else if (rbtnRecepientBirthDate.Checked)
            {
                attribute = "Birth_date";
                if (!logic.ValidationHelper.IsValidDate(tbRecepientData.Text))
                {
                    MessageBox.Show("Invalid data in \"New Data\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbRecepientData.Focus();
                    return;
                }
            }
            else if (rbtnRecepientBloodType.Checked)
            {
                attribute = "Blood_type";
                if (!logic.ValidationHelper.IsValidType(tbRecepientData.Text))
                {
                    MessageBox.Show("Invalid data in \"New Data\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbRecepientData.Focus();
                    return;
                }
            }
            else if (rbtnRecepientOrganStatus.Checked)
            {
                attribute = "Organ_status";
                if (!logic.ValidationHelper.IsValidStatus(tbRecepientData.Text))
                {
                    MessageBox.Show("Invalid data in \"New Data\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbRecepientData.Focus();
                    return;
                }
            }
            else if (rbtnRecepientPriority.Checked)
            {
                attribute = "Priority";
                if (!logic.ValidationHelper.IsValidName(tbRecepientData.Text))
                {
                    MessageBox.Show("Invalid data in \"New Data\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbRecepientData.Focus();
                    return;
                }
            }
            else if (rbtnRecepientOperationDate.Checked)
            {
                attribute = "Operation_date";
                if (!logic.ValidationHelper.IsValidDate(tbRecepientData.Text))
                {
                    MessageBox.Show("Invalid data in \"New Data\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbRecepientData.Focus();
                    return;
                }
            }
            else
            {
                attribute = "";
                MessageBox.Show("Choose an attribute to change", "Choice Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                gbUpdateRecepient.Focus();
                return;
            }

            try
            {
                logic.DatabaseManager.Update(3, int.Parse(tbUpdateRecepientID.Text), attribute, tbRecepientData.Text);
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
