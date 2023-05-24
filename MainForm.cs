using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoadingForms;

namespace F1Aggregator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonSchedule_Click(object sender, EventArgs e)
        {
            LoadForm.AddForms(this.mainPanel, new Schedule());
        }

        private void buttonStandings_Click(object sender, EventArgs e)
        {
            LoadForm.AddForms(this.mainPanel, new Standings());
        }

        private void buttonTeams_Click(object sender, EventArgs e)
        {
            LoadForm.AddForms(this.mainPanel, new Teams());

        }

        private void buttonResults_Click(object sender, EventArgs e)
        {
            LoadForm.AddForms(this.mainPanel, new Results());
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();
        }
    }
}
