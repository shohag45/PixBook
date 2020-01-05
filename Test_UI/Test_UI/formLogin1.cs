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
    public partial class formLogin1 : Form
    {
        public formLogin1()
        {
            InitializeComponent();
            rtbUserName.Focus();
        }

        private void RtbUserName_Enter(object sender, EventArgs e)
        {
            if(rtbUserName.Text == "User Name")
            {
                rtbUserName.Text = null;
                rtbUserName.ForeColor = Color.Black;
            }
        }

        private void RtbUserName_Leave(object sender, EventArgs e)
        {
            if (rtbUserName.Text == "")
            {
                rtbUserName.Text = "User Name";
                rtbUserName.ForeColor = Color.DarkGray;
            }
        }

        private void RtbPassword_Leave(object sender, EventArgs e)
        {

            
        }

        private void RtbPassword_Enter(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }


        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            formSignUp1 sf = new formSignUp1();
            sf.Show();
            this.Hide();
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            PersonRepo pr = new PersonRepo();
            Persons p1 = pr.GetPerson(rtbUserName.Text, mtbPass.Text);
            Persons p2 = pr.GetPersonInfo(rtbUserName.Text);

            if (rtbUserName.Text.Equals(null) || rtbUserName.Text == null)
            {
                MessageBox.Show("Please Enter User Name!");
            }
            else if(rtbUserName.Text.Equals("User Name"))
            {
                MessageBox.Show("Please Enter User Name!");
            }
            else if(mtbPass.Text.Equals(null) || mtbPass.Text == null)
            {
                MessageBox.Show("Please Enter Password!");
            }
            else if (mtbPass.Text.Equals("Password"))
            {
                MessageBox.Show("Please Enter Password!");
            }
            else if(p1 == null)
            {
                MessageBox.Show("Incorrect User Name or Password!");
            }
            else if (p2 == null)
            {
                MessageBox.Show("Incorrect User Name or Password!");
            }
            else if (p1 != null)
            {
                if(p1.PersonType == 3)
                {
                    formAdminHome1 ah = new formAdminHome1(rtbUserName.Text);
                    ah.Show();
                    this.Hide();
                }
                else if(p1.PersonType == 2)
                {
                    formPhotographerHome ph = new formPhotographerHome(p1.UserName);
                    ph.Show();
                    this.Hide();
                }
                else if(p1.PersonType == 1)
                {
                    formUserHome uh = new formUserHome(p1.UserName);
                    uh.Show();
                    this.Hide();
                }
            }
        }

        private void PanelSignIn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MtbPass_Enter(object sender, EventArgs e)
        {
            if (mtbPass.Text == "Password")
            {
                mtbPass.Text = null;
                mtbPass.ForeColor = Color.Black;
            }
        }

        private void MtbPass_Leave(object sender, EventArgs e)
        {

            if (mtbPass.Text == "")
            {
                mtbPass.Text = "Password";
                mtbPass.ForeColor = Color.DarkGray;
            }
        }

        private void RtbUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnForgotPass_Click(object sender, EventArgs e)
        {
            fromForgotPassword fh = new fromForgotPassword();
            fh.Show();
            this.Hide();
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void formLogin1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
