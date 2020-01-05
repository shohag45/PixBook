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
    public partial class formPhotgraphersRequests : Form
    {
        public String PhotographerName { get; set; }
        HireRepo hr = new HireRepo();
        Hire  h = new Hire();

        public formPhotgraphersRequests(String PhotographerName)
        {
            InitializeComponent();
            this.PhotographerName = PhotographerName;
            dataGridView1.DataSource=hr.ShowAllPhotographerData(this.PhotographerName);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            formPhotographerHome ph = new formPhotographerHome(this.PhotographerName);
            ph.Show();
            this.Hide();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            formLogin1 lf = new formLogin1();
            lf.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            formPhotographerHome ph = new formPhotographerHome(this.PhotographerName);
            ph.Show();
            this.Hide();
        }

        private void formPhotgraphersRequests_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnAccept_Click(object sender, EventArgs e)
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
                MessageBox.Show("You Already Accepted the Request!");
            }
            else if (h != null)
            {
                MessageBox.Show("" + h.HireId);
                h.RequestStatus = 1;
                hr.UpdateHireInfo(h);
                MessageBox.Show("Request Accepted!");
                this.dataGridView1.DataSource = hr.ShowAllPhotographerData(this.PhotographerName);
            }
           
        }

        private void btnReject_Click(object sender, EventArgs e)
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
            }else if (h.RequestStatus==1)
            {
                MessageBox.Show("Request Already Accepted!\nYou Can't Reject Now!");
            }
            else if (h != null)
            {
                h.RequestStatus = 2;
                hr.UpdateHireInfo(h);
                MessageBox.Show("Request Rejected!");
                this.dataGridView1.DataSource = hr.ShowAllPhotographerData(this.PhotographerName);
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
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        private void formPhotgraphersRequests_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
