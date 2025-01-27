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
    public partial class frmBDonorsAdd : Form
    {
        public frmBDonorsAdd()
        {
            InitializeComponent();
        }

        private void btnAddBOrganAdd_Click(object sender, EventArgs e)
        {
            if (!logic.ValidationHelper.IsValidName(tbBDonorFirstName.Text))
            {
                MessageBox.Show("Invalid data in \"First Name\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbBDonorFirstName.Focus();
                return;
            }
            if (!logic.ValidationHelper.IsValidName(tbBDonorLastName.Text))
            {
                MessageBox.Show("Invalid data in \"Last Name\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbBDonorLastName.Focus();
                return;
            }
            if (!logic.ValidationHelper.IsValidType(tbBDonorBloodType.Text))
            {
                MessageBox.Show("Invalid data in \"Blood Type\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbBDonorBloodType.Focus();
                return;
            }
            if (!logic.ValidationHelper.IsValidName(tbBDonorCity.Text))
            {
                MessageBox.Show("Invalid data in \"City\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbBDonorCity.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(tbBDonorAddress.Text))
            {
                MessageBox.Show("Invalid data in \"Address\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbBDonorAddress.Focus();
                return;
            }

            try
            {
                int id = logic.DatabaseManager.MaxID(2) + 1;
                string firstName = tbBDonorFirstName.Text;
                string lastName = tbBDonorLastName.Text;
                DateTime birthDate = dtpBDonorBirthDate.Value;
                string bloodType = tbBDonorBloodType.Text;
                string city = tbBDonorCity.Text;
                string address = tbBDonorAddress.Text;

                logic.BloodDonor bloodDonor = new logic.BloodDonor(id, firstName, lastName, birthDate, bloodType, city, address);
                logic.DatabaseManager.Create(bloodDonor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Entry created successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
