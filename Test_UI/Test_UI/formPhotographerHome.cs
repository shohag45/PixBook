using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EntityPackages;
using RepositoryPackages;

namespace Test_UI
{
    public partial class formPhotographerHome : Form
    {
        public String PhotographerName { get; set; }
        public String UserName { get; set; }
        public formPhotographerHome(String PhotographerName)
        {
            InitializeComponent();
            this.PhotographerName = PhotographerName;
            labelWelcome.Text = labelWelcome.Text + " " + PhotographerName + "!";
            showDetails();
            btnExit.Click += BtnExit_Click;
            InterfaceDetailsForPhotographer();
            btnBack.Visible = false;

            btnUpload1.Visible = false;
            btnUpload2.Visible = false;
            btnUpload3.Visible = false;
            btnUpload4.Visible = false;
            btnUpload5.Visible = false;
            btnUpload6.Visible = false;
            btnUpload7.Visible = false;
            btnUpload8.Visible = false;
            btnUpload9.Visible = false;
            btnUpload10.Visible = false;

            btnRemove1.Visible = false;
            btnRemove2.Visible = false;
            btnremove3.Visible = false;
            btnRemove4.Visible = false;
            btnRemove5.Visible = false;
            btnRemove6.Visible = false;
            btnRemove7.Visible = false;
            btnRemove8.Visible = false;
            btnRemove9.Visible = false;
            btnRemove10.Visible = false;

            btnEdit.Visible = true;
            btnDone.Visible = false;
        }

        public formPhotographerHome(String PhotographerName,String UserName)
        {
            InitializeComponent();
            this.PhotographerName = PhotographerName;
            this.UserName = UserName;
            labelWelcome.Text = labelWelcome.Text + " " + UserName + "!";
            showDetails();
            btnExit.Click += BtnExit_Click;
            InterfaceDetailsForUser();
            btnBack.Visible = true;
        }

