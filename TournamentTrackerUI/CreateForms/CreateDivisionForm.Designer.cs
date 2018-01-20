namespace TournamentTrackerUI
{
    partial class CreateDivisionForm
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
            this.DivisionHeaderLabel = new System.Windows.Forms.Label();
            this.DivisionNameLabel = new System.Windows.Forms.Label();
            this.DivisionNumberLabel = new System.Windows.Forms.Label();
            this.AddTeamsLabel = new System.Windows.Forms.Label();
            this.SkipDatesLabel = new System.Windows.Forms.Label();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.DivisionNameTextbox = new System.Windows.Forms.TextBox();
            this.DivisionNumberTextbox = new System.Windows.Forms.TextBox();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.SkipDatesdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.skipDatesAddButton = new System.Windows.Forms.Button();
            this.createDivisionButton = new System.Windows.Forms.Button();
            this.ExitToMainMenuButton = new System.Windows.Forms.Button();
            this.skipDatesRemoveButton = new System.Windows.Forms.Button();
            this.addTeamsDropdown = new System.Windows.Forms.ComboBox();
            this.createNewTeamLinkLabel = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DisplayNumber = new System.Windows.Forms.Label();
            this.DisplayName = new System.Windows.Forms.Label();
            this.DisplayNumTeams = new System.Windows.Forms.Label();
            this.teamsListBox = new System.Windows.Forms.ListBox();
            this.skippedDatesLabel = new System.Windows.Forms.Label();
            this.selectedStartDate = new System.Windows.Forms.Label();
            this.startDateLabel2 = new System.Windows.Forms.Label();
            this.TeamLabel = new System.Windows.Forms.Label();
            this.numTeams = new System.Windows.Forms.Label();
            this.DisplayNumTeamsLabel = new System.Windows.Forms.Label();
            this.DisplayNumberLabel = new System.Windows.Forms.Label();
            this.DisplayNameLabel = new System.Windows.Forms.Label();
            this.skippedDatesListbox = new System.Windows.Forms.ListBox();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.removeTeamButton = new System.Windows.Forms.Button();
            this.seasonNameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DivisionHeaderLabel
            // 
            this.DivisionHeaderLabel.AutoSize = true;
            this.DivisionHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivisionHeaderLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.DivisionHeaderLabel.Location = new System.Drawing.Point(134, 9);
            this.DivisionHeaderLabel.Name = "DivisionHeaderLabel";
            this.DivisionHeaderLabel.Size = new System.Drawing.Size(263, 37);
            this.DivisionHeaderLabel.TabIndex = 0;
            this.DivisionHeaderLabel.Text = "Create Division(s) for";
            // 
            // DivisionNameLabel
            // 
            this.DivisionNameLabel.AutoSize = true;
            this.DivisionNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivisionNameLabel.Location = new System.Drawing.Point(6, 81);
            this.DivisionNameLabel.Name = "DivisionNameLabel";
            this.DivisionNameLabel.Size = new System.Drawing.Size(112, 21);
            this.DivisionNameLabel.TabIndex = 2;
            this.DivisionNameLabel.Text = "Division Name";
            // 
            // DivisionNumberLabel
            // 
            this.DivisionNumberLabel.AutoSize = true;
            this.DivisionNumberLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivisionNumberLabel.Location = new System.Drawing.Point(6, 127);
            this.DivisionNumberLabel.Name = "DivisionNumberLabel";
            this.DivisionNumberLabel.Size = new System.Drawing.Size(128, 21);
            this.DivisionNumberLabel.TabIndex = 3;
            this.DivisionNumberLabel.Text = "Division Number";
            // 
            // AddTeamsLabel
            // 
            this.AddTeamsLabel.AutoSize = true;
            this.AddTeamsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTeamsLabel.Location = new System.Drawing.Point(6, 271);
            this.AddTeamsLabel.Name = "AddTeamsLabel";
            this.AddTeamsLabel.Size = new System.Drawing.Size(87, 21);
            this.AddTeamsLabel.TabIndex = 4;
            this.AddTeamsLabel.Text = "Add Teams";
            // 
            // SkipDatesLabel
            // 
            this.SkipDatesLabel.AutoSize = true;
            this.SkipDatesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkipDatesLabel.Location = new System.Drawing.Point(6, 209);
            this.SkipDatesLabel.Name = "SkipDatesLabel";
            this.SkipDatesLabel.Size = new System.Drawing.Size(101, 21);
            this.SkipDatesLabel.TabIndex = 5;
            this.SkipDatesLabel.Text = "Dates to Skip";
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDateLabel.Location = new System.Drawing.Point(6, 165);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(79, 21);
            this.StartDateLabel.TabIndex = 6;
            this.StartDateLabel.Text = "Start Date";
            // 
            // DivisionNameTextbox
            // 
            this.DivisionNameTextbox.BackColor = System.Drawing.SystemColors.Info;
            this.DivisionNameTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivisionNameTextbox.Location = new System.Drawing.Point(141, 78);
            this.DivisionNameTextbox.Name = "DivisionNameTextbox";
            this.DivisionNameTextbox.Size = new System.Drawing.Size(218, 29);
            this.DivisionNameTextbox.TabIndex = 7;
            this.DivisionNameTextbox.TextChanged += new System.EventHandler(this.DivisionNameTextbox_TextChanged);
            // 
            // DivisionNumberTextbox
            // 
            this.DivisionNumberTextbox.BackColor = System.Drawing.SystemColors.Info;
            this.DivisionNumberTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivisionNumberTextbox.Location = new System.Drawing.Point(141, 124);
            this.DivisionNumberTextbox.Name = "DivisionNumberTextbox";
            this.DivisionNumberTextbox.Size = new System.Drawing.Size(218, 29);
            this.DivisionNumberTextbox.TabIndex = 11;
            this.DivisionNumberTextbox.TextChanged += new System.EventHandler(this.DivisionNumberTextbox_TextChanged);
            // 
            // StartDate
            // 
            this.StartDate.Location = new System.Drawing.Point(141, 164);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(200, 22);
            this.StartDate.TabIndex = 12;
            this.StartDate.ValueChanged += new System.EventHandler(this.StartDate_ValueChanged);
            // 
            // SkipDatesdateTimePicker
            // 
            this.SkipDatesdateTimePicker.Location = new System.Drawing.Point(141, 208);
            this.SkipDatesdateTimePicker.Name = "SkipDatesdateTimePicker";
            this.SkipDatesdateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.SkipDatesdateTimePicker.TabIndex = 13;
            // 
            // skipDatesAddButton
            // 
            this.skipDatesAddButton.Location = new System.Drawing.Point(141, 236);
            this.skipDatesAddButton.Name = "skipDatesAddButton";
            this.skipDatesAddButton.Size = new System.Drawing.Size(75, 30);
            this.skipDatesAddButton.TabIndex = 14;
            this.skipDatesAddButton.Text = "Add";
            this.skipDatesAddButton.UseVisualStyleBackColor = true;
            this.skipDatesAddButton.Click += new System.EventHandler(this.skipDatesAddButton_Click);
            // 
            // createDivisionButton
            // 
            this.createDivisionButton.Location = new System.Drawing.Point(302, 415);
            this.createDivisionButton.Name = "createDivisionButton";
            this.createDivisionButton.Size = new System.Drawing.Size(138, 34);
            this.createDivisionButton.TabIndex = 17;
            this.createDivisionButton.Text = "Create Division";
            this.createDivisionButton.UseVisualStyleBackColor = true;
            this.createDivisionButton.Click += new System.EventHandler(this.createDivisionButton_Click);
            // 
            // ExitToMainMenuButton
            // 
            this.ExitToMainMenuButton.Location = new System.Drawing.Point(671, 415);
            this.ExitToMainMenuButton.Name = "ExitToMainMenuButton";
            this.ExitToMainMenuButton.Size = new System.Drawing.Size(87, 34);
            this.ExitToMainMenuButton.TabIndex = 18;
            this.ExitToMainMenuButton.Text = "Exit to Main Menu";
            this.ExitToMainMenuButton.UseVisualStyleBackColor = true;
            this.ExitToMainMenuButton.Click += new System.EventHandler(this.ExitToMainMenuButton_Click);
            // 
            // skipDatesRemoveButton
            // 
            this.skipDatesRemoveButton.Location = new System.Drawing.Point(313, 108);
            this.skipDatesRemoveButton.Name = "skipDatesRemoveButton";
            this.skipDatesRemoveButton.Size = new System.Drawing.Size(75, 30);
            this.skipDatesRemoveButton.TabIndex = 20;
            this.skipDatesRemoveButton.Text = "Remove";
            this.skipDatesRemoveButton.UseVisualStyleBackColor = true;
            this.skipDatesRemoveButton.Click += new System.EventHandler(this.skipDatesRemoveButton_Click);
            // 
            // addTeamsDropdown
            // 
            this.addTeamsDropdown.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeamsDropdown.FormattingEnabled = true;
            this.addTeamsDropdown.Location = new System.Drawing.Point(141, 271);
            this.addTeamsDropdown.Name = "addTeamsDropdown";
            this.addTeamsDropdown.Size = new System.Drawing.Size(218, 25);
            this.addTeamsDropdown.TabIndex = 25;
            // 
            // createNewTeamLinkLabel
            // 
            this.createNewTeamLinkLabel.AutoSize = true;
            this.createNewTeamLinkLabel.Location = new System.Drawing.Point(138, 315);
            this.createNewTeamLinkLabel.Name = "createNewTeamLinkLabel";
            this.createNewTeamLinkLabel.Size = new System.Drawing.Size(109, 13);
            this.createNewTeamLinkLabel.TabIndex = 30;
            this.createNewTeamLinkLabel.TabStop = true;
            this.createNewTeamLinkLabel.Text = "or Create New Team";
            this.createNewTeamLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createNewTeamLinkLabel_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DisplayNumber);
            this.panel1.Controls.Add(this.DisplayName);
            this.panel1.Controls.Add(this.DisplayNumTeams);
            this.panel1.Controls.Add(this.teamsListBox);
            this.panel1.Controls.Add(this.skippedDatesLabel);
            this.panel1.Controls.Add(this.skipDatesRemoveButton);
            this.panel1.Controls.Add(this.selectedStartDate);
            this.panel1.Controls.Add(this.startDateLabel2);
            this.panel1.Controls.Add(this.TeamLabel);
            this.panel1.Controls.Add(this.numTeams);
            this.panel1.Controls.Add(this.DisplayNumTeamsLabel);
            this.panel1.Controls.Add(this.DisplayNumberLabel);
            this.panel1.Controls.Add(this.DisplayNameLabel);
            this.panel1.Controls.Add(this.skippedDatesListbox);
            this.panel1.Location = new System.Drawing.Point(378, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 338);
            this.panel1.TabIndex = 31;
            // 
            // DisplayNumber
            // 
            this.DisplayNumber.AutoSize = true;
            this.DisplayNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayNumber.Location = new System.Drawing.Point(68, 61);
            this.DisplayNumber.Name = "DisplayNumber";
            this.DisplayNumber.Size = new System.Drawing.Size(56, 17);
            this.DisplayNumber.TabIndex = 41;
            this.DisplayNumber.Text = "Number";
            // 
            // DisplayName
            // 
            this.DisplayName.AutoSize = true;
            this.DisplayName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayName.Location = new System.Drawing.Point(62, 14);
            this.DisplayName.Name = "DisplayName";
            this.DisplayName.Size = new System.Drawing.Size(43, 17);
            this.DisplayName.TabIndex = 40;
            this.DisplayName.Text = "Name";
            // 
            // DisplayNumTeams
            // 
            this.DisplayNumTeams.AutoSize = true;
            this.DisplayNumTeams.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayNumTeams.Location = new System.Drawing.Point(87, 97);
            this.DisplayNumTeams.Name = "DisplayNumTeams";
            this.DisplayNumTeams.Size = new System.Drawing.Size(58, 17);
            this.DisplayNumTeams.TabIndex = 39;
            this.DisplayNumTeams.Text = "# Teams";
            // 
            // teamsListBox
            // 
            this.teamsListBox.FormattingEnabled = true;
            this.teamsListBox.Location = new System.Drawing.Point(6, 142);
            this.teamsListBox.Name = "teamsListBox";
            this.teamsListBox.Size = new System.Drawing.Size(180, 186);
            this.teamsListBox.TabIndex = 36;
            // 
            // skippedDatesLabel
            // 
            this.skippedDatesLabel.AutoSize = true;
            this.skippedDatesLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skippedDatesLabel.Location = new System.Drawing.Point(215, 121);
            this.skippedDatesLabel.Name = "skippedDatesLabel";
            this.skippedDatesLabel.Size = new System.Drawing.Size(92, 17);
            this.skippedDatesLabel.TabIndex = 35;
            this.skippedDatesLabel.Text = "Skipped Dates";
            // 
            // selectedStartDate
            // 
            this.selectedStartDate.AutoSize = true;
            this.selectedStartDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedStartDate.Location = new System.Drawing.Point(215, 88);
            this.selectedStartDate.Name = "selectedStartDate";
            this.selectedStartDate.Size = new System.Drawing.Size(0, 17);
            this.selectedStartDate.TabIndex = 34;
            // 
            // startDateLabel2
            // 
            this.startDateLabel2.AutoSize = true;
            this.startDateLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateLabel2.Location = new System.Drawing.Point(215, 62);
            this.startDateLabel2.Name = "startDateLabel2";
            this.startDateLabel2.Size = new System.Drawing.Size(66, 17);
            this.startDateLabel2.TabIndex = 33;
            this.startDateLabel2.Text = "Start Date";
            // 
            // TeamLabel
            // 
            this.TeamLabel.AutoSize = true;
            this.TeamLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamLabel.Location = new System.Drawing.Point(3, 121);
            this.TeamLabel.Name = "TeamLabel";
            this.TeamLabel.Size = new System.Drawing.Size(46, 17);
            this.TeamLabel.TabIndex = 32;
            this.TeamLabel.Text = "Teams";
            // 
            // numTeams
            // 
            this.numTeams.AutoSize = true;
            this.numTeams.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTeams.Location = new System.Drawing.Point(62, 73);
            this.numTeams.Name = "numTeams";
            this.numTeams.Size = new System.Drawing.Size(0, 17);
            this.numTeams.TabIndex = 31;
            // 
            // DisplayNumTeamsLabel
            // 
            this.DisplayNumTeamsLabel.AutoSize = true;
            this.DisplayNumTeamsLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayNumTeamsLabel.Location = new System.Drawing.Point(3, 96);
            this.DisplayNumTeamsLabel.Name = "DisplayNumTeamsLabel";
            this.DisplayNumTeamsLabel.Size = new System.Drawing.Size(58, 17);
            this.DisplayNumTeamsLabel.TabIndex = 30;
            this.DisplayNumTeamsLabel.Text = "# Teams";
            // 
            // DisplayNumberLabel
            // 
            this.DisplayNumberLabel.AutoSize = true;
            this.DisplayNumberLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayNumberLabel.Location = new System.Drawing.Point(6, 61);
            this.DisplayNumberLabel.Name = "DisplayNumberLabel";
            this.DisplayNumberLabel.Size = new System.Drawing.Size(56, 17);
            this.DisplayNumberLabel.TabIndex = 28;
            this.DisplayNumberLabel.Text = "Number";
            // 
            // DisplayNameLabel
            // 
            this.DisplayNameLabel.AutoSize = true;
            this.DisplayNameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayNameLabel.Location = new System.Drawing.Point(6, 15);
            this.DisplayNameLabel.Name = "DisplayNameLabel";
            this.DisplayNameLabel.Size = new System.Drawing.Size(43, 17);
            this.DisplayNameLabel.TabIndex = 26;
            this.DisplayNameLabel.Text = "Name";
            // 
            // skippedDatesListbox
            // 
            this.skippedDatesListbox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skippedDatesListbox.FormattingEnabled = true;
            this.skippedDatesListbox.HorizontalScrollbar = true;
            this.skippedDatesListbox.Location = new System.Drawing.Point(218, 142);
            this.skippedDatesListbox.Name = "skippedDatesListbox";
            this.skippedDatesListbox.Size = new System.Drawing.Size(180, 186);
            this.skippedDatesListbox.TabIndex = 24;
            // 
            // addTeamButton
            // 
            this.addTeamButton.Location = new System.Drawing.Point(284, 315);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(75, 39);
            this.addTeamButton.TabIndex = 32;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = true;
            this.addTeamButton.Click += new System.EventHandler(this.addTeamButton_Click);
            // 
            // removeTeamButton
            // 
            this.removeTeamButton.Location = new System.Drawing.Point(284, 360);
            this.removeTeamButton.Name = "removeTeamButton";
            this.removeTeamButton.Size = new System.Drawing.Size(75, 39);
            this.removeTeamButton.TabIndex = 33;
            this.removeTeamButton.Text = "Remove Team";
            this.removeTeamButton.UseVisualStyleBackColor = true;
            this.removeTeamButton.Click += new System.EventHandler(this.removeTeamButton_Click);
            // 
            // seasonNameLabel
            // 
            this.seasonNameLabel.AutoSize = true;
            this.seasonNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seasonNameLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.seasonNameLabel.Location = new System.Drawing.Point(403, 9);
            this.seasonNameLabel.Name = "seasonNameLabel";
            this.seasonNameLabel.Size = new System.Drawing.Size(23, 37);
            this.seasonNameLabel.TabIndex = 34;
            this.seasonNameLabel.Text = ".";
            // 
            // CreateDivisionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(793, 461);
            this.Controls.Add(this.seasonNameLabel);
            this.Controls.Add(this.removeTeamButton);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.createNewTeamLinkLabel);
            this.Controls.Add(this.addTeamsDropdown);
            this.Controls.Add(this.ExitToMainMenuButton);
            this.Controls.Add(this.createDivisionButton);
            this.Controls.Add(this.skipDatesAddButton);
            this.Controls.Add(this.SkipDatesdateTimePicker);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.DivisionNumberTextbox);
            this.Controls.Add(this.DivisionNameTextbox);
            this.Controls.Add(this.StartDateLabel);
            this.Controls.Add(this.SkipDatesLabel);
            this.Controls.Add(this.AddTeamsLabel);
            this.Controls.Add(this.DivisionNumberLabel);
            this.Controls.Add(this.DivisionNameLabel);
            this.Controls.Add(this.DivisionHeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CreateDivisionForm";
            this.Text = "DivisionCreator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DivisionHeaderLabel;
        private System.Windows.Forms.Label DivisionNameLabel;
        private System.Windows.Forms.Label DivisionNumberLabel;
        private System.Windows.Forms.Label AddTeamsLabel;
        private System.Windows.Forms.Label SkipDatesLabel;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.TextBox DivisionNameTextbox;
        private System.Windows.Forms.TextBox DivisionNumberTextbox;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.DateTimePicker SkipDatesdateTimePicker;
        private System.Windows.Forms.Button skipDatesAddButton;
        private System.Windows.Forms.Button createDivisionButton;
        private System.Windows.Forms.Button ExitToMainMenuButton;
        private System.Windows.Forms.Button skipDatesRemoveButton;
        private System.Windows.Forms.ComboBox addTeamsDropdown;
        private System.Windows.Forms.LinkLabel createNewTeamLinkLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DisplayNumTeams;
        private System.Windows.Forms.ListBox teamsListBox;
        private System.Windows.Forms.Label skippedDatesLabel;
        private System.Windows.Forms.Label selectedStartDate;
        private System.Windows.Forms.Label startDateLabel2;
        private System.Windows.Forms.Label TeamLabel;
        private System.Windows.Forms.Label numTeams;
        private System.Windows.Forms.Label DisplayNumTeamsLabel;
        private System.Windows.Forms.Label DisplayNumberLabel;
        private System.Windows.Forms.Label DisplayNameLabel;
        private System.Windows.Forms.ListBox skippedDatesListbox;
        private System.Windows.Forms.Label DisplayNumber;
        private System.Windows.Forms.Label DisplayName;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Button removeTeamButton;
        private System.Windows.Forms.Label seasonNameLabel;
    }
}