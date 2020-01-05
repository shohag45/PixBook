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
    public partial class formUserHome : Form
    {
        public String UserName { get; set; }
        public formUserHome(String UserName)
        {
            InitializeComponent();
            this.UserName = UserName;
            labelWelcome.Text = labelWelcome.Text + " " + UserName + "!";
            showDetails();
            btnExit.Click += BtnExit_Click;
            this.labelDetails.Text = "PixBook!\nIts Free and Easy!\nBest Way to Book Photgrapher for Your Events!\nTo Check Portfolios Click on 'Portfolios'\nTo Check Your Request Status Click on 'Requests!'";
        }

        private void FormUserHome_Load(object sender, EventArgs e)
        {

        }
        public void showDetails()
        {
            PersonRepo pr = new PersonRepo();
            Persons p = null;
            p = pr.GetPersonInfo(UserName);
            if (p != null)
            {
                labelNameGender.Text = p.FullName + "\n" + p.Age+" Years" + "\n";
                labelAddress.Text = p.Address + "\n" + p.Mail + "\n" + p.Phone;
                labelUserName.Text = p.UserName;
                pbProfilePic.ImageLocation = p.ProfilePic.Trim();
                if (p.PersonType == 3)
                {
                    btnRequests.Visible = false;
                    btnShowPortfolio.Visible = false;
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            formLogin1 lf = new formLogin1();
            lf.Show();
            this.Hide();
        }

        private void BtnSignOut_Click(object sender, EventArgs e)
        {
            formLogin1 lf = new formLogin1();
            lf.Show();
            this.Hide();
        }

        private void BtnShowPortfolio_Click(object sender, EventArgs e)
        {
            formSearchPortfolio sp = new formSearchPortfolio(UserName);
            sp.Show();
            this.Hide();
        }

        private void btnRequests_Click(object sender, EventArgs e)
        {
            formUserRequests fur = new formUserRequests(UserName);
            fur.Show();
            this.Hide();
        }

        private void formUserHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
