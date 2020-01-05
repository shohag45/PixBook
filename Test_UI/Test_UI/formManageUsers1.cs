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
using System.Text.RegularExpressions;

namespace Test_UI
{
    public partial class formManageUsers1 : Form
    {
        public String UserName { get; set; }
        public formManageUsers1(String UserName)
        {
            InitializeComponent();
            btnExit.Click += BtnExit_Click;
            this.UserName = UserName;
            comboGender.Text = "";
        }

        private void FormManageUsers1_Load(object sender, EventArgs e)
        {
            comboGender.Items.Add("Male");
            comboGender.Items.Add("Female");

            comboGender.Text = "";
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            formAdminHome1 Ah = new formAdminHome1(UserName);
            Ah.Show();
            this.Hide();
        }

        private void BtnSignOut_Click(object sender, EventArgs e)
        {
            formLogin1 login = new formLogin1();
            login.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LoginInfo lf = null;
            LoginInfoRepo lr = new LoginInfoRepo();

            Random r = new Random();
            int VerificationCode = r.Next();

            Persons p = null;
            PersonRepo pr = new PersonRepo();
            p = pr.GetPersonInfo(tbUserName.Text);
            if (p != null)
            {
                MessageBox.Show("User Already Exist!");
            }
            else if (tbPhn.Text.Length > 11 || tbPhn.Text.Length < 6)
            {
                MessageBox.Show("Phone Number Too Long or Short!");
            }
            else if (tbUserName.Text == null || tbUserName.Text.Equals(null) || tbUserName.Text.Equals(""))
            {
                MessageBox.Show("User Name Can Not Be Empty!");
            }
            else if (tbUserName.Text.Length > 50 || tbUserName.Text.Length < 3)
            {
                MessageBox.Show("UserName is Too Long or Short!");
            }
            else if (tbFullName.Text == null || tbFullName.Text.Equals(null) || tbFullName.Text.Equals(""))
            {
                MessageBox.Show("Full Name Can Not Be Empty!");
            }
            else if (tbFullName.Text.Length > 50 || tbFullName.Text.Length < 3)
            {
                MessageBox.Show("Full Name Length is Too Long or Short!");
            }
            else if (mtbPass.Text == null || mtbPass.Text.Equals(null) || mtbPass.Text.Equals(""))
            {
                MessageBox.Show("Password Can Not Be Empty!");
            }
            else if (mtbPass.Text.Length > 15)
            {
                MessageBox.Show("Password Length Too Long!");
            }
            else if (mtbConfirmPass.Text == null || mtbConfirmPass.Text.Equals(null) || mtbConfirmPass.Text.Equals(""))
            {
                MessageBox.Show("Confirm Password Field Can Not Be Empty!");
            }
            else if (mtbConfirmPass.Text.Length > 15)
            {
                MessageBox.Show("Confirm Password Length Too Long!");
            }
            else if (tbAge.Text == null || tbAge.Text.Equals(null) || tbAge.Text.Equals(""))
            {
                MessageBox.Show("Age Can Not Be Empty!");
            }
            else if (tbAge.Text.Length > 2 || Convert.ToInt32(tbAge.Text) >= 100)
            {
                MessageBox.Show("Invalid Age!");
            }
            else if (comboGender.SelectedItem == null || comboGender.SelectedItem.Equals(null))
            {
                MessageBox.Show("Please Select Gender!");
            }
            else if (rtbAddress.Text == null || rtbAddress.Text.Equals(null) || rtbAddress.Text.Equals(""))
            {
                MessageBox.Show("Address Can Not Be Empty!");
            }
            else if (rtbAddress.Text.Length > 100 || rtbAddress.Text.Length < 5)
            {
                MessageBox.Show("Address Length Too Short or Long!");
            }
            else if (tbMail.Text == null || tbMail.Text.Equals(null) || tbMail.Text.Equals(""))
            {
                MessageBox.Show("Mail Can Not Be Empty!");
            }
            else if (tbPhn.Text == null || tbPhn.Text.Equals(null) || tbPhn.Text.Equals(""))
            {
                MessageBox.Show("Phone Number Can Not Be Empty!");
            }
            else if (Convert.ToInt32(tbFullName.Text.Length) > 50 || Convert.ToInt32(tbFullName.Text.Length) < 5)
            {
                MessageBox.Show("Invalid Full Name!");
            }
            else if (Convert.ToInt32(tbUserName.Text.Length) > 50 || Convert.ToInt32(tbUserName.Text.Length) < 5)
            {
                MessageBox.Show("Invalid User Name!");
            }
            else if (tbUserName.Text == null)
            {
                MessageBox.Show("User Name Can Not Be Empty!");
            }
            else if (tbFullName.Text == null)
            {
                MessageBox.Show("Full Name Can Not Be Empty!");
            }
            else if (mtbPass.Text == null)
            {
                MessageBox.Show("Password Can Not Be Empty!");
            }
            else if (mtbConfirmPass.Text == null)
            {
                MessageBox.Show("Confirm Password Field Can Not Be Empty!");
            }
            else if (tbAge.Text == null)
            {
                MessageBox.Show("Age Can Not Be Empty!");
            }
            else if (comboGender.SelectedItem == null || comboGender.SelectedItem.Equals(""))
            {
                MessageBox.Show("Please Select Gender!");
            }
            else if (rtbAddress.Text == null)
            {
                MessageBox.Show("Address Can Not Be Empty!");
            }
            else if (tbMail.Text == null)
            {
                MessageBox.Show("Mail Can Not Be Empty!");
            }
            else if (tbPhn.Text == null)
            {
                MessageBox.Show("Phone Number Can Not Be Empty!");
            }
            else if(Convert.ToInt32(tbFullName.Text.Length) >50 || Convert.ToInt32(tbFullName.Text.Length) < 5)
            {
                MessageBox.Show("Invalid Full Name!");
            }
            else if(Convert.ToInt32(tbUserName.Text.Length) >50 || Convert.ToInt32(tbUserName.Text.Length) < 5)
            {
                MessageBox.Show("Invalid User Name!");
            }
            else if(tbPic.Text.Equals(null) || tbPic.Text.Equals(""))
            {
                MessageBox.Show("No Image Selected!");
            }
            else
            {
                p = new Persons();
                p.UserName = tbUserName.Text;
                p.FullName = tbFullName.Text;
                p.Password = mtbPass.Text;
                try
                {
                    p.Age = Convert.ToInt32(tbAge.Text);
                }
                catch(Exception Ex)
                {
                    Console.WriteLine(Ex.Message);
                    MessageBox.Show("Invalid Age Type!");
                }
                
                p.Gender = Convert.ToInt32(comboGender.SelectedIndex);
                p.Address = rtbAddress.Text;
                p.Mail = tbMail.Text;
                p.Phone = Convert.ToInt32(tbPhn.Text);
                p.PersonType = Convert.ToInt32(1);
                p.ProfilePic = tbPic.Text.Trim();

                lf = new LoginInfo();
                lf.UserName = tbUserName.Text;
                lf.Password = mtbPass.Text;
                lf.VerificationCode = VerificationCode;

                lr.InsertPersonLoginInfo(lf);
                pr.InsertPerson(p);

                MessageBox.Show("Sign Up Complete!\nUser Name: " + p.UserName + "\nPassword : " + p.Password);
                MessageBox.Show("Verification Code : " + lf.VerificationCode + "\nKeep the Verification Code Safe In Case You Forget Password!");

                tbFullName.Clear();
                tbUserName.Clear();
                mtbPass.Clear();
                mtbConfirmPass.Clear();
                tbAge.Clear();
                comboGender.Text = "";
                rtbAddress.Clear();
                tbMail.Clear();
                tbPhn.Clear();
                tbPic.Clear();
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            formAdminHome1 ah = new formAdminHome1(UserName);
            ah.Show();
            this.Hide();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {

            PersonRepo pr = new PersonRepo();
            Persons p = null;
            p = pr.GetPersonInfo(tbUserName.Text);
            if (tbUserName.Text.Equals(null) || tbUserName.Text.Equals(""))
            {
                MessageBox.Show("Enter User Name to Search!");
            }
            else if (p != null)
            {
                tbFullName.Text = p.FullName;
                tbUserName.Text = p.UserName;
                tbAge.Text = (p.Age).ToString();
                comboGender.SelectedIndex = p.Gender;
                rtbAddress.Text = p.Address;
                tbMail.Text = p.Mail;
                tbPhn.Text = (p.Phone).ToString();
                tbPic.Text = p.ProfilePic;
                MessageBox.Show("User Found!");
                dataGridView1.DataSource = null;
            }
            else
            {
                MessageBox.Show("User Not Found!");
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            HireRepo hr = new HireRepo();
            LoginInfo lf = null;
            LoginInfoRepo lr = new LoginInfoRepo();
            lf = lr.GetLoginInfo(tbUserName.Text);

            PersonRepo pr = new PersonRepo();
            Persons p = pr.GetPersonInfo(tbUserName.Text);

            if (p == null || lr== null)
            {
                MessageBox.Show("User Doesn't Exists!");
            }
            else if (p.UserName.Equals(UserName))
            {
                MessageBox.Show("Can't Remove Yourself!");
            }
            else if (tbUserName.Text.Equals(null) || tbUserName.Text.Equals(""))
            {
                MessageBox.Show("Enter User Name to Delete!");
            }
            else
            {
                lr.RemoveLoginInfo(tbUserName.Text);
                pr.RemovePerson(tbUserName.Text);
                hr.RemoveHireInfo(tbUserName.Text);
                MessageBox.Show("User Removed!");
                tbFullName.Clear();
                tbUserName.Clear();
                mtbPass.Clear();
                mtbConfirmPass.Clear();
                tbAge.Clear();
                comboGender.Text = "";
                rtbAddress.Clear();
                tbMail.Clear();
                tbPhn.Clear();
                tbPic.Clear();
            }
            
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            LoginInfo lf = null;
            LoginInfoRepo lr = new LoginInfoRepo();
            lf = lr.GetLoginInfo(tbUserName.Text);

            LoginInfo lf3 = new LoginInfo();
            lf3 = lr.GetLoginInfo(tbUserName.Text);


            PersonRepo pr = new PersonRepo();
            Persons p1 = null;
            p1 = pr.GetPersonInfo(tbUserName.Text);

            if (p1 == null || lf == null)
            {
                MessageBox.Show("User Not Found!");
            }
            else if (tbPhn.Text.Length > 11 || tbPhn.Text.Length < 6)
            {
                MessageBox.Show("Phone Number Too Long or Short!");
            }
            else if (tbUserName.Text == null || tbUserName.Text.Equals(null) || tbUserName.Text.Equals(""))
            {
                MessageBox.Show("User Name Can Not Be Empty!");
            }
            else if (tbUserName.Text.Length > 50 || tbUserName.Text.Length < 3)
            {
                MessageBox.Show("UserName is Too Long or Short!");
            }
            else if (tbFullName.Text == null || tbFullName.Text.Equals(null) || tbFullName.Text.Equals(""))
            {
                MessageBox.Show("Full Name Can Not Be Empty!");
            }
            else if (tbFullName.Text.Length > 50 || tbFullName.Text.Length < 3)
            {
                MessageBox.Show("Full Name Length is Too Long or Short!");
            }
            else if (tbAge.Text == null || tbAge.Text.Equals(null) || tbAge.Text.Equals(""))
            {
                MessageBox.Show("Age Can Not Be Empty!");
            }
            else if (tbAge.Text.Length > 2 || Convert.ToInt32(tbAge.Text) >= 100)
            {
                MessageBox.Show("Invalid Age!");
            }
            else if (comboGender.SelectedItem == null || comboGender.SelectedItem.Equals(null))
            {
                MessageBox.Show("Please Select Gender!");
            }
            else if (rtbAddress.Text == null || rtbAddress.Text.Equals(null) || rtbAddress.Text.Equals(""))
            {
                MessageBox.Show("Address Can Not Be Empty!");
            }
            else if (rtbAddress.Text.Length > 100 || rtbAddress.Text.Length < 5)
            {
                MessageBox.Show("Address Length Too Short or Long!");
            }
            else if (tbMail.Text == null || tbMail.Text.Equals(null) || tbMail.Text.Equals(""))
            {
                MessageBox.Show("Mail Can Not Be Empty!");
            }
            else if (tbPhn.Text == null || tbPhn.Text.Equals(null) || tbPhn.Text.Equals(""))
            {
                MessageBox.Show("Phone Number Can Not Be Empty!");
            }
            else if (Convert.ToInt32(tbFullName.Text.Length) > 50 || Convert.ToInt32(tbFullName.Text.Length) < 5)
            {
                MessageBox.Show("Invalid Full Name!");
            }
            else if (Convert.ToInt32(tbUserName.Text.Length) > 50 || Convert.ToInt32(tbUserName.Text.Length) < 5)
            {
                MessageBox.Show("Invalid User Name!");
            }
            else if (!p1.UserName.Equals(tbUserName.Text))
            {
                MessageBox.Show("Can't Change User Name!\nIt is Unique!");
            }
            else if (tbPic.Text.Equals(null) || tbPic.Text.Equals(""))
            {
                MessageBox.Show("No Image Selected!");
            }
            else if (p1 != null && lf != null)
            {
                Persons p2 = new Persons();
                LoginInfo lf2 = new LoginInfo();

                lf2.UserName = tbUserName.Text;
                lf2.Password = p1.Password;
                lf2.VerificationCode = lf3.VerificationCode;

                p2.UserName = tbUserName.Text;
                p2.FullName = tbFullName.Text;
                p2.Password = p1.Password;
                p2.Age = Convert.ToInt32(tbAge.Text);
                p2.Gender = Convert.ToInt32(comboGender.SelectedIndex);
                p2.Address = rtbAddress.Text;
                p2.Mail = tbMail.Text;
                p2.Phone = Convert.ToInt32(tbPhn.Text);
                p2.PersonType = 1;
                p2.ProfilePic = tbPic.Text.Trim();

                pr = new PersonRepo();
                pr.UpdatePerson(p2);
                lr = new LoginInfoRepo();
                lr.UpdateLoginInfo(lf2);

                MessageBox.Show("User Updated!");
                tbFullName.Clear();
                tbUserName.Clear();
                mtbPass.Clear();
                mtbConfirmPass.Clear();
                tbAge.Clear();
                comboGender.Text = "";
                rtbAddress.Clear();
                tbMail.Clear();
                tbPhn.Clear();
                tbPic.Clear();
            }
           
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            tbFullName.Clear();
            tbUserName.Clear();
            mtbPass.Clear();
            mtbConfirmPass.Clear();
            tbAge.Clear();
            comboGender.SelectedIndex = 0;
            rtbAddress.Clear();
            tbMail.Clear();
            tbPhn.Clear();
            tbPic.Clear();
            comboGender.Text = "";
            dataGridView1.DataSource = null;
        }

        private void TbFullName_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void TbUserName_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void MtbPass_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void MtbPass_Leave(object sender, EventArgs e)
        {
            Regex r = new Regex("^[a-zA-Z0-9]*$");
            if (!r.IsMatch(tbUserName.Text))
            {
                MessageBox.Show("Password Can Only Be Alpha-Numeric!");
              //  mtbPass.Focus();
            }
            else if (Convert.ToInt32(mtbPass.Text.Length) > 50 || Convert.ToInt32(mtbPass.Text.Length) < 8)
            {
                MessageBox.Show("Password Length Too Short or Long!");
             //    mtbPass.Focus();
            }
        }

        private void MtbConfirmPass_Leave(object sender, EventArgs e)
        {
            Regex r = new Regex("^[a-zA-Z0-9]*$");
            if (!(mtbPass.Text).Equals(mtbConfirmPass.Text))
            {
                MessageBox.Show("Passwords Did Not Match!");
              //  mtbConfirmPass.Focus();
            }
            else if (!r.IsMatch(tbUserName.Text))
            {
                MessageBox.Show("Password Can Only Be Alpha-Numeric!");
               // mtbConfirmPass.Focus();
            }
            else if (Convert.ToInt32(mtbPass.Text.Length) > 50 || Convert.ToInt32(mtbPass.Text.Length) < 8)
            {
                MessageBox.Show("Password Length Too Short or Long!");
              // mtbConfirmPass.Focus();
            }
        }

        private void TbUserName_Leave(object sender, EventArgs e)
        {
            Persons p = null;
            PersonRepo pr = new PersonRepo();
            p = pr.GetPersonInfo(tbUserName.Text);

            Regex r = new Regex("^[a-zA-Z0-9]*$");
            if (!r.IsMatch(tbUserName.Text))
            {
                MessageBox.Show("User Name Can Only Be Alpha-Numeric!");
                //tbUserName.Focus();
            }
            else if (Convert.ToInt32(tbUserName.Text.Length) > 50 || Convert.ToInt32(tbUserName.Text.Length) < 5)
            {
                MessageBox.Show("User Name Length Too Short or Long!");
                //tbUserName.Focus();
            }
            /*if (p != null)
            {
                MessageBox.Show("User Name Already Exists!\n Try Another UserName!");
                //tbUserName.Focus();
            }*/
        }

        private void TbFullName_Leave(object sender, EventArgs e)
        {
            Regex r = new Regex("^[a-zA-Z]");
            if (r.IsMatch(tbFullName.Text))
            {
                MessageBox.Show("Full Name Should Be Only Alphabetic!");
                //tbFullName.Focus();
            }
            else if (Convert.ToInt32(tbFullName.Text.Length) > 50 || Convert.ToInt32(tbFullName.Text.Length) < 5)
            {
                MessageBox.Show("Full Name Length Too Short or Long!");
                //tbFullName.Focus();
            }

        }

        private void TbAge_Leave(object sender, EventArgs e)
        {
            int y;
            bool x=Int32.TryParse(tbAge.Text, out y);
            if (x == false)
            {
                MessageBox.Show("Invalid Age!");
               // tbAge.Focus();
            }
            else if (Convert.ToInt32(tbAge.Text) > 100 || Convert.ToInt32(tbAge.Text) < 5)
            {
                MessageBox.Show("Age is Too Short or Long!");
              //  tbAge.Focus();
            }
        }

        private void RtbAddress_Leave(object sender, EventArgs e)
        {
            if (rtbAddress.Text == null)
            {
                MessageBox.Show("Address Can Not Be Empty!");
                //rtbAddress.Focus();
            }
            else if (rtbAddress.Text.Length >100 || rtbAddress.Text.Length<5)
            {
                MessageBox.Show("Address Is Too Short or Long!");
                //rtbAddress.Focus();
            }
        }

        private void TbMail_Leave(object sender, EventArgs e)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

            Regex re = new Regex(strRegex);

            if (tbMail.Text.Length > 50 || tbMail.Text.Length < 5)
            {
                MessageBox.Show("Mail Is Too Short or Long!");
                //tbMail.Focus();
            }
            else if (!re.IsMatch(tbMail.Text))
            {
                MessageBox.Show("Invalid Mail Address Format!");
                //tbMail.Focus();
            }
        }

        private void TbPhn_Leave(object sender, EventArgs e)
        {
            Regex re = new Regex("[0-9]");

            if (!re.IsMatch(tbPhn.Text))
            {
                MessageBox.Show("Phone Number Must Be Only Numerical!");
                //tbPhn.Focus();
            }
            else if (tbPhn.Text.Length > 11 || tbPhn.Text.Length < 6)
            {
                MessageBox.Show("Phone Number Is Too Short or Long!");
                //tbPhn.Focus();
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            PersonRepo pr = new PersonRepo();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = pr.ShowAllData(1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBrowseUserPic_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            tbPic.Text = openFileDialog1.FileName.ToString().Trim();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                String userName = dataGridView1.Rows[e.RowIndex].Cells["UserNameDB"].FormattedValue.ToString();
                PersonRepo pr = new PersonRepo();
                Persons p = null;
                p = pr.GetPersonInfo(userName);
                if (p == null)
                {
                    MessageBox.Show("Person Does Not Exist!");
                }
                else
                {
                    formUserHome uh = new formUserHome(UserName);
                    uh.Show();
                    this.Hide();
                }
            }*/
        }

        private void comboGender_Leave(object sender, EventArgs e)
        {
            try
            {
                if (comboGender.SelectedItem.Equals(null))
                {
                    MessageBox.Show("Select Gender!");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Select Gender!");            }
            
        }

        private void formManageUsers1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
