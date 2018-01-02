namespace TournamentTrackerUI
{
    partial class CreateVenueForm
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
            this.detailsHeadingsListbox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.detailsListbox = new System.Windows.Forms.ListBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            this.venueNameLabel.Location = new System.Drawing.Point(23, 82);
            this.venueNameLabel.Name = "venueNameLabel";
            this.venueNameLabel.Size = new System.Drawing.Size(69, 13);
            this.venueNameLabel.TabIndex = 0;
            this.venueNameLabel.Text = "Venue Name";
            // 
            // venueNameTextBox
            // 
            this.venueNameTextBox.Location = new System.Drawing.Point(127, 79);
            this.venueNameTextBox.Name = "venueNameTextBox";
            this.venueNameTextBox.Size = new System.Drawing.Size(145, 20);
            this.venueNameTextBox.TabIndex = 1;
            this.venueNameTextBox.Enter += new System.EventHandler(this.venueNameTextBox_Enter);
            this.venueNameTextBox.Leave += new System.EventHandler(this.venueNameTextBox_Leave);
            // 
            // venueAddressTextBox
            // 
            this.venueAddressTextBox.Location = new System.Drawing.Point(127, 118);
            this.venueAddressTextBox.Name = "venueAddressTextBox";
            this.venueAddressTextBox.Size = new System.Drawing.Size(145, 20);
            this.venueAddressTextBox.TabIndex = 2;
            this.venueAddressTextBox.Enter += new System.EventHandler(this.venueAddressTextBox_Enter);
            this.venueAddressTextBox.Leave += new System.EventHandler(this.venueAddressTextBox_Leave);
            // 
            // venueAddressLabel
            // 
            this.venueAddressLabel.AutoSize = true;
            this.venueAddressLabel.Location = new System.Drawing.Point(23, 121);
            this.venueAddressLabel.Name = "venueAddressLabel";
            this.venueAddressLabel.Size = new System.Drawing.Size(79, 13);
            this.venueAddressLabel.TabIndex = 0;
            this.venueAddressLabel.Text = "Venue Address";
            // 
            // venuePhoneTextBox
            // 
            this.venuePhoneTextBox.Location = new System.Drawing.Point(127, 153);
            this.venuePhoneTextBox.Name = "venuePhoneTextBox";
            this.venuePhoneTextBox.Size = new System.Drawing.Size(145, 20);
            this.venuePhoneTextBox.TabIndex = 3;
            this.venuePhoneTextBox.Enter += new System.EventHandler(this.venuePhoneTextBox_Enter);
            this.venuePhoneTextBox.Leave += new System.EventHandler(this.venuePhoneTextBox_Leave);
            // 
            // venuePhoneLabel
            // 
            this.venuePhoneLabel.AutoSize = true;
            this.venuePhoneLabel.Location = new System.Drawing.Point(23, 156);
            this.venuePhoneLabel.Name = "venuePhoneLabel";
            this.venuePhoneLabel.Size = new System.Drawing.Size(72, 13);
            this.venuePhoneLabel.TabIndex = 0;
            this.venuePhoneLabel.Text = "Venue Phone";
            // 
            // contactPersonTextBox
            // 
            this.contactPersonTextBox.Location = new System.Drawing.Point(127, 189);
            this.contactPersonTextBox.Name = "contactPersonTextBox";
            this.contactPersonTextBox.Size = new System.Drawing.Size(145, 20);
            this.contactPersonTextBox.TabIndex = 4;
            this.contactPersonTextBox.Enter += new System.EventHandler(this.contactPersonTextBox_Enter);
            this.contactPersonTextBox.Leave += new System.EventHandler(this.contactPersonTextBox_Leave);
            // 
            // contactPersonLabel
            // 
            this.contactPersonLabel.AutoSize = true;
            this.contactPersonLabel.Location = new System.Drawing.Point(23, 192);
            this.contactPersonLabel.Name = "contactPersonLabel";
            this.contactPersonLabel.Size = new System.Drawing.Size(80, 13);
            this.contactPersonLabel.TabIndex = 0;
            this.contactPersonLabel.Text = "Contact Person";
            // 
            // numberOfPoolTableslabel
            // 
            this.numberOfPoolTableslabel.AutoSize = true;
            this.numberOfPoolTableslabel.Location = new System.Drawing.Point(23, 230);
            this.numberOfPoolTableslabel.Name = "numberOfPoolTableslabel";
            this.numberOfPoolTableslabel.Size = new System.Drawing.Size(103, 13);
            this.numberOfPoolTableslabel.TabIndex = 0;
            this.numberOfPoolTableslabel.Text = "Num. of Pool Tables";
            // 
            // createVenueButton
            // 
            this.createVenueButton.Location = new System.Drawing.Point(306, 267);
            this.createVenueButton.Name = "createVenueButton";
            this.createVenueButton.Size = new System.Drawing.Size(117, 34);
            this.createVenueButton.TabIndex = 6;
            this.createVenueButton.Text = "Create Venue";
            this.createVenueButton.UseVisualStyleBackColor = true;
            this.createVenueButton.Click += new System.EventHandler(this.createVenueButton_Click);
            // 
            // numberOfPoolTablesTextBox
            // 
            this.numberOfPoolTablesTextBox.Location = new System.Drawing.Point(148, 222);
            this.numberOfPoolTablesTextBox.Name = "numberOfPoolTablesTextBox";
            this.numberOfPoolTablesTextBox.Size = new System.Drawing.Size(124, 20);
            this.numberOfPoolTablesTextBox.TabIndex = 5;
            this.numberOfPoolTablesTextBox.Enter += new System.EventHandler(this.numberOfPoolTablesTextBox_Enter);
            this.numberOfPoolTablesTextBox.Leave += new System.EventHandler(this.numberOfPoolTablesTextBox_Leave);
            // 
            // detailsHeadingsListbox
            // 
            this.detailsHeadingsListbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detailsHeadingsListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsHeadingsListbox.FormattingEnabled = true;
            this.detailsHeadingsListbox.ItemHeight = 16;
            this.detailsHeadingsListbox.Items.AddRange(new object[] {
            "Name :",
            "Address :",
            "Phone :",
            "Contact :",
            "PoolTables :"});
            this.detailsHeadingsListbox.Location = new System.Drawing.Point(3, 3);
            this.detailsHeadingsListbox.Name = "detailsHeadingsListbox";
            this.detailsHeadingsListbox.Size = new System.Drawing.Size(93, 128);
            this.detailsHeadingsListbox.TabIndex = 0;
            this.detailsHeadingsListbox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.detailsListbox);
            this.panel1.Controls.Add(this.detailsHeadingsListbox);
            this.panel1.Location = new System.Drawing.Point(278, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 163);
            this.panel1.TabIndex = 0;
            // 
            // detailsListbox
            // 
            this.detailsListbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detailsListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsListbox.FormattingEnabled = true;
            this.detailsListbox.ItemHeight = 16;
            this.detailsListbox.Items.AddRange(new object[] {
            "",
            "",
            "",
            "",
            ""});
            this.detailsListbox.Location = new System.Drawing.Point(102, 3);
            this.detailsListbox.Name = "detailsListbox";
            this.detailsListbox.Size = new System.Drawing.Size(197, 128);
            this.detailsListbox.TabIndex = 0;
            this.detailsListbox.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(493, 267);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(87, 34);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit To Main Menu";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // CreateVenueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 327);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.panel1);
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
            this.Name = "CreateVenueForm";
            this.Text = "VenueCreatorForm";
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.ListBox detailsHeadingsListbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox detailsListbox;
        private System.Windows.Forms.Button exitButton;
    }
}