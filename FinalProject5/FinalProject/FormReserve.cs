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

namespace Reservations
{
    public partial class frmReserve : Form
    {
        //Declare public variables, constants, and arrays
        int[] price;
        int[] revenue;
        int[] days;
        const int NUM_LOTS = 4;
        const int MIN_AGE = 18;
        const string FILEPRICE = "PRICE_LOT.txt", FILEREVENUE = "REVENUE.txt", FILEQTY = "DAYS_ORDER.txt", FILEORDER = "CustOrder.txt";
        FileStream inFile = new FileStream(FILEPRICE, FileMode.Open, FileAccess.Read);
        FileStream outFile = new FileStream(FILEREVENUE, FileMode.Append, FileAccess.Write);
        FileStream outFile1 = new FileStream(FILEQTY, FileMode.Append, FileAccess.Write);
        FileStream outFile2 = new FileStream(FILEORDER, FileMode.Append, FileAccess.Write);

        public frmReserve()
        {
            InitializeComponent();
        }

        private void frmReserve_Load(object sender, EventArgs e)
        {
            //Read data into arrays to use later
            StreamReader reader = new StreamReader(inFile);
            price = new int[NUM_LOTS];

            for (int x = 0; x < price.Length; ++x)
            {
                price[x] = Convert.ToInt16(reader.ReadLine());
            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            //Back button
            FinalProject.frmHome secondForm = new FinalProject.frmHome();
            secondForm.Show();
            this.Hide();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Declare variables, constants, arrays, and streams
            int orderNumInput, age, daysInput, customerTot = 0, foundPosition;
            string name;
            revenue = new int[NUM_LOTS];
            days = new int[NUM_LOTS];
            StreamWriter writer = new StreamWriter(outFile);
            StreamWriter writer1 = new StreamWriter(outFile1);
            StreamWriter writer2 = new StreamWriter(outFile2);

            //Accept user input
            orderNumInput = Convert.ToInt16(txtOption.Text);
            daysInput = Convert.ToInt16(txtDays.Text);
            age = Convert.ToInt16(txtAge.Text);
            name = txtName.Text;
            foundPosition = orderNumInput - 1;

            customerTot = daysInput * price[foundPosition];
            days[foundPosition] += daysInput;
            revenue[foundPosition] += customerTot;

            if (age >= MIN_AGE)
            {
                customerTot = daysInput * price[foundPosition];
                days[foundPosition] += daysInput;
                revenue[foundPosition] += customerTot;

                lblResults.Text = String.Format("Your total will be {0}, please place order if you are satisfied.", customerTot.ToString("C"));

                //Write to permanent storage
                writer.WriteLine(revenue[foundPosition]);
                writer1.WriteLine(days[foundPosition]);

                //Write to temporary storage
                writer2.WriteLine(name);
                writer2.WriteLine(customerTot);

                //Close streams
                writer.Close();
                outFile.Close();

                writer1.Close();
                outFile1.Close();

                writer2.Close();
                outFile2.Close();
            }

            else
            {
                lblResults.Text = "You must be at least 18 to place an order.";
                txtAge.Text = "";
                txtAge.Focus();
            }
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            int age;

            age = Convert.ToInt16(txtAge.Text);

            if (age >= MIN_AGE)
            {
                FinalProjectCheckout.frmCheckout secondForm = new FinalProjectCheckout.frmCheckout();
                secondForm.Show();
                this.Hide();
            }

            else
            {
                lblResults.Text = "You must be at least 18 to place an order.";
                txtAge.Text = "";
                txtAge.Focus();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Back button
            FinalProject.frmHome secondForm = new FinalProject.frmHome();
            secondForm.Show();
            this.Hide();
        }
    }

}




