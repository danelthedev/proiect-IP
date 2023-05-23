﻿
namespace F1Aggregator
{
    partial class Standings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Standings));
            this.buttonStandingsPlayers = new System.Windows.Forms.Button();
            this.buttonStandingsTeams = new System.Windows.Forms.Button();
            this.panelStandings = new System.Windows.Forms.Panel();
            this.panelMenuButtons = new System.Windows.Forms.Panel();
            this.panelMenuButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStandingsPlayers
            // 
            this.buttonStandingsPlayers.BackColor = System.Drawing.Color.Black;
            this.buttonStandingsPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStandingsPlayers.ForeColor = System.Drawing.Color.Transparent;
            this.buttonStandingsPlayers.Location = new System.Drawing.Point(384, 22);
            this.buttonStandingsPlayers.Name = "buttonStandingsPlayers";
            this.buttonStandingsPlayers.Size = new System.Drawing.Size(142, 31);
            this.buttonStandingsPlayers.TabIndex = 3;
            this.buttonStandingsPlayers.Text = "Players";
            this.buttonStandingsPlayers.UseVisualStyleBackColor = false;
            this.buttonStandingsPlayers.Click += new System.EventHandler(this.buttonStandingsPlayers_Click);
            // 
            // buttonStandingsTeams
            // 
            this.buttonStandingsTeams.BackColor = System.Drawing.Color.Black;
            this.buttonStandingsTeams.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStandingsTeams.ForeColor = System.Drawing.Color.Transparent;
            this.buttonStandingsTeams.Location = new System.Drawing.Point(545, 22);
            this.buttonStandingsTeams.Name = "buttonStandingsTeams";
            this.buttonStandingsTeams.Size = new System.Drawing.Size(142, 31);
            this.buttonStandingsTeams.TabIndex = 4;
            this.buttonStandingsTeams.Text = "Teams";
            this.buttonStandingsTeams.UseVisualStyleBackColor = false;
            this.buttonStandingsTeams.Click += new System.EventHandler(this.buttonStandingsTeams_Click);
            // 
            // panelStandings
            // 
            this.panelStandings.BackColor = System.Drawing.Color.Transparent;
            this.panelStandings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStandings.Location = new System.Drawing.Point(0, 100);
            this.panelStandings.Name = "panelStandings";
            this.panelStandings.Size = new System.Drawing.Size(1084, 581);
            this.panelStandings.TabIndex = 5;
            // 
            // panelMenuButtons
            // 
            this.panelMenuButtons.BackColor = System.Drawing.Color.Transparent;
            this.panelMenuButtons.Controls.Add(this.buttonStandingsTeams);
            this.panelMenuButtons.Controls.Add(this.buttonStandingsPlayers);
            this.panelMenuButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuButtons.Location = new System.Drawing.Point(0, 0);
            this.panelMenuButtons.Name = "panelMenuButtons";
            this.panelMenuButtons.Size = new System.Drawing.Size(1084, 100);
            this.panelMenuButtons.TabIndex = 6;
            // 
            // Standings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(58)))));
            this.BackgroundImage = global::F1Aggregator.Properties.Resources.backgroundTintBlur;
            this.ClientSize = new System.Drawing.Size(1084, 681);
            this.Controls.Add(this.panelStandings);
            this.Controls.Add(this.panelMenuButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Standings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Standings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Standings_FormClosed);
            this.panelMenuButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonStandingsPlayers;
        private System.Windows.Forms.Button buttonStandingsTeams;
        private System.Windows.Forms.Panel panelStandings;
        private System.Windows.Forms.Panel panelMenuButtons;
    }
}