using logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ui
{
    public partial class frmOrgans : Form
    {
        public frmOrgans()
        {
            InitializeComponent();
        }

        private void frmOrgans_Load(object sender, EventArgs e)
        {
            dgvOrgans.ReadOnly = true;
            dgvOrgans.AutoGenerateColumns = false;
            dgvOrgans.BackgroundColor = SystemColors.Window;
            dgvOrgans.Columns.Clear();

            dgvOrgans.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Organ ID", DataPropertyName = "Id" });
            dgvOrgans.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Organ Name", DataPropertyName = "Organ" });
            dgvOrgans.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Organ Status", DataPropertyName = "Status" });
            dgvOrgans.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Donor ID", DataPropertyName = "DonorId" });
            dgvOrgans.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Donation Date", DataPropertyName = "DonationDate" });
            dgvOrgans.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Place ID", DataPropertyName = "PlaceId" });

            this.Show("Dostepne");
        }
        private void Show(string status)
        {
            var data = DatabaseManager.Search(5, "\"Status\"", status);
            List<OrganDonation> list = new List<OrganDonation>();
            foreach (var i in data)
            {
                OrganDonation item = new OrganDonation(i);
                list.Add(item);
            }
            dgvOrgans.DataSource = list;
            dgvOrgans.Refresh();
        }

        private void btnAvailable_Click(object sender, EventArgs e)
        {
            this.Show("Dostepne");
        }

        private void btnUsed_Click(object sender, EventArgs e)
        {
            this.Show("Wykorzystane");
        }

        private void btnAwaited_Click(object sender, EventArgs e)
        {
            this.Show("Oczekiwane");
        }

        private void btnAddOrgan_Click(object sender, EventArgs e)
        {
            frmOrgansAdd frmOrgansAdd = new frmOrgansAdd();
            frmOrgansAdd.ShowDialog();
        }

        private void btnRemoveOrgan_Click(object sender, EventArgs e)
        {
            frmOrgansRemove frmOrgansRemove = new frmOrgansRemove();
            frmOrgansRemove.ShowDialog();
        }

        private void btnUpdateOrgan_Click(object sender, EventArgs e)
        {
            frmOrgansUpdate frmOrgansUpdate = new frmOrgansUpdate();
            frmOrgansUpdate.ShowDialog();
        }
    }
}