        private void FormPhotographerHome_Load(object sender, EventArgs e)
        {

        }
        public void InterfaceDetailsForUser()
        {
            PersonRepo pr = new PersonRepo();
            Persons p = null;
            p = pr.GetPersonInfo(UserName);
            if (p.PersonType == 3)
            {
                btnHire.Visible = false;
            }
            else if(p.PersonType == 1)
            {
                btnHire.Visible = true;
            }
            else if(p.PersonType == 2)
            {
                btnHire.Visible = false;
            }
                   
            btnRequests.Visible = false;
            btnUpload1.Visible = false;
            btnUpload2.Visible = false;
            btnUpload3.Visible = false;
            btnUpload4.Visible = false;
            btnUpload5.Visible = false;
            btnUpload6.Visible = false;
            btnUpload7.Visible = false;
            btnUpload8.Visible = false;
            btnUpload9.Visible = false;
            btnUpload10.Visible = false;

            btnRemove1.Visible = false;
            btnRemove2.Visible = false;
            btnremove3.Visible = false;
            btnRemove4.Visible = false;
            btnRemove5.Visible = false;
            btnRemove6.Visible = false;
            btnRemove7.Visible = false;
            btnRemove8.Visible = false;
            btnRemove9.Visible = false;
            btnRemove10.Visible = false;
        }
        public void InterfaceDetailsForPhotographer()
        {
            btnHire.Visible = false;
        }
        public void showDetails()
        {
            Gallery g = null;
            GalleryRepo gr = new GalleryRepo();
            g = gr.GetGalleryInfo(PhotographerName);

            PersonRepo pr = new PersonRepo();
            Photographers pg = null;
            Persons p = null;
            PhotographerRepo pgr = new PhotographerRepo();
            pg = pgr.GetPhotographerInfo(PhotographerName);
            p = pr.GetPersonInfo(PhotographerName);
            if (p != null)
            {
                String GenresType = pg.Genres;
                labelNameGender.Text = p.FullName + "\n" + p.Age + " Years" + "\n";
                labelAddress.Text = p.Address + "\n" + p.Mail + "\n0" + p.Phone+"\n"+pg.Experience+" Years of Experience\n"+GenresType+"\n"+pg.Fees+" BDT";
                labelUserName.Text = p.UserName;
                pbProfilePic.ImageLocation = p.ProfilePic;

                pictureBox1.ImageLocation = g.Pic1;
                pictureBox2.ImageLocation = g.Pic2;
                pictureBox3.ImageLocation = g.Pic3;
                pictureBox4.ImageLocation = g.Pic4;
                pictureBox5.ImageLocation = g.Pic5;
                pictureBox6.ImageLocation = g.Pic6;
                pictureBox7.ImageLocation = g.Pic7;
                pictureBox8.ImageLocation = g.Pic8;
                pictureBox9.ImageLocation = g.Pic9;
                pictureBox10.ImageLocation = g.Pic10;
            }
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void BtnSignOut_Click(object sender, EventArgs e)
        {
            formLogin1 lf = new formLogin1();
            lf.Show();
            this.Hide();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            PersonRepo pr = new PersonRepo();
            Persons p = null;
            p=pr.GetPersonInfo(UserName);
            if (p == null)
            {
                MessageBox.Show("System Error!");
            }
            else if(p.PersonType == 1)
            {
                formSearchPortfolio ph = new formSearchPortfolio(UserName);
                ph.Show();
                this.Hide();
            }
            else if (p.PersonType == 2)
            {
                formLogin1 lf = new formLogin1();
                lf.Show();
                this.Hide();
            }
            else if(p.PersonType == 3)
            {
                formManagementPhotographer1 pg = new formManagementPhotographer1(UserName);
                pg.Show();
                this.Hide();
            }
        }

        private void btnHire_Click(object sender, EventArgs e)
        {
            formHiring hr = new formHiring(PhotographerName, UserName);
            hr.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnShowPhotographer_Click(object sender, EventArgs e)
        {

        }

        private void btnManagePhotographer_Click(object sender, EventArgs e)
        {
            formPhotgraphersRequests phr = new formPhotgraphersRequests(this.PhotographerName);
            phr.Show();
            this.Hide();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {

        }

        private void labelWelcome_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelLogo_Click(object sender, EventArgs e)
        {

        }

        private void labelUserName_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelAddress_Click(object sender, EventArgs e)
        {

        }

        private void labelNameGender_Click(object sender, EventArgs e)
        {

        }

        private void labelUpload_Click(object sender, EventArgs e)
        {

        }

        private void tbPhotoDir_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

        }

        private void tlpPhotos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpload1_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation= openFileDialog1.FileName.ToString().Trim();

            if (!pictureBox1.ImageLocation.Equals(null) || !pictureBox1.ImageLocation.Equals(""))
            {
                Gallery g2 = null;

                Gallery g = new Gallery();
                GalleryRepo gr = new GalleryRepo();
                g2 = gr.GetGalleryInfo(PhotographerName);

                g.UserName = PhotographerName;
                g.Pic1 = pictureBox1.ImageLocation;
                g.Pic2 = g2.Pic2;
                g.Pic3 = g2.Pic3;
                g.Pic4 = g2.Pic4;
                g.Pic5 = g2.Pic5;
                g.Pic6 = g2.Pic6;
                g.Pic7 = g2.Pic7;
                g.Pic8 = g2.Pic8;
                g.Pic9 = g2.Pic9;
                g.Pic10 = g2.Pic10;

                gr.UpdateGallery(g);

                MessageBox.Show("Uploaded!");
            }
           
        }

        private void btnUpload2_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            pictureBox2.ImageLocation = openFileDialog1.FileName.ToString().Trim();

            if (!pictureBox2.ImageLocation.Equals(null))
            {
                Gallery g2 = null;

                Gallery g = new Gallery();
                GalleryRepo gr = new GalleryRepo();
                g2 = gr.GetGalleryInfo(PhotographerName);

                g.UserName = PhotographerName;
                g.Pic1 = g2.Pic1;
                g.Pic2 = pictureBox2.ImageLocation;
                g.Pic3 = g2.Pic3;
                g.Pic4 = g2.Pic4;
                g.Pic5 = g2.Pic5;
                g.Pic6 = g2.Pic6;
                g.Pic7 = g2.Pic7;
                g.Pic8 = g2.Pic8;
                g.Pic9 = g2.Pic9;
                g.Pic10 = g2.Pic10;

                gr.UpdateGallery(g);

                MessageBox.Show("Uploaded!");
            }
            
        }

