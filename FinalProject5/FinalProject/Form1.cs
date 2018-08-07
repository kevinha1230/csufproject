using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
            var pos = this.PointToScreen(lblWelcome.Location);
            pos = picWelcome.PointToClient(pos);
            lblWelcome.Parent = picWelcome;
            lblWelcome.Location = pos;
            lblWelcome.BackColor = Color.Transparent;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnManagerLogin_Click(object sender, EventArgs e)
        {
            frmRanger secondForm = new frmRanger();
            secondForm.Show();
            this.Hide();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout secondForm = new frmAbout();
            secondForm.Show();
            this.Hide();
        }

        private void linkWild_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmWild secondForm = new frmWild();
            secondForm.Show();
            this.Hide();
        }

        private void btnVisit_Click(object sender, EventArgs e)
        {
            Reservations.frmReserve secondForm = new Reservations.frmReserve();
            secondForm.Show();
            this.Hide();
        }

        private void btnGallery_Click(object sender, EventArgs e)
        {
            Galleryyy.frmGallery secondForm = new Galleryyy.frmGallery();
            secondForm.Show();
            this.Hide();
        }
    }
}
