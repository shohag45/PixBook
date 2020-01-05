using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RepositoryPackages;
using EntityPackages;

namespace Test_UI
{
    public partial class formHiring : Form
    {
        String PhotographerName { get; set; }
        String UserName { get; set; }
        public formHiring(String PhotographerName, String UserName)
        {
            InitializeComponent();
            this.PhotographerName = PhotographerName;
            this.UserName = UserName;
            PersonRepo pr = new PersonRepo();
            PhotographerRepo pgr = new PhotographerRepo();
            Persons p = null;
            Photographers pg = null;
            p = pr.GetPersonInfo(PhotographerName);
            pg = pgr.GetPhotographerInfo(PhotographerName);
            if(p==null && pg == null)
            {
                MessageBox.Show("Photographer Not Found!");
            }
            else
            {
                pbPhotographerInfoPic.ImageLocation = p.ProfilePic;
                String GenderType = null;
                if (p.Gender==0)
                {
                    GenderType = "Male";
                }
                else
                {
                    GenderType = "Female";
                }
                labelDetails.Text = p.UserName+"\nName : " +p.FullName+"\nAge : "+p.Age+"\nGender : "+GenderType+"\nAddress : "+p.Address+"\nMail : "+p.Mail+"\nPhone : "+p.Phone+"\nExperience : "+pg.Experience+"\nGenre : "+pg.Genres+"\nFees : "+pg.Fees;
            }
            
        }

        private void formHiring_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            formPhotographerHome ph = new formPhotographerHome(PhotographerName,UserName);
            ph.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            formLogin1 lf = new formLogin1();
            lf.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            formUserHome uh = new formUserHome(UserName);
            uh.Show();
            this.Hide();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            HireRepo hr = new HireRepo();
            Hire h = new Hire();

            Hire h2 = null;
            h.HireId = r.Next();
            h2 = hr.GetHireInfo(h.HireId);

            Hire h3 = new Hire();
            h3= hr.GetHireInfo(this.PhotographerName);
            if ( h3!=null && dtpHireFrom.Value >= h3.HireFrom && dtpHireTo.Value <= h3.HireTo )
            {
                MessageBox.Show("Photographer is Not Available!\nChoose Another Date-Time!");
            }
            else if(dtpHireFrom.Value < DateTime.Now || dtpHireTo.Value < DateTime.Now || dtpHireTo.Value > DateTime.Now.AddMonths(3) || dtpHireFrom.Value > DateTime.Now.AddMonths(3))
            {
                MessageBox.Show("Invalid Date-Time!");
            }
            else if (h3!=null && h3.UserName.Equals(this.UserName) && h.RequestStatus==0)
            {
                MessageBox.Show("You Already Have a Pending Request to This Photographer!\nSo You Can't Request Another One!");
            }
            else if (h2!=null)
            {
                MessageBox.Show("Hire Id Already Exists!\nPlease Click Again Request Button!");
            }
            else if (rtbPlace.Text.Equals(null) || rtbPlace.Text.Equals(""))
            {
                MessageBox.Show("Place is Empty!");
            }
            else if (dtpHireFrom.Value.Equals(null))
            {
                MessageBox.Show("Select Date Time!");
            }
            else if (dtpHireTo.Value.Equals(null))
            {
                MessageBox.Show("Select Date Time!");
            }
            else
            {
                h.UserName = this.UserName;
                h.PhotographerName = this.PhotographerName;
                h.HireFrom = dtpHireFrom.Value;
                h.HireTo = dtpHireTo.Value;
                h.Place = rtbPlace.Text;
                h.RequestStatus = 0;

                hr.InsertHireInfo(h);
                MessageBox.Show("Requested For Hiring!\nHire ID : " + h.HireId);
                rtbPlace.Clear();
                dtpHireFrom.ResetText();
                dtpHireTo.ResetText();
            } 
        }

        private void PhotographerInfoPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelLogo_Click(object sender, EventArgs e)
        {

        }

        private void pbPhotographerInfoPic_Click(object sender, EventArgs e)
        {

        }

        private void labelDetails_Click(object sender, EventArgs e)
        {

        }

        private void labelPhotographerInfo_Click(object sender, EventArgs e)
        {

        }

        private void labelHirePhotographer_Click(object sender, EventArgs e)
        {

        }

        private void labelStartDate_Click(object sender, EventArgs e)
        {

        }

        private void labelHireTo_Click(object sender, EventArgs e)
        {

        }

        private void dtpHireFrom_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpHireTo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void labelAddress_Click(object sender, EventArgs e)
        {

        }

        private void rtbPlace_TextChanged(object sender, EventArgs e)
        {

        }

        private void formHiring_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
