using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FinalProject
{
    public partial class frmRanger : Form
    {
        //Declare public arrays, constants, and variables
        string[] name;
        string[] pass;
        const int NUM_RANGER = 4;
        const string FILENAME = "RANGER_LOGINS.txt";
        FileStream inFile = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);

        public frmRanger()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //Read login data into arrays for later use
            StreamReader reader = new StreamReader(inFile);
            name = new string[NUM_RANGER];
            pass = new string[NUM_RANGER];

            for (int x = 0; x < name.Length; ++x)
            {
                name[x] = reader.ReadLine();
                pass[x] = reader.ReadLine();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Declare variables
            string inputName, inputPass;
            bool match = false;

            //Input Data
            inputName = txtUsername.Text;
            inputPass = txtPassword.Text;

            for (int i = 0; i < name.Length; ++i)
            {
                if (inputName == name[i] && inputPass == pass[i])
                {
                    match = true;
                }
            }

            if (match)
            {
                frmReport secondForm = new frmReport();
                secondForm.Show();
                this.Hide();
            }

            else
            {
                lblResults.Text = "Username or password is incorrect, try again.";
                txtPassword.Text = "";
                txtUsername.Focus();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Back button
            frmHome secondForm = new frmHome();
            secondForm.Show();
            this.Hide();
        }
    }
}
