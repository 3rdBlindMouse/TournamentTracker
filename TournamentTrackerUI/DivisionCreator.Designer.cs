namespace TournamentTrackerUI
{
    partial class DivisionCreator
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
            this.NumberOfTeamsLabel = new System.Windows.Forms.Label();
            this.SkipDatesLabel = new System.Windows.Forms.Label();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.DivisionNameTextbox = new System.Windows.Forms.TextBox();
            this.NumberOfTeamsTextbox = new System.Windows.Forms.TextBox();
            this.DivisionNumberTextbox = new System.Windows.Forms.TextBox();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.SkipDatesdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.skipDatesAddButton = new System.Windows.Forms.Button();
            this.HeadingsListbox = new System.Windows.Forms.ListBox();
            this.createDivisionButton = new System.Windows.Forms.Button();
            this.ExitToMainMenuButton = new System.Windows.Forms.Button();
            this.DivisionTournamentNameLabel = new System.Windows.Forms.Label();
            this.skipDatesRemoveButton = new System.Windows.Forms.Button();
            this.TeamsButton = new System.Windows.Forms.Button();
            this.EditDivisionButton = new System.Windows.Forms.Button();
            this.detailsListbox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.skippedDatesListbox = new System.Windows.Forms.ListBox();
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
            // NumberOfTeamsLabel
            // 
            this.NumberOfTeamsLabel.AutoSize = true;
            this.NumberOfTeamsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfTeamsLabel.Location = new System.Drawing.Point(6, 167);
            this.NumberOfTeamsLabel.Name = "NumberOfTeamsLabel";
            this.NumberOfTeamsLabel.Size = new System.Drawing.Size(135, 21);
            this.NumberOfTeamsLabel.TabIndex = 4;
            this.NumberOfTeamsLabel.Text = "Number of Teams";
            // 
            // SkipDatesLabel
            // 
            this.SkipDatesLabel.AutoSize = true;
            this.SkipDatesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkipDatesLabel.Location = new System.Drawing.Point(6, 251);
            this.SkipDatesLabel.Name = "SkipDatesLabel";
            this.SkipDatesLabel.Size = new System.Drawing.Size(101, 21);
            this.SkipDatesLabel.TabIndex = 5;
            this.SkipDatesLabel.Text = "Dates to Skip";
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDateLabel.Location = new System.Drawing.Point(6, 207);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(79, 21);
            this.StartDateLabel.TabIndex = 6;
            this.StartDateLabel.Text = "Start Date";
            // 
            // DivisionNameTextbox
            // 
            this.DivisionNameTextbox.BackColor = System.Drawing.SystemColors.Info;
            this.DivisionNameTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivisionNameTextbox.Location = new System.Drawing.Point(154, 78);
            this.DivisionNameTextbox.Name = "DivisionNameTextbox";
            this.DivisionNameTextbox.Size = new System.Drawing.Size(218, 29);
            this.DivisionNameTextbox.TabIndex = 7;
            this.DivisionNameTextbox.Enter += new System.EventHandler(this.DivisionNameTextbox_Enter);
            this.DivisionNameTextbox.Leave += new System.EventHandler(this.DivisionNameTextbox_Leave);
            // 
            // NumberOfTeamsTextbox
            // 
            this.NumberOfTeamsTextbox.BackColor = System.Drawing.SystemColors.Info;
            this.NumberOfTeamsTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfTeamsTextbox.Location = new System.Drawing.Point(154, 164);
            this.NumberOfTeamsTextbox.Name = "NumberOfTeamsTextbox";
            this.NumberOfTeamsTextbox.Size = new System.Drawing.Size(218, 29);
            this.NumberOfTeamsTextbox.TabIndex = 8;
            this.NumberOfTeamsTextbox.Enter += new System.EventHandler(this.NumberOfTeamsTextbox_Enter);
            this.NumberOfTeamsTextbox.Leave += new System.EventHandler(this.NumberOfTeamsTextbox_Leave);
            // 
            // DivisionNumberTextbox
            // 
            this.DivisionNumberTextbox.BackColor = System.Drawing.SystemColors.Info;
            this.DivisionNumberTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivisionNumberTextbox.Location = new System.Drawing.Point(154, 124);
            this.DivisionNumberTextbox.Name = "DivisionNumberTextbox";
            this.DivisionNumberTextbox.Size = new System.Drawing.Size(218, 29);
            this.DivisionNumberTextbox.TabIndex = 11;
            this.DivisionNumberTextbox.Enter += new System.EventHandler(this.DivisionNumberTextbox_Enter);
            this.DivisionNumberTextbox.Leave += new System.EventHandler(this.DivisionNumberTextbox_Leave);
            // 
            // StartDate
            // 
            this.StartDate.Location = new System.Drawing.Point(154, 206);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(200, 22);
            this.StartDate.TabIndex = 12;
            this.StartDate.ValueChanged += new System.EventHandler(this.StartDate_ValueChanged);
            // 
            // SkipDatesdateTimePicker
            // 
            this.SkipDatesdateTimePicker.Location = new System.Drawing.Point(154, 250);
            this.SkipDatesdateTimePicker.Name = "SkipDatesdateTimePicker";
            this.SkipDatesdateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.SkipDatesdateTimePicker.TabIndex = 13;
            // 
            // skipDatesAddButton
            // 
            this.skipDatesAddButton.Location = new System.Drawing.Point(154, 278);
            this.skipDatesAddButton.Name = "skipDatesAddButton";
            this.skipDatesAddButton.Size = new System.Drawing.Size(75, 30);
            this.skipDatesAddButton.TabIndex = 14;
            this.skipDatesAddButton.Text = "Add";
            this.skipDatesAddButton.UseVisualStyleBackColor = true;
            this.skipDatesAddButton.Click += new System.EventHandler(this.skipDatesAddButton_Click);
            // 
            // HeadingsListbox
            // 
            this.HeadingsListbox.BackColor = System.Drawing.SystemColors.Info;
            this.HeadingsListbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HeadingsListbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadingsListbox.FormattingEnabled = true;
            this.HeadingsListbox.ItemHeight = 17;
            this.HeadingsListbox.Items.AddRange(new object[] {
            "Name",
            "\t",
            "Number",
            "\t\t",
            "# of Teams",
            "\t",
            "Start Date",
            "",
            "Skipped Dates"});
            this.HeadingsListbox.Location = new System.Drawing.Point(3, 3);
            this.HeadingsListbox.Name = "HeadingsListbox";
            this.HeadingsListbox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.HeadingsListbox.Size = new System.Drawing.Size(109, 238);
            this.HeadingsListbox.TabIndex = 15;
            // 
            // createDivisionButton
            // 
            this.createDivisionButton.Location = new System.Drawing.Point(204, 361);
            this.createDivisionButton.Name = "createDivisionButton";
            this.createDivisionButton.Size = new System.Drawing.Size(138, 34);
            this.createDivisionButton.TabIndex = 17;
            this.createDivisionButton.Text = "Create Division";
            this.createDivisionButton.UseVisualStyleBackColor = true;
            this.createDivisionButton.Click += new System.EventHandler(this.createDivisionButton_Click);
            // 
            // ExitToMainMenuButton
            // 
            this.ExitToMainMenuButton.Location = new System.Drawing.Point(8, 361);
            this.ExitToMainMenuButton.Name = "ExitToMainMenuButton";
            this.ExitToMainMenuButton.Size = new System.Drawing.Size(87, 34);
            this.ExitToMainMenuButton.TabIndex = 18;
            this.ExitToMainMenuButton.Text = "Exit to Main Menu";
            this.ExitToMainMenuButton.UseVisualStyleBackColor = true;
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
            this.skipDatesRemoveButton.Location = new System.Drawing.Point(279, 278);
            this.skipDatesRemoveButton.Name = "skipDatesRemoveButton";
            this.skipDatesRemoveButton.Size = new System.Drawing.Size(75, 30);
            this.skipDatesRemoveButton.TabIndex = 20;
            this.skipDatesRemoveButton.Text = "Remove";
            this.skipDatesRemoveButton.UseVisualStyleBackColor = true;
            this.skipDatesRemoveButton.Click += new System.EventHandler(this.skipDatesRemoveButton_Click);
            // 
            // TeamsButton
            // 
            this.TeamsButton.Location = new System.Drawing.Point(633, 361);
            this.TeamsButton.Name = "TeamsButton";
            this.TeamsButton.Size = new System.Drawing.Size(87, 34);
            this.TeamsButton.TabIndex = 21;
            this.TeamsButton.Text = "Teams";
            this.TeamsButton.UseVisualStyleBackColor = true;
            // 
            // EditDivisionButton
            // 
            this.EditDivisionButton.Location = new System.Drawing.Point(473, 361);
            this.EditDivisionButton.Name = "EditDivisionButton";
            this.EditDivisionButton.Size = new System.Drawing.Size(138, 34);
            this.EditDivisionButton.TabIndex = 22;
            this.EditDivisionButton.Text = "Edit Division";
            this.EditDivisionButton.UseVisualStyleBackColor = true;
            // 
            // detailsListbox
            // 
            this.detailsListbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detailsListbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsListbox.FormattingEnabled = true;
            this.detailsListbox.ItemHeight = 17;
            this.detailsListbox.Items.AddRange(new object[] {
            "",
            "",
            "",
            "",
            "",
            "",
            ""});
            this.detailsListbox.Location = new System.Drawing.Point(113, 3);
            this.detailsListbox.Name = "detailsListbox";
            this.detailsListbox.Size = new System.Drawing.Size(264, 119);
            this.detailsListbox.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.skippedDatesListbox);
            this.panel1.Controls.Add(this.HeadingsListbox);
            this.panel1.Controls.Add(this.detailsListbox);
            this.panel1.Location = new System.Drawing.Point(378, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 277);
            this.panel1.TabIndex = 24;
            // 
            // skippedDatesListbox
            // 
            this.skippedDatesListbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skippedDatesListbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skippedDatesListbox.FormattingEnabled = true;
            this.skippedDatesListbox.HorizontalScrollbar = true;
            this.skippedDatesListbox.ItemHeight = 17;
            this.skippedDatesListbox.Location = new System.Drawing.Point(104, 138);
            this.skippedDatesListbox.Name = "skippedDatesListbox";
            this.skippedDatesListbox.Size = new System.Drawing.Size(264, 119);
            this.skippedDatesListbox.TabIndex = 24;
            // 
            // DivisionCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(770, 408);
            this.Controls.Add(this.EditDivisionButton);
            this.Controls.Add(this.TeamsButton);
            this.Controls.Add(this.skipDatesRemoveButton);
            this.Controls.Add(this.DivisionTournamentNameLabel);
            this.Controls.Add(this.ExitToMainMenuButton);
            this.Controls.Add(this.createDivisionButton);
            this.Controls.Add(this.skipDatesAddButton);
            this.Controls.Add(this.SkipDatesdateTimePicker);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.DivisionNumberTextbox);
            this.Controls.Add(this.NumberOfTeamsTextbox);
            this.Controls.Add(this.DivisionNameTextbox);
            this.Controls.Add(this.StartDateLabel);
            this.Controls.Add(this.SkipDatesLabel);
            this.Controls.Add(this.NumberOfTeamsLabel);
            this.Controls.Add(this.DivisionNumberLabel);
            this.Controls.Add(this.DivisionNameLabel);
            this.Controls.Add(this.DivisionHeaderLabel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DivisionCreator";
            this.Text = "DivisionCreator";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DivisionHeaderLabel;
        private System.Windows.Forms.Label DivisionNameLabel;
        private System.Windows.Forms.Label DivisionNumberLabel;
        private System.Windows.Forms.Label NumberOfTeamsLabel;
        private System.Windows.Forms.Label SkipDatesLabel;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.TextBox DivisionNameTextbox;
        private System.Windows.Forms.TextBox NumberOfTeamsTextbox;
        private System.Windows.Forms.TextBox DivisionNumberTextbox;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.DateTimePicker SkipDatesdateTimePicker;
        private System.Windows.Forms.Button skipDatesAddButton;
        private System.Windows.Forms.ListBox HeadingsListbox;
        private System.Windows.Forms.Button createDivisionButton;
        private System.Windows.Forms.Button ExitToMainMenuButton;
        private System.Windows.Forms.Label DivisionTournamentNameLabel;
        private System.Windows.Forms.Button skipDatesRemoveButton;
        private System.Windows.Forms.Button TeamsButton;
        private System.Windows.Forms.Button EditDivisionButton;
        private System.Windows.Forms.ListBox detailsListbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox skippedDatesListbox;
    }
}