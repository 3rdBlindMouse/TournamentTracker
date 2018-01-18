namespace TournamentTrackerUI
{
    partial class EditDivisionForm
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
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.SkipDatesdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.skipDatesAddButton = new System.Windows.Forms.Button();
            this.ExitToMainMenuButton = new System.Windows.Forms.Button();
            this.DivisionTournamentNameLabel = new System.Windows.Forms.Label();
            this.skipDatesRemoveButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numberErrorLabel = new System.Windows.Forms.Label();
            this.nameErrorLabel = new System.Windows.Forms.Label();
            this.numberOfTeamsLabel = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.teamsListBox = new System.Windows.Forms.ListBox();
            this.skippedDatesLabel = new System.Windows.Forms.Label();
            this.selectedStartDate = new System.Windows.Forms.Label();
            this.startDateLabel2 = new System.Windows.Forms.Label();
            this.TeamLabel = new System.Windows.Forms.Label();
            this.numTeams = new System.Windows.Forms.Label();
            this.numTeamsLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.skippedDatesListbox = new System.Windows.Forms.ListBox();
            this.addTeamsDropdown = new System.Windows.Forms.ComboBox();
            this.DivisionNameComboBox = new System.Windows.Forms.ComboBox();
            this.RemoveTeamButton = new System.Windows.Forms.Button();
            this.AddTeamButton = new System.Windows.Forms.Button();
            this.EditDivisionButton = new System.Windows.Forms.Button();
            this.DivNumberLabel = new System.Windows.Forms.Label();
            this.createNewTeamLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.DivisionHeaderLabel.Size = new System.Drawing.Size(232, 37);
            this.DivisionHeaderLabel.TabIndex = 0;
            this.DivisionHeaderLabel.Text = "Edit Division(s) for";
            // 
            // DivisionNameLabel
            // 
            this.DivisionNameLabel.AutoSize = true;
            this.DivisionNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivisionNameLabel.Location = new System.Drawing.Point(6, 102);
            this.DivisionNameLabel.Name = "DivisionNameLabel";
            this.DivisionNameLabel.Size = new System.Drawing.Size(66, 21);
            this.DivisionNameLabel.TabIndex = 2;
            this.DivisionNameLabel.Text = "Division";
            // 
            // DivisionNumberLabel
            // 
            this.DivisionNumberLabel.AutoSize = true;
            this.DivisionNumberLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivisionNumberLabel.Location = new System.Drawing.Point(6, 148);
            this.DivisionNumberLabel.Name = "DivisionNumberLabel";
            this.DivisionNumberLabel.Size = new System.Drawing.Size(128, 21);
            this.DivisionNumberLabel.TabIndex = 3;
            this.DivisionNumberLabel.Text = "Division Number";
            // 
            // AddTeamsLabel
            // 
            this.AddTeamsLabel.AutoSize = true;
            this.AddTeamsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTeamsLabel.Location = new System.Drawing.Point(6, 292);
            this.AddTeamsLabel.Name = "AddTeamsLabel";
            this.AddTeamsLabel.Size = new System.Drawing.Size(87, 21);
            this.AddTeamsLabel.TabIndex = 4;
            this.AddTeamsLabel.Text = "Add Teams";
            // 
            // SkipDatesLabel
            // 
            this.SkipDatesLabel.AutoSize = true;
            this.SkipDatesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkipDatesLabel.Location = new System.Drawing.Point(6, 230);
            this.SkipDatesLabel.Name = "SkipDatesLabel";
            this.SkipDatesLabel.Size = new System.Drawing.Size(101, 21);
            this.SkipDatesLabel.TabIndex = 5;
            this.SkipDatesLabel.Text = "Dates to Skip";
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDateLabel.Location = new System.Drawing.Point(6, 186);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(79, 21);
            this.StartDateLabel.TabIndex = 6;
            this.StartDateLabel.Text = "Start Date";
            // 
            // StartDate
            // 
            this.StartDate.Location = new System.Drawing.Point(141, 185);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(200, 22);
            this.StartDate.TabIndex = 12;
            this.StartDate.ValueChanged += new System.EventHandler(this.StartDate_ValueChanged);
            // 
            // SkipDatesdateTimePicker
            // 
            this.SkipDatesdateTimePicker.Location = new System.Drawing.Point(141, 229);
            this.SkipDatesdateTimePicker.Name = "SkipDatesdateTimePicker";
            this.SkipDatesdateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.SkipDatesdateTimePicker.TabIndex = 13;
            // 
            // skipDatesAddButton
            // 
            this.skipDatesAddButton.Location = new System.Drawing.Point(141, 257);
            this.skipDatesAddButton.Name = "skipDatesAddButton";
            this.skipDatesAddButton.Size = new System.Drawing.Size(75, 30);
            this.skipDatesAddButton.TabIndex = 14;
            this.skipDatesAddButton.Text = "Add";
            this.skipDatesAddButton.UseVisualStyleBackColor = true;
            this.skipDatesAddButton.Click += new System.EventHandler(this.skipDatesAddButton_Click);
            // 
            // ExitToMainMenuButton
            // 
            this.ExitToMainMenuButton.Location = new System.Drawing.Point(714, 458);
            this.ExitToMainMenuButton.Name = "ExitToMainMenuButton";
            this.ExitToMainMenuButton.Size = new System.Drawing.Size(87, 34);
            this.ExitToMainMenuButton.TabIndex = 18;
            this.ExitToMainMenuButton.Text = "Exit to Main Menu";
            this.ExitToMainMenuButton.UseVisualStyleBackColor = true;
            this.ExitToMainMenuButton.Click += new System.EventHandler(this.ExitToMainMenuButton_Click);
            // 
            // DivisionTournamentNameLabel
            // 
            this.DivisionTournamentNameLabel.AutoSize = true;
            this.DivisionTournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivisionTournamentNameLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.DivisionTournamentNameLabel.Location = new System.Drawing.Point(403, 9);
            this.DivisionTournamentNameLabel.Name = "DivisionTournamentNameLabel";
            this.DivisionTournamentNameLabel.Size = new System.Drawing.Size(209, 37);
            this.DivisionTournamentNameLabel.TabIndex = 19;
            this.DivisionTournamentNameLabel.Text = "PlaceHolderText";
            // 
            // skipDatesRemoveButton
            // 
            this.skipDatesRemoveButton.Location = new System.Drawing.Point(266, 257);
            this.skipDatesRemoveButton.Name = "skipDatesRemoveButton";
            this.skipDatesRemoveButton.Size = new System.Drawing.Size(75, 30);
            this.skipDatesRemoveButton.TabIndex = 20;
            this.skipDatesRemoveButton.Text = "Remove";
            this.skipDatesRemoveButton.UseVisualStyleBackColor = true;
            this.skipDatesRemoveButton.Click += new System.EventHandler(this.skipDatesRemoveButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numberErrorLabel);
            this.panel1.Controls.Add(this.nameErrorLabel);
            this.panel1.Controls.Add(this.numberOfTeamsLabel);
            this.panel1.Controls.Add(this.numberTextBox);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.teamsListBox);
            this.panel1.Controls.Add(this.skippedDatesLabel);
            this.panel1.Controls.Add(this.selectedStartDate);
            this.panel1.Controls.Add(this.startDateLabel2);
            this.panel1.Controls.Add(this.TeamLabel);
            this.panel1.Controls.Add(this.numTeams);
            this.panel1.Controls.Add(this.numTeamsLabel);
            this.panel1.Controls.Add(this.numberLabel);
            this.panel1.Controls.Add(this.nameLabel1);
            this.panel1.Controls.Add(this.skippedDatesListbox);
            this.panel1.Location = new System.Drawing.Point(378, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 378);
            this.panel1.TabIndex = 24;
            // 
            // numberErrorLabel
            // 
            this.numberErrorLabel.AutoSize = true;
            this.numberErrorLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberErrorLabel.Location = new System.Drawing.Point(215, 61);
            this.numberErrorLabel.Name = "numberErrorLabel";
            this.numberErrorLabel.Size = new System.Drawing.Size(0, 17);
            this.numberErrorLabel.TabIndex = 41;
            // 
            // nameErrorLabel
            // 
            this.nameErrorLabel.AutoSize = true;
            this.nameErrorLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameErrorLabel.Location = new System.Drawing.Point(215, 15);
            this.nameErrorLabel.Name = "nameErrorLabel";
            this.nameErrorLabel.Size = new System.Drawing.Size(0, 17);
            this.nameErrorLabel.TabIndex = 40;
            // 
            // numberOfTeamsLabel
            // 
            this.numberOfTeamsLabel.AutoSize = true;
            this.numberOfTeamsLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfTeamsLabel.Location = new System.Drawing.Point(87, 144);
            this.numberOfTeamsLabel.Name = "numberOfTeamsLabel";
            this.numberOfTeamsLabel.Size = new System.Drawing.Size(58, 17);
            this.numberOfTeamsLabel.TabIndex = 39;
            this.numberOfTeamsLabel.Text = "# Teams";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberTextBox.Location = new System.Drawing.Point(81, 58);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(119, 25);
            this.numberTextBox.TabIndex = 38;
            this.numberTextBox.TextChanged += new System.EventHandler(this.numberTextBox_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(81, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(119, 25);
            this.nameTextBox.TabIndex = 37;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // teamsListBox
            // 
            this.teamsListBox.FormattingEnabled = true;
            this.teamsListBox.Location = new System.Drawing.Point(6, 189);
            this.teamsListBox.Name = "teamsListBox";
            this.teamsListBox.Size = new System.Drawing.Size(180, 186);
            this.teamsListBox.TabIndex = 36;
            // 
            // skippedDatesLabel
            // 
            this.skippedDatesLabel.AutoSize = true;
            this.skippedDatesLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skippedDatesLabel.Location = new System.Drawing.Point(215, 168);
            this.skippedDatesLabel.Name = "skippedDatesLabel";
            this.skippedDatesLabel.Size = new System.Drawing.Size(92, 17);
            this.skippedDatesLabel.TabIndex = 35;
            this.skippedDatesLabel.Text = "Skipped Dates";
            // 
            // selectedStartDate
            // 
            this.selectedStartDate.AutoSize = true;
            this.selectedStartDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedStartDate.Location = new System.Drawing.Point(215, 143);
            this.selectedStartDate.Name = "selectedStartDate";
            this.selectedStartDate.Size = new System.Drawing.Size(23, 17);
            this.selectedStartDate.TabIndex = 34;
            this.selectedStartDate.Text = "---";
            // 
            // startDateLabel2
            // 
            this.startDateLabel2.AutoSize = true;
            this.startDateLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateLabel2.Location = new System.Drawing.Point(215, 109);
            this.startDateLabel2.Name = "startDateLabel2";
            this.startDateLabel2.Size = new System.Drawing.Size(66, 17);
            this.startDateLabel2.TabIndex = 33;
            this.startDateLabel2.Text = "Start Date";
            // 
            // TeamLabel
            // 
            this.TeamLabel.AutoSize = true;
            this.TeamLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamLabel.Location = new System.Drawing.Point(3, 168);
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
            // numTeamsLabel
            // 
            this.numTeamsLabel.AutoSize = true;
            this.numTeamsLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTeamsLabel.Location = new System.Drawing.Point(3, 143);
            this.numTeamsLabel.Name = "numTeamsLabel";
            this.numTeamsLabel.Size = new System.Drawing.Size(58, 17);
            this.numTeamsLabel.TabIndex = 30;
            this.numTeamsLabel.Text = "# Teams";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLabel.Location = new System.Drawing.Point(6, 61);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(56, 17);
            this.numberLabel.TabIndex = 28;
            this.numberLabel.Text = "Number";
            // 
            // nameLabel1
            // 
            this.nameLabel1.AutoSize = true;
            this.nameLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel1.Location = new System.Drawing.Point(6, 15);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(43, 17);
            this.nameLabel1.TabIndex = 26;
            this.nameLabel1.Text = "Name";
            // 
            // skippedDatesListbox
            // 
            this.skippedDatesListbox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skippedDatesListbox.FormattingEnabled = true;
            this.skippedDatesListbox.HorizontalScrollbar = true;
            this.skippedDatesListbox.Location = new System.Drawing.Point(218, 189);
            this.skippedDatesListbox.Name = "skippedDatesListbox";
            this.skippedDatesListbox.Size = new System.Drawing.Size(180, 186);
            this.skippedDatesListbox.TabIndex = 24;
            // 
            // addTeamsDropdown
            // 
            this.addTeamsDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addTeamsDropdown.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeamsDropdown.FormattingEnabled = true;
            this.addTeamsDropdown.Location = new System.Drawing.Point(141, 292);
            this.addTeamsDropdown.Name = "addTeamsDropdown";
            this.addTeamsDropdown.Size = new System.Drawing.Size(218, 25);
            this.addTeamsDropdown.TabIndex = 25;
            // 
            // DivisionNameComboBox
            // 
            this.DivisionNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DivisionNameComboBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivisionNameComboBox.FormattingEnabled = true;
            this.DivisionNameComboBox.Location = new System.Drawing.Point(141, 102);
            this.DivisionNameComboBox.Name = "DivisionNameComboBox";
            this.DivisionNameComboBox.Size = new System.Drawing.Size(218, 25);
            this.DivisionNameComboBox.TabIndex = 30;
            this.DivisionNameComboBox.SelectedIndexChanged += new System.EventHandler(this.DivisionNameComboBox_SelectedValueChanged);
            this.DivisionNameComboBox.SelectedValueChanged += new System.EventHandler(this.DivisionNameComboBox_SelectedValueChanged);
            // 
            // RemoveTeamButton
            // 
            this.RemoveTeamButton.Location = new System.Drawing.Point(284, 368);
            this.RemoveTeamButton.Name = "RemoveTeamButton";
            this.RemoveTeamButton.Size = new System.Drawing.Size(75, 39);
            this.RemoveTeamButton.TabIndex = 31;
            this.RemoveTeamButton.Text = "Remove Team";
            this.RemoveTeamButton.UseVisualStyleBackColor = true;
            this.RemoveTeamButton.Click += new System.EventHandler(this.RemoveTeamButton_Click);
            // 
            // AddTeamButton
            // 
            this.AddTeamButton.Location = new System.Drawing.Point(284, 323);
            this.AddTeamButton.Name = "AddTeamButton";
            this.AddTeamButton.Size = new System.Drawing.Size(75, 39);
            this.AddTeamButton.TabIndex = 33;
            this.AddTeamButton.Text = "Add Team";
            this.AddTeamButton.UseVisualStyleBackColor = true;
            this.AddTeamButton.Click += new System.EventHandler(this.AddTeamButton_Click);
            // 
            // EditDivisionButton
            // 
            this.EditDivisionButton.Location = new System.Drawing.Point(378, 453);
            this.EditDivisionButton.Name = "EditDivisionButton";
            this.EditDivisionButton.Size = new System.Drawing.Size(75, 39);
            this.EditDivisionButton.TabIndex = 34;
            this.EditDivisionButton.Text = "Edit Division";
            this.EditDivisionButton.UseVisualStyleBackColor = true;
            this.EditDivisionButton.Click += new System.EventHandler(this.EditDivisionButton_Click);
            // 
            // DivNumberLabel
            // 
            this.DivNumberLabel.AutoSize = true;
            this.DivNumberLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivNumberLabel.Location = new System.Drawing.Point(146, 148);
            this.DivNumberLabel.Name = "DivNumberLabel";
            this.DivNumberLabel.Size = new System.Drawing.Size(128, 21);
            this.DivNumberLabel.TabIndex = 35;
            this.DivNumberLabel.Text = "DivNumberLabel";
            // 
            // createNewTeamLinkLabel
            // 
            this.createNewTeamLinkLabel.AutoSize = true;
            this.createNewTeamLinkLabel.Location = new System.Drawing.Point(138, 336);
            this.createNewTeamLinkLabel.Name = "createNewTeamLinkLabel";
            this.createNewTeamLinkLabel.Size = new System.Drawing.Size(109, 13);
            this.createNewTeamLinkLabel.TabIndex = 36;
            this.createNewTeamLinkLabel.TabStop = true;
            this.createNewTeamLinkLabel.Text = "or Create New Team";
            this.createNewTeamLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createNewTeamLinkLabel_LinkClicked);
            // 
            // SeasonComboBox
            // 
            this.SeasonComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SeasonComboBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeasonComboBox.FormattingEnabled = true;
            this.SeasonComboBox.Location = new System.Drawing.Point(141, 71);
            this.SeasonComboBox.Name = "SeasonComboBox";
            this.SeasonComboBox.Size = new System.Drawing.Size(218, 25);
            this.SeasonComboBox.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 37;
            this.label1.Text = "Season";
            // 
            // EditDivisionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(813, 504);
            this.Controls.Add(this.SeasonComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createNewTeamLinkLabel);
            this.Controls.Add(this.DivNumberLabel);
            this.Controls.Add(this.EditDivisionButton);
            this.Controls.Add(this.AddTeamButton);
            this.Controls.Add(this.RemoveTeamButton);
            this.Controls.Add(this.DivisionNameComboBox);
            this.Controls.Add(this.addTeamsDropdown);
            this.Controls.Add(this.skipDatesRemoveButton);
            this.Controls.Add(this.DivisionTournamentNameLabel);
            this.Controls.Add(this.ExitToMainMenuButton);
            this.Controls.Add(this.skipDatesAddButton);
            this.Controls.Add(this.SkipDatesdateTimePicker);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.StartDateLabel);
            this.Controls.Add(this.SkipDatesLabel);
            this.Controls.Add(this.AddTeamsLabel);
            this.Controls.Add(this.DivisionNumberLabel);
            this.Controls.Add(this.DivisionNameLabel);
            this.Controls.Add(this.DivisionHeaderLabel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EditDivisionForm";
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
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.DateTimePicker SkipDatesdateTimePicker;
        private System.Windows.Forms.Button skipDatesAddButton;
        private System.Windows.Forms.Button ExitToMainMenuButton;
        private System.Windows.Forms.Label DivisionTournamentNameLabel;
        private System.Windows.Forms.Button skipDatesRemoveButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox skippedDatesListbox;
        private System.Windows.Forms.ComboBox addTeamsDropdown;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Label TeamLabel;
        private System.Windows.Forms.Label numTeams;
        private System.Windows.Forms.Label numTeamsLabel;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label selectedStartDate;
        private System.Windows.Forms.Label startDateLabel2;
        private System.Windows.Forms.Label skippedDatesLabel;
        private System.Windows.Forms.ListBox teamsListBox;
        private System.Windows.Forms.ComboBox DivisionNameComboBox;
        private System.Windows.Forms.Label numberOfTeamsLabel;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button RemoveTeamButton;
        private System.Windows.Forms.Button AddTeamButton;
        private System.Windows.Forms.Button EditDivisionButton;
        private System.Windows.Forms.Label numberErrorLabel;
        private System.Windows.Forms.Label nameErrorLabel;
        private System.Windows.Forms.Label DivNumberLabel;
        private System.Windows.Forms.LinkLabel createNewTeamLinkLabel;
        private System.Windows.Forms.ComboBox SeasonComboBox;
        private System.Windows.Forms.Label label1;
    }
}