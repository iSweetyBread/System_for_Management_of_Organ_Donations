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
    public partial class frmRecepientsRemove : Form
    {
        public frmRecepientsRemove()
        {
            InitializeComponent();
        }

        private void btnRemoveRecepientRemove_Click(object sender, EventArgs e)
        {
            if (!logic.ValidationHelper.IsValidID(tbRemoveRecepientID.Text))
            {
                MessageBox.Show("Invalid data in \"Donor ID Number\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbRemoveRecepientID.Focus();
                return;
            }

            try
            {
                logic.DatabaseManager.Delete(3, int.Parse(tbRemoveRecepientID.Text));
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
