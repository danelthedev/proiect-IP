using HTMLDataGrabber;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace F1Aggregator
{
    public partial class Standings : Form
    {
        private DataGridView _dataGridView1, _dataGridView2;
        
        public DataGrabber dataGrabber = new DataGrabber();

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
            dataGrabber.setPage("https://www.formula1.com/en/results.html/2023/drivers.html");
            //grab data from web
            List<string> names1 = dataGrabber.getTextListByXpath("//table[@class='resultsarchive-table']//tr//td[3]//span[not(contains(@class, 'uppercase hide-for-desktop'))][1]");
            List<string> names2 = dataGrabber.getTextListByXpath("//table[@class='resultsarchive-table']//tr//td[3]//span[not(contains(@class, 'uppercase hide-for-desktop'))][2]");
            List<string> nationalities = dataGrabber.getTextListByXpath("//table[@class='resultsarchive-table']//tr//td[4]");
            List<string> cars = dataGrabber.getTextListByXpath("//table[@class='resultsarchive-table']//tr//td[5]");
            List<string> points = dataGrabber.getTextListByXpath("//table[@class='resultsarchive-table']//tr//td[6]");


            var columnCount = 5;
            var rowCount = 21;

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
                    label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;


                    if (row == 0)
                    {
                        // Header row
                        label.Text = GetHeaderLabel(col);
                    }
                    else
                    {
                        // Data rows
                        switch (col) {
                            case 0:
                                 label.Text = row.ToString();
                            break;
                            case 1:
                                label.Text = names1[row-1].Trim() + " " + names2[row - 1].Trim();
                            break;
                            case 2:
                                label.Text = nationalities[row-1].Trim();
                            break;
                            case 3:
                                label.Text = cars[row-1].Trim();
                            break;
                            case 4:
                                label.Text = points[row-1].Trim();
                            break;
                        }
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

        //Creating table for teams with no background, only with labels

        private void CreateDynamicTableTeamsV2()
        {
            dataGrabber.setPage("https://www.formula1.com/en/results.html/2023/team.html");
            //grab data from web
            List<string> teams = dataGrabber.getTextListByXpath("//table[@class='resultsarchive-table']//tr//td[3]");
            List<string> points = dataGrabber.getTextListByXpath("//table[@class='resultsarchive-table']//tr//td[4]");

            var columnCount = 3;
            var rowCount = 11;

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
                    label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                    if (row == 0)
                    {
                        // Header row
                        label.Text = GetHeaderLabelv2(col);
                    }
                    else
                    {
                        // Data rows
                        switch (col)
                        {
                            case 0:
                                label.Text = row.ToString();
                                break;
                            case 1:
                                label.Text = teams[row - 1].Trim();
                                break;
                            case 2:
                                label.Text = points[row - 1].Trim();
                                break;
                        }
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
