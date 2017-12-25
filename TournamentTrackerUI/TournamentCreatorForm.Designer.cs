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
            this.LoadTournamentLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoadTorunamentComboBox = new System.Windows.Forms.ComboBox();
            this.CreateNewTournamentTextBox = new System.Windows.Forms.TextBox();
            this.LoadTournamentButton = new System.Windows.Forms.Button();
            this.CreaeNewTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TournamentHeaderLabel
            // 
            this.TournamentHeaderLabel.AutoSize = true;
            this.TournamentHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentHeaderLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.TournamentHeaderLabel.Location = new System.Drawing.Point(150, 35);
            this.TournamentHeaderLabel.Name = "TournamentHeaderLabel";
            this.TournamentHeaderLabel.Size = new System.Drawing.Size(466, 50);
            this.TournamentHeaderLabel.TabIndex = 0;
            this.TournamentHeaderLabel.Text = "Tournament Creator/Editor";
            // 
            // LoadTournamentLabel
            // 
            this.LoadTournamentLabel.AutoSize = true;
            this.LoadTournamentLabel.Location = new System.Drawing.Point(78, 132);
            this.LoadTournamentLabel.Name = "LoadTournamentLabel";
            this.LoadTournamentLabel.Size = new System.Drawing.Size(111, 17);
            this.LoadTournamentLabel.TabIndex = 1;
            this.LoadTournamentLabel.Text = "Load Tournament";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Create New Tournament";
            // 
            // LoadTorunamentComboBox
            // 
            this.LoadTorunamentComboBox.BackColor = System.Drawing.SystemColors.Info;
            this.LoadTorunamentComboBox.FormattingEnabled = true;
            this.LoadTorunamentComboBox.Location = new System.Drawing.Point(262, 129);
            this.LoadTorunamentComboBox.Name = "LoadTorunamentComboBox";
            this.LoadTorunamentComboBox.Size = new System.Drawing.Size(282, 25);
            this.LoadTorunamentComboBox.TabIndex = 3;
            // 
            // CreateNewTournamentTextBox
            // 
            this.CreateNewTournamentTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.CreateNewTournamentTextBox.Location = new System.Drawing.Point(262, 180);
            this.CreateNewTournamentTextBox.Name = "CreateNewTournamentTextBox";
            this.CreateNewTournamentTextBox.Size = new System.Drawing.Size(282, 25);
            this.CreateNewTournamentTextBox.TabIndex = 4;
            // 
            // LoadTournamentButton
            // 
            this.LoadTournamentButton.Location = new System.Drawing.Point(640, 129);
            this.LoadTournamentButton.Name = "LoadTournamentButton";
            this.LoadTournamentButton.Size = new System.Drawing.Size(75, 24);
            this.LoadTournamentButton.TabIndex = 5;
            this.LoadTournamentButton.Text = "Load";
            this.LoadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreaeNewTournamentButton
            // 
            this.CreaeNewTournamentButton.Location = new System.Drawing.Point(640, 180);
            this.CreaeNewTournamentButton.Name = "CreaeNewTournamentButton";
            this.CreaeNewTournamentButton.Size = new System.Drawing.Size(75, 24);
            this.CreaeNewTournamentButton.TabIndex = 6;
            this.CreaeNewTournamentButton.Text = "Create";
            this.CreaeNewTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(770, 301);
            this.Controls.Add(this.CreaeNewTournamentButton);
            this.Controls.Add(this.LoadTournamentButton);
            this.Controls.Add(this.CreateNewTournamentTextBox);
            this.Controls.Add(this.LoadTorunamentComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LoadTournamentLabel);
            this.Controls.Add(this.TournamentHeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TournamentCreator";
            this.Text = "Tournament Creation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TournamentHeaderLabel;
        private System.Windows.Forms.Label LoadTournamentLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox LoadTorunamentComboBox;
        private System.Windows.Forms.TextBox CreateNewTournamentTextBox;
        private System.Windows.Forms.Button LoadTournamentButton;
        private System.Windows.Forms.Button CreaeNewTournamentButton;
    }
}

