/**************************************************************************
 *                                                                        *
 *  File:        Results.cs                                               *
 *  Copyright:   (c) 2023, Daniel, Marina, Alexandru                      *
 *  Description: It represents the page dedicated to the results of the   *
 *               races that have taken place up to this moment.           *
 *                                                                        *
 *  This program is free software; you can redistribute it and/or modify  *
 *  it under the terms of the GNU General Public License as published by  *
 *  the Free Software Foundation. This program is distributed in the      *
 *  hope that it will be useful, but WITHOUT ANY WARRANTY; without even   *
 *  the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR   *
 *  PURPOSE. See the GNU General Public License for more details.         *
 *                                                                        *
 **************************************************************************/

using HTMLDataGrabber;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Windows.Forms;

//Comment
namespace F1Aggregator
{
    /// <summary>
    /// Class for the results page.
    /// </summary>
    public partial class Results : Form
    {
        public static DataGrabber dataGrabber = new DataGrabber();
        private static int _verstappenCount = 0;

        /// <summary>
        /// Setting the picture for the player.
        /// </summary>
        /// <param name="pictureBox"></param>
        /// <param name="playerName"></param>
        public void SetPicture(PictureBox pictureBox, string playerName)
        {
            pictureBox.ImageLocation = "https://www.formula1.com/content/dam/fom-website/2018-redesign-assets/Drivers/2023/" + playerName + "01.png.transform/2col/image.png";
        }

        /// <summary>
        /// Getting the name of the player.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string ShortenName(string name)
        {
            string[] splitName = name.Split(' ');
            string shortName = splitName[0].Substring(0, 3) + splitName[1].Substring(0, 3);
            return shortName;
        }

        /// <summary>
        /// Constructor for the class where we are getting the data from the website and displaying it.
        /// </summary>
        public Results()
        {
            InitializeComponent();
            dataGrabber.SetPage("https://www.skysports.com/f1/schedule-results");
            List<string> firstPlaces = dataGrabber.GetTextListByXpath("(//a[@class='f1-races__race']//table[@class='standing-table__table']//tr[1]//td[@data-long-name])");
            List<string> secondPlaces = dataGrabber.GetTextListByXpath("(//a[@class='f1-races__race']//table[@class='standing-table__table']//tr[2]//td[@data-long-name])");
            List<string> thirdPlaces = dataGrabber.GetTextListByXpath("(//a[@class='f1-races__race']//table[@class='standing-table__table']//tr[3]//td[@data-long-name])");
            List<string> locations = dataGrabber.GetTextListByXpath("//a[@class='f1-races__race']//h2[@class='f1-races__race-name']");
            List<string> dates = dataGrabber.GetTextListByXpath("//a[@class='f1-races__race']//p[@class='f1-races__race-date']");

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
                
                labelResults1stPlayer[i].Text = firstPlaces[firstPlaces.Count - i - 1].Trim();
                labelResults2ndPlayer[i].Text = secondPlaces[firstPlaces.Count - i - 1].Trim();
                labelResults3rdPlayer[i].Text = thirdPlaces[firstPlaces.Count - i - 1].Trim();
                labelResultsLocations[i].Text = locations[firstPlaces.Count - i - 1].Trim();
                labelResultsDates[i].Text = dates[5 - i];

                SetPicture(pictureBoxResults1stPlayer[i], ShortenName(labelResults1stPlayer[i].Text));
                SetPicture(pictureBoxResults2stPlayer[i], ShortenName(labelResults2ndPlayer[i].Text));
                SetPicture(pictureBoxResults3stPlayer[i], ShortenName(labelResults3rdPlayer[i].Text));

                if (labelResults1stPlayer[i].Text == "Max Verstappen")
                {
                    pictureBoxResults1stPlayer[i].Click += new System.EventHandler(this.PictureBoxResults1stPlayer_Click);
                }
            }

        }

        private void PictureBoxResults1stPlayer_Click(object sender, System.EventArgs e)
        {
            _verstappenCount++;
            if(_verstappenCount == 10)
            {
                SoundPlayer simpleSound = new SoundPlayer("./maxSong.wav");
                simpleSound.Play();
            }
        }

        private void PanelResults_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
