using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectCheckout
{
    public partial class frmCheckout : Form
    {
        public frmCheckout()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Back button
            Reservations.frmReserve secondForm = new Reservations.frmReserve();
            secondForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmConfirm secondForm = new frmConfirm();
            secondForm.Show();
            this.Hide();
        }
    }
}
