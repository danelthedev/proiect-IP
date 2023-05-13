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
    public partial class Standings : Form
    {
        private DataGridView _dataGridView1, _dataGridView2;
        public Standings()
        {
            InitializeComponent();
        }

        private void toolStripButtonSchedule3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.schedule.Show();
        }

        private void toolStripButtonResults3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.results.Show();
        }

        private void toolStripButtonTeams3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.teams.Show();
        }

        private void buttonStandingsPlayers_Click(object sender, EventArgs e)
        {
            panelStandings.Controls.Clear();
            CreateDynamicTablePlayers();
        }

        private void buttonStandingsTeams_Click(object sender, EventArgs e)
        {
            panelStandings.Controls.Clear();
            CreateDynamicTableTeams();
        }

        private void CreateDynamicTablePlayers()
        {
            //Create the DataGridView
            _dataGridView1 = new DataGridView();

            //Set properties for the DataGridView
            _dataGridView1.Name = "dynamicDataGridView";
            _dataGridView1.Location = new Point(30, 10);
            _dataGridView1.Size = new Size(1000, 500);

            //Add the DataGridView to the form's controls
            panelStandings.Controls.Add(_dataGridView1);

            //Add columns to the DataGridView
            _dataGridView1.Columns.Add("Position", "Position");
            _dataGridView1.Columns["Position"].Width = 200;

            _dataGridView1.Columns.Add("Name", "Name");
            _dataGridView1.Columns["Name"].Width = 200;

            _dataGridView1.Columns.Add("Nationality", "Nationality");
            _dataGridView1.Columns["Nationality"].Width = 200;

            _dataGridView1.Columns.Add("Car", "Car");
            _dataGridView1.Columns["Car"].Width = 200;

            _dataGridView1.Columns.Add("Points", "Points");
            _dataGridView1.Columns["Points"].Width = 157;


            //Add rows to the DataGridView
            _dataGridView1.Rows.Add("Value1", "Value2", "Value3", "Value4", "Value5");
        }

        private void Standings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CreateDynamicTableTeams()
        {
            //Create the DataGridView
            _dataGridView2 = new DataGridView();

            //Set properties for the DataGridView
            _dataGridView2.Name = "dynamicDataGridView";
            _dataGridView2.Location = new Point(30, 10);
            _dataGridView2.Size = new Size(1000, 500);

            //Add the DataGridView to the form's controls
            panelStandings.Controls.Add(_dataGridView2);

            //Add columns to the DataGridView
            _dataGridView2.Columns.Add("Position", "Position");
            _dataGridView2.Columns["Position"].Width = 319;

            _dataGridView2.Columns.Add("Name", "Name");
            _dataGridView2.Columns["Name"].Width = 319;

            _dataGridView2.Columns.Add("Points", "Points");
            _dataGridView2.Columns["Points"].Width = 319;


            //Add rows to the DataGridView
            _dataGridView2.Rows.Add("Value1", "Value2", "Value3");
        }
    }
}
