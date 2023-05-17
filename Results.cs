using F1Aggregator.DynamicFormObjs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
//Comment
namespace F1Aggregator
{
    public partial class Results : Form
    {
        public Results()
        {
            InitializeComponent();

            //Making the cursor invisible
            ReadOnlyTBObjs readOnlyObjs = new ReadOnlyTBObjs(panelResults);
            readOnlyObjs.MakeObjReadOnly();

            //Creating the tables for the results
            CreateDynamicInterface(7);
        }

        private void toolStripButtonSchedule2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.schedule.Show();
        }

        private void toolStripButtonStandings2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.standings.Show();
        }

        private void toolStripButtonTeams2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.teams.Show();
        }

        private void buttonResultsDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.extendedResults.Show();
        }

        /// <summary>
        /// Method to copy and multiply an object from the Results interface
        /// </summary>
        /// <param name="number"></param>
        private void CreateDynamicInterface(int number)
        {
            int index;

            //Iterating to create a number of objects
            for(index = 1; index <= number; ++index)
            {
                //GroupBox
                GroupBoxReference groupBoxCopy = new GroupBoxReference(groupBoxResults, index);
                System.Windows.Forms.GroupBox groupBoxElement = groupBoxCopy.GroupBox;
                //Adding the new object to the panel
                panelResults.Controls.Add(groupBoxElement);

                //Label Location
                LabelReference labelLocationCopy = new LabelReference(labelResultsLocation, index);
                System.Windows.Forms.Label labelLocationElement = labelLocationCopy.Label;
                //Adding the new object to the panel
                groupBoxElement.Controls.Add(labelLocationElement);

                //Label Period
                LabelReference labelPeriodCopy = new LabelReference(labelResultsPeriod, index);
                System.Windows.Forms.Label labelPeriodElement = labelPeriodCopy.Label;
                //Adding the new object to the panel
                groupBoxElement.Controls.Add(labelPeriodElement);

                //Label 1st Place
                LabelReference label1stCopy = new LabelReference(labelResults1st, index);
                System.Windows.Forms.Label label1stElement = label1stCopy.Label;
                //Adding the new object to the panel
                groupBoxElement.Controls.Add(label1stElement);

                //Label 2nd Place
                LabelReference label2ndCopy = new LabelReference(labelResults2nd, index);
                System.Windows.Forms.Label label2ndElement = label2ndCopy.Label;
                //Adding the new object to the panel
                groupBoxElement.Controls.Add(label2ndElement);

                //Label 3rd Place
                LabelReference label3rdCopy = new LabelReference(labelResults3rd, index);
                System.Windows.Forms.Label label3rdElement = label3rdCopy.Label;
                //Adding the new object to the panel
                groupBoxElement.Controls.Add(label3rdElement);

                //TextBox Location
                TextBoxReference textBoxLocationCopy = new TextBoxReference(textBoxResultsLocation, index);
                System.Windows.Forms.TextBox textBoxLocationElement = textBoxLocationCopy.TextBox;
                //Adding the new object to the panel
                groupBoxElement.Controls.Add(textBoxLocationElement);

                //TextBox Period
                TextBoxReference textBoxPeriodCopy = new TextBoxReference(textBoxResultsPeriod, index);
                System.Windows.Forms.TextBox textBoxPeriodElement = textBoxPeriodCopy.TextBox;
                //Adding the new object to the panel
                groupBoxElement.Controls.Add(textBoxPeriodElement);

                //TextBox 1st Place
                TextBoxReference textBox1stCopy = new TextBoxReference(textBoxResults1st, index);
                System.Windows.Forms.TextBox textBox1stElement = textBox1stCopy.TextBox;
                //Adding the new object to the panel
                groupBoxElement.Controls.Add(textBox1stElement);

                //TextBox 2nd Place
                TextBoxReference textBox2ndCopy = new TextBoxReference(textBoxResults2nd, index);
                System.Windows.Forms.TextBox textBox2ndElement = textBox2ndCopy.TextBox;
                //Adding the new object to the panel
                groupBoxElement.Controls.Add(textBox2ndElement);

                //TextBox 3rd Place
                TextBoxReference textBox3rdCopy = new TextBoxReference(textBoxResults3rd, index);
                System.Windows.Forms.TextBox textBox3rdElement = textBox3rdCopy.TextBox;
                //Adding the new object to the panel
                groupBoxElement.Controls.Add(textBox3rdElement);

                //PictureBox 1st Place
                PictureBoxReference pictureBox1stCopy = new PictureBoxReference(pictureBoxResults1st, index);
                System.Windows.Forms.PictureBox pictureBox1stElement = pictureBox1stCopy.PictureBox;
                //Adding the new object to the panel
                groupBoxElement.Controls.Add(pictureBox1stElement);

                //PictureBox 2nd Place
                PictureBoxReference pictureBox2ndCopy = new PictureBoxReference(pictureBoxResults2nd, index);
                System.Windows.Forms.PictureBox pictureBox2ndElement = pictureBox2ndCopy.PictureBox;
                //Adding the new object to the panel
                groupBoxElement.Controls.Add(pictureBox2ndElement);

                //PictureBox 3rd Place
                PictureBoxReference pictureBox3rdCopy = new PictureBoxReference(pictureBoxResults3rd, index);
                System.Windows.Forms.PictureBox pictureBox3rdElement = pictureBox3rdCopy.PictureBox;
                //Adding the new object to the panel
                groupBoxElement.Controls.Add(pictureBox3rdElement);   
            }

            //Iterating in panel for the dynamic objects
            //Pentru Daniel, in caz de ai nevoie
            /*
            foreach (Control C in panelResults.Controls)
            {
                if (C is System.Windows.Forms.GroupBox)
                {
                    MessageBox.Show(C.Name);
                }
            }*/
        }

        private void Results_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
