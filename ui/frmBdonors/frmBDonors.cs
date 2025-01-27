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

namespace ui
{
    public partial class frmBDonors : Form
    {
        public frmBDonors()
        {
            InitializeComponent();
        }

        private void frmBDonors_Load(object sender, EventArgs e)
        {
            dgvBDonors.ReadOnly = true;
            dgvBDonors.AutoGenerateColumns = false;
            dgvBDonors.BackgroundColor = SystemColors.Window;
            dgvBDonors.Columns.Clear();

            dgvBDonors.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Donor ID", DataPropertyName = "Id" });
            dgvBDonors.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "First Name", DataPropertyName = "FirstName" });
            dgvBDonors.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Last Name", DataPropertyName = "LastName" });
            dgvBDonors.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Birth Date", DataPropertyName = "BirthDate" });
            dgvBDonors.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Blood Type", DataPropertyName = "BloodType" });
            dgvBDonors.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Donation Count", DataPropertyName = "DonationCount" });

            this.Show();
        }
        private void Show()
        {
            var data = DatabaseManager.Read(2);
            List<BloodDonor> list = new List<BloodDonor>();
            foreach (var i in data)
            {
                BloodDonor item = new BloodDonor(i);
                list.Add(item);
            }
            dgvBDonors.DataSource = list;
            dgvBDonors.Refresh();
        }

        private void btnAddBDonor_Click(object sender, EventArgs e)
        {
            frmBDonorsAdd frmBDonorsAdd = new frmBDonorsAdd();
            frmBDonorsAdd.ShowDialog();
            this.Show();
        }

        private void btnRemoveBDonor_Click(object sender, EventArgs e)
        {
            frmBDonorsRemove frmBDonorsRemove = new frmBDonorsRemove();
            frmBDonorsRemove.ShowDialog();
            this.Show();
        }

        private void btnUpdateBDonor_Click(object sender, EventArgs e)
        {
            frmBDonorsUpdate frmBDonorsUpdate = new frmBDonorsUpdate();
            frmBDonorsUpdate.ShowDialog();
            this.Show();
        }

        private void btnBDonorsAddDonation_Click(object sender, EventArgs e)
        {
            frmBDonorAddDonation frmBDonorAddDonation = new frmBDonorAddDonation();
            frmBDonorAddDonation.ShowDialog();
            this.Show();
        }
    }
}
