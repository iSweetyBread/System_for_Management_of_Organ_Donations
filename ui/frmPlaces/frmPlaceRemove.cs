using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ui
{
    public partial class frmPlaceRemove : Form
    {
        public frmPlaceRemove()
        {
            InitializeComponent();
        }

        private void btnRemovePlaceRemove_Click(object sender, EventArgs e)
        {
            if (!logic.ValidationHelper.IsValidID(tbRemovePlaceID.Text))
            {
                MessageBox.Show("Invalid data in \"Place ID Number\" field", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbRemovePlaceID.Focus();
                return;
            }

            try
            {
                int id = int.Parse(tbRemovePlaceID.Text);

                if (rbtnBank.Checked)
                {
                    logic.DatabaseManager.Delete(7, id);
                }
                else if (rbtnHospital.Checked)
                {
                    logic.DatabaseManager.Delete(6, id);
                }
                else
                {
                    MessageBox.Show("Choose a type of facility", "Choice Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    gbPlaceType.Focus();
                    return;
                }
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
