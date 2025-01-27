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
    public partial class frmPlaces : Form
    {
        public frmPlaces()
        {
            InitializeComponent();
        }

        private void frmPlaces_Load(object sender, EventArgs e)
        {
            dgvHospitals.ReadOnly = true;
            dgvBanks.ReadOnly = true;
            dgvHospitals.AutoGenerateColumns = false;
            dgvBanks.AutoGenerateColumns = false;
            dgvHospitals.BackgroundColor = SystemColors.Window;
            dgvBanks.BackgroundColor = SystemColors.Window;
            dgvHospitals.Columns.Clear();
            dgvBanks.Columns.Clear();

            dgvHospitals.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Hospital ID", DataPropertyName = "Id" });
            dgvHospitals.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "City", DataPropertyName = "City" });
            dgvHospitals.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Address", DataPropertyName = "Address" });
            dgvHospitals.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Contact Info", DataPropertyName = "ContactInfo" });

            dgvBanks.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Bank ID", DataPropertyName = "Id" });
            dgvBanks.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "City", DataPropertyName = "City" });
            dgvBanks.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Address", DataPropertyName = "Address" });
            dgvBanks.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Contact Info", DataPropertyName = "ContactInfo" });
            
            this.Show();
        }
        private void Show()
        {
            var data1 = DatabaseManager.Read(6);
            List<Hospital> list1 = new List<Hospital>();
            foreach (var i in data1)
            {
                Hospital item = new Hospital(i);
                list1.Add(item);
            }
            dgvHospitals.DataSource = list1;
            dgvHospitals.Refresh();

            var data2 = DatabaseManager.Read(7);
            List<Bank> list2 = new List<Bank>();
            foreach (var i in data2)
            {
                Bank item = new Bank(i);
                list2.Add(item);
            }
            dgvBanks.DataSource = list2;
            dgvBanks.Refresh();
        }

        private void btnPlaceAdd_Click(object sender, EventArgs e)
        {
            frmPlaceAdd frmPlaceAdd = new frmPlaceAdd();
            frmPlaceAdd.ShowDialog();
            this.Show();
        }

        private void btnPlaceRemove_Click(object sender, EventArgs e)
        {
            frmPlaceRemove frmPlaceRemove = new frmPlaceRemove();
            frmPlaceRemove.ShowDialog();
            this.Show();
        }

        private void btnPlaceUpdate_Click(object sender, EventArgs e)
        {
            frmPlaceUpdate frmPlaceUpdate = new frmPlaceUpdate();
            frmPlaceUpdate.ShowDialog();
            this.Show();
        }
    }
}
