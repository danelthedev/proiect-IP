/**************************************************************************
 *                                                                        *
 *  File:        Teams.cs                                                 *
 *  Copyright:   (c) 2023, Hrițcu Marina-Dumitrița                        *
 *  E-mail:      marina-dumitrita.hritcu@student.tuiasi.ro                *
 *  Description: It represents the page dedicated to the teams and their  *
 *               presentation.                                            *
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
        public static DataGrabber dataGrabber = new DataGrabber();

        public Teams()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Getting the drivers name by team name.
        /// </summary>
        /// <param name="teamName"></param>
        /// <returns></returns>
        public List<string> GetDriversByTeam(string teamName)
        {
            string xpath = "//a[@class='listing-item--link ']//p[contains(text(), '" + teamName.Trim() + "')]/..//div[contains(@class, 'listing-item--name')]//span";
            List<string> driverNamesIntermediary = dataGrabber.GetTextListByXpath(xpath);
            //combine first and last name
            List<string> driverNames = new List<string>();
            for(int i = 0; i < driverNamesIntermediary.Count; i += 2)
            {
                driverNames.Add(driverNamesIntermediary[i] + " " + driverNamesIntermediary[i + 1]);
            }

            return driverNames;
        }

        /// <summary>
        /// Getting the image of the car by team name.
        /// </summary>
        /// <param name="pictureBox"></param>
        /// <param name="teamName"></param>
        public void SetCarPicture(PictureBox pictureBox, string teamName)
        {
            teamName = teamName.Trim().Replace(" ", "-");
            string url = "https://media.formula1.com/d_team_car_fallback_image.png/content/dam/fom-website/teams/2023/" + teamName + ".png.transform/4col/image.png";
            pictureBox.ImageLocation = url;
        }

        private void PanelTeams_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// Loading the page and setting the data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Teams_Load(object sender, EventArgs e)
        {
            dataGrabber.SetPage("https://www.formula1.com/en/teams.html");
            //grab car picture/team name/points
            PictureBox[] carPictures = new PictureBox[] { pictureBoxTeamsCar1, pictureBoxTeamsCar2, pictureBoxTeamsCar3, pictureBoxTeamsCar4, pictureBoxTeamsCar5, pictureBoxTeamsCar6, pictureBoxTeamsCar7, pictureBoxTeamsCar8, pictureBoxTeamsCar9, pictureBoxTeamsCar10};
            Label[] teamNames = new Label[] {labelTeamsName1, labelTeamsName2, labelTeamsName3, labelTeamsName4, labelTeamsName5, labelTeamsName6, labelTeamsName7, labelTeamsName8, labelTeamsName9, labelTeamsName10};
            Label[] teamPoints = new Label[] { labelTeamsPoints1, labelTeamsPoints2, labelTeamsPoints3, labelTeamsPoints4, labelTeamsPoints5, labelTeamsPoints6, labelTeamsPoints7, labelTeamsPoints8, labelTeamsPoints9, labelTeamsPoints10 };

            List<string> teams = dataGrabber.GetTextListByXpath("//div[@class='name f1-bold--m']//span[text()]");
            List<string> points = dataGrabber.GetTextListByXpath("//div[@class='points']//div[1]");

            //set team names, points and car pictures
            for (int i = 0; i < teams.Count; i++)
            {
                teamNames[i].Text = teams[i];
                teamNames[i].TextAlign = ContentAlignment.MiddleCenter;
                teamPoints[i].Text = points[i] + " pts";
                SetCarPicture(carPictures[i], teams[i]);
            }

            //grab driver names
            dataGrabber.SetPage("https://www.formula1.com/en/drivers.html");
            Label[] driverNames = new Label[] { labelTeamsPOne1, labelTeamsPOne2, labelTeamsPOne3, labelTeamsPOne4, labelTeamsPOne5, labelTeamsPOne6, labelTeamsPOne7, labelTeamsPOne8, labelTeamsPOne9, labelTeamsPOne10, 
                                                labelTeamsPTwo1, labelTeamsPTwo2, labelTeamsPTwo3, labelTeamsPTwo4, labelTeamsPTwo5, labelTeamsPTwo6, labelTeamsPTwo7, labelTeamsPTwo8, labelTeamsPTwo9, labelTeamsPTwo10};
            
            for(int i = 0; i < teams.Count; i++)
            {
                List<string> driverNamesByTeam = GetDriversByTeam(teams[i]);
                driverNames[i].Text = driverNamesByTeam[0];
                driverNames[i + 10].Text = driverNamesByTeam[1];
            }
        }
    }
}
