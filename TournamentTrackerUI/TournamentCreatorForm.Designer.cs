namespace TournamentTrackerUI
{
    partial class TournamentCreatorForm
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
            this.TournamentHeaderLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.CreateNewTournamentButton = new System.Windows.Forms.Button();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionErrorLabel = new System.Windows.Forms.Label();
            this.yearErrorLabel = new System.Windows.Forms.Label();
            this.nameErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TournamentHeaderLabel
            // 
            this.TournamentHeaderLabel.AutoSize = true;
            this.TournamentHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentHeaderLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.TournamentHeaderLabel.Location = new System.Drawing.Point(191, 36);
            this.TournamentHeaderLabel.Name = "TournamentHeaderLabel";
            this.TournamentHeaderLabel.Size = new System.Drawing.Size(354, 50);
            this.TournamentHeaderLabel.TabIndex = 0;
            this.TournamentHeaderLabel.Text = "Tournament Creator";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(68, 124);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(43, 17);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.nameTextBox.Location = new System.Drawing.Point(198, 121);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(282, 25);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // CreateNewTournamentButton
            // 
            this.CreateNewTournamentButton.Location = new System.Drawing.Point(337, 214);
            this.CreateNewTournamentButton.Name = "CreateNewTournamentButton";
            this.CreateNewTournamentButton.Size = new System.Drawing.Size(75, 24);
            this.CreateNewTournamentButton.TabIndex = 4;
            this.CreateNewTournamentButton.Text = "Create";
            this.CreateNewTournamentButton.UseVisualStyleBackColor = true;
            this.CreateNewTournamentButton.Click += new System.EventHandler(this.CreateNewTournamentButton_Click);
            // 
            // yearTextBox
            // 
            this.yearTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.yearTextBox.Location = new System.Drawing.Point(198, 152);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(282, 25);
            this.yearTextBox.TabIndex = 2;
            this.yearTextBox.TextChanged += new System.EventHandler(this.yearTextBox_TextChanged);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.descriptionTextBox.Location = new System.Drawing.Point(198, 183);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(282, 25);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(68, 155);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(34, 17);
            this.yearLabel.TabIndex = 0;
            this.yearLabel.Text = "Year";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(68, 184);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(74, 17);
            this.descriptionLabel.TabIndex = 0;
            this.descriptionLabel.Text = "Description";
            // 
            // descriptionErrorLabel
            // 
            this.descriptionErrorLabel.AutoSize = true;
            this.descriptionErrorLabel.Location = new System.Drawing.Point(486, 184);
            this.descriptionErrorLabel.Name = "descriptionErrorLabel";
            this.descriptionErrorLabel.Size = new System.Drawing.Size(66, 17);
            this.descriptionErrorLabel.TabIndex = 0;
            this.descriptionErrorLabel.Text = "(Optional)";
            // 
            // yearErrorLabel
            // 
            this.yearErrorLabel.AutoSize = true;
            this.yearErrorLabel.Location = new System.Drawing.Point(486, 155);
            this.yearErrorLabel.Name = "yearErrorLabel";
            this.yearErrorLabel.Size = new System.Drawing.Size(11, 17);
            this.yearErrorLabel.TabIndex = 0;
            this.yearErrorLabel.Text = ".";
            // 
            // nameErrorLabel
            // 
            this.nameErrorLabel.AutoSize = true;
            this.nameErrorLabel.Location = new System.Drawing.Point(486, 124);
            this.nameErrorLabel.Name = "nameErrorLabel";
            this.nameErrorLabel.Size = new System.Drawing.Size(11, 17);
            this.nameErrorLabel.TabIndex = 0;
            this.nameErrorLabel.Text = ".";
            // 
            // TournamentCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(770, 301);
            this.Controls.Add(this.descriptionErrorLabel);
            this.Controls.Add(this.yearErrorLabel);
            this.Controls.Add(this.nameErrorLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.CreateNewTournamentButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.TournamentHeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TournamentCreatorForm";
            this.Text = "Tournament Creation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TournamentHeaderLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button CreateNewTournamentButton;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label descriptionErrorLabel;
        private System.Windows.Forms.Label yearErrorLabel;
        private System.Windows.Forms.Label nameErrorLabel;
    }
}

