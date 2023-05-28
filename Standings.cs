/**************************************************************************
 *                                                                        *
 *  File:        Standings.cs                                             *
 *  Copyright:   (c) 2023, Daniel, Marina, Alexandru                      *
 *  Description: It represents the page dedicated to the results, where   *
 *               we display the ranking of the pilots, but also of the    *
 *               teams.                                                   *
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
    /// <summary>
    /// Class that represents the standings page.
    /// </summary>
    public partial class Standings : Form
    {        
        public DataGrabber dataGrabber = new DataGrabber();

        /// <summary>
        /// Constructor of the class.
        /// </summary>
        public Standings()
        {
            InitializeComponent();
            panelStandings.AutoScroll = true;
        }

        private void ButtonStandingsPlayers_Click(object sender, EventArgs e)
        {
            panelStandings.Controls.Clear();
            CreateDynamicTablePlayersV2();
        }

        private void ButtonStandingsTeams_Click(object sender, EventArgs e)
        {
            panelStandings.Controls.Clear();
            CreateDynamicTableTeamsV2();
        }


        /// <summary>
        /// Creating table for players with no background, only with labels
        /// </summary>
        private void CreateDynamicTablePlayersV2()
        {
            dataGrabber.SetPage("https://www.formula1.com/en/results.html/2023/drivers.html");
            //grab data from web
            List<string> names1 = dataGrabber.GetTextListByXpath("//table[@class='resultsarchive-table']//tr//td[3]//span[not(contains(@class, 'uppercase hide-for-desktop'))][1]");
            List<string> names2 = dataGrabber.GetTextListByXpath("//table[@class='resultsarchive-table']//tr//td[3]//span[not(contains(@class, 'uppercase hide-for-desktop'))][2]");
            List<string> nationalities = dataGrabber.GetTextListByXpath("//table[@class='resultsarchive-table']//tr//td[4]");
            List<string> cars = dataGrabber.GetTextListByXpath("//table[@class='resultsarchive-table']//tr//td[5]");
            List<string> points = dataGrabber.GetTextListByXpath("//table[@class='resultsarchive-table']//tr//td[6]");


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
                                 label.Text = "                    " + row.ToString();
                            break;
                            case 1:
                                label.Text = "          " + names1[row-1].Trim() + " " + names2[row - 1].Trim();
                            break;
                            case 2:
                                label.Text = "                    " + nationalities[row-1].Trim();
                            break;
                            case 3:
                                label.Text = cars[row-1].Trim();
                            break;
                            case 4:
                                label.Text = "                      " + points[row-1].Trim();
                            break;
                        }
                    }

                    label.Location = new Point(col * cellWidth, row * cellHeight);
                    label.Size = new Size(cellWidth, cellHeight);

                    panelStandings.Controls.Add(label);
                }
            }

        }

        /// <summary>
        /// Method that returns the header label for the table.
        /// </summary>
        /// <param name="column"></param>
        /// <returns></returns>
        private string GetHeaderLabel(int column)
        {
            switch (column)
            {
                case 0: return "               Position";
                case 1: return "               Name";
                case 2: return "               Nationality";
                case 3: return "                   Car";
                case 4: return "                    Points";
                default: return "";
            }
        }

        /// <summary>
        /// Creating table for teams with no background, only with labels
        /// </summary>
        private void CreateDynamicTableTeamsV2()
        {
            dataGrabber.SetPage("https://www.formula1.com/en/results.html/2023/team.html");
            //grab data from web
            List<string> teams = dataGrabber.GetTextListByXpath("//table[@class='resultsarchive-table']//tr//td[3]");
            List<string> points = dataGrabber.GetTextListByXpath("//table[@class='resultsarchive-table']//tr//td[4]");

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
                                label.Text = "                    " + row.ToString();
                                break;
                            case 1:
                                label.Text = teams[row - 1].Trim();
                                break;
                            case 2:
                                label.Text = "                 " + points[row - 1].Trim();
                                break;
                        }
                    }

                    label.Location = new Point(col * cellWidth, row * cellHeight);
                    label.Size = new Size(cellWidth, cellHeight);

                    panelStandings.Controls.Add(label);
                }
            }
        }

        /// <summary>
        /// Method that returns the header label for the table.
        /// </summary>
        /// <param name="column"></param>
        /// <returns></returns>
        private string GetHeaderLabelv2(int column)
        {
            switch (column)
            {
                case 0: return "               Position";
                case 1: return "                 Name";
                case 2: return "               Points";
                default: return "";
            }
        }
    }
}
