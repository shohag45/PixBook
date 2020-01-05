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
    public partial class fromForgotPassword : Form
    {
        public fromForgotPassword()
        {
            InitializeComponent();
            btnExit.Click += BtnExit_Click;
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            formLogin1 fh = new formLogin1();
            fh.Show();
            this.Hide();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            formLogin1 fh = new formLogin1();
            fh.Show();
            this.Hide();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void BtnGetPassword_Click(object sender, EventArgs e)
        {
            LoginInfo lf = null;
            LoginInfoRepo lr = new LoginInfoRepo();
            lf = lr.GetLoginInfo(rtbUserName.Text);
            if (lf == null)
            {
                MessageBox.Show("Invalid User Name or Verificaton Code!");
            }
            else if (rtbUserName.Text.Equals(null) || rtbUserName.Text == "")
            {
                MessageBox.Show("Invalid User Name!");
            }
            else if(rtbVerificationCode.Text.Equals(null) || rtbVerificationCode.Text.Equals(""))
            {
                MessageBox.Show("Invalid Verification Code!");
            }
            else if(lf!=null)
            {
                if (Convert.ToInt32(rtbVerificationCode.Text) != (lf.VerificationCode))
                {
                    MessageBox.Show("Invalid Verificatoin Code!");
                }

                else if (lf.VerificationCode.Equals(rtbVerificationCode.Text) || lf.VerificationCode == Convert.ToInt32(rtbVerificationCode.Text))
                {
                    rtbYourPassword.Enabled = false;
                    rtbYourPassword.Text = lf.Password;

                    rtbUserName2.Clear();
                    rtbPassword.Clear();
                    rtbNewPassword.Clear();
                    rtbConfirmPassword.Clear();
                  

                }
                else
                {
                    MessageBox.Show("Systematic Error!");
                }
                
            }
        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            Persons p = null;
            PersonRepo pr = new PersonRepo();
            p = pr.GetPersonInfo(rtbUserName2.Text);

            LoginInfo lf = null;
            LoginInfoRepo lr = new LoginInfoRepo();
            lf = lr.GetLoginInfo(rtbUserName2.Text);
            
            if(lf==null || p==null)
            {
                MessageBox.Show("Invalid User Name of Old Password!");
            }
            else if (!lf.Password.Equals(rtbPassword.Text) || !p.Password.Equals(rtbPassword.Text))
            {
                MessageBox.Show("Wrong Password Entered!");
            }
            else if (rtbUserName2.Text.Equals(null) || rtbPassword.Text.Equals(null))
            {
                MessageBox.Show("Empty User Name or Old Password!");
            }
            else if (!rtbNewPassword.Text.Equals(rtbConfirmPassword.Text))
            {
                MessageBox.Show("Passwords Didn't Match!");
            }
            else if (rtbPassword.Text.Equals(rtbNewPassword.Text))
            {
                MessageBox.Show("Can Not Change With Old Password!");
            }
            else if (rtbNewPassword.Text.Length < 6 || rtbNewPassword.Text.Length>30)
            {
                MessageBox.Show("New Password Is Too Short or Long!");
            }
            else if (rtbPassword.Text.Length < 6 || rtbPassword.Text.Length > 30)
            {
                MessageBox.Show("Old Password Is Too Short or Long!");
            }
            else if (rtbConfirmPassword.Text.Length < 6 || rtbConfirmPassword.Text.Length > 30)
            {
                MessageBox.Show("Confirm Password Is Too Short or Long!");
            }
            else if(lf!=null && p != null)
            {
                Random r = new Random();

                Persons p2 = new Persons();
                p2.UserName = p.UserName;
                p2.FullName = p.FullName;
                p2.Password = rtbNewPassword.Text;
                p2.Age = p.Age;
                p2.Address = p.Address;
                p2.Gender = p.Gender;
                p2.Mail = p.Mail;
                p2.Phone = p.Phone;
                p2.PersonType = p.PersonType;
                pr.UpdatePerson(p2);

                LoginInfo lf2 = new LoginInfo();
                lf2.UserName = lf.UserName;
                lf2.Password = rtbNewPassword.Text;
                lf2.VerificationCode = r.Next();
                lr.UpdateLoginInfo(lf2);

                MessageBox.Show("Password Changed!\nUser Name : "+lf2.UserName+"\nNew Password : "+lf2.Password);
                MessageBox.Show("Verificatino Code Has Been Also Changed!\nVerification Code : "+lf2.VerificationCode+"\nSave The Verification Code For Using If You Forget the Password!");

                rtbUserName.Clear();
                rtbLastPassword.Clear();
                rtbVerificationCode.Clear();
                rtbYourPassword.Clear();
            }
        }

        private void rtbUserName2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void rtbUserName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void rtbUserName2_Enter(object sender, EventArgs e)
        {
            rtbUserName.Clear();
            rtbLastPassword.Clear();
            rtbVerificationCode.Clear();
            rtbYourPassword.Clear();
        }

        private void rtbUserName_Enter(object sender, EventArgs e)
        {
            rtbUserName2.Clear();
            rtbPassword.Clear();
            rtbNewPassword.Clear();
            rtbConfirmPassword.Clear();
        }

        private void fromForgotPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