        private void btnUpload3_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            pictureBox3.ImageLocation = openFileDialog1.FileName.ToString().Trim();
            if (!pictureBox3.ImageLocation.Equals(null))
            {

                Gallery g2 = null;

                Gallery g = new Gallery();
                GalleryRepo gr = new GalleryRepo();
                g2 = gr.GetGalleryInfo(PhotographerName);

                g.UserName = PhotographerName;
                g.Pic1 = g2.Pic1;
                g.Pic2 = g2.Pic2;
                g.Pic3 = pictureBox3.ImageLocation;
                g.Pic4 = g2.Pic4;
                g.Pic5 = g2.Pic5;
                g.Pic6 = g2.Pic6;
                g.Pic7 = g2.Pic7;
                g.Pic8 = g2.Pic8;
                g.Pic9 = g2.Pic9;
                g.Pic10 = g2.Pic10;

                gr.UpdateGallery(g);

                MessageBox.Show("Uploaded!");
            }
        }

        private void btnUpload4_Click(object sender, EventArgs e)
        {

            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            pictureBox4.ImageLocation = openFileDialog1.FileName.ToString().Trim();

            if (!pictureBox4.ImageLocation.Equals(null))
            {
                Gallery g2 = null;

                Gallery g = new Gallery();
                GalleryRepo gr = new GalleryRepo();
                g2 = gr.GetGalleryInfo(PhotographerName);

                g.UserName = PhotographerName;
                g.Pic1 = g2.Pic1;
                g.Pic2 = g2.Pic2;
                g.Pic3 = g2.Pic3;
                g.Pic4 = pictureBox4.ImageLocation;
                g.Pic5 = g2.Pic5;
                g.Pic6 = g2.Pic6;
                g.Pic7 = g2.Pic7;
                g.Pic8 = g2.Pic8;
                g.Pic9 = g2.Pic9;
                g.Pic10 = g2.Pic10;

                gr.UpdateGallery(g);

                MessageBox.Show("Uploaded!");
            }
                
        }

        private void btnUpload5_Click(object sender, EventArgs e)
        {

            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            pictureBox5.ImageLocation = openFileDialog1.FileName.ToString().Trim();

            if (!pictureBox5.ImageLocation.Equals(null))
            {
                Gallery g2 = null;

                Gallery g = new Gallery();
                GalleryRepo gr = new GalleryRepo();
                g2 = gr.GetGalleryInfo(PhotographerName);

                g.UserName = PhotographerName;
                g.Pic1 = g2.Pic1;
                g.Pic2 = g2.Pic2;
                g.Pic3 = g2.Pic3;
                g.Pic4 = g2.Pic4;
                g.Pic5 = pictureBox5.ImageLocation;
                g.Pic6 = g2.Pic6;
                g.Pic7 = g2.Pic7;
                g.Pic8 = g2.Pic8;
                g.Pic9 = g2.Pic9;
                g.Pic10 = g2.Pic10;

                gr.UpdateGallery(g);

                MessageBox.Show("Uploaded!");
            }
                
        }

