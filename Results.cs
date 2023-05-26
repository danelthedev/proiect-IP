using HTMLDataGrabber;
using System.Collections.Generic;
using System.Windows.Forms;

//Comment
namespace F1Aggregator
{
    public partial class Results : Form
    {
        public static DataGrabber dataGrabber = new DataGrabber();

        public void setPicture(PictureBox pictureBox, string playerName)
        {
            pictureBox.ImageLocation = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Drivers/2018/" + playerName + "01.png.transform/2col/image.png";
        }

        public string shortenName(string name)
        {
            string[] splitName = name.Split(' ');
            string shortName = splitName[0].Substring(0, 3) + splitName[1].Substring(0, 3);
            return shortName;
        }

        public Results()
        {
            InitializeComponent();
            dataGrabber.setPage("https://www.skysports.com/f1/schedule-results");
            List<string> firstPlaces = dataGrabber.getTextListByXpath("(//a[@class='f1-races__race']//table[@class='standing-table__table']//tr[1]//td[@data-long-name])");
            List<string> secondPlaces = dataGrabber.getTextListByXpath("(//a[@class='f1-races__race']//table[@class='standing-table__table']//tr[2]//td[@data-long-name])");
            List<string> thirdPlaces = dataGrabber.getTextListByXpath("(//a[@class='f1-races__race']//table[@class='standing-table__table']//tr[3]//td[@data-long-name])");
            List<string> locations = dataGrabber.getTextListByXpath("//a[@class='f1-races__race']//h2[@class='f1-races__race-name']");
            List<string> dates = dataGrabber.getTextListByXpath("//a[@class='f1-races__race']//p[@class='f1-races__race-date']");

            Label[] labelResults1stPlayer = { labelResults1stPlayer1, labelResults1stPlayer2, labelResults1stPlayer3, labelResults1stPlayer4, labelResults1stPlayer5 };
            Label[] labelResults2ndPlayer = { labelResults2ndPlayer1, labelResults2ndPlayer2, labelResults2ndPlayer3, labelResults2ndPlayer4, labelResults2ndPlayer5 };
            Label[] labelResults3rdPlayer = { labelResults3rdPlayer1, labelResults3rdPlayer2, labelResults3rdPlayer3, labelResults3rdPlayer4, labelResults3rdPlayer5 };

            PictureBox[] pictureBoxResults1stPlayer = { pictureBoxResults1st1, pictureBoxResults1st2, pictureBoxResults1st3, pictureBoxResults1st4, pictureBoxResults1st5 };
            PictureBox[] pictureBoxResults2stPlayer = { pictureBoxResults2nd1, pictureBoxResults2nd2, pictureBoxResults2nd3, pictureBoxResults2nd4, pictureBoxResults2nd5 };
            PictureBox[] pictureBoxResults3stPlayer = { pictureBoxResults3rd1, pictureBoxResults3rd2, pictureBoxResults3rd3, pictureBoxResults3rd4, pictureBoxResults3rd5 };

            Label[] labelResultsLocations = {labelResultsLocation1, labelResultsLocation2, labelResultsLocation3, labelResultsLocation4, labelResultsLocation5};
            Label[] labelResultsDates = { labelResultsPeriod1, labelResultsPeriod2, labelResultsPeriod3, labelResultsPeriod4, labelResultsPeriod5 };

            //set text for all labels
            for (int i = 0; i < 5; i++)
            {
                labelResults1stPlayer[4 - i].Text = firstPlaces[i].Trim();
                labelResults2ndPlayer[4 - i].Text = secondPlaces[i].Trim();
                labelResults3rdPlayer[4 - i].Text = thirdPlaces[i].Trim();
                labelResultsLocations[4 - i].Text = locations[i].Trim();
                labelResultsDates[4- i].Text = dates[i];

                setPicture(pictureBoxResults1stPlayer[4 - i], shortenName(labelResults1stPlayer[4 - i].Text));
                setPicture(pictureBoxResults2stPlayer[4 - i], shortenName(labelResults2ndPlayer[4 - i].Text));
                setPicture(pictureBoxResults3stPlayer[4 - i], shortenName(labelResults3rdPlayer[4 - i].Text));
            }

        }

        private void panelResults_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
