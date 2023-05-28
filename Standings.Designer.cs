
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
            this.panelStandings = new System.Windows.Forms.Panel();
            this.panelMenuButtons = new System.Windows.Forms.Panel();
            this.buttonStandingsTeams = new System.Windows.Forms.Button();
            this.buttonStandingsPlayers = new System.Windows.Forms.Button();
            this.panelMenuButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelStandings
            // 
            this.panelStandings.BackColor = System.Drawing.Color.Transparent;
            this.panelStandings.BackgroundImage = global::F1Aggregator.Properties.Resources.standingsBG_2;
            this.panelStandings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelStandings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStandings.Location = new System.Drawing.Point(0, 100);
            this.panelStandings.Name = "panelStandings";
            this.panelStandings.Size = new System.Drawing.Size(1084, 581);
            this.panelStandings.TabIndex = 5;
            // 
            // panelMenuButtons
            // 
            this.panelMenuButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(31)))));
            this.panelMenuButtons.Controls.Add(this.buttonStandingsTeams);
            this.panelMenuButtons.Controls.Add(this.buttonStandingsPlayers);
            this.panelMenuButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuButtons.Location = new System.Drawing.Point(0, 0);
            this.panelMenuButtons.Name = "panelMenuButtons";
            this.panelMenuButtons.Size = new System.Drawing.Size(1084, 100);
            this.panelMenuButtons.TabIndex = 6;
            // 
            // buttonStandingsTeams
            // 
            this.buttonStandingsTeams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(31)))));
            this.buttonStandingsTeams.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonStandingsTeams.FlatAppearance.BorderSize = 0;
            this.buttonStandingsTeams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStandingsTeams.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStandingsTeams.ForeColor = System.Drawing.Color.White;
            this.buttonStandingsTeams.Location = new System.Drawing.Point(545, 22);
            this.buttonStandingsTeams.Name = "buttonStandingsTeams";
            this.buttonStandingsTeams.Size = new System.Drawing.Size(147, 41);
            this.buttonStandingsTeams.TabIndex = 14;
            this.buttonStandingsTeams.Text = "Teams";
            this.buttonStandingsTeams.UseVisualStyleBackColor = false;
            this.buttonStandingsTeams.Click += new System.EventHandler(this.ButtonStandingsTeams_Click);
            // 
            // buttonStandingsPlayers
            // 
            this.buttonStandingsPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(31)))));
            this.buttonStandingsPlayers.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonStandingsPlayers.FlatAppearance.BorderSize = 0;
            this.buttonStandingsPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStandingsPlayers.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStandingsPlayers.ForeColor = System.Drawing.Color.White;
            this.buttonStandingsPlayers.Location = new System.Drawing.Point(392, 22);
            this.buttonStandingsPlayers.Name = "buttonStandingsPlayers";
            this.buttonStandingsPlayers.Size = new System.Drawing.Size(147, 41);
            this.buttonStandingsPlayers.TabIndex = 13;
            this.buttonStandingsPlayers.Text = "Players";
            this.buttonStandingsPlayers.UseVisualStyleBackColor = false;
            this.buttonStandingsPlayers.Click += new System.EventHandler(this.ButtonStandingsPlayers_Click);
            // 
            // Standings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(31)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1084, 681);
            this.Controls.Add(this.panelStandings);
            this.Controls.Add(this.panelMenuButtons);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Standings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Standings";
            this.panelMenuButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelStandings;
        private System.Windows.Forms.Panel panelMenuButtons;
        private System.Windows.Forms.Button buttonStandingsPlayers;
        private System.Windows.Forms.Button buttonStandingsTeams;
    }
}