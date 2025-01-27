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
    public partial class frmPlaceUpdate : Form
    {
        public frmPlaceUpdate()
        {
            InitializeComponent();
        }

        private void btnUpdatePlaceUpdate_Click(object sender, EventArgs e)
        {
            if (!logic.ValidationHelper.IsValidID(tbUpdatePlaceID.Text))
            {
                MessageBox.Show("Invalid data in \"Place ID Number\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbUpdatePlaceID.Focus();
                return;
            }

            string attribute;
            if (rbtnPlaceContactInfo.Checked)
            {
                attribute = "Contact_info";
                if (!logic.ValidationHelper.IsValidName(tbPlaceData.Text))
                {
                    MessageBox.Show("Invalid data in \"New Data\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbPlaceData.Focus();
                    return;
                }
            }
            else if (rbtnPlaceCity.Checked)
            {
                attribute = "City";
                if (!logic.ValidationHelper.IsValidName(tbPlaceData.Text))
                {
                    MessageBox.Show("Invalid data in \"New Data\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbPlaceData.Focus();
                    return;
                }
            }
            else if (rbtnPlaceAddress.Checked)
            {
                attribute = "Address";
                if (string.IsNullOrWhiteSpace(tbPlaceData.Text))
                {
                    MessageBox.Show("Invalid data in \"New Data\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbPlaceData.Focus();
                    return;
                }
            }
            else
            {
                attribute = "";
                MessageBox.Show("Choose an attribute to change", "Choice Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                gbUpdatePlace.Focus();
                return;
            }

            try
            {
                int id = int.Parse(tbUpdatePlaceID.Text);

                if (rbtnBank.Checked)
                {
                    logic.DatabaseManager.Update(7, id, attribute, tbPlaceData.Text);
                }
                else if (rbtnHospital.Checked)
                {
                    logic.DatabaseManager.Update(6, id, attribute, tbPlaceData.Text);
                }
                else
                {
                    MessageBox.Show("Choose a type of facility", "Choice Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    gbPlaceType.Focus();
                    return;
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
