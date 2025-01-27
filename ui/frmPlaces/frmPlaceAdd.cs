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
    public partial class frmPlaceAdd : Form
    {
        public frmPlaceAdd()
        {
            InitializeComponent();
        }

        private void btnAddOrganAdd_Click(object sender, EventArgs e)
        {
            if (!logic.ValidationHelper.IsValidName(tbPlaceCity.Text))
            {
                MessageBox.Show("Invalid data in \"City\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbPlaceCity.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(tbPlaceAddress.Text))
            {
                MessageBox.Show("Invalid data in \"Address\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbPlaceAddress.Focus();
                return;
            }
            if (!logic.ValidationHelper.IsValidPhone(tbPlaceContactInfo.Text))
            {
                MessageBox.Show("Invalid data in \"Contact Number\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbPlaceContactInfo.Focus();
                return;
            }

            try
            {
                string city = tbPlaceCity.Text;
                string address = tbPlaceAddress.Text;
                string contactInfo = tbPlaceContactInfo.Text;
                int id;

                if (rbtnBank.Checked)
                {
                    id = logic.DatabaseManager.MaxID(7) + 1;
                    logic.Bank bank = new logic.Bank(id, city, address, contactInfo);
                    logic.DatabaseManager.Create(bank);
                    logic.BankBloodAmount bankBloodAmount = new logic.BankBloodAmount(id);
                    logic.DatabaseManager.Create(bankBloodAmount);
                }
                else if (rbtnHospital.Checked)
                {
                    id = logic.DatabaseManager.MaxID(6) + 1;
                    logic.Hospital hospital = new logic.Hospital(id, city, address, contactInfo);
                    logic.DatabaseManager.Create(hospital);
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

            MessageBox.Show("Entry created successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
