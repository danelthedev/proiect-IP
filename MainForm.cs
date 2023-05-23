using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1Aggregator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void loadform(object Form)
        {
            if(this.mainPanel.Controls.Count > 0) 
            {
                this.mainPanel.Controls.RemoveAt(0);
            }
            Form frm = Form as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(frm);
            this.mainPanel.Tag = frm;
            frm.Show();
        }

        private void buttonSchedule_Click(object sender, EventArgs e)
        {
            loadform(new Schedule());
        }

        private void buttonStandings_Click(object sender, EventArgs e)
        {
            loadform(new Standings());
        }

        private void buttonTeams_Click(object sender, EventArgs e)
        {
            loadform(new Teams());
        }

        private void buttonResults_Click(object sender, EventArgs e)
        {
            loadform(new Results());
        }
    }
}
