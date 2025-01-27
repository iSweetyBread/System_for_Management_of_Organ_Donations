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
    public partial class frmAmount : Form
    {
        public frmAmount()
        {
            InitializeComponent();
        }

        private void frmAmount_Load(object sender, EventArgs e)
        {
            dgvAmount.ReadOnly = true;
            dgvAmount.AutoGenerateColumns = false;
            dgvAmount.BackgroundColor = SystemColors.Window;
            dgvAmount.Columns.Clear();

            dgvAmount.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Bank ID", DataPropertyName = "Id" });
            dgvAmount.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "A+", DataPropertyName = "Aplus" });
            dgvAmount.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "A-", DataPropertyName = "Aminus" });
            dgvAmount.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "B+", DataPropertyName = "Bplus" });
            dgvAmount.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "B-", DataPropertyName = "Bminus" });
            dgvAmount.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "AB+", DataPropertyName = "ABplus" });
            dgvAmount.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "AB-", DataPropertyName = "ABminus" });
            dgvAmount.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "O+", DataPropertyName = "Oplus" });
            dgvAmount.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "O-", DataPropertyName = "Ominus" });

            this.Show();
        }
        private void Show()
        {
            var data = DatabaseManager.Read(8);
            List<BankBloodAmount> list = new List<BankBloodAmount>();
            foreach (var i in data)
            {
                BankBloodAmount item = new BankBloodAmount(i);
                list.Add(item);
            }
            dgvAmount.DataSource = list;
            dgvAmount.Refresh();
        }

        private void btnAmountUpdate_Click(object sender, EventArgs e)
        {
            frmAmountUpdate frmAmountUpdate = new frmAmountUpdate();
            frmAmountUpdate.ShowDialog();
            this.Show();
        }
    }
}
