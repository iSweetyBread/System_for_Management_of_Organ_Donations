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
    public partial class frmRecepientsAdd : Form
    {
        public frmRecepientsAdd()
        {
            InitializeComponent();
        }

        private void btnAddOrganAdd_Click(object sender, EventArgs e)
        {
            if (!logic.ValidationHelper.IsValidName(tbRecepientFirstName.Text))
            {
                MessageBox.Show("Invalid data in \"First Name\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbRecepientFirstName.Focus();
                return;
            }
            if (!logic.ValidationHelper.IsValidName(tbRecepientLastName.Text))
            {
                MessageBox.Show("Invalid data in \"Last Name\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbRecepientLastName.Focus();
                return;
            }
            if (!logic.ValidationHelper.IsValidType(tbRecepientBloodType.Text))
            {
                MessageBox.Show("Invalid data in \"Blood Type\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbRecepientBloodType.Focus();
                return;
            }
            if (!logic.ValidationHelper.IsValidName(tbRecepientCity.Text))
            {
                MessageBox.Show("Invalid data in \"City\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbRecepientCity.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(tbRecepientAddress.Text))
            {
                MessageBox.Show("Invalid data in \"Address\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbRecepientAddress.Focus();
                return;
            }
            if (!logic.ValidationHelper.IsValidID(tbRecepientHospitalID.Text))
            {
                MessageBox.Show("Invalid data in \"Hospital ID Number\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbRecepientHospitalID.Focus();
                return;
            }
            if (!logic.ValidationHelper.IsValidName(tbRecepientOrgan.Text))
            {
                MessageBox.Show("Invalid data in \"Organ\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbRecepientOrgan.Focus();
                return;
            }

            try
            {
                int id = logic.DatabaseManager.MaxID(3) + 1;
                string firstName = tbRecepientFirstName.Text;
                string lastName = tbRecepientLastName.Text;
                DateTime birthDate = dtpRecepientBirthDate.Value;
                string bloodType = tbRecepientBloodType.Text;
                string city = tbRecepientCity.Text;
                string address = tbRecepientAddress.Text;
                int hospitalId = int.Parse(tbRecepientHospitalID.Text);

                int placeId = int.Parse(tbRecepientHospitalID.Text);
                int organId = logic.DatabaseManager.MaxID(5) + 1;
                string organ = tbRecepientOrgan.Text;
                logic.OrganDonation organDonation = new logic.OrganDonation(organId, null, organ, null, placeId, "Oczekiwane");
                logic.DatabaseManager.Create(organDonation);

                logic.Receiver receiver = new logic.Receiver(id, firstName, lastName, birthDate, bloodType, city, address, hospitalId, DateTime.Today, organId);
                logic.DatabaseManager.Create(receiver);
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
