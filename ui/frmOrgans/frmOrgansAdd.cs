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
    public partial class frmOrgansAdd : Form
    {
        public frmOrgansAdd()
        {
            InitializeComponent();
        }

        private void btnAddOrganAdd_Click(object sender, EventArgs e)
        {
            if (!logic.ValidationHelper.IsValidName(tbOrganName.Text))
            {
                MessageBox.Show("Invalid data in \"Organ Name\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbOrganName.Focus();
                return;
            }
            if (!logic.ValidationHelper.IsValidID(tbOrganDonorID.Text))
            {
                MessageBox.Show("Invalid data in \"Donor ID Number\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbOrganDonorID.Focus();
                return;
            }
            if (!logic.ValidationHelper.IsValidID(tbOrganPlaceID.Text))
            {
                MessageBox.Show("Invalid data in \"Place ID Number\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbOrganPlaceID.Focus();
                return;
            }

            try
            {
                int id = logic.DatabaseManager.MaxID(5) + 1;
                int donorId = int.Parse(tbOrganDonorID.Text);
                string organ = tbOrganName.Text;
                DateTime donationDate = dtpOrganDonationDate.Value;
                int placeId = int.Parse(tbOrganPlaceID.Text);

                logic.OrganDonation organDonation = new logic.OrganDonation(id, donorId, organ, donationDate, placeId, "Dostepne");
                logic.DatabaseManager.Create(organDonation);
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
