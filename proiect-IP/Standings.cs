using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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
            panelStandings.AutoScroll = true;
        }

        private void buttonStandingsPlayers_Click(object sender, EventArgs e)
        {
            panelStandings.Controls.Clear();
            CreateDynamicTablePlayersV2();
        }

        private void buttonStandingsTeams_Click(object sender, EventArgs e)
        {
            panelStandings.Controls.Clear();
            CreateDynamicTableTeamsV2();
        }

        //Creating table for players with no background, only with labels
        private void CreateDynamicTablePlayersV2()
        {
            var columnCount = 5;
            var rowCount = 6;

            var cellWidth = ClientSize.Width / columnCount;
            var cellHeight = ClientSize.Height / rowCount;

            for (int row = 0; row < rowCount; row++)
            {
                for (int col = 0; col < columnCount; col++)
                {
                    var label = new System.Windows.Forms.Label();
                    label.AutoSize = true;
                    label.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Bold);
                    label.ForeColor = System.Drawing.Color.White;
                    label.Name = "labelTablePlayers_" + row + "_" + col;
                    label.TextAlign = ContentAlignment.MiddleCenter;

                    if (row == 0)
                    {
                        // Header row
                        label.Text = GetHeaderLabel(col);
                    }
                    else
                    {
                        // Data rows
                        //label.Text = GetCellData(row - 1, col);
                    }

                    label.Location = new Point(col * cellWidth, row * cellHeight);
                    label.Size = new Size(cellWidth, cellHeight);

                    panelStandings.Controls.Add(label);
                }
            }
        }

        private string GetHeaderLabel(int column)
        {
            switch (column)
            {
                case 0: return "Position";
                case 1: return "Name";
                case 2: return "Nationality";
                case 3: return "Car";
                case 4: return "Points";
                default: return "";
            }
        }

        private void Standings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Creating table for teams with no background, only with labels

        private void CreateDynamicTableTeamsV2()
        {
            var columnCount = 3;
            var rowCount = 10;

            var cellWidth = ClientSize.Width / columnCount;
            var cellHeight = ClientSize.Height / rowCount;

            for (int row = 0; row < rowCount; row++)
            {
                for (int col = 0; col < columnCount; col++)
                {
                    var label = new System.Windows.Forms.Label();
                    label.AutoSize = true;
                    label.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Bold);
                    label.ForeColor = System.Drawing.Color.White;
                    label.Name = "labelTablePlayers_" + row + "_" + col;
                    label.TextAlign = ContentAlignment.MiddleCenter;

                    if (row == 0)
                    {
                        // Header row
                        label.Text = GetHeaderLabelv2(col);
                    }
                    else
                    {
                        // Data rows
                        //label.Text = GetCellDatav2(row - 1, col);
                    }

                    label.Location = new Point(col * cellWidth, row * cellHeight);
                    label.Size = new Size(cellWidth, cellHeight);

                    panelStandings.Controls.Add(label);
                }
            }
        }

        private string GetHeaderLabelv2(int column)
        {
            switch (column)
            {
                case 0: return "Position";
                case 1: return "Name";
                case 2: return "Points";
                default: return "";
            }
        }

        /*
        private void CreateDynamicTablePlayers()
        {
            //Create the DataGridView
            _dataGridView1 = new DataGridView();
            _dataGridView1.Dock = DockStyle.Fill;


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
        */
    }
}
