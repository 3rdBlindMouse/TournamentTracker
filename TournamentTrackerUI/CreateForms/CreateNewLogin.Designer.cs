namespace TournamentTrackerUI.CreateForms
{
    partial class CreateNewLogin
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
            this.selectPersonComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.seasonsComboBox = new System.Windows.Forms.ComboBox();
            this.userIDLabel = new System.Windows.Forms.Label();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.passwordTextBox1 = new System.Windows.Forms.TextBox();
            this.passwordtextBox2 = new System.Windows.Forms.TextBox();
            this.passwordMatchLabel = new System.Windows.Forms.Label();
            this.userIDLabel2 = new System.Windows.Forms.Label();
            this.passwordLabel2 = new System.Windows.Forms.Label();
            this.createLoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectPersonComboBox
            // 
            this.selectPersonComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectPersonComboBox.FormattingEnabled = true;
            this.selectPersonComboBox.Location = new System.Drawing.Point(197, 81);
            this.selectPersonComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selectPersonComboBox.Name = "selectPersonComboBox";
            this.selectPersonComboBox.Size = new System.Drawing.Size(160, 24);
            this.selectPersonComboBox.TabIndex = 0;
            this.selectPersonComboBox.SelectedValueChanged += new System.EventHandler(this.selectPersonComboBox_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select A Person";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select A Season";
            // 
            // seasonsComboBox
            // 
            this.seasonsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seasonsComboBox.FormattingEnabled = true;
            this.seasonsComboBox.Location = new System.Drawing.Point(197, 38);
            this.seasonsComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.seasonsComboBox.Name = "seasonsComboBox";
            this.seasonsComboBox.Size = new System.Drawing.Size(160, 24);
            this.seasonsComboBox.TabIndex = 2;
            this.seasonsComboBox.SelectedValueChanged += new System.EventHandler(this.seasonsComboBox_SelectedValueChanged);
            // 
            // userIDLabel
            // 
            this.userIDLabel.AutoSize = true;
            this.userIDLabel.Location = new System.Drawing.Point(54, 131);
            this.userIDLabel.Name = "userIDLabel";
            this.userIDLabel.Size = new System.Drawing.Size(53, 16);
            this.userIDLabel.TabIndex = 4;
            this.userIDLabel.Text = "User ID";
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Location = new System.Drawing.Point(54, 169);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(68, 16);
            this.passwordlabel.TabIndex = 5;
            this.passwordlabel.Text = "Password";
            // 
            // passwordTextBox1
            // 
            this.passwordTextBox1.Location = new System.Drawing.Point(197, 164);
            this.passwordTextBox1.Name = "passwordTextBox1";
            this.passwordTextBox1.Size = new System.Drawing.Size(160, 22);
            this.passwordTextBox1.TabIndex = 6;
            this.passwordTextBox1.Enter += new System.EventHandler(this.passwordTextBox1_Enter);
            this.passwordTextBox1.Leave += new System.EventHandler(this.passwordTextBox1_Leave);
            // 
            // passwordtextBox2
            // 
            this.passwordtextBox2.Location = new System.Drawing.Point(197, 192);
            this.passwordtextBox2.Name = "passwordtextBox2";
            this.passwordtextBox2.Size = new System.Drawing.Size(160, 22);
            this.passwordtextBox2.TabIndex = 7;
            this.passwordtextBox2.TextChanged += new System.EventHandler(this.passwordtextBox2_TextChanged);
            this.passwordtextBox2.Enter += new System.EventHandler(this.passwordtextBox2_Enter);
            // 
            // passwordMatchLabel
            // 
            this.passwordMatchLabel.AutoSize = true;
            this.passwordMatchLabel.Location = new System.Drawing.Point(197, 221);
            this.passwordMatchLabel.Name = "passwordMatchLabel";
            this.passwordMatchLabel.Size = new System.Drawing.Size(45, 16);
            this.passwordMatchLabel.TabIndex = 9;
            this.passwordMatchLabel.Text = "label3";
            // 
            // userIDLabel2
            // 
            this.userIDLabel2.AutoSize = true;
            this.userIDLabel2.Location = new System.Drawing.Point(197, 131);
            this.userIDLabel2.Name = "userIDLabel2";
            this.userIDLabel2.Size = new System.Drawing.Size(45, 16);
            this.userIDLabel2.TabIndex = 10;
            this.userIDLabel2.Text = "label3";
            // 
            // passwordLabel2
            // 
            this.passwordLabel2.AutoSize = true;
            this.passwordLabel2.Location = new System.Drawing.Point(54, 195);
            this.passwordLabel2.Name = "passwordLabel2";
            this.passwordLabel2.Size = new System.Drawing.Size(120, 16);
            this.passwordLabel2.TabIndex = 11;
            this.passwordLabel2.Text = "ReEnter Password";
            // 
            // createLoginButton
            // 
            this.createLoginButton.Location = new System.Drawing.Point(200, 262);
            this.createLoginButton.Name = "createLoginButton";
            this.createLoginButton.Size = new System.Drawing.Size(75, 48);
            this.createLoginButton.TabIndex = 12;
            this.createLoginButton.Text = "Create Login";
            this.createLoginButton.UseVisualStyleBackColor = true;
            this.createLoginButton.Click += new System.EventHandler(this.createLoginButton_Click);
            // 
            // CreateNewLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 322);
            this.Controls.Add(this.createLoginButton);
            this.Controls.Add(this.passwordLabel2);
            this.Controls.Add(this.userIDLabel2);
            this.Controls.Add(this.passwordMatchLabel);
            this.Controls.Add(this.passwordtextBox2);
            this.Controls.Add(this.passwordTextBox1);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.userIDLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.seasonsComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectPersonComboBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CreateNewLogin";
            this.Text = "CreateNewLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selectPersonComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox seasonsComboBox;
        private System.Windows.Forms.Label userIDLabel;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.TextBox passwordTextBox1;
        private System.Windows.Forms.TextBox passwordtextBox2;
        private System.Windows.Forms.Label passwordMatchLabel;
        private System.Windows.Forms.Label userIDLabel2;
        private System.Windows.Forms.Label passwordLabel2;
        private System.Windows.Forms.Button createLoginButton;
    }
}