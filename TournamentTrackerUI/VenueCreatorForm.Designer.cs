namespace TournamentTrackerUI
{
    partial class VenueCreatorForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.venueNameLabel = new System.Windows.Forms.Label();
            this.venueNameTextBox = new System.Windows.Forms.TextBox();
            this.venueAddressTextBox = new System.Windows.Forms.TextBox();
            this.venueAddressLabel = new System.Windows.Forms.Label();
            this.venuePhoneTextBox = new System.Windows.Forms.TextBox();
            this.venuePhoneLabel = new System.Windows.Forms.Label();
            this.contactPersonTextBox = new System.Windows.Forms.TextBox();
            this.contactPersonLabel = new System.Windows.Forms.Label();
            this.numberOfPoolTableslabel = new System.Windows.Forms.Label();
            this.createVenueButton = new System.Windows.Forms.Button();
            this.numberOfPoolTablesTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // venueNameLabel
            // 
            this.venueNameLabel.AutoSize = true;
            this.venueNameLabel.Location = new System.Drawing.Point(45, 83);
            this.venueNameLabel.Name = "venueNameLabel";
            this.venueNameLabel.Size = new System.Drawing.Size(69, 13);
            this.venueNameLabel.TabIndex = 1;
            this.venueNameLabel.Text = "Venue Name";
            // 
            // venueNameTextBox
            // 
            this.venueNameTextBox.Location = new System.Drawing.Point(149, 80);
            this.venueNameTextBox.Name = "venueNameTextBox";
            this.venueNameTextBox.Size = new System.Drawing.Size(145, 20);
            this.venueNameTextBox.TabIndex = 2;
            // 
            // venueAddressTextBox
            // 
            this.venueAddressTextBox.Location = new System.Drawing.Point(149, 119);
            this.venueAddressTextBox.Name = "venueAddressTextBox";
            this.venueAddressTextBox.Size = new System.Drawing.Size(145, 20);
            this.venueAddressTextBox.TabIndex = 4;
            // 
            // venueAddressLabel
            // 
            this.venueAddressLabel.AutoSize = true;
            this.venueAddressLabel.Location = new System.Drawing.Point(45, 122);
            this.venueAddressLabel.Name = "venueAddressLabel";
            this.venueAddressLabel.Size = new System.Drawing.Size(79, 13);
            this.venueAddressLabel.TabIndex = 3;
            this.venueAddressLabel.Text = "Venue Address";
            // 
            // venuePhoneTextBox
            // 
            this.venuePhoneTextBox.Location = new System.Drawing.Point(149, 154);
            this.venuePhoneTextBox.Name = "venuePhoneTextBox";
            this.venuePhoneTextBox.Size = new System.Drawing.Size(145, 20);
            this.venuePhoneTextBox.TabIndex = 6;
            // 
            // venuePhoneLabel
            // 
            this.venuePhoneLabel.AutoSize = true;
            this.venuePhoneLabel.Location = new System.Drawing.Point(45, 157);
            this.venuePhoneLabel.Name = "venuePhoneLabel";
            this.venuePhoneLabel.Size = new System.Drawing.Size(72, 13);
            this.venuePhoneLabel.TabIndex = 5;
            this.venuePhoneLabel.Text = "Venue Phone";
            // 
            // contactPersonTextBox
            // 
            this.contactPersonTextBox.Location = new System.Drawing.Point(149, 190);
            this.contactPersonTextBox.Name = "contactPersonTextBox";
            this.contactPersonTextBox.Size = new System.Drawing.Size(145, 20);
            this.contactPersonTextBox.TabIndex = 8;
            // 
            // contactPersonLabel
            // 
            this.contactPersonLabel.AutoSize = true;
            this.contactPersonLabel.Location = new System.Drawing.Point(45, 193);
            this.contactPersonLabel.Name = "contactPersonLabel";
            this.contactPersonLabel.Size = new System.Drawing.Size(80, 13);
            this.contactPersonLabel.TabIndex = 7;
            this.contactPersonLabel.Text = "Contact Person";
            // 
            // numberOfPoolTableslabel
            // 
            this.numberOfPoolTableslabel.AutoSize = true;
            this.numberOfPoolTableslabel.Location = new System.Drawing.Point(45, 231);
            this.numberOfPoolTableslabel.Name = "numberOfPoolTableslabel";
            this.numberOfPoolTableslabel.Size = new System.Drawing.Size(103, 13);
            this.numberOfPoolTableslabel.TabIndex = 9;
            this.numberOfPoolTableslabel.Text = "Num. of Pool Tables";
            // 
            // createVenueButton
            // 
            this.createVenueButton.Location = new System.Drawing.Point(387, 266);
            this.createVenueButton.Name = "createVenueButton";
            this.createVenueButton.Size = new System.Drawing.Size(117, 34);
            this.createVenueButton.TabIndex = 11;
            this.createVenueButton.Text = "Create Venue";
            this.createVenueButton.UseVisualStyleBackColor = true;
            this.createVenueButton.Click += new System.EventHandler(this.createVenueButton_Click);
            // 
            // numberOfPoolTablesTextBox
            // 
            this.numberOfPoolTablesTextBox.Location = new System.Drawing.Point(170, 223);
            this.numberOfPoolTablesTextBox.Name = "numberOfPoolTablesTextBox";
            this.numberOfPoolTablesTextBox.Size = new System.Drawing.Size(124, 20);
            this.numberOfPoolTablesTextBox.TabIndex = 12;
            // 
            // VenueCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 327);
            this.Controls.Add(this.numberOfPoolTablesTextBox);
            this.Controls.Add(this.createVenueButton);
            this.Controls.Add(this.numberOfPoolTableslabel);
            this.Controls.Add(this.contactPersonTextBox);
            this.Controls.Add(this.contactPersonLabel);
            this.Controls.Add(this.venuePhoneTextBox);
            this.Controls.Add(this.venuePhoneLabel);
            this.Controls.Add(this.venueAddressTextBox);
            this.Controls.Add(this.venueAddressLabel);
            this.Controls.Add(this.venueNameTextBox);
            this.Controls.Add(this.venueNameLabel);
            this.Controls.Add(this.label1);
            this.Name = "VenueCreatorForm";
            this.Text = "VenueCreatorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label venueNameLabel;
        private System.Windows.Forms.TextBox venueNameTextBox;
        private System.Windows.Forms.TextBox venueAddressTextBox;
        private System.Windows.Forms.Label venueAddressLabel;
        private System.Windows.Forms.TextBox venuePhoneTextBox;
        private System.Windows.Forms.Label venuePhoneLabel;
        private System.Windows.Forms.TextBox contactPersonTextBox;
        private System.Windows.Forms.Label contactPersonLabel;
        private System.Windows.Forms.Label numberOfPoolTableslabel;
        private System.Windows.Forms.Button createVenueButton;
        private System.Windows.Forms.TextBox numberOfPoolTablesTextBox;
    }
}