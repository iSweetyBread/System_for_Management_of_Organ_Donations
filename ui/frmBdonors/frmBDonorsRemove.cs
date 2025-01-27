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
    public partial class frmBDonorsRemove : Form
    {
        public frmBDonorsRemove()
        {
            InitializeComponent();
        }

        private void btnRemoveBDonorRemove_Click(object sender, EventArgs e)
        {
            if (!logic.ValidationHelper.IsValidID(tbRemoveBDonorID.Text))
            {
                MessageBox.Show("Invalid data in \"Blood Donor ID Number\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbRemoveBDonorID.Focus();
                return;
            }

            try
            {
                logic.DatabaseManager.Delete(2, int.Parse(tbRemoveBDonorID.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Entry removed successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
