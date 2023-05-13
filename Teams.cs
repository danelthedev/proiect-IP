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
    public partial class Teams : Form
    {
        public Teams()
        {
            InitializeComponent();
            ReadOnlyTBObjs readOnlyObjs = new ReadOnlyTBObjs(panelTeams);
            readOnlyObjs.MakeObjReadOnly();
        }

        private void toolStripButtonSchedule4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.schedule.Show();
        }

        private void toolStripButtonResults4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.results.Show();
        }

        private void toolStripButtonStandings4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.standings.Show();
        }

        private void Teams_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
