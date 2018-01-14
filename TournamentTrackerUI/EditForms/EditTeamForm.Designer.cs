namespace TournamentTrackerUI.EditForms
{
    partial class EditTeamForm
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CreateNewTeamLabel = new System.Windows.Forms.Label();
            this.teamDropDown = new System.Windows.Forms.ComboBox();
            this.EditTeamButton = new System.Windows.Forms.Button();
            this.TeamNameLabel = new System.Windows.Forms.Label();
            this.teamNameTextbox = new System.Windows.Forms.TextBox();
            this.TeamVenueLabel = new System.Windows.Forms.Label();
            this.AddPlayerLabel = new System.Windows.Forms.Label();
            this.addPlayerDropdown = new System.Windows.Forms.ComboBox();
            this.CreateNewPlayerLinkLabel = new System.Windows.Forms.LinkLabel();
            this.teamCaptainDropdown = new System.Windows.Forms.ComboBox();
            this.TeamCaptainLabel = new System.Windows.Forms.Label();
            this.AddPlayerButton = new System.Windows.Forms.Button();
            this.removePlayerButton = new System.Windows.Forms.Button();
            this.teamMemberListBox = new System.Windows.Forms.ListBox();
            this.captainSelectButton = new System.Windows.Forms.Button();
            this.venueDropDown = new System.Windows.Forms.ComboBox();
            this.createNewVenueLinkLabel = new System.Windows.Forms.LinkLabel();
            this.DisplayCaptain = new System.Windows.Forms.Label();
            this.DisplayCaptainLabel = new System.Windows.Forms.Label();
            this.DisplayTeamVenue = new System.Windows.Forms.Label();
            this.DisplayTeamVenueLabel = new System.Windows.Forms.Label();
            this.DisplayTeamName = new System.Windows.Forms.Label();
            this.DisplayTeamNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.TitleLabel.Location = new System.Drawing.Point(257, 22);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(160, 37);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Team Editor";
            // 
            // CreateNewTeamLabel
            // 
            this.CreateNewTeamLabel.AutoSize = true;
            this.CreateNewTeamLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateNewTeamLabel.Location = new System.Drawing.Point(40, 88);
            this.CreateNewTeamLabel.Name = "CreateNewTeamLabel";
            this.CreateNewTeamLabel.Size = new System.Drawing.Size(281, 21);
            this.CreateNewTeamLabel.TabIndex = 1;
            this.CreateNewTeamLabel.Text = "Create New Team or Edit Existing Team";
            // 
            // teamDropDown
            // 
            this.teamDropDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamDropDown.FormattingEnabled = true;
            this.teamDropDown.Location = new System.Drawing.Point(345, 85);
            this.teamDropDown.Name = "teamDropDown";
            this.teamDropDown.Size = new System.Drawing.Size(156, 29);
            this.teamDropDown.TabIndex = 2;
            this.teamDropDown.SelectedValueChanged += new System.EventHandler(this.teamDropDown_SelectedValueChanged);
            // 
            // EditTeamButton
            // 
            this.EditTeamButton.Location = new System.Drawing.Point(389, 355);
            this.EditTeamButton.Name = "EditTeamButton";
            this.EditTeamButton.Size = new System.Drawing.Size(112, 37);
            this.EditTeamButton.TabIndex = 3;
            this.EditTeamButton.Text = "Edit Team";
            this.EditTeamButton.UseVisualStyleBackColor = true;
            this.EditTeamButton.Click += new System.EventHandler(this.EditTeamButton_Click);
            // 
            // TeamNameLabel
            // 
            this.TeamNameLabel.AutoSize = true;
            this.TeamNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamNameLabel.Location = new System.Drawing.Point(40, 139);
            this.TeamNameLabel.Name = "TeamNameLabel";
            this.TeamNameLabel.Size = new System.Drawing.Size(94, 21);
            this.TeamNameLabel.TabIndex = 4;
            this.TeamNameLabel.Text = "Team Name";
            // 
            // teamNameTextbox
            // 
            this.teamNameTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamNameTextbox.Location = new System.Drawing.Point(171, 139);
            this.teamNameTextbox.Name = "teamNameTextbox";
            this.teamNameTextbox.Size = new System.Drawing.Size(165, 29);
            this.teamNameTextbox.TabIndex = 5;
            this.teamNameTextbox.Enter += new System.EventHandler(this.teamNameTextbox_Enter);
            this.teamNameTextbox.Leave += new System.EventHandler(this.teamNameTextbox_Leave);
            // 
            // TeamVenueLabel
            // 
            this.TeamVenueLabel.AutoSize = true;
            this.TeamVenueLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamVenueLabel.Location = new System.Drawing.Point(40, 195);
            this.TeamVenueLabel.Name = "TeamVenueLabel";
            this.TeamVenueLabel.Size = new System.Drawing.Size(96, 21);
            this.TeamVenueLabel.TabIndex = 6;
            this.TeamVenueLabel.Text = "Team Venue";
            // 
            // AddPlayerLabel
            // 
            this.AddPlayerLabel.AutoSize = true;
            this.AddPlayerLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPlayerLabel.Location = new System.Drawing.Point(40, 253);
            this.AddPlayerLabel.Name = "AddPlayerLabel";
            this.AddPlayerLabel.Size = new System.Drawing.Size(85, 21);
            this.AddPlayerLabel.TabIndex = 8;
            this.AddPlayerLabel.Text = "Add Player";
            // 
            // addPlayerDropdown
            // 
            this.addPlayerDropdown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPlayerDropdown.FormattingEnabled = true;
            this.addPlayerDropdown.Location = new System.Drawing.Point(171, 250);
            this.addPlayerDropdown.Name = "addPlayerDropdown";
            this.addPlayerDropdown.Size = new System.Drawing.Size(165, 29);
            this.addPlayerDropdown.TabIndex = 9;
            // 
            // CreateNewPlayerLinkLabel
            // 
            this.CreateNewPlayerLinkLabel.AutoSize = true;
            this.CreateNewPlayerLinkLabel.Location = new System.Drawing.Point(223, 291);
            this.CreateNewPlayerLinkLabel.Name = "CreateNewPlayerLinkLabel";
            this.CreateNewPlayerLinkLabel.Size = new System.Drawing.Size(113, 13);
            this.CreateNewPlayerLinkLabel.TabIndex = 10;
            this.CreateNewPlayerLinkLabel.TabStop = true;
            this.CreateNewPlayerLinkLabel.Text = "or Create New Player";
            this.CreateNewPlayerLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateNewPlayerLinkLabel_LinkClicked);
            // 
            // teamCaptainDropdown
            // 
            this.teamCaptainDropdown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamCaptainDropdown.FormattingEnabled = true;
            this.teamCaptainDropdown.Location = new System.Drawing.Point(171, 314);
            this.teamCaptainDropdown.Name = "teamCaptainDropdown";
            this.teamCaptainDropdown.Size = new System.Drawing.Size(165, 29);
            this.teamCaptainDropdown.TabIndex = 12;
            // 
            // TeamCaptainLabel
            // 
            this.TeamCaptainLabel.AutoSize = true;
            this.TeamCaptainLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamCaptainLabel.Location = new System.Drawing.Point(40, 317);
            this.TeamCaptainLabel.Name = "TeamCaptainLabel";
            this.TeamCaptainLabel.Size = new System.Drawing.Size(105, 21);
            this.TeamCaptainLabel.TabIndex = 11;
            this.TeamCaptainLabel.Text = "Team Captain";
            // 
            // AddPlayerButton
            // 
            this.AddPlayerButton.Location = new System.Drawing.Point(389, 234);
            this.AddPlayerButton.Name = "AddPlayerButton";
            this.AddPlayerButton.Size = new System.Drawing.Size(112, 36);
            this.AddPlayerButton.TabIndex = 13;
            this.AddPlayerButton.Text = "Add Player -->";
            this.AddPlayerButton.UseVisualStyleBackColor = true;
            this.AddPlayerButton.Click += new System.EventHandler(this.AddPlayerButton_Click);
            // 
            // removePlayerButton
            // 
            this.removePlayerButton.Location = new System.Drawing.Point(389, 279);
            this.removePlayerButton.Name = "removePlayerButton";
            this.removePlayerButton.Size = new System.Drawing.Size(112, 36);
            this.removePlayerButton.TabIndex = 17;
            this.removePlayerButton.Text = "<---Remove Player";
            this.removePlayerButton.UseVisualStyleBackColor = true;
            this.removePlayerButton.Click += new System.EventHandler(this.removePlayerButton_Click);
            // 
            // teamMemberListBox
            // 
            this.teamMemberListBox.FormattingEnabled = true;
            this.teamMemberListBox.Location = new System.Drawing.Point(523, 201);
            this.teamMemberListBox.Name = "teamMemberListBox";
            this.teamMemberListBox.Size = new System.Drawing.Size(235, 212);
            this.teamMemberListBox.TabIndex = 18;
            // 
            // captainSelectButton
            // 
            this.captainSelectButton.Location = new System.Drawing.Point(261, 355);
            this.captainSelectButton.Name = "captainSelectButton";
            this.captainSelectButton.Size = new System.Drawing.Size(75, 37);
            this.captainSelectButton.TabIndex = 19;
            this.captainSelectButton.Text = "Select Captain";
            this.captainSelectButton.UseVisualStyleBackColor = true;
            this.captainSelectButton.Click += new System.EventHandler(this.captainSelectButton_Click);
            // 
            // venueDropDown
            // 
            this.venueDropDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.venueDropDown.FormattingEnabled = true;
            this.venueDropDown.Location = new System.Drawing.Point(171, 192);
            this.venueDropDown.Name = "venueDropDown";
            this.venueDropDown.Size = new System.Drawing.Size(165, 29);
            this.venueDropDown.TabIndex = 20;
            // 
            // createNewVenueLinkLabel
            // 
            this.createNewVenueLinkLabel.AutoSize = true;
            this.createNewVenueLinkLabel.Location = new System.Drawing.Point(220, 224);
            this.createNewVenueLinkLabel.Name = "createNewVenueLinkLabel";
            this.createNewVenueLinkLabel.Size = new System.Drawing.Size(116, 13);
            this.createNewVenueLinkLabel.TabIndex = 24;
            this.createNewVenueLinkLabel.TabStop = true;
            this.createNewVenueLinkLabel.Text = "or Create New Venue";
            // 
            // DisplayCaptain
            // 
            this.DisplayCaptain.AutoSize = true;
            this.DisplayCaptain.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayCaptain.Location = new System.Drawing.Point(614, 167);
            this.DisplayCaptain.Name = "DisplayCaptain";
            this.DisplayCaptain.Size = new System.Drawing.Size(43, 17);
            this.DisplayCaptain.TabIndex = 35;
            this.DisplayCaptain.Text = "label7";
            // 
            // DisplayCaptainLabel
            // 
            this.DisplayCaptainLabel.AutoSize = true;
            this.DisplayCaptainLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayCaptainLabel.Location = new System.Drawing.Point(520, 167);
            this.DisplayCaptainLabel.Name = "DisplayCaptainLabel";
            this.DisplayCaptainLabel.Size = new System.Drawing.Size(88, 17);
            this.DisplayCaptainLabel.TabIndex = 34;
            this.DisplayCaptainLabel.Text = "Team Captain";
            // 
            // DisplayTeamVenue
            // 
            this.DisplayTeamVenue.AutoSize = true;
            this.DisplayTeamVenue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayTeamVenue.Location = new System.Drawing.Point(614, 141);
            this.DisplayTeamVenue.Name = "DisplayTeamVenue";
            this.DisplayTeamVenue.Size = new System.Drawing.Size(43, 17);
            this.DisplayTeamVenue.TabIndex = 33;
            this.DisplayTeamVenue.Text = "label5";
            // 
            // DisplayTeamVenueLabel
            // 
            this.DisplayTeamVenueLabel.AutoSize = true;
            this.DisplayTeamVenueLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayTeamVenueLabel.Location = new System.Drawing.Point(520, 141);
            this.DisplayTeamVenueLabel.Name = "DisplayTeamVenueLabel";
            this.DisplayTeamVenueLabel.Size = new System.Drawing.Size(44, 17);
            this.DisplayTeamVenueLabel.TabIndex = 32;
            this.DisplayTeamVenueLabel.Text = "Venue";
            // 
            // DisplayTeamName
            // 
            this.DisplayTeamName.AutoSize = true;
            this.DisplayTeamName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayTeamName.Location = new System.Drawing.Point(614, 117);
            this.DisplayTeamName.Name = "DisplayTeamName";
            this.DisplayTeamName.Size = new System.Drawing.Size(43, 17);
            this.DisplayTeamName.TabIndex = 31;
            this.DisplayTeamName.Text = "label3";
            // 
            // DisplayTeamNameLabel
            // 
            this.DisplayTeamNameLabel.AutoSize = true;
            this.DisplayTeamNameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayTeamNameLabel.Location = new System.Drawing.Point(520, 117);
            this.DisplayTeamNameLabel.Name = "DisplayTeamNameLabel";
            this.DisplayTeamNameLabel.Size = new System.Drawing.Size(79, 17);
            this.DisplayTeamNameLabel.TabIndex = 30;
            this.DisplayTeamNameLabel.Text = "Team Name";
            // 
            // EditTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(770, 420);
            this.Controls.Add(this.DisplayCaptain);
            this.Controls.Add(this.DisplayCaptainLabel);
            this.Controls.Add(this.DisplayTeamVenue);
            this.Controls.Add(this.DisplayTeamVenueLabel);
            this.Controls.Add(this.DisplayTeamName);
            this.Controls.Add(this.DisplayTeamNameLabel);
            this.Controls.Add(this.createNewVenueLinkLabel);
            this.Controls.Add(this.venueDropDown);
            this.Controls.Add(this.captainSelectButton);
            this.Controls.Add(this.teamMemberListBox);
            this.Controls.Add(this.removePlayerButton);
            this.Controls.Add(this.AddPlayerButton);
            this.Controls.Add(this.teamCaptainDropdown);
            this.Controls.Add(this.TeamCaptainLabel);
            this.Controls.Add(this.CreateNewPlayerLinkLabel);
            this.Controls.Add(this.addPlayerDropdown);
            this.Controls.Add(this.AddPlayerLabel);
            this.Controls.Add(this.TeamVenueLabel);
            this.Controls.Add(this.teamNameTextbox);
            this.Controls.Add(this.TeamNameLabel);
            this.Controls.Add(this.EditTeamButton);
            this.Controls.Add(this.teamDropDown);
            this.Controls.Add(this.CreateNewTeamLabel);
            this.Controls.Add(this.TitleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EditTeamForm";
            this.Text = "TeamCreator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label CreateNewTeamLabel;
        private System.Windows.Forms.ComboBox teamDropDown;
        private System.Windows.Forms.Button EditTeamButton;
        private System.Windows.Forms.Label TeamNameLabel;
        private System.Windows.Forms.TextBox teamNameTextbox;
        private System.Windows.Forms.Label TeamVenueLabel;
        private System.Windows.Forms.Label AddPlayerLabel;
        private System.Windows.Forms.ComboBox addPlayerDropdown;
        private System.Windows.Forms.LinkLabel CreateNewPlayerLinkLabel;
        private System.Windows.Forms.ComboBox teamCaptainDropdown;
        private System.Windows.Forms.Label TeamCaptainLabel;
        private System.Windows.Forms.Button AddPlayerButton;
        private System.Windows.Forms.Button removePlayerButton;
        private System.Windows.Forms.ListBox teamMemberListBox;
        private System.Windows.Forms.Button captainSelectButton;
        private System.Windows.Forms.ComboBox venueDropDown;
        private System.Windows.Forms.LinkLabel createNewVenueLinkLabel;
        private System.Windows.Forms.Label DisplayCaptain;
        private System.Windows.Forms.Label DisplayCaptainLabel;
        private System.Windows.Forms.Label DisplayTeamVenue;
        private System.Windows.Forms.Label DisplayTeamVenueLabel;
        private System.Windows.Forms.Label DisplayTeamName;
        private System.Windows.Forms.Label DisplayTeamNameLabel;
    }
}