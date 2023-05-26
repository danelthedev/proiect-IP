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
            Program.state = new ScheduleState(Program.state.Context);
            Program.state.loadPage();
        }

        private void buttonStandings_Click(object sender, EventArgs e)
        {
            Program.state = new StandingsState(Program.state.Context);
            Program.state.loadPage();
        }

        private void buttonTeams_Click(object sender, EventArgs e)
        {
            Program.state = new TeamsState(Program.state.Context);
            Program.state.loadPage();
        }

        private void buttonResults_Click(object sender, EventArgs e)
        {
            Program.state = new ResultsState(Program.state.Context);
            Program.state.loadPage();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Program.state.Context = this.mainPanel;
            //Program.state = new HomeState();
            //Program.state.loadPage();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proiect realizat de Arhip Alexandru Constantin, Hrițcu Marina Dumitrița și Imbrea Daniel.");
        }
    }
}
