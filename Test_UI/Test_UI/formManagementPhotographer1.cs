using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using EntityPackages;
using RepositoryPackages;

namespace Test_UI
{
    public partial class formManagementPhotographer1 : Form
    {
        public String AdminName { get; set; }
        public formManagementPhotographer1(String AdminName)
        {
            InitializeComponent();
            btnExit.Click += BtnExit_Click;
            this.AdminName = AdminName;
            tbFullName.Focus();
            comboGender.Text = "";
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
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

        private void TbFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbFullName_Leave(object sender, EventArgs e)
        {
            Regex r = new Regex("^[a-zA-Z]");
            if (!r.IsMatch(tbFullName.Text))
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

        private void TbAge_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void RtbAddress_Leave(object sender, EventArgs e)
        {
            if (rtbAddress.Text == null)
            {
                MessageBox.Show("Address Can Not Be Empty!");
                //rtbAddress.Focus();
            }
            else if (rtbAddress.Text.Length > 100 || rtbAddress.Text.Length < 5)
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
            else if (tbPhn.Text.Length > 25 || tbPhn.Text.Length < 10)
            {
                MessageBox.Show("Phone Number Is Too Short or Long!");
                //tbPhn.Focus();
            }
        }

        private void TbExperience_Leave(object sender, EventArgs e)
        {
            int y;
            bool x = Int32.TryParse(tbExperience.Text, out y);
            if (x == false)
            {
                MessageBox.Show("Invalid Experience Years!");
            }
            else if(tbExperience.Text.Length >2 || tbExperience.Text.Length <= 0)
            {
                MessageBox.Show("Invalid Experience Years!");
            }
            else if (Convert.ToInt32(tbExperience.Text) > 30 || Convert.ToInt32(tbExperience.Text)<=0)
            {
                MessageBox.Show("Invalid Experience Years!");
            }
        }

        private void TbSalary_Leave(object sender, EventArgs e)
        {
            double y;
            bool x = double.TryParse(tbSalary.Text, out y);
            if (x == false)
            {
                MessageBox.Show("Please Enter Double/Decimal Format!");
            }
            else if(Convert.ToDouble(tbSalary.Text) > 50000 || Convert.ToDouble(tbSalary.Text) < 500)
            {
                MessageBox.Show("Fees Is Too Less or High!");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            GalleryRepo gr = new GalleryRepo();
            Gallery g = null;

            LoginInfo lf = null;
            LoginInfoRepo lr = new LoginInfoRepo();

            Random r = new Random();
            int VerificationCode = r.Next();

            String GenresString = null;
            Persons p = null;
            Photographers pg = null;
            PersonRepo pr = new PersonRepo();
            PhotographerRepo pgr = new PhotographerRepo();
            pg=pgr.GetPhotographer(tbUserName.Text);
            p = pr.GetPersonInfo(tbUserName.Text);
            foreach (String s in clbGenres.CheckedItems)
            {
                GenresString = GenresString + "+" + s;
            }
            if (p != null)
            {
                MessageBox.Show("Photographer Already Exist!");
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
            else if (comboGender.SelectedItem == null || comboGender.SelectedItem.Equals(null))
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
            else if (Convert.ToInt32(tbFullName.Text.Length) > 50 || Convert.ToInt32(tbFullName.Text.Length) < 5)
            {
                MessageBox.Show("Invalid Full Name!");
            }
            else if (Convert.ToInt32(tbUserName.Text.Length) > 50 || Convert.ToInt32(tbUserName.Text.Length) < 5)
            {
                MessageBox.Show("Invalid User Name!");
            }
            else if (pg != null)
            {
                MessageBox.Show("Photographer Already Exitst!");
            }
            else if (tbExperience.Text==null || tbExperience.Text.Equals(null))
            {
                MessageBox.Show("Experience Years Can Not Be Empty!");
            }
            else if(tbSalary.Text==null || tbSalary.Text.Equals(null))
            {
                MessageBox.Show("Fees  Can Not Be Empty!");
            }
            else if(GenresString.Equals(null) || GenresString == null)
            {
                MessageBox.Show("Please Select Genres!");
            }
            else if (clbGenres.CheckedItems == null)
            {
                MessageBox.Show("Please Select Genres!");
            }
            else
            {
                p = new Persons();
                pg = new Photographers();
                
                p.UserName = tbUserName.Text;
                p.FullName = tbFullName.Text;
                p.Password = mtbPass.Text;
                p.Age = Convert.ToInt32(tbAge.Text);
                p.Gender = Convert.ToInt32(comboGender.SelectedIndex);
                p.Address = rtbAddress.Text;
                p.Mail = tbMail.Text;
                p.Phone = Convert.ToInt32(tbPhn.Text);
                p.PersonType = Convert.ToInt32(2);
                p.ProfilePic = tbPic.Text.Trim();

                pg.UserName = tbUserName.Text;
                pg.Experience = Convert.ToInt32(tbExperience.Text);
                pg.Genres = GenresString;
                pg.Fees = Convert.ToDouble(tbSalary.Text);

                lf = new LoginInfo();
                lf.UserName = tbUserName.Text;
                lf.Password = mtbPass.Text;
                lf.VerificationCode = VerificationCode;

                g = new Gallery();
                g.UserName = tbUserName.Text;

                pr.InsertPerson(p);
                pgr.InsertPhotographer(pg);
                lr.InsertPersonLoginInfo(lf);
                gr.InsertIntoGallery(g);

                MessageBox.Show("Sign Up Complete!\nUser Name: " + pg.UserName + "\nPassword : " + p.Password);
                MessageBox.Show("Verification Code : " + lf.VerificationCode + "\nKeep the Verification Code Safe In Case You Forget Password!");


                tbFullName.Clear();
                tbUserName.Clear();
                mtbPass.Clear();
                mtbConfirmPass.Clear();
                tbAge.Clear();
                comboGender.Text= "";
                rtbAddress.Clear();
                tbMail.Clear();
                tbPhn.Clear();
                tbExperience.Clear();
                tbSalary.Clear();
                clbGenres.ClearSelected();
                tbPic.Clear();
            }

        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            HireRepo hr = new HireRepo();
            GalleryRepo gr = new GalleryRepo();

            LoginInfo lf = null;
            LoginInfoRepo lr = new LoginInfoRepo();
            lf = lr.GetLoginInfo(tbUserName.Text);

            PersonRepo pr = new PersonRepo();
            PhotographerRepo pgr = new PhotographerRepo();
            Photographers pg = null;
            Persons p = null;
            p = pr.GetPersonInfo(tbUserName.Text);
            pg = pgr.GetPhotographerInfo(tbUserName.Text);
            if (p == null || lr==null)
            {
                MessageBox.Show("User Doesn't Exists!");
            }
            else if (pg == null)
            {
                MessageBox.Show("User Doesn't Exists!");
            }
            else if (p.UserName.Equals(AdminName) || pg.UserName.Equals(AdminName))
            {
                MessageBox.Show("Can't Remove Yourself!");
            }
            else if (tbUserName.Text.Equals(null) || tbUserName.Text.Equals(""))
            {
                MessageBox.Show("Enter User Name to Remove!");
            }
            else if (p!=null && pg!=null)
            {
                lr.RemoveLoginInfo(tbUserName.Text);
                pr.RemovePerson(tbUserName.Text);
                pgr.RemovePhotographer(tbUserName.Text);
                hr.RemoveHireInfo(tbUserName.Text);
                gr.RemoveFromGallery(tbUserName.Text);

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
                tbSalary.Clear();
                tbExperience.Clear();
                clbGenres.ClearSelected();
                comboGender.Text = "";
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            PersonRepo pr = new PersonRepo();
            PhotographerRepo pgr = new PhotographerRepo();
            Photographers pg = null;
            Persons p = null;
            p = pr.GetPersonInfo(tbUserName.Text);
            pg = pgr.GetPhotographerInfo(tbUserName.Text);
            if(tbUserName.Text.Equals(null) || tbUserName.Text.Equals(""))
            {
                MessageBox.Show("Enter User Name to Search!");
            }
            else if (p != null && pg != null)
            {
                tbFullName.Text = p.FullName;
                tbUserName.Text = p.UserName;
                tbAge.Text = (p.Age).ToString();
                comboGender.SelectedIndex = p.Gender;
                rtbAddress.Text = p.Address;
                tbMail.Text = p.Mail;
                tbPhn.Text = (p.Phone).ToString();
                tbExperience.Text = (pg.Experience).ToString();
                tbSalary.Text = (pg.Fees).ToString();
                tbPic.Text = (p.ProfilePic).ToString();
                MessageBox.Show("Photographer Found!");
            }
            else
            {
                MessageBox.Show("Photographer Not Found!");
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            tbFullName.Clear();
            tbUserName.Clear();
            mtbPass.Clear();
            mtbConfirmPass.Clear();
            tbAge.Clear();
            comboGender.Text= "";
            rtbAddress.Clear();
            tbMail.Clear();
            tbPhn.Clear();
            tbExperience.Clear();
            tbSalary.Clear();
            clbGenres.ClearSelected();
            dataGridView1.DataSource = null;
            tbPic.Clear();
        }

        private void TbAge_Leave(object sender, EventArgs e)
        {
            int y;
            bool x = Int32.TryParse(tbAge.Text, out y);
            if (x == false)
            {
                MessageBox.Show("Invalid Age!");
                // tbAge.Focus();
            }
            else if (Convert.ToInt32(tbAge.Text) > 100 || Convert.ToInt32(tbAge.Text) < 5)
            {
                MessageBox.Show("Full Name Length Too Short or Long!");
                //  tbAge.Focus();
            }
        }

        private void BtnSignOut_Click(object sender, EventArgs e)
        {
            formLogin1 lf = new formLogin1();
            lf.Show();
            this.Hide();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            formAdminHome1 ah = new formAdminHome1(AdminName);
            ah.Show();
            this.Hide();
        }

        private void FormManagementPhotographer1_Load(object sender, EventArgs e)
        {

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            String GenresString = null;
            foreach(String s in clbGenres.CheckedItems)
            {
                GenresString += s;
            }

            LoginInfo lf = null;
            LoginInfoRepo lr = new LoginInfoRepo();
            lf = lr.GetLoginInfo(tbUserName.Text);

            LoginInfo lf3 = new LoginInfo();
            lf3 = lr.GetLoginInfo(tbUserName.Text);


            PersonRepo pr = new PersonRepo();
            Persons p1 = null;
            p1 = pr.GetPersonInfo(tbUserName.Text);

            Photographers pg1 = null;
            PhotographerRepo pgr = new PhotographerRepo();
            pg1 = pgr.GetPhotographer(tbUserName.Text);


            if (p1 == null || lf == null || pg1==null)
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
            else if (p1 != null && lf != null && pg1 != null)
            {
                Persons p2 = new Persons();
                LoginInfo lf2 = new LoginInfo();
                Photographers pg2 = new Photographers();

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
                p2.ProfilePic = tbPic.Text;

                pg2.UserName = tbUserName.Text;
                pg2.Experience = Convert.ToInt32(tbExperience.Text);
                pg2.Genres = GenresString;
                pg2.Fees = Convert.ToDouble(tbSalary.Text);

                pgr = new PhotographerRepo();
                pgr.UpdatePhotographer(pg2);
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
                tbExperience.Clear();
                tbSalary.Clear();
                clbGenres.ResetText();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            PersonRepo pr = new PersonRepo();
            PhotographerRepo pgr = new PhotographerRepo();
            //dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = pgr.ShowAllData();
            
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
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
                        formPhotographerHome ph = new formPhotographerHome(userName, AdminName);
                        ph.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        private void btnBrowseUserPic_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            tbPic.Text = openFileDialog1.FileName.ToString().Trim();
        }

        private void formManagementPhotographer1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
