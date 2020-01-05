using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test_UI
{
    public partial class formRequests : Form
    {
        String PhotographerName { get; set; }
        public formRequests(String PhotographerName)
        {
            InitializeComponent();
            this.PhotographerName = PhotographerName;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            formPhotographerHome ph = new formPhotographerHome(PhotographerName);
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
            formPhotographerHome ph = new formPhotographerHome(PhotographerName);
            ph.Show();
            this.Hide();
        }

        private void formRequests_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
