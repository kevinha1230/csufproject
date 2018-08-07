using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galleryyy
{
    public partial class frmGallery : Form
    {
        private static int i;
        private static string[] pictures = new string[]
        {
         @"E:\FinalProject5\FinalProject\bin\Debug\GalleryPics\1.jpg",
          @"E:\FinalProject5\FinalProject\bin\Debug\GalleryPics\2.jpg",
           @"E:\FinalProject5\FinalProject\bin\Debug\GalleryPics\3.jpg",
            @"E:\FinalProject5\FinalProject\bin\Debug\GalleryPics\4.jpg",
             @"E:\FinalProject5\FinalProject\bin\Debug\GalleryPics\5.jpg",
              @"E:\FinalProject5\FinalProject\bin\Debug\GalleryPics\6.jpg",
               @"E:\FinalProject5\FinalProject\bin\Debug\GalleryPics\8.jpg",
                @"E:\FinalProject5\FinalProject\bin\Debug\GalleryPics\9.jpg",
                 @"E:\FinalProject5\FinalProject\bin\Debug\GalleryPics\11.jpg",
                  @"E:\FinalProject5\FinalProject\bin\Debug\GalleryPics\12.jpg",
                   @"E:\FinalProject5\FinalProject\bin\Debug\GalleryPics\15.jpg"





        };
        public frmGallery()
        {
            InitializeComponent();
            btnPrevious.Text = "Previous";
            btnNext.Text = "Next";
            pictureBox1.ImageLocation = pictures[i];
            pictureBox2.ImageLocation = pictures[i+1];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i += 2;
            if (i == pictures.Length) i = 0;
            pictureBox1.ImageLocation = pictures[i];
            pictureBox2.ImageLocation = pictures[i + 1];
            Text = pictureBox1.ImageLocation;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (i == 0) i = pictures.Length;
            i -= 2;
            pictureBox1.ImageLocation = pictures[i];
            pictureBox2.ImageLocation = pictures[i + 1];
            Text = pictureBox1.ImageLocation; 
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FinalProject.frmHome secondForm = new FinalProject.frmHome();
            secondForm.Show();
            this.Hide();
        }
    }
}
