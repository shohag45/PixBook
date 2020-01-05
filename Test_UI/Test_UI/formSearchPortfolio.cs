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
    public partial class formSearchPortfolio : Form
    {
        public String UserName { get; set; }
        public formSearchPortfolio(String UserName)
        {
            InitializeComponent();
            btnExit.Click += BtnExit_Click;
            this.UserName = UserName;
            PersonRepo pr = new PersonRepo();
            PhotographerRepo pgr = new PhotographerRepo();
            //dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = pgr.ShowAllData();
        }
        

        private void BtnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            formUserHome uh = new formUserHome(UserName);
            uh.Show();
            this.Hide();
        }

        private void BtnSignOut_Click(object sender, EventArgs e)
        {
            formLogin1 lf = new formLogin1();
            lf.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1.CurrentRow.Selected = true;
                    String PhotographerName = dataGridView1.Rows[e.RowIndex].Cells["UserNameDB"].FormattedValue.ToString();
                    PersonRepo pr = new PersonRepo();
                    Persons p = null;
                    p = pr.GetPersonInfo(PhotographerName);
                    if (p == null)
                    {
                        MessageBox.Show("Person Does Not Exist or Blank Data!");
                    }
                    else
                    {
                        formPhotographerHome ph = new formPhotographerHome(PhotographerName, UserName);
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            formUserHome uh = new formUserHome(UserName);
            uh.Show();
            this.Hide();
        }

        private void formSearchPortfolio_Load(object sender, EventArgs e)
        {

        }

        private void formSearchPortfolio_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
