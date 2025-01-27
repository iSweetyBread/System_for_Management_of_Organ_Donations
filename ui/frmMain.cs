using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using logic;
using logic.infoObjects;

namespace ui
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOrgans_Click(object sender, EventArgs e)
        {
            frmOrgans frmOrgans = new frmOrgans();
            frmOrgans.ShowDialog();
        }

        private void btnDonors_Click(object sender, EventArgs e)
        {
            frmDonors frmDonors = new frmDonors();
            frmDonors.ShowDialog();
        }

        private void btnReceivers_Click(object sender, EventArgs e)
        {
            frmRecepients frmRecepients = new frmRecepients();
            frmRecepients.ShowDialog();
        }

        private void btnBdonors_Click(object sender, EventArgs e)
        {
            frmBDonors frmBDonors = new frmBDonors();
            frmBDonors.ShowDialog();
        }

        private void btnPlaces_Click(object sender, EventArgs e)
        {
            frmPlaces frmPlaces = new frmPlaces();
            frmPlaces.ShowDialog();
        }

        private void btnBlood_Click(object sender, EventArgs e)
        {
            frmAmount frmAmount = new frmAmount();
            frmAmount.ShowDialog();
        }
    }
}
