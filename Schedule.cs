using F1Aggregator.DynamicFormObjs;
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
    public partial class Schedule : Form
    {
        public Schedule()
        {
            InitializeComponent();
            //Making the cursor invisible
            ReadOnlyTBObjs readOnlyObjs = new ReadOnlyTBObjs(panelSchedule);
            readOnlyObjs.MakeObjReadOnly();
        }

        private void toolStripButtonResults1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.results.Show();
        }

        private void toolStripButtonStandings1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.standings.Show();
        }

        private void toolStripButtonTeams1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.teams.Show();
        }

        private void Schedule_Leave(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Schedule_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
