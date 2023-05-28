/**************************************************************************
 *                                                                        *
 *  File:        MainForm.cs                                              *
 *  Copyright:   (c) 2023, Daniel, Marina, Alexandru                      *
 *  Description: It represents the main menu where we load the other      *
 *               forms(pages).                                            *
 *                                                                        *
 *  This program is free software; you can redistribute it and/or modify  *
 *  it under the terms of the GNU General Public License as published by  *
 *  the Free Software Foundation. This program is distributed in the      *
 *  hope that it will be useful, but WITHOUT ANY WARRANTY; without even   *
 *  the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR   *
 *  PURPOSE. See the GNU General Public License for more details.         *
 *                                                                        *
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoadingForms;

namespace F1Aggregator
{
    /// <summary>
    /// This is the main form of the application. It contains the main menu and the main panel where the pages are loaded.
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonSchedule_Click(object sender, EventArgs e)
        {
            Program.state = new ScheduleState(Program.state.Context);
            Program.state.loadPage();
        }

        private void ButtonStandings_Click(object sender, EventArgs e)
        {
            Program.state = new StandingsState(Program.state.Context);
            Program.state.loadPage();
        }

        private void ButtonTeams_Click(object sender, EventArgs e)
        {
            Program.state = new TeamsState(Program.state.Context);
            Program.state.loadPage();
        }

        private void ButtonResults_Click(object sender, EventArgs e)
        {
            Program.state = new ResultsState(Program.state.Context);
            Program.state.loadPage();
        }

        private void ButtonHome_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Program.state.Context = this.mainPanel;
            //Program.state = new HomeState();
            //Program.state.loadPage();
        }

        private void ButtonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Project made by: \n\n" +
                "* Arhip Alexandru Constantin \n" +
                "* Hrițcu Marina Dumitrița \n" +
                "* Imbrea Daniel");
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "HelpF1Aggregator.chm");
        }
    }
}
