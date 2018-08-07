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
    public partial class frmReport : Form
    {
        //Declare public variables, constants, arrays, and filestreams
        int[] days;
        int[] price;
        int[] revenue;
        const int QTY_LOT = 4;
        const string FILEDAYS = "DAYS_ORDER.txt", FILEPRICE = "PRICE_LOT.txt", FILEREVENUE = "REVENUE.txt";
        FileStream inFile = new FileStream(FILEDAYS, FileMode.Open, FileAccess.Read);
        FileStream inFile1 = new FileStream(FILEPRICE, FileMode.Open, FileAccess.Read);
        FileStream inFile2 = new FileStream(FILEREVENUE, FileMode.Open, FileAccess.Read);

        private void btnReport_Click(object sender, EventArgs e)
        {
            //Display quantities, prices, and revenues
            lblDayResult.Text = String.Format("{0}\n\n{1}\n\n{2}\n\n{3}", days[0], days[1], days[2], days[3]);
            lblPriceResult.Text = String.Format("{0}\n\n{1}\n\n{2}\n\n{3}", price[0].ToString("C0"), price[1].ToString("C0"), price[2].ToString("C0"), price[3].ToString("C0"));
            lblRevResult.Text = String.Format("{0}\n\n{1}\n\n{2}\n\n{3}", revenue[0].ToString("C0"), revenue[1].ToString("C0"), revenue[2].ToString("C0"), revenue[3].ToString("C0"));
        }

        private void btnBackReport_Click(object sender, EventArgs e)
        {
            //Back button
            FinalProject.frmHome secondForm = new FinalProject.frmHome();
            secondForm.Show();
            this.Hide();
        }

        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            //Read data into arrays to use later
            StreamReader reader = new StreamReader(inFile);
            StreamReader reader1 = new StreamReader(inFile1);
            StreamReader reader2 = new StreamReader(inFile2);
            days = new int[QTY_LOT];
            price = new int[QTY_LOT];
            revenue = new int[QTY_LOT];

            for (int x = 0; x < price.Length; ++x)
            {
                days[x] = Convert.ToInt16(reader.ReadLine());
                price[x] = Convert.ToInt16(reader1.ReadLine());
                revenue[x] = Convert.ToInt32(reader2.ReadLine());
            }
        }
    }
}