        private void btnUpload6_Click(object sender, EventArgs e)
        {

            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            pictureBox6.ImageLocation = openFileDialog1.FileName.ToString().Trim();

            if (!pictureBox6.ImageLocation.Equals(null))
            {
                Gallery g2 = null;

                Gallery g = new Gallery();
                GalleryRepo gr = new GalleryRepo();
                g2 = gr.GetGalleryInfo(PhotographerName);

                g.UserName = PhotographerName;
                g.Pic1 = g2.Pic1;
                g.Pic2 = g2.Pic2;
                g.Pic3 = g2.Pic3;
                g.Pic4 = g2.Pic4;
                g.Pic5 = g2.Pic5;
                g.Pic6 = pictureBox6.ImageLocation;
                g.Pic7 = g2.Pic7;
                g.Pic8 = g2.Pic8;
                g.Pic9 = g2.Pic9;
                g.Pic10 = g2.Pic10;

                gr.UpdateGallery(g);

                MessageBox.Show("Uploaded!");
            }
               
        }

        private void btnUpload7_Click(object sender, EventArgs e)
        {

            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            pictureBox7.ImageLocation = openFileDialog1.FileName.ToString().Trim();

            if (!pictureBox7.ImageLocation.Equals(null))
            {
                Gallery g2 = null;

                Gallery g = new Gallery();
                GalleryRepo gr = new GalleryRepo();
                g2 = gr.GetGalleryInfo(PhotographerName);

                g.UserName = PhotographerName;
                g.Pic1 = g2.Pic1;
                g.Pic2 = g2.Pic2;
                g.Pic3 = g2.Pic3;
                g.Pic4 = g2.Pic4;
                g.Pic5 = g2.Pic5;
                g.Pic6 = g2.Pic6;
                g.Pic7 = pictureBox7.ImageLocation;
                g.Pic8 = g2.Pic8;
                g.Pic9 = g2.Pic9;
                g.Pic10 = g2.Pic10;

                gr.UpdateGallery(g);

                MessageBox.Show("Uploaded!");
            }
               
        }

        private void btnUpload8_Click(object sender, EventArgs e)
        {

            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            pictureBox8.ImageLocation = openFileDialog1.FileName.ToString().Trim();

            if (!pictureBox8.ImageLocation.Equals(null))
            {
                Gallery g2 = null;

                Gallery g = new Gallery();
                GalleryRepo gr = new GalleryRepo();
                g2 = gr.GetGalleryInfo(PhotographerName);

                g.UserName = PhotographerName;
                g.Pic1 = g2.Pic1;
                g.Pic2 = g2.Pic2;
                g.Pic3 = g2.Pic3;
                g.Pic4 = g2.Pic4;
                g.Pic5 = g2.Pic5;
                g.Pic6 = g2.Pic6;
                g.Pic7 = g2.Pic7;
                g.Pic8 = pictureBox8.ImageLocation;
                g.Pic9 = g2.Pic9;
                g.Pic10 = g2.Pic10;

                gr.UpdateGallery(g);

                MessageBox.Show("Uploaded!");
            }
                
        }

        private void btnUpload9_Click(object sender, EventArgs e)
        {

            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            pictureBox9.ImageLocation = openFileDialog1.FileName.ToString().Trim();

            if (!pictureBox9.ImageLocation.Equals(null))
            {
                Gallery g2 = null;

                Gallery g = new Gallery();
                GalleryRepo gr = new GalleryRepo();
                g2 = gr.GetGalleryInfo(PhotographerName);

                g.UserName = PhotographerName;
                g.Pic1 = g2.Pic1;
                g.Pic2 = g2.Pic2;
                g.Pic3 = g2.Pic3;
                g.Pic4 = g2.Pic4;
                g.Pic5 = g2.Pic5;
                g.Pic6 = g2.Pic6;
                g.Pic7 = g2.Pic7;
                g.Pic8 = g2.Pic8;
                g.Pic9 = pictureBox9.ImageLocation;
                g.Pic10 = g2.Pic10;

                gr.UpdateGallery(g);

                MessageBox.Show("Uploaded!");
            }
                
        }

