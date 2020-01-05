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
    
    public partial class formSignUp1 : Form
    {
        public formSignUp1()
        {
            InitializeComponent();
            btnExit.Click += BtnExit_Click;   
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void LabelAge_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void LabelPhotographerName_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            formLogin1 f1 = new formLogin1();
            f1.Show();
            this.Hide();
        }

        private void FormSignUp1_Load(object sender, EventArgs e)
        {
            comboGender.Items.Add("Male");
            comboGender.Items.Add("Female");

            comboGender.Text = "";
        }

        private void BtnSignUpUser_Click(object sender, EventArgs e)
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
            else if (rtbAddress.Text.Length > 100 || rtbAddress.Text.Length<5)
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
            else
            {
                p = new Persons();
                p.UserName = tbUserName.Text;
                p.FullName = tbFullName.Text;
                p.Password = mtbPass.Text;
                p.Age = Convert.ToInt32(tbAge.Text);
                p.Gender = Convert.ToInt32(comboGender.SelectedIndex);
                p.Address = rtbAddress.Text;
                p.Mail = tbMail.Text;
                p.Phone = Convert.ToInt32(tbPhn.Text);
                p.PersonType = Convert.ToInt32(1);
                p.ProfilePic = tbPic.Text;

                lf = new LoginInfo();
                lf.UserName = tbUserName.Text;
                lf.Password = mtbPass.Text;
                lf.VerificationCode = VerificationCode;

                pr.InsertPerson(p);
                lr.InsertPersonLoginInfo(lf);

                MessageBox.Show("Sign Up Complete!\nUser Name: "+p.UserName+"\nPassword : "+p.Password);
                MessageBox.Show("Verification Code : "+lf.VerificationCode+"\nKeep the Verification Code Safe In Case You Forget Password!");

                tbFullName.Clear();
                tbUserName.Clear();
                mtbPass.Clear();
                mtbConfirmPass.Clear();
                tbAge.Clear();
                rtbAddress.Clear();
                tbMail.Clear();
                tbPhn.Clear();
                comboGender.Text = "";
                clbGenres.ClearSelected();
                tbPic.Clear();
                pbProfilePic.Image = null;
            }
            
        }

        private void BtnSignUpAsPhotographer_Click(object sender, EventArgs e)
        {
            Gallery g = null;
            GalleryRepo gr = new GalleryRepo();

            LoginInfo lf = null;
            LoginInfoRepo lr = new LoginInfoRepo();

            Random r = new Random();
            int VerificationCode = r.Next();

            Persons p = null;
            Photographers pg = null;
            PersonRepo pr = new PersonRepo();
            p = pr.GetPersonInfo(tbUserName.Text);
            PhotographerRepo pgr = new PhotographerRepo();
            pg = pgr.GetPhotographerInfo(tbUserName.Text);
            String genres=null;

            if (p != null && p != null)
            {
                MessageBox.Show("Photographer Already Exist!");
            }
            else if (tbUserName.Text == null || tbUserName.Text.Equals(null) || tbUserName.Text.Equals(""))
            {
                MessageBox.Show("User Name Can Not Be Empty!");
            }
            else if (tbUserName.Text.Length > 50 || tbUserName.Text.Length<5)
            {
                MessageBox.Show("User Name Length is Too Long or Short!");
            }
            else if (tbFullName.Text == null || tbUserName.Text.Equals(null) || tbUserName.Text.Equals(""))
            {
                MessageBox.Show("Full Name Can Not Be Empty!");
            }
            else if (tbFullName.Text.Length > 50 || tbFullName.Text.Length<5)
            {
                MessageBox.Show("Full Name Length is Too Long or Short!");
            }
            else if (mtbPass.Text == null || mtbPass.Text.Equals(null) || mtbPass.Text.Equals(""))
            {
                MessageBox.Show("Password Can Not Be Empty!");
            }
            else if(mtbPass.Text.Length>15 || mtbPass.Text.Length < 6)
            {
                MessageBox.Show("Password Length is Too Long or Short!");
            }
            else if (mtbConfirmPass.Text == null || mtbConfirmPass.Text.Equals(null) || mtbConfirmPass.Text.Equals(""))
            {
                MessageBox.Show("Confirm Password Field Can Not Be Empty!");
            }
            else if(mtbConfirmPass.Text.Length > 15 || mtbConfirmPass.Text.Length < 6)
            {
                MessageBox.Show("Confirm Password Length is Too Long or Short!");
            }
            else if (tbAge.Text == null || tbAge.Text.Equals(null) || tbAge.Text.Equals(""))
            {
                MessageBox.Show("Age Can Not Be Empty!");
            }
            else if(tbAge.Text.Length > 2 ||  Convert.ToInt32(tbAge.Text)>=100)
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
            else if(rtbAddress.Text.Length>100 || rtbAddress.Text.Length < 5)
            {
                MessageBox.Show("Address Length is Too Short or Long!");
            }
            else if (tbMail.Text == null || tbMail.Text.Equals(null) || tbMail.Text.Equals(""))
            {
                MessageBox.Show("Mail Can Not Be Empty!");
            }
            else if (tbMail.Text.Length > 50 || tbMail.Text.Length<5)
            {
                MessageBox.Show("Mail Length Too Long or Short!");
            }
            else if (tbPhn.Text == null || tbPhn.Text.Equals(null) || tbPhn.Text.Equals(""))
            {
                MessageBox.Show("Phone Number Can Not Be Empty!");
            }
            else if(tbPhn.Text.Length>11 || tbPhn.Text.Length < 6)
            {
                MessageBox.Show("Phone Number Length Too Long or Short!");
            }
            else if (Convert.ToInt32(tbFullName.Text.Length) > 50 || Convert.ToInt32(tbFullName.Text.Length) < 5)
            {
                MessageBox.Show("Invalid Full Name!");
            }
            else if (Convert.ToInt32(tbUserName.Text.Length) > 50 || Convert.ToInt32(tbUserName.Text.Length) < 5)
            {
                MessageBox.Show("Invalid User Name!");
            }
            else if (clbGenres.SelectedItem == null || clbGenres.SelectedItem.Equals(null) || clbGenres.SelectedItem.Equals(""))
            {
                MessageBox.Show("Please Select Genres!");
            }
            else if (tbExperience.Text.Equals(null) || tbExperience.Text.Equals(""))
            {
                MessageBox.Show("Expereince Field Can't Be Empty!");
            }
            else if(Convert.ToInt32(tbExperience.Text)>10 || Convert.ToInt32(tbExperience.Text) <= 0)
            {
                MessageBox.Show("Invalid Experience Years!");
            }
            else if (tbFees.Text.Equals(null) || tbFees.Text.Equals(""))
            {
                MessageBox.Show("Fees Field Can't Be Empty!");
            }
            else if (Convert.ToDouble(tbFees.Text) > 100000 || Convert.ToDouble(tbFees.Text)<500)
            {
                MessageBox.Show("Invalid Fees!");
            }
            else
            {
                g = new Gallery();
                g.UserName = tbUserName.Text;
                gr.InsertIntoGallery(g);

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
                foreach (string s in clbGenres.CheckedItems)
                {
                    genres = genres + "+" + s;
                }
                pg.Genres = genres;
                pg.Fees = Convert.ToDouble(tbFees.Text);


                lf = new LoginInfo();
                lf.UserName = tbUserName.Text;
                lf.Password = mtbPass.Text;
                lf.VerificationCode = VerificationCode;

                pr.InsertPerson(p);
                pgr.InsertPhotographer(pg);
                lr.InsertPersonLoginInfo(lf);

                MessageBox.Show("Sign Up Complete!\nUser Name: " + pg.UserName + "\nPassword : " + p.Password);
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
                tbExperience.Clear();
                tbFees.Clear();
                clbGenres.ClearSelected();
                tbPic.Clear();
                clbGenres.ResetText();
                pbProfilePic.ImageLocation = null;
            }

        }

        private void ClbGenres_SelectedIndexChanged(object sender, EventArgs e)
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
            else if (tbExperience.Text.Length > 2 || tbExperience.Text.Length <= 0)
            {
                MessageBox.Show("Invalid Experience Years!");
            }
            else if (Convert.ToInt32(tbExperience.Text) > 30 || Convert.ToInt32(tbExperience.Text) <= 0)
            {
                MessageBox.Show("Invalid Experience Years!");
            }
        }

        private void TbFees_Leave(object sender, EventArgs e)
        {
            double y;
            bool x = double.TryParse(tbFees.Text, out y);
            if (x == false)
            {
                MessageBox.Show("Please Enter Double/Decimal Format!");
            }
            else if (Convert.ToDouble(tbFees.Text) > 50000 || Convert.ToDouble(tbFees.Text) < 500)
            {
                MessageBox.Show("Fees Is Too Less or High!");
            }
        }

        private void btnBrowseUserPic_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            tbPic.Text = openFileDialog1.FileName.ToString().Trim();
            pbProfilePic.ImageLocation = tbPic.Text.Trim();
        }

        private void formSignUp1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
