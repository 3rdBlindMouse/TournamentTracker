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
            this.DivisionNumberTextbox = new System.Windows.Forms.TextBox();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.SkipDatesdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.skipDatesAddButton = new System.Windows.Forms.Button();
            this.createDivisionButton = new System.Windows.Forms.Button();
            this.ExitToMainMenuButton = new System.Windows.Forms.Button();
            this.DivisionTournamentNameLabel = new System.Windows.Forms.Label();
            this.skipDatesRemoveButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DivisionNameComboBox = new System.Windows.Forms.ComboBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
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
            // DivisionNumberTextbox
            // 
            this.DivisionNumberTextbox.BackColor = System.Drawing.SystemColors.Info;
            this.DivisionNumberTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivisionNumberTextbox.Location = new System.Drawing.Point(141, 124);
            this.DivisionNumberTextbox.Name = "DivisionNumberTextbox";
            this.DivisionNumberTextbox.ReadOnly = true;
            this.DivisionNumberTextbox.Size = new System.Drawing.Size(218, 29);
            this.DivisionNumberTextbox.TabIndex = 11;
            this.DivisionNumberTextbox.Enter += new System.EventHandler(this.DivisionNumberTextbox_Enter);
            this.DivisionNumberTextbox.Leave += new System.EventHandler(this.DivisionNumberTextbox_Leave);
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
            this.createDivisionButton.Location = new System.Drawing.Point(310, 415);
            this.createDivisionButton.Name = "createDivisionButton";
            this.createDivisionButton.Size = new System.Drawing.Size(138, 34);
            this.createDivisionButton.TabIndex = 17;
            this.createDivisionButton.Text = "Edit Division";
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
            this.skipDatesRemoveButton.Location = new System.Drawing.Point(266, 236);
            this.skipDatesRemoveButton.Name = "skipDatesRemoveButton";
            this.skipDatesRemoveButton.Size = new System.Drawing.Size(75, 30);
            this.skipDatesRemoveButton.TabIndex = 20;
            this.skipDatesRemoveButton.Text = "Remove";
            this.skipDatesRemoveButton.UseVisualStyleBackColor = true;
            this.skipDatesRemoveButton.Click += new System.EventHandler(this.skipDatesRemoveButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
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
            this.panel1.Size = new System.Drawing.Size(403, 318);
            this.panel1.TabIndex = 24;
            // 
            // teamsListBox
            // 
            this.teamsListBox.FormattingEnabled = true;
            this.teamsListBox.Location = new System.Drawing.Point(6, 121);
            this.teamsListBox.Name = "teamsListBox";
            this.teamsListBox.Size = new System.Drawing.Size(194, 186);
            this.teamsListBox.TabIndex = 36;
            // 
            // skippedDatesLabel
            // 
            this.skippedDatesLabel.AutoSize = true;
            this.skippedDatesLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skippedDatesLabel.Location = new System.Drawing.Point(215, 73);
            this.skippedDatesLabel.Name = "skippedDatesLabel";
            this.skippedDatesLabel.Size = new System.Drawing.Size(92, 17);
            this.skippedDatesLabel.TabIndex = 35;
            this.skippedDatesLabel.Text = "Skipped Dates";
            // 
            // selectedStartDate
            // 
            this.selectedStartDate.AutoSize = true;
            this.selectedStartDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedStartDate.Location = new System.Drawing.Point(215, 39);
            this.selectedStartDate.Name = "selectedStartDate";
            this.selectedStartDate.Size = new System.Drawing.Size(0, 17);
            this.selectedStartDate.TabIndex = 34;
            // 
            // startDateLabel2
            // 
            this.startDateLabel2.AutoSize = true;
            this.startDateLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateLabel2.Location = new System.Drawing.Point(215, 5);
            this.startDateLabel2.Name = "startDateLabel2";
            this.startDateLabel2.Size = new System.Drawing.Size(66, 17);
            this.startDateLabel2.TabIndex = 33;
            this.startDateLabel2.Text = "Start Date";
            // 
            // TeamLabel
            // 
            this.TeamLabel.AutoSize = true;
            this.TeamLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamLabel.Location = new System.Drawing.Point(3, 100);
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
            this.numTeamsLabel.Location = new System.Drawing.Point(3, 73);
            this.numTeamsLabel.Name = "numTeamsLabel";
            this.numTeamsLabel.Size = new System.Drawing.Size(58, 17);
            this.numTeamsLabel.TabIndex = 30;
            this.numTeamsLabel.Text = "# Teams";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLabel.Location = new System.Drawing.Point(6, 39);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(56, 17);
            this.numberLabel.TabIndex = 28;
            this.numberLabel.Text = "Number";
            // 
            // nameLabel1
            // 
            this.nameLabel1.AutoSize = true;
            this.nameLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel1.Location = new System.Drawing.Point(6, 12);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(43, 17);
            this.nameLabel1.TabIndex = 26;
            this.nameLabel1.Text = "Name";
            // 
            // skippedDatesListbox
            // 
            this.skippedDatesListbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skippedDatesListbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skippedDatesListbox.FormattingEnabled = true;
            this.skippedDatesListbox.HorizontalScrollbar = true;
            this.skippedDatesListbox.ItemHeight = 17;
            this.skippedDatesListbox.Location = new System.Drawing.Point(218, 95);
            this.skippedDatesListbox.Name = "skippedDatesListbox";
            this.skippedDatesListbox.Size = new System.Drawing.Size(182, 119);
            this.skippedDatesListbox.TabIndex = 24;
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
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(138, 299);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(109, 13);
            this.linkLabel1.TabIndex = 26;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "or Create New Team";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(284, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 39);
            this.button2.TabIndex = 28;
            this.button2.Text = "Remove Team";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 29;
            this.button1.Text = "Add Team";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DivisionNameComboBox
            // 
            this.DivisionNameComboBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivisionNameComboBox.FormattingEnabled = true;
            this.DivisionNameComboBox.Location = new System.Drawing.Point(141, 81);
            this.DivisionNameComboBox.Name = "DivisionNameComboBox";
            this.DivisionNameComboBox.Size = new System.Drawing.Size(218, 25);
            this.DivisionNameComboBox.TabIndex = 30;
            this.DivisionNameComboBox.SelectedIndexChanged += new System.EventHandler(this.DivisionNameComboBox_SelectedIndexChanged);
            this.DivisionNameComboBox.Leave += new System.EventHandler(this.DivisionNameComboBox_Leave);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(81, 9);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(119, 25);
            this.nameTextBox.TabIndex = 37;
            // 
            // numberTextBox
            // 
            this.numberTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberTextBox.Location = new System.Drawing.Point(81, 36);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(119, 25);
            this.numberTextBox.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "# Teams";
            // 
            // EditDivisionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(793, 461);
            this.Controls.Add(this.DivisionNameComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.addTeamsDropdown);
            this.Controls.Add(this.skipDatesRemoveButton);
            this.Controls.Add(this.DivisionTournamentNameLabel);
            this.Controls.Add(this.ExitToMainMenuButton);
            this.Controls.Add(this.createDivisionButton);
            this.Controls.Add(this.skipDatesAddButton);
            this.Controls.Add(this.SkipDatesdateTimePicker);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.DivisionNumberTextbox);
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
        private System.Windows.Forms.TextBox DivisionNumberTextbox;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.DateTimePicker SkipDatesdateTimePicker;
        private System.Windows.Forms.Button skipDatesAddButton;
        private System.Windows.Forms.Button createDivisionButton;
        private System.Windows.Forms.Button ExitToMainMenuButton;
        private System.Windows.Forms.Label DivisionTournamentNameLabel;
        private System.Windows.Forms.Button skipDatesRemoveButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox skippedDatesListbox;
        private System.Windows.Forms.ComboBox addTeamsDropdown;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
    }
}