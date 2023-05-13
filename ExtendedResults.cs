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
    public partial class ExtendedResults : Form
    {
        private DataGridView _dataGridView1;
        private DataGridView _dataGridView2;
        private DataGridView _dataGridView3;
        private DataGridView _dataGridView4;

        public ExtendedResults()
        {
            InitializeComponent();
        }

        private void toolStripButtonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.results.Show();
        }

        private void toolStripButtonQualifying_Click(object sender, EventArgs e)
        {
            panelExtendedResults.Controls.Clear();
            CreateDynamicTableQualifying();
        }

        private void CreateDynamicTableQualifying()
        {
            //Create the DataGridView
            _dataGridView1 = new DataGridView();

            //Set properties for the DataGridView
            _dataGridView1.Name = "dynamicDataGridView";
            _dataGridView1.Location = new Point(10, 10);
            _dataGridView1.Size = new Size(930, 540);

            //Add the DataGridView to the form's controls
            panelExtendedResults.Controls.Add(_dataGridView1);

            //Add columns to the DataGridView
            _dataGridView1.Columns.Add("Position", "Position");
            _dataGridView1.Columns["Position"].Width = 60;

            _dataGridView1.Columns.Add("Number", "Number");
            _dataGridView1.Columns["Number"].Width = 60;

            _dataGridView1.Columns.Add("Driver", "Driver");
            _dataGridView1.Columns["Driver"].Width = 200;

            _dataGridView1.Columns.Add("Car", "Car");
            _dataGridView1.Columns["Car"].Width = 200;

            _dataGridView1.Columns.Add("Q1", "Q1");
            _dataGridView1.Columns.Add("Q2", "Q2");
            _dataGridView1.Columns.Add("Q3", "Q3");

            _dataGridView1.Columns.Add("Laps", "Laps");
            _dataGridView1.Columns["Laps"].Width = 60;

            //Add rows to the DataGridView
            _dataGridView1.Rows.Add("Value1", "Value2", "Value3");
        }

        private void toolStripButtonPitStop_Click(object sender, EventArgs e)
        {
            panelExtendedResults.Controls.Clear();
            CreateDynamicTablePitStop();
        }

        private void CreateDynamicTablePitStop()
        {
            //Create the DataGridView
            _dataGridView2 = new DataGridView();

            //Set properties for the DataGridView
            _dataGridView2.Name = "dynamicDataGridView";
            _dataGridView2.Location = new Point(10, 10);
            _dataGridView2.Size = new Size(930, 540);

            //Add the DataGridView to the form's controls
            panelExtendedResults.Controls.Add(_dataGridView2);

            //Add columns to the DataGridView
            _dataGridView2.Columns.Add("Stops", "Stops");
            _dataGridView2.Columns["Stops"].Width = 60;

            _dataGridView2.Columns.Add("Number", "Number");
            _dataGridView2.Columns["Number"].Width = 60;

            _dataGridView2.Columns.Add("Driver", "Driver");
            _dataGridView2.Columns["Driver"].Width = 200;

            _dataGridView2.Columns.Add("Car", "Car");
            _dataGridView2.Columns["Car"].Width = 200;

            _dataGridView2.Columns.Add("Lap", "Lap");
            _dataGridView2.Columns["Lap"].Width = 60;

            _dataGridView2.Columns.Add("Time of day", "Time of day");
            _dataGridView2.Columns.Add("Time", "Time");
            _dataGridView2.Columns.Add("Total", "Total");

            //Add rows to the DataGridView
            _dataGridView2.Rows.Add("Value1", "Value2", "Value3");
        }

        private void toolStripButtonFastestLap_Click(object sender, EventArgs e)
        {
            panelExtendedResults.Controls.Clear();
            CreateDynamicTableFastestLaps();
        }

        private void CreateDynamicTableFastestLaps()
        {
            //Create the DataGridView
            _dataGridView3 = new DataGridView();

            //Set properties for the DataGridView
            _dataGridView3.Name = "dynamicDataGridView";
            _dataGridView3.Location = new Point(10, 10);
            _dataGridView3.Size = new Size(930, 540);

            //Add the DataGridView to the form's controls
            panelExtendedResults.Controls.Add(_dataGridView3);

            //Add columns to the DataGridView
            _dataGridView3.Columns.Add("Position", "Position");
            _dataGridView3.Columns["Position"].Width = 60;

            _dataGridView3.Columns.Add("Number", "Number");
            _dataGridView3.Columns["Number"].Width = 60;

            _dataGridView3.Columns.Add("Driver", "Driver");
            _dataGridView3.Columns["Driver"].Width = 200;

            _dataGridView3.Columns.Add("Car", "Car");
            _dataGridView3.Columns["Car"].Width = 200;

            _dataGridView3.Columns.Add("Lap", "Lap");
            _dataGridView3.Columns["Lap"].Width = 60;

            _dataGridView3.Columns.Add("Time of day", "Time of day");
            _dataGridView3.Columns.Add("Time", "Time");
            _dataGridView3.Columns.Add("AVG Speed", "AVG Speed");

            //Add rows to the DataGridView
            _dataGridView3.Rows.Add("Value1", "Value2", "Value3");
        }

        private void toolStripButtonRaceResult_Click(object sender, EventArgs e)
        {
            panelExtendedResults.Controls.Clear();
            CreateDynamicTableRaceResult();
        }

        private void CreateDynamicTableRaceResult()
        {
            //Create the DataGridView
            _dataGridView4 = new DataGridView();

            //Set properties for the DataGridView
            _dataGridView4.Name = "dynamicDataGridView";
            _dataGridView4.Location = new Point(10, 10);
            _dataGridView4.Size = new Size(930, 540);

            //Add the DataGridView to the form's controls
            panelExtendedResults.Controls.Add(_dataGridView4);

            //Add columns to the DataGridView
            _dataGridView4.Columns.Add("Position", "Position");
            _dataGridView4.Columns["Position"].Width = 60;

            _dataGridView4.Columns.Add("Number", "Number");
            _dataGridView4.Columns["Number"].Width = 60;

            _dataGridView4.Columns.Add("Driver", "Driver");
            _dataGridView4.Columns["Driver"].Width = 210;

            _dataGridView4.Columns.Add("Car", "Car");
            _dataGridView4.Columns["Car"].Width = 210;

            _dataGridView4.Columns.Add("Laps", "Laps");
            _dataGridView4.Columns.Add("Time/Retired", "Time/Retired");
            _dataGridView4.Columns["Time/Retired"].Width = 140;

            _dataGridView4.Columns.Add("Points", "Points");

            //Add rows to the DataGridView
            _dataGridView4.Rows.Add("Value1", "Value2", "Value3", "Value4", "Value5", "Value6", "Value7");
        }

        private void ExtendedResults_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
