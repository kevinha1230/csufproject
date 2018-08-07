namespace FinalProject
{
    partial class frmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnGallery = new System.Windows.Forms.Button();
            this.btnManagerLogin = new System.Windows.Forms.Button();
            this.btnVisit = new System.Windows.Forms.Button();
            this.picWelcome = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblBanner = new System.Windows.Forms.Label();
            this.linkWild = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picWelcome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(488, 12);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 0;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnGallery
            // 
            this.btnGallery.Location = new System.Drawing.Point(396, 12);
            this.btnGallery.Name = "btnGallery";
            this.btnGallery.Size = new System.Drawing.Size(75, 23);
            this.btnGallery.TabIndex = 1;
            this.btnGallery.Text = "Gallery";
            this.btnGallery.UseVisualStyleBackColor = true;
            this.btnGallery.Click += new System.EventHandler(this.btnGallery_Click);
            // 
            // btnManagerLogin
            // 
            this.btnManagerLogin.Location = new System.Drawing.Point(466, 440);
            this.btnManagerLogin.Name = "btnManagerLogin";
            this.btnManagerLogin.Size = new System.Drawing.Size(97, 23);
            this.btnManagerLogin.TabIndex = 2;
            this.btnManagerLogin.Text = "Ranger Login";
            this.btnManagerLogin.UseVisualStyleBackColor = true;
            this.btnManagerLogin.Click += new System.EventHandler(this.btnManagerLogin_Click);
            // 
            // btnVisit
            // 
            this.btnVisit.BackColor = System.Drawing.Color.OrangeRed;
            this.btnVisit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVisit.Location = new System.Drawing.Point(247, 306);
            this.btnVisit.Name = "btnVisit";
            this.btnVisit.Size = new System.Drawing.Size(124, 23);
            this.btnVisit.TabIndex = 3;
            this.btnVisit.Text = "Book today!";
            this.btnVisit.UseVisualStyleBackColor = false;
            this.btnVisit.Click += new System.EventHandler(this.btnVisit_Click);
            // 
            // picWelcome
            // 
            this.picWelcome.Image = ((System.Drawing.Image)(resources.GetObject("picWelcome.Image")));
            this.picWelcome.Location = new System.Drawing.Point(0, 41);
            this.picWelcome.Name = "picWelcome";
            this.picWelcome.Size = new System.Drawing.Size(605, 393);
            this.picWelcome.TabIndex = 4;
            this.picWelcome.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox2.Location = new System.Drawing.Point(0, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(605, 43);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox3.Location = new System.Drawing.Point(0, 432);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(605, 45);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // lblBanner
            // 
            this.lblBanner.BackColor = System.Drawing.Color.SteelBlue;
            this.lblBanner.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanner.ForeColor = System.Drawing.Color.White;
            this.lblBanner.Location = new System.Drawing.Point(12, 9);
            this.lblBanner.Name = "lblBanner";
            this.lblBanner.Size = new System.Drawing.Size(198, 26);
            this.lblBanner.TabIndex = 7;
            this.lblBanner.Text = "Go WILD for parks!";
            // 
            // linkWild
            // 
            this.linkWild.AutoSize = true;
            this.linkWild.BackColor = System.Drawing.Color.SteelBlue;
            this.linkWild.ForeColor = System.Drawing.Color.White;
            this.linkWild.LinkColor = System.Drawing.Color.White;
            this.linkWild.Location = new System.Drawing.Point(273, 17);
            this.linkWild.Name = "linkWild";
            this.linkWild.Size = new System.Drawing.Size(31, 13);
            this.linkWild.TabIndex = 8;
            this.linkWild.TabStop = true;
            this.linkWild.Text = "here!";
            this.linkWild.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkWild_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(216, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Learn more";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Kristen ITC", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblWelcome.Location = new System.Drawing.Point(129, 142);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(403, 110);
            this.lblWelcome.TabIndex = 10;
            this.lblWelcome.Text = "Welcome to Arches National Park";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 475);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkWild);
            this.Controls.Add(this.lblBanner);
            this.Controls.Add(this.btnVisit);
            this.Controls.Add(this.btnManagerLogin);
            this.Controls.Add(this.btnGallery);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.picWelcome);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Name = "frmHome";
            this.Text = "Camp at Arches National Park, Utah";
            ((System.ComponentModel.ISupportInitialize)(this.picWelcome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnGallery;
        private System.Windows.Forms.Button btnManagerLogin;
        private System.Windows.Forms.Button btnVisit;
        private System.Windows.Forms.PictureBox picWelcome;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblBanner;
        private System.Windows.Forms.LinkLabel linkWild;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWelcome;
    }
}

