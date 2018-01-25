namespace TournamentTrackerUI
{
    partial class DivisionDatesForm
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
            this.SkipDatesLabel = new System.Windows.Forms.Label();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.SkipDatesdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.skipDatesAddButton = new System.Windows.Forms.Button();
            this.ExitToMainMenuButton = new System.Windows.Forms.Button();
            this.DivisionTournamentNameLabel = new System.Windows.Forms.Label();
            this.skipDatesRemoveButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.skippedDatesLabel = new System.Windows.Forms.Label();
            this.selectedStartDate = new System.Windows.Forms.Label();
            this.startDateLabel2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.skippedDatesListbox = new System.Windows.Forms.ListBox();
            this.DivNumberLabel2 = new System.Windows.Forms.Label();
            this.DivNameLabel2 = new System.Windows.Forms.Label();
            this.addDatesButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DivisionHeaderLabel
            // 
            this.DivisionHeaderLabel.AutoSize = true;
            this.DivisionHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivisionHeaderLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.DivisionHeaderLabel.Location = new System.Drawing.Point(37, 9);
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
            this.DivisionTournamentNameLabel.Location = new System.Drawing.Point(306, 9);
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
            this.panel1.Controls.Add(this.skippedDatesLabel);
            this.panel1.Controls.Add(this.selectedStartDate);
            this.panel1.Controls.Add(this.startDateLabel2);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.skippedDatesListbox);
            this.panel1.Location = new System.Drawing.Point(378, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 318);
            this.panel1.TabIndex = 24;
            // 
            // skippedDatesLabel
            // 
            this.skippedDatesLabel.AutoSize = true;
            this.skippedDatesLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skippedDatesLabel.Location = new System.Drawing.Point(20, 69);
            this.skippedDatesLabel.Name = "skippedDatesLabel";
            this.skippedDatesLabel.Size = new System.Drawing.Size(92, 17);
            this.skippedDatesLabel.TabIndex = 35;
            this.skippedDatesLabel.Text = "Skipped Dates";
            // 
            // selectedStartDate
            // 
            this.selectedStartDate.AutoSize = true;
            this.selectedStartDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedStartDate.Location = new System.Drawing.Point(20, 41);
            this.selectedStartDate.Name = "selectedStartDate";
            this.selectedStartDate.Size = new System.Drawing.Size(125, 17);
            this.selectedStartDate.TabIndex = 34;
            this.selectedStartDate.Text = "Choose a Start Date";
            // 
            // startDateLabel2
            // 
            this.startDateLabel2.AutoSize = true;
            this.startDateLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateLabel2.Location = new System.Drawing.Point(20, 12);
            this.startDateLabel2.Name = "startDateLabel2";
            this.startDateLabel2.Size = new System.Drawing.Size(66, 17);
            this.startDateLabel2.TabIndex = 33;
            this.startDateLabel2.Text = "Start Date";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(62, 5);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(0, 17);
            this.name.TabIndex = 27;
            // 
            // skippedDatesListbox
            // 
            this.skippedDatesListbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skippedDatesListbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skippedDatesListbox.FormattingEnabled = true;
            this.skippedDatesListbox.HorizontalScrollbar = true;
            this.skippedDatesListbox.ItemHeight = 17;
            this.skippedDatesListbox.Location = new System.Drawing.Point(23, 89);
            this.skippedDatesListbox.Name = "skippedDatesListbox";
            this.skippedDatesListbox.Size = new System.Drawing.Size(182, 204);
            this.skippedDatesListbox.TabIndex = 24;
            // 
            // DivNumberLabel2
            // 
            this.DivNumberLabel2.AutoSize = true;
            this.DivNumberLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivNumberLabel2.Location = new System.Drawing.Point(137, 127);
            this.DivNumberLabel2.Name = "DivNumberLabel2";
            this.DivNumberLabel2.Size = new System.Drawing.Size(128, 21);
            this.DivNumberLabel2.TabIndex = 26;
            this.DivNumberLabel2.Text = "Division Number";
            // 
            // DivNameLabel2
            // 
            this.DivNameLabel2.AutoSize = true;
            this.DivNameLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivNameLabel2.Location = new System.Drawing.Point(137, 81);
            this.DivNameLabel2.Name = "DivNameLabel2";
            this.DivNameLabel2.Size = new System.Drawing.Size(121, 21);
            this.DivNameLabel2.TabIndex = 25;
            this.DivNameLabel2.Text = "DivNameLabel2";
            // 
            // addDatesButton
            // 
            this.addDatesButton.Location = new System.Drawing.Point(215, 313);
            this.addDatesButton.Name = "addDatesButton";
            this.addDatesButton.Size = new System.Drawing.Size(138, 34);
            this.addDatesButton.TabIndex = 27;
            this.addDatesButton.Text = "Add Dates";
            this.addDatesButton.UseVisualStyleBackColor = true;
            this.addDatesButton.Click += new System.EventHandler(this.addDatesButton_Click);
            // 
            // DivisionDatesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(667, 461);
            this.Controls.Add(this.addDatesButton);
            this.Controls.Add(this.DivNumberLabel2);
            this.Controls.Add(this.DivNameLabel2);
            this.Controls.Add(this.skipDatesRemoveButton);
            this.Controls.Add(this.DivisionTournamentNameLabel);
            this.Controls.Add(this.ExitToMainMenuButton);
            this.Controls.Add(this.skipDatesAddButton);
            this.Controls.Add(this.SkipDatesdateTimePicker);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.StartDateLabel);
            this.Controls.Add(this.SkipDatesLabel);
            this.Controls.Add(this.DivisionNumberLabel);
            this.Controls.Add(this.DivisionNameLabel);
            this.Controls.Add(this.DivisionHeaderLabel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DivisionDatesForm";
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
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label selectedStartDate;
        private System.Windows.Forms.Label startDateLabel2;
        private System.Windows.Forms.Label skippedDatesLabel;
        private System.Windows.Forms.Label DivNumberLabel2;
        private System.Windows.Forms.Label DivNameLabel2;
        private System.Windows.Forms.Button addDatesButton;
    }
}