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
    public partial class frmRecepients : Form
    {
        public frmRecepients()
        {
            InitializeComponent();
        }

        private void frmRecepients_Load(object sender, EventArgs e)
        {
            dgvRecepients.ReadOnly = true;
            dgvRecepients.AutoGenerateColumns = false;
            dgvRecepients.BackgroundColor = SystemColors.Window;
            dgvRecepients.Columns.Clear();

            dgvRecepients.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Recepient ID", DataPropertyName = "Id" });
            dgvRecepients.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "First Name", DataPropertyName = "FirstName" });
            dgvRecepients.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Last Name", DataPropertyName = "LastName" });
            dgvRecepients.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Birth Date", DataPropertyName = "BirthDate" });
            dgvRecepients.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Blood Type", DataPropertyName = "BloodType" });
            dgvRecepients.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Organ ID", DataPropertyName = "OrganId" });
            dgvRecepients.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Organ Status", DataPropertyName = "OrganStatus" });
            dgvRecepients.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Priority", DataPropertyName = "Priority" });
            dgvRecepients.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Operation Date", DataPropertyName = "OperationDate" });

            this.Show();
        }
        private void Show()
        {
            var data = DatabaseManager.Read(3);
            List<Receiver> list = new List<Receiver>();
            foreach (var i in data)
            {
                Receiver item = new Receiver(i);
                list.Add(item);
            }
            dgvRecepients.DataSource = list;
            dgvRecepients.Refresh();
        }

        private void btnAddRecepients_Click(object sender, EventArgs e)
        {
            frmRecepientsAdd frmRecepientsAdd = new frmRecepientsAdd();
            frmRecepientsAdd.ShowDialog();
            this.Show();
        }

        private void btnRemoveRecepients_Click(object sender, EventArgs e)
        {
            frmRecepientsRemove frmRecepientsRemove = new frmRecepientsRemove();
            frmRecepientsRemove.ShowDialog();
            this.Show();
        }

        private void btnUpdateRecepients_Click(object sender, EventArgs e)
        {
            frmRecepientsUpdate frmRecepientsUpdate = new frmRecepientsUpdate();
            frmRecepientsUpdate.ShowDialog();
            this.Show();
        }
    }
}
