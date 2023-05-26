using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HTMLDataGrabber;
using System.Net;
using System.IO;
using System.Windows.Forms.VisualStyles;
using System.Globalization;

namespace F1Aggregator
{
    public partial class Schedule : Form
    {
        static DataGrabber dataGrabber = new DataGrabber();

        public void setSchedulePictures(string raceName)
        {
            pictureBoxScheduleTrack.ImageLocation = "https://media.formula1.com/content/dam/fom-website/2018-redesign-assets/Track%20icons%204x3/" + raceName + ".png.transform/2col/image.png";
            pictureBoxSchedulePresentation.ImageLocation = "https://media.formula1.com/content/dam/fom-website/races/2023/race-listing/" + raceName + ".jpg.transform/9col/image.jpg";
        }

        public Schedule()
        {
            InitializeComponent();

            //add all race name labels to list in one line
            Label[] raceNameLabels = new Label[] { labelScheduleName1, labelScheduleName2, labelScheduleName3, labelScheduleName4, labelScheduleName5, labelScheduleName6, labelScheduleName7, labelScheduleName8, labelScheduleName9, labelScheduleName10 };
            Label[] raceDateLabels = new Label[] { labelScheduleTime1, labelScheduleTime2, labelScheduleTime3, labelScheduleTime4, labelScheduleTime5, labelScheduleTime6, labelScheduleTime7, labelScheduleTime8, labelScheduleTime9, labelScheduleTime10 };
            Button[] buttons = new Button[] { buttonScheduleShow1, buttonScheduleShow2, buttonScheduleShow3, buttonScheduleShow4, buttonScheduleShow5, buttonScheduleShow6, buttonScheduleShow7, buttonScheduleShow8, buttonScheduleShow9, buttonScheduleShow10 };

            PictureBox[] raceTrackPicture = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10 };

            dataGrabber.setPage("https://www.skysports.com/f1/schedule-results");

            //get most recent event first

            labelScheduleRaceName.Text = dataGrabber.getTextByXpath("(//a[@class='f1-races__race ']//h2[@class='f1-races__race-name'])[1]").Trim();
        
            List<string> datesAndTimes = new List<string>();
            for(int i = 0; i < 5; i++)
            {
                string date = dataGrabber.getTextByXpath("(//a[@class='f1-races__race ']//table[@class='standing-table__table']//tr[" + (i + 1) + "]//td)[1]");
                string time = dataGrabber.getTextByXpath("(//a[@class='f1-races__race ']//table[@class='standing-table__table']//tr[" + (i + 1) + "]//td)[3]");
            
                //remove trailing whitespace
                date = date.Trim();
                time = time.Trim();
                datesAndTimes.Add(date + " " + time);

            }

            labelPractice1.Text = "Practice 1: " + datesAndTimes[0];
            labelPractice2.Text = "Practice 2: " + datesAndTimes[1];
            labelPractice3.Text = "Practice 3: " + datesAndTimes[2];
            labelQuali.Text = "Quali: " + datesAndTimes[3];
            labelRace.Text = "Race: " + datesAndTimes[4];

            setSchedulePictures(labelScheduleRaceName.Text);

            //Go over the rest of the scheduled races
            List<string> raceNames = dataGrabber.getTextListByXpath("(//a[@class='f1-races__race ']//h2[@class='f1-races__race-name'])");
            List<string> startDates = dataGrabber.getTextListByXpath("//a[@class='f1-races__race ']//p[@class='f1-races__race-date']");

            for(int i=0; i < raceNameLabels.Length;  i++)
            {
                raceNameLabels[i].Text = raceNames[i].Trim();
                raceDateLabels[i].Text = startDates[i].Trim().Substring(0, startDates[i].Trim().IndexOf("-"));
                raceTrackPicture[i].ImageLocation = "https://media.formula1.com/content/dam/fom-website/2018-redesign-assets/Track%20icons%204x3/" + raceNameLabels[i].Text + ".png.transform/2col/image.png";
            }

            //create callbacks for buttonScheduleShow button clicks and send index as parameter
            for(int i = 0; i < buttons.Length; i++)
            {
                int index = i;
                buttons[i].Click += (sender, e) => buttonScheduleShow_Click(sender, e, index);
            }
        }

        private void buttonScheduleShow_Click(object sender, EventArgs e, int index)
        {
            //set text of labelScheduleRaceName
            Label[] raceNameLabels = new Label[] { labelScheduleName1, labelScheduleName2, labelScheduleName3, labelScheduleName4, labelScheduleName5, labelScheduleName6, labelScheduleName7, labelScheduleName8, labelScheduleName9, labelScheduleName10 };
            labelScheduleRaceName.Text = raceNameLabels[index].Text;

            //grab data from website for dates and times
            DataGrabber dataGrabber = new DataGrabber();
            dataGrabber.setPage("https://www.skysports.com/f1/schedule-results");
            List<string> datesAndTimes = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                string date = dataGrabber.getTextByXpath("(//a[@class='f1-races__race ']//table[@class='standing-table__table']//tr[" + (i + 1) + "]//td[1])[" + (index + 2) + "]");
                string time = dataGrabber.getTextByXpath("(//a[@class='f1-races__race ']//table[@class='standing-table__table']//tr[" + (i + 1) + "]//td[3])[" + (index + 2) + "]");

                //remove trailing whitespace
                date = date.Trim();
                time = time.Trim();
                datesAndTimes.Add(date + " " + time);

            }

            labelPractice1.Text = "Practice 1: " + datesAndTimes[0];
            labelPractice2.Text = "Practice 2: " + datesAndTimes[1];
            labelPractice3.Text = "Practice 3: " + datesAndTimes[2];
            labelQuali.Text = "Quali: " + datesAndTimes[3];
            labelRace.Text = "Race: " + datesAndTimes[4];

            setSchedulePictures(labelScheduleRaceName.Text);
        }

        private void panelSchedule_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
