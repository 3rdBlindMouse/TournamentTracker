namespace TournamentTrackerUI
{
    partial class CreateTeamForm
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
            this.TeamNameLabel = new System.Windows.Forms.Label();
            this.teamNameTextbox = new System.Windows.Forms.TextBox();
            this.TeamVenueLabel = new System.Windows.Forms.Label();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.venueDropDown = new System.Windows.Forms.ComboBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.createNewVenueLinkLabel = new System.Windows.Forms.LinkLabel();
            this.DisplayTeamNameLabel = new System.Windows.Forms.Label();
            this.DisplayTeamName = new System.Windows.Forms.Label();
            this.DisplayTeamVenueLabel = new System.Windows.Forms.Label();
            this.DisplayTeamVenue = new System.Windows.Forms.Label();
            this.HeadingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TeamNameLabel
            // 
            this.TeamNameLabel.AutoSize = true;
            this.TeamNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamNameLabel.Location = new System.Drawing.Point(31, 84);
            this.TeamNameLabel.Name = "TeamNameLabel";
            this.TeamNameLabel.Size = new System.Drawing.Size(94, 21);
            this.TeamNameLabel.TabIndex = 4;
            this.TeamNameLabel.Text = "Team Name";
            // 
            // teamNameTextbox
            // 
            this.teamNameTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamNameTextbox.Location = new System.Drawing.Point(162, 84);
            this.teamNameTextbox.Name = "teamNameTextbox";
            this.teamNameTextbox.Size = new System.Drawing.Size(165, 29);
            this.teamNameTextbox.TabIndex = 5;
            this.teamNameTextbox.TextChanged += new System.EventHandler(this.teamNameTextbox_TextChanged);
            this.teamNameTextbox.Enter += new System.EventHandler(this.teamNameTextbox_Enter);
            this.teamNameTextbox.Leave += new System.EventHandler(this.teamNameTextbox_Leave);
            // 
            // TeamVenueLabel
            // 
            this.TeamVenueLabel.AutoSize = true;
            this.TeamVenueLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamVenueLabel.Location = new System.Drawing.Point(31, 140);
            this.TeamVenueLabel.Name = "TeamVenueLabel";
            this.TeamVenueLabel.Size = new System.Drawing.Size(96, 21);
            this.TeamVenueLabel.TabIndex = 6;
            this.TeamVenueLabel.Text = "Team Venue";
            // 
            // createTeamButton
            // 
            this.createTeamButton.Location = new System.Drawing.Point(354, 374);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(112, 34);
            this.createTeamButton.TabIndex = 16;
            this.createTeamButton.Text = "Create Team";
            this.createTeamButton.UseVisualStyleBackColor = true;
            this.createTeamButton.Click += new System.EventHandler(this.createTeamButton_Click);
            // 
            // venueDropDown
            // 
            this.venueDropDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.venueDropDown.FormattingEnabled = true;
            this.venueDropDown.Location = new System.Drawing.Point(162, 137);
            this.venueDropDown.Name = "venueDropDown";
            this.venueDropDown.Size = new System.Drawing.Size(165, 29);
            this.venueDropDown.TabIndex = 20;
            this.venueDropDown.SelectedValueChanged += new System.EventHandler(this.venueDropDown_SelectedValueChanged);
            this.venueDropDown.Enter += new System.EventHandler(this.venueDropDown_Enter);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(625, 374);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(96, 34);
            this.exitButton.TabIndex = 22;
            this.exitButton.Text = "Exit To Main Menu";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // createNewVenueLinkLabel
            // 
            this.createNewVenueLinkLabel.AutoSize = true;
            this.createNewVenueLinkLabel.Location = new System.Drawing.Point(214, 169);
            this.createNewVenueLinkLabel.Name = "createNewVenueLinkLabel";
            this.createNewVenueLinkLabel.Size = new System.Drawing.Size(116, 13);
            this.createNewVenueLinkLabel.TabIndex = 23;
            this.createNewVenueLinkLabel.TabStop = true;
            this.createNewVenueLinkLabel.Text = "or Create New Venue";
            this.createNewVenueLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createNewVenueLinkLabel_LinkClicked);
            // 
            // DisplayTeamNameLabel
            // 
            this.DisplayTeamNameLabel.AutoSize = true;
            this.DisplayTeamNameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayTeamNameLabel.Location = new System.Drawing.Point(475, 90);
            this.DisplayTeamNameLabel.Name = "DisplayTeamNameLabel";
            this.DisplayTeamNameLabel.Size = new System.Drawing.Size(79, 17);
            this.DisplayTeamNameLabel.TabIndex = 24;
            this.DisplayTeamNameLabel.Text = "Team Name";
            // 
            // DisplayTeamName
            // 
            this.DisplayTeamName.AutoSize = true;
            this.DisplayTeamName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayTeamName.Location = new System.Drawing.Point(569, 90);
            this.DisplayTeamName.Name = "DisplayTeamName";
            this.DisplayTeamName.Size = new System.Drawing.Size(43, 17);
            this.DisplayTeamName.TabIndex = 25;
            this.DisplayTeamName.Text = "label3";
            // 
            // DisplayTeamVenueLabel
            // 
            this.DisplayTeamVenueLabel.AutoSize = true;
            this.DisplayTeamVenueLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayTeamVenueLabel.Location = new System.Drawing.Point(475, 114);
            this.DisplayTeamVenueLabel.Name = "DisplayTeamVenueLabel";
            this.DisplayTeamVenueLabel.Size = new System.Drawing.Size(44, 17);
            this.DisplayTeamVenueLabel.TabIndex = 26;
            this.DisplayTeamVenueLabel.Text = "Venue";
            // 
            // DisplayTeamVenue
            // 
            this.DisplayTeamVenue.AutoSize = true;
            this.DisplayTeamVenue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayTeamVenue.Location = new System.Drawing.Point(569, 114);
            this.DisplayTeamVenue.Name = "DisplayTeamVenue";
            this.DisplayTeamVenue.Size = new System.Drawing.Size(43, 17);
            this.DisplayTeamVenue.TabIndex = 27;
            this.DisplayTeamVenue.Text = "label5";
            // 
            // HeadingLabel
            // 
            this.HeadingLabel.AutoSize = true;
            this.HeadingLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadingLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.HeadingLabel.Location = new System.Drawing.Point(259, 19);
            this.HeadingLabel.Name = "HeadingLabel";
            this.HeadingLabel.Size = new System.Drawing.Size(177, 37);
            this.HeadingLabel.TabIndex = 30;
            this.HeadingLabel.Text = "Team Creator";
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(770, 420);
            this.Controls.Add(this.HeadingLabel);
            this.Controls.Add(this.DisplayTeamVenue);
            this.Controls.Add(this.DisplayTeamVenueLabel);
            this.Controls.Add(this.DisplayTeamName);
            this.Controls.Add(this.DisplayTeamNameLabel);
            this.Controls.Add(this.createNewVenueLinkLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.venueDropDown);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.TeamVenueLabel);
            this.Controls.Add(this.teamNameTextbox);
            this.Controls.Add(this.TeamNameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CreateTeamForm";
            this.Text = "TeamCreator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TeamNameLabel;
        private System.Windows.Forms.TextBox teamNameTextbox;
        private System.Windows.Forms.Label TeamVenueLabel;
        private System.Windows.Forms.Button createTeamButton;
        private System.Windows.Forms.ComboBox venueDropDown;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.LinkLabel createNewVenueLinkLabel;
        private System.Windows.Forms.Label DisplayTeamNameLabel;
        private System.Windows.Forms.Label DisplayTeamName;
        private System.Windows.Forms.Label DisplayTeamVenueLabel;
        private System.Windows.Forms.Label DisplayTeamVenue;
        private System.Windows.Forms.Label HeadingLabel;
    }
}