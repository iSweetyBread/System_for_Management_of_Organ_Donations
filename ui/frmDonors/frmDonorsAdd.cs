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
    public partial class frmDonorsAdd : Form
    {
        public frmDonorsAdd()
        {
            InitializeComponent();
        }

        private void btnAddOrganAdd_Click(object sender, EventArgs e)
        {
            if (!logic.ValidationHelper.IsValidName(tbDonorFirstName.Text))
            {
                MessageBox.Show("Invalid data in \"First Name\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbDonorFirstName.Focus();
                return;
            }
            if (!logic.ValidationHelper.IsValidName(tbDonorLastName.Text))
            {
                MessageBox.Show("Invalid data in \"Last Name\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbDonorLastName.Focus();
                return;
            }
            if (!logic.ValidationHelper.IsValidType(tbDonorBloodType.Text))
            {
                MessageBox.Show("Invalid data in \"Blood Type\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbDonorBloodType.Focus();
                return;
            }
            if (!logic.ValidationHelper.IsValidName(tbDonorCity.Text))
            {
                MessageBox.Show("Invalid data in \"City\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbDonorCity.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(tbDonorAddress.Text))
            {
                MessageBox.Show("Invalid data in \"Address\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbDonorAddress.Focus();
                return;
            }
            if (!logic.ValidationHelper.IsValidID(tbDonorOrganPlaceID.Text))
            {
                MessageBox.Show("Invalid data in \"Hospital ID Number\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbDonorOrganPlaceID.Focus();
                return;
            }

            string rawOrganData = tbDonorOrgan.Text;
            List<string> organData = new List<string>();
            foreach (string i in rawOrganData.Split(','))
            { 
                organData.Add(i.Trim());
            }
            foreach (string i in organData)
            {
                if (!logic.ValidationHelper.IsValidName(i))
                {
                    MessageBox.Show("Invalid data in \"Organ(s)\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbDonorOrgan.Focus();
                    return;
                }
            }

            try
            {
                int id = logic.DatabaseManager.MaxID(1) + 1;
                string firstName = tbDonorFirstName.Text;
                string lastName = tbDonorLastName.Text;
                DateTime birthDate = dtpDonorBirthDate.Value;
                string bloodType = tbDonorBloodType.Text;
                string city = tbDonorCity.Text;
                string address = tbDonorAddress.Text;

                logic.OrganDonor organDonor = new logic.OrganDonor(id, firstName, lastName, birthDate, bloodType, city, address);
                logic.DatabaseManager.Create(organDonor);

                int placeId = int.Parse(tbDonorOrganPlaceID.Text);
                DateTime donationDate = dtpDonorDonationDate.Value;
                int temp = 1;
                foreach (string i in organData)
                {
                    int organId = logic.DatabaseManager.MaxID(5) + temp;
                    logic.OrganDonation organDonation = new logic.OrganDonation(organId, id, i, donationDate, placeId, "Dostepne");
                    logic.DatabaseManager.Create(organDonation);
                }
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
