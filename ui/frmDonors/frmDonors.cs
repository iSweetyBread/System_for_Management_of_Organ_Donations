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
    public partial class frmDonors : Form
    {
        public frmDonors()
        {
            InitializeComponent();
        }
        private void frmDonors_Load(object sender, EventArgs e)
        {
            dgvDonors.ReadOnly = true;
            dgvDonors.AutoGenerateColumns = false;
            dgvDonors.BackgroundColor = SystemColors.Window;
            dgvDonors.Columns.Clear();

            dgvDonors.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Donor ID", DataPropertyName = "Id" });
            dgvDonors.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "First Name", DataPropertyName = "FirstName" });
            dgvDonors.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Last Name", DataPropertyName = "LastName" });
            dgvDonors.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Birth Date", DataPropertyName = "BirthDate" });
            dgvDonors.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Blood Type", DataPropertyName = "BloodType" });
            dgvDonors.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "City", DataPropertyName = "City" });
            dgvDonors.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Address", DataPropertyName = "Address" });

            this.Show();
        }
        private void Show()
        {
            var data = DatabaseManager.Read(1);
            List<OrganDonor> list = new List<OrganDonor>();
            foreach (var i in data)
            {
                OrganDonor item = new OrganDonor(i);
                list.Add(item);
            }
            dgvDonors.DataSource = list;
            dgvDonors.Refresh();
        }

        private void btnAddDonor_Click(object sender, EventArgs e)
        {
            frmDonorsAdd frmDonorsAdd = new frmDonorsAdd();
            frmDonorsAdd.ShowDialog();
            this.Show();
        }

        private void btnRemoveDonor_Click(object sender, EventArgs e)
        {
            frmDonorsRemove frmDonorsRemove = new frmDonorsRemove();
            frmDonorsRemove.ShowDialog();
            this.Show();
        }

        private void btnUpdateDonor_Click(object sender, EventArgs e)
        {
            frmDonorsUpdate frmDonorsUpdate = new frmDonorsUpdate();
            frmDonorsUpdate.ShowDialog();
            this.Show();
        }
    }
}
