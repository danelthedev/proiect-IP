/**************************************************************************
 *                                                                        *
 *  File:        MainForm.cs                                              *
 *  Copyright:   (c) 2023, Hrițcu Marina-Dumitrița                        *
 *  E-mail:      marina-dumitrita.hritcu@student.tuiasi.ro                *
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonSchedule_Click(object sender, EventArgs e)
        {
            Program.state = new ScheduleState(Program.state.Context);
            Program.state.loadPage();
        }

        private void buttonStandings_Click(object sender, EventArgs e)
        {
            Program.state = new StandingsState(Program.state.Context);
            Program.state.loadPage();
        }

        private void buttonTeams_Click(object sender, EventArgs e)
        {
            Program.state = new TeamsState(Program.state.Context);
            Program.state.loadPage();
        }

        private void buttonResults_Click(object sender, EventArgs e)
        {
            Program.state = new ResultsState(Program.state.Context);
            Program.state.loadPage();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Program.state.Context = this.mainPanel;
            //Program.state = new HomeState();
            //Program.state.loadPage();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proiect realizat de Arhip Alexandru Constantin, Hrițcu Marina Dumitrița și Imbrea Daniel.");
        }
    }
}
