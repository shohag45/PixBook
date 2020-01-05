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
    public partial class formUserRequests : Form
    {
        public int id;
        public HireRepo  hr = new HireRepo();
        public Hire h = new Hire();
        String UserName { get; set; }
        public formUserRequests(String UserName)
        {
            InitializeComponent();
            this.UserName = UserName;
            dataGridView1.DataSource = hr.ShowAllData(this.UserName);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            formUserHome uh = new formUserHome(UserName);
            uh.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            formUserHome uh = new formUserHome(UserName);
            uh.Show();
            this.Hide();
        }

        private void formUserRequests_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnCancelRequest_Click(object sender, EventArgs e)
        {
            try
            {
                h = hr.GetHireInfo(h.HireId);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            if (h == null)
            {
                MessageBox.Show("No Hiring Events Selected or Blank!");
            }
            else if (h.RequestStatus == 1)
            {
                MessageBox.Show("Your Request Already Accepted!\nYou Can't Cancel Now!");
            }
            else if (h != null)
            {
                MessageBox.Show("" + h.HireId);
                hr.RemoveHireInfo(h.HireId);
                this.dataGridView1.DataSource = hr.ShowAllData(this.UserName);
                MessageBox.Show("Request Cancelled!");
            }
        }
           

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
                var id = dataGridView1.SelectedRows[0].Cells[0].Value;
                //studentRegistrationForm.StudentId = (int)id;
                h.HireId = (int)id;
                this.id = (int)id;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            formLogin1 lf = new formLogin1();
            lf.Show();
            this.Hide();
        }

        private void formUserRequests_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
