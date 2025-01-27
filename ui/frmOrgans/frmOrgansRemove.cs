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
    public partial class frmOrgansRemove : Form
    {
        public frmOrgansRemove()
        {
            InitializeComponent();
        }

        private void btnRemoveOrganRemove_Click(object sender, EventArgs e)
        {
            if (!logic.ValidationHelper.IsValidID(tbRemoveOrganID.Text))
            {
                MessageBox.Show("Invalid data in \"Organ ID Number\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbRemoveOrganID.Focus();
                return;
            }

            try
            {
                logic.DatabaseManager.Delete(5, int.Parse(tbRemoveOrganID.Text));
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
