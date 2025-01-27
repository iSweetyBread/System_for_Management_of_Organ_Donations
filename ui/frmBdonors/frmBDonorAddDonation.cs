using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ui
{
    public partial class frmBDonorAddDonation : Form
    {
        public frmBDonorAddDonation()
        {
            InitializeComponent();
        }

        private void btnAddBDonorAmount_Click(object sender, EventArgs e)
        {
            if (!logic.ValidationHelper.IsValidID(tbBDonorIDDonation.Text))
            {
                MessageBox.Show("Invalid data in \"Blood Donor ID Number\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbBDonorIDDonation.Focus();
                return;
            }
            if (!int.TryParse(tbBDonorAmount.Text, out _))
            {
                MessageBox.Show("Invalid data in \"Amount\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbBDonorAmount.Focus();
                return;
            }
            if (!logic.ValidationHelper.IsValidID(tbBDonationPlaceID.Text))
            {
                MessageBox.Show("Invalid data in \"Blood Donor ID Number\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbBDonorIDDonation.Focus();
                return;
            }

            try
            {
                int id = int.Parse(tbBDonorIDDonation.Text);
                string data = (logic.DatabaseManager.GetCount(id) + 1).ToString();
                logic.DatabaseManager.Update(2, id, "Donation_count", data);

                int placeId = int.Parse(tbBDonationPlaceID.Text);
                DateTime donationDate = dtpBDonationDate.Value;
                int amount = int.Parse(tbBDonorAmount.Text);
                logic.BloodDonation bloodDonation = new logic.BloodDonation(donationDate, amount, id, placeId);
                logic.DatabaseManager.Create(bloodDonation);

                var aaa = logic.DatabaseManager.Search(2, "Bdonor_id", id.ToString());
                logic.BloodDonor bloodDonor = new logic.BloodDonor(aaa.First());
                string bloodType = bloodDonor.BloodType;

                var bbb = logic.DatabaseManager.Search(8, "Place_id", placeId.ToString());
                logic.BankBloodAmount bankBloodAmount = new logic.BankBloodAmount(bbb.First());
                string attribute = bankBloodAmount.GetType(bloodType).Item1;
                int resultAmount = bankBloodAmount.GetType(bloodType).Item2 + amount;

                logic.DatabaseManager.Update(8, placeId, attribute, resultAmount.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Donation added successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
