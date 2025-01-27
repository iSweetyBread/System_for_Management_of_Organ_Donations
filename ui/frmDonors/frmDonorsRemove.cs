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
    public partial class frmDonorsRemove : Form
    {
        public frmDonorsRemove()
        {
            InitializeComponent();
        }

        private void btnRemoveDonorRemove_Click(object sender, EventArgs e)
        {
            if (!logic.ValidationHelper.IsValidID(tbRemoveDonorID.Text))
            {
                MessageBox.Show("Invalid data in \"Donor ID Number\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbRemoveDonorID.Focus();
                return;
            }

            try
            {
                logic.DatabaseManager.Delete(1, int.Parse(tbRemoveDonorID.Text));
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