        private void btnUpload10_Click(object sender, EventArgs e)
        {

            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            pictureBox10.ImageLocation = openFileDialog1.FileName.ToString().Trim();


            if (!pictureBox10.ImageLocation.Equals(null))
            {
                Gallery g2 = null;

                Gallery g = new Gallery();
                GalleryRepo gr = new GalleryRepo();
                g2 = gr.GetGalleryInfo(PhotographerName);

                g.UserName = PhotographerName;
                g.Pic1 = g2.Pic1;
                g.Pic2 = g2.Pic2;
                g.Pic3 = g2.Pic3;
                g.Pic4 = g2.Pic4;
                g.Pic5 = g2.Pic5;
                g.Pic6 = g2.Pic6;
                g.Pic7 = g2.Pic7;
                g.Pic8 = g2.Pic8;
                g.Pic9 = g2.Pic9;
                g.Pic10 = pictureBox10.ImageLocation;

                gr.UpdateGallery(g);

                MessageBox.Show("Uploaded!");
            }
                
        }

        private void btnRemove1_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = null;

            Gallery g2 = null;

            Gallery g = new Gallery();
            GalleryRepo gr = new GalleryRepo();
            g2 = gr.GetGalleryInfo(PhotographerName);

            g.UserName = PhotographerName;
            g.Pic1 = pictureBox1.ImageLocation;
            g.Pic2 = g2.Pic2;
            g.Pic3 = g2.Pic3;
            g.Pic4 = g2.Pic4;
            g.Pic5 = g2.Pic5;
            g.Pic6 = g2.Pic6;
            g.Pic7 = g2.Pic7;
            g.Pic8 = g2.Pic8;
            g.Pic9 = g2.Pic9;
            g.Pic10 = g2.Pic10;

            gr.UpdateGallery(g);

