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
    public partial class formAdminHome1 : Form
    {
        public HireRepo hr = new HireRepo();
        PersonRepo pr = new PersonRepo();
        PhotographerRepo pgr = new PhotographerRepo();

        int Pending, Accepted, Rejected;
        public String AdminName { get; set; }
        public formAdminHome1(String AdminName)
        {
            InitializeComponent();
            this.AdminName = AdminName;
            btnExit.Click += BtnExit_Click;
            labelWelcome.Text = labelWelcome.Text +" "+ AdminName+"!";
            hr.GetHireInfoCount(out Pending, out Accepted, out Rejected);
            labelInfo.Text ="User Count : "+(pr.GetPeronsCount()-pgr.GetPhotographerCount())+"\n\nPhotographer Count : "+pgr.GetPhotographerCount()+"\n\nHire Requests Count : "+hr.GetHireCount().ToString()+"\n\nPending Requests : "+Pending+"\n\nAccepted Requests : "+Accepted+"\n\nRejected Requests : "+Rejected;
        }
        
        private void BtnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void FormAdminHome1_Load(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            formLogin1 loginFrame = new formLogin1();
            loginFrame.Show();
            this.Hide();
        }

        private void BtnSignOut_Click(object sender, EventArgs e)
        {
            formLogin1 loginFrame = new formLogin1();
            loginFrame.Show();
            this.Hide();
        }

        private void BtnManageUser_Click(object sender, EventArgs e)
        {
            formManageUsers1 UserManagementForm = new formManageUsers1(AdminName);
            UserManagementForm.Show();
            this.Hide();
        }

        private void formAdminHome1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void BtnManagePhotographer_Click(object sender, EventArgs e)
        {
            formManagementPhotographer1 PhotographerManagementForm = new formManagementPhotographer1(AdminName);
            PhotographerManagementForm.Show();
            this.Hide();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {

        }
    }
}