            MessageBox.Show("Removed!");
        }

        private void btnRemove2_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = null;

            Gallery g2 = null;

            Gallery g = new Gallery();
            GalleryRepo gr = new GalleryRepo();
            g2 = gr.GetGalleryInfo(PhotographerName);

            g.UserName = PhotographerName;
            g.Pic1 = g2.Pic1;
            g.Pic2 = pictureBox2.ImageLocation;
            g.Pic3 = g2.Pic3;
            g.Pic4 = g2.Pic4;
            g.Pic5 = g2.Pic5;
            g.Pic6 = g2.Pic6;
            g.Pic7 = g2.Pic7;
            g.Pic8 = g2.Pic8;
            g.Pic9 = g2.Pic9;
            g.Pic10 = g2.Pic10;

            gr.UpdateGallery(g);

            MessageBox.Show("Removed!");
        }

        private void btnremove3_Click(object sender, EventArgs e)
        {
            pictureBox3.ImageLocation = null;

            Gallery g2 = null;

            Gallery g = new Gallery();
            GalleryRepo gr = new GalleryRepo();
            g2 = gr.GetGalleryInfo(PhotographerName);

            g.UserName = PhotographerName;
            g.Pic1 = g2.Pic1;
            g.Pic2 = g2.Pic2;
            g.Pic3 = pictureBox3.ImageLocation;
            g.Pic4 = g2.Pic4;
            g.Pic5 = g2.Pic5;
            g.Pic6 = g2.Pic6;
            g.Pic7 = g2.Pic7;
            g.Pic8 = g2.Pic8;
            g.Pic9 = g2.Pic9;
            g.Pic10 = g2.Pic10;

            gr.UpdateGallery(g);

            MessageBox.Show("Removed!");
        }

        private void btnRemove4_Click(object sender, EventArgs e)
        {
            pictureBox4.ImageLocation = null;

            Gallery g2 = null;

            Gallery g = new Gallery();
            GalleryRepo gr = new GalleryRepo();
            g2 = gr.GetGalleryInfo(PhotographerName);

            g.UserName = PhotographerName;
            g.Pic1 = g2.Pic1;
            g.Pic2 = g2.Pic2;
            g.Pic3 = g2.Pic3;
            g.Pic4 = pictureBox4.ImageLocation;
            g.Pic5 = g2.Pic5;
            g.Pic6 = g2.Pic6;
            g.Pic7 = g2.Pic7;
            g.Pic8 = g2.Pic8;
            g.Pic9 = g2.Pic9;
            g.Pic10 = g2.Pic10;

            gr.UpdateGallery(g);

            MessageBox.Show("Removed!");
        }

        private void btnRemove5_Click(object sender, EventArgs e)
        {
            pictureBox5.ImageLocation = null;

            Gallery g2 = null;

            Gallery g = new Gallery();
            GalleryRepo gr = new GalleryRepo();
            g2 = gr.GetGalleryInfo(PhotographerName);

            g.UserName = PhotographerName;
            g.Pic1 = g2.Pic1;
            g.Pic2 = g2.Pic2;
            g.Pic3 = g2.Pic3;
            g.Pic4 = g2.Pic4;
            g.Pic5 = pictureBox5.ImageLocation;
            g.Pic6 = g2.Pic6;
            g.Pic7 = g2.Pic7;
            g.Pic8 = g2.Pic8;
            g.Pic9 = g2.Pic9;
            g.Pic10 = g2.Pic10;

            gr.UpdateGallery(g);

            MessageBox.Show("Removed!");
        }

        private void btnRemove6_Click(object sender, EventArgs e)
        {
            pictureBox6.ImageLocation = null;

            Gallery g2 = null;

            Gallery g = new Gallery();
            GalleryRepo gr = new GalleryRepo();
            g2 = gr.GetGalleryInfo(PhotographerName);

            g.UserName = PhotographerName;
            g.Pic1 = g2.Pic1;
            g.Pic2 = g2.Pic2;
            g.Pic3 = g2.Pic3;
            g.Pic4 = g2.Pic4;
            g.Pic5 = g2.Pic5;
            g.Pic6 = pictureBox6.ImageLocation;
            g.Pic7 = g2.Pic7;
            g.Pic8 = g2.Pic8;
            g.Pic9 = g2.Pic9;
            g.Pic10 = g2.Pic10;

            gr.UpdateGallery(g);

            MessageBox.Show("Removed!");
        }

        private void btnRemove7_Click(object sender, EventArgs e)
        {
            pictureBox7.ImageLocation = null;

            Gallery g2 = null;

            Gallery g = new Gallery();
            GalleryRepo gr = new GalleryRepo();
            g2 = gr.GetGalleryInfo(PhotographerName);

            g.UserName = PhotographerName;
            g.Pic1 = g2.Pic1;
            g.Pic2 = g2.Pic2;
            g.Pic3 = g2.Pic3;
            g.Pic4 = g2.Pic4;
            g.Pic5 = g2.Pic5;
            g.Pic6 = g2.Pic6;
            g.Pic7 = pictureBox7.ImageLocation;
            g.Pic8 = g2.Pic8;
            g.Pic9 = g2.Pic9;
            g.Pic10 = g2.Pic10;

            gr.UpdateGallery(g);

            MessageBox.Show("Removed!");
        }

        private void btnRemove8_Click(object sender, EventArgs e)
        {
            pictureBox8.ImageLocation = null;

            Gallery g2 = null;

            Gallery g = new Gallery();
            GalleryRepo gr = new GalleryRepo();
            g2 = gr.GetGalleryInfo(PhotographerName);

            g.UserName = PhotographerName;
            g.Pic1 = g2.Pic1;
            g.Pic2 = g2.Pic2;
            g.Pic3 = g2.Pic3;
            g.Pic4 = g2.Pic4;
            g.Pic5 = g2.Pic5;
            g.Pic6 = g2.Pic6;
            g.Pic7 = g2.Pic7;
            g.Pic8 = pictureBox8.ImageLocation;
            g.Pic9 = g2.Pic9;
            g.Pic10 = g2.Pic10;

            gr.UpdateGallery(g);

            MessageBox.Show("Removed!");
        }

        private void btnRemove9_Click(object sender, EventArgs e)
        {
            pictureBox9.ImageLocation = null;

            Gallery g2 = null;

            Gallery g = new Gallery();
            GalleryRepo gr = new GalleryRepo();
            g2 = gr.GetGalleryInfo(PhotographerName);

            g.UserName = PhotographerName;
            g.Pic1 = g2.Pic1;
            g.Pic2 = g2.Pic2;
            g.Pic3 = g2.Pic3;
            g.Pic4 = g2.Pic4;
            g.Pic5 = g2.Pic5;
            g.Pic6 = g2.Pic6;
            g.Pic7 = g2.Pic7;
            g.Pic8 = g2.Pic8;
            g.Pic9 = pictureBox9.ImageLocation;
            g.Pic10 = g2.Pic10;

            gr.UpdateGallery(g);

            MessageBox.Show("Removed!");
        }

        private void btnRemove10_Click(object sender, EventArgs e)
        {
            pictureBox10.ImageLocation = null;

            Gallery g2 = null;

            Gallery g = new Gallery();
            GalleryRepo gr = new GalleryRepo();
            g2 = gr.GetGalleryInfo(PhotographerName);

            g.UserName = PhotographerName;
            g.Pic1 = g2.Pic1;
            g.Pic2 = g2.Pic2;
            g.Pic3 = g2.Pic3;
            g.Pic4 = g2.Pic4;
            g.Pic5 = g2.Pic5;
            g.Pic6 = g2.Pic6;
            g.Pic7 = g2.Pic7;
            g.Pic8 = g2.Pic8;
            g.Pic9 = g2.Pic9;
            g.Pic10 = pictureBox10.ImageLocation;

            gr.UpdateGallery(g);

            MessageBox.Show("Removed!");
        }

        private void pbProfilePic_Click(object sender, EventArgs e)
        {

        }

        private void formPhotographerHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnDone.Visible = true;

            btnUpload1.Visible = true;
            btnUpload2.Visible = true;
            btnUpload3.Visible = true;
            btnUpload4.Visible = true;
            btnUpload5.Visible = true;
            btnUpload6.Visible = true;
            btnUpload7.Visible = true;
            btnUpload8.Visible = true;
            btnUpload9.Visible = true;
            btnUpload10.Visible = true;

            btnRemove1.Visible = true;
            btnRemove2.Visible = true;
            btnremove3.Visible = true;
            btnRemove4.Visible = true;
            btnRemove5.Visible = true;
            btnRemove6.Visible = true;
            btnRemove7.Visible = true;
            btnRemove8.Visible = true;
            btnRemove9.Visible = true;
            btnRemove10.Visible = true;
            
            btnEdit.Visible = false;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            btnEdit.Visible = true;

            btnUpload1.Visible = false;
            btnUpload2.Visible = false;
            btnUpload3.Visible = false;
            btnUpload4.Visible = false;
            btnUpload5.Visible = false;
            btnUpload6.Visible = false;
            btnUpload7.Visible = false;
            btnUpload8.Visible = false;
            btnUpload9.Visible = false;
            btnUpload10.Visible = false;

            btnRemove1.Visible = false;
            btnRemove2.Visible = false;
            btnremove3.Visible = false;
            btnRemove4.Visible = false;
            btnRemove5.Visible = false;
            btnRemove6.Visible = false;
            btnRemove7.Visible = false;
            btnRemove8.Visible = false;
            btnRemove9.Visible = false;
            btnRemove10.Visible = false;

            btnDone.Visible = false;
        }
    }
}
