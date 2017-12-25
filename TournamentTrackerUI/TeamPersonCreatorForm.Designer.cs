namespace TournamentTrackerUI
{
    partial class TeamPersonCreatorForm
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
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.sexLabel = new System.Windows.Forms.Label();
            this.contactNumberLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.EmailTextbox = new System.Windows.Forms.TextBox();
            this.ContactNumberTextbox = new System.Windows.Forms.TextBox();
            this.FirstNameTextbox = new System.Windows.Forms.TextBox();
            this.LastNameTextbox = new System.Windows.Forms.TextBox();
            this.createPlayerButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SexComboBox = new System.Windows.Forms.ComboBox();
            this.dayComboBox = new System.Windows.Forms.ComboBox();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.resetDOBButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.confirmDOBButton = new System.Windows.Forms.Button();
            this.detailsHeadingsListBox = new System.Windows.Forms.ListBox();
            this.detailsListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(220, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Player";
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateOfBirthLabel.Location = new System.Drawing.Point(13, 14);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(271, 21);
            this.dateOfBirthLabel.TabIndex = 0;
            this.dateOfBirthLabel.Text = "Date Of Birth (Leave blank for no age)";
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sexLabel.Location = new System.Drawing.Point(12, 272);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(34, 21);
            this.sexLabel.TabIndex = 0;
            this.sexLabel.Text = "Sex";
            // 
            // contactNumberLabel
            // 
            this.contactNumberLabel.AutoSize = true;
            this.contactNumberLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNumberLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.contactNumberLabel.Location = new System.Drawing.Point(12, 231);
            this.contactNumberLabel.Name = "contactNumberLabel";
            this.contactNumberLabel.Size = new System.Drawing.Size(125, 21);
            this.contactNumberLabel.TabIndex = 4;
            this.contactNumberLabel.Text = "Contact Number";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.emailLabel.Location = new System.Drawing.Point(12, 190);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(108, 21);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "Email Address";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lastNameLabel.Location = new System.Drawing.Point(12, 150);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(84, 21);
            this.lastNameLabel.TabIndex = 0;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.firstNameLabel.Location = new System.Drawing.Point(12, 110);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(86, 21);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.BackColor = System.Drawing.SystemColors.Info;
            this.EmailTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextbox.Location = new System.Drawing.Point(183, 187);
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.Size = new System.Drawing.Size(227, 29);
            this.EmailTextbox.TabIndex = 4;
            this.EmailTextbox.Enter += new System.EventHandler(this.EmailTextbox_Enter);
            this.EmailTextbox.Leave += new System.EventHandler(this.EmailTextbox_Leave);
            // 
            // ContactNumberTextbox
            // 
            this.ContactNumberTextbox.BackColor = System.Drawing.SystemColors.Info;
            this.ContactNumberTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactNumberTextbox.Location = new System.Drawing.Point(183, 228);
            this.ContactNumberTextbox.Name = "ContactNumberTextbox";
            this.ContactNumberTextbox.Size = new System.Drawing.Size(227, 29);
            this.ContactNumberTextbox.TabIndex = 5;
            this.ContactNumberTextbox.Enter += new System.EventHandler(this.contactNumberTextbox_Enter);
            this.ContactNumberTextbox.Leave += new System.EventHandler(this.contactNumberTextbox_Leave);
            // 
            // FirstNameTextbox
            // 
            this.FirstNameTextbox.BackColor = System.Drawing.SystemColors.Info;
            this.FirstNameTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameTextbox.Location = new System.Drawing.Point(183, 107);
            this.FirstNameTextbox.Name = "FirstNameTextbox";
            this.FirstNameTextbox.Size = new System.Drawing.Size(227, 29);
            this.FirstNameTextbox.TabIndex = 2;
            this.FirstNameTextbox.Enter += new System.EventHandler(this.FirstNameTextbox_Enter);
            this.FirstNameTextbox.Leave += new System.EventHandler(this.FirstNameTextbox_Leave);
            // 
            // LastNameTextbox
            // 
            this.LastNameTextbox.BackColor = System.Drawing.SystemColors.Info;
            this.LastNameTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTextbox.Location = new System.Drawing.Point(183, 147);
            this.LastNameTextbox.Name = "LastNameTextbox";
            this.LastNameTextbox.Size = new System.Drawing.Size(227, 29);
            this.LastNameTextbox.TabIndex = 3;
            this.LastNameTextbox.Enter += new System.EventHandler(this.LastNameTextbox_Enter);
            this.LastNameTextbox.Leave += new System.EventHandler(this.LastNameTextbox_Leave);
            // 
            // createPlayerButton
            // 
            this.createPlayerButton.ForeColor = System.Drawing.Color.Black;
            this.createPlayerButton.Location = new System.Drawing.Point(528, 307);
            this.createPlayerButton.Name = "createPlayerButton";
            this.createPlayerButton.Size = new System.Drawing.Size(126, 36);
            this.createPlayerButton.TabIndex = 12;
            this.createPlayerButton.Text = "Create Player";
            this.createPlayerButton.UseVisualStyleBackColor = true;
            this.createPlayerButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitButton
            // 
            this.exitButton.ForeColor = System.Drawing.Color.Black;
            this.exitButton.Location = new System.Drawing.Point(683, 368);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 28);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // SexComboBox
            // 
            this.SexComboBox.BackColor = System.Drawing.SystemColors.Info;
            this.SexComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SexComboBox.FormattingEnabled = true;
            this.SexComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.SexComboBox.Location = new System.Drawing.Point(183, 264);
            this.SexComboBox.MaxDropDownItems = 2;
            this.SexComboBox.Name = "SexComboBox";
            this.SexComboBox.Size = new System.Drawing.Size(173, 29);
            this.SexComboBox.TabIndex = 6;
            this.SexComboBox.Leave += new System.EventHandler(this.SexComboBox_Leave);
            // 
            // dayComboBox
            // 
            this.dayComboBox.FormattingEnabled = true;
            this.dayComboBox.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.dayComboBox.Location = new System.Drawing.Point(17, 48);
            this.dayComboBox.Name = "dayComboBox";
            this.dayComboBox.Size = new System.Drawing.Size(59, 21);
            this.dayComboBox.TabIndex = 7;
            this.dayComboBox.Text = "DAY";
            this.dayComboBox.Enter += new System.EventHandler(this.dayComboBox_Enter);
            this.dayComboBox.Leave += new System.EventHandler(this.dayComboBox_Leave);
            // 
            // monthComboBox
            // 
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.monthComboBox.Location = new System.Drawing.Point(82, 48);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(96, 21);
            this.monthComboBox.TabIndex = 8;
            this.monthComboBox.Text = "MONTH";
            this.monthComboBox.Enter += new System.EventHandler(this.monthComboBox_Enter);
            this.monthComboBox.Leave += new System.EventHandler(this.monthComboBox_Leave);
            // 
            // yearComboBox
            // 
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Items.AddRange(new object[] {
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985 ",
            "1984",
            "1983",
            "1982 ",
            "1981",
            "1980 ",
            "1979 ",
            "1978",
            "1977",
            "1976",
            "1975",
            "1974",
            "1973",
            "1972",
            "1971",
            "1970",
            "1969",
            "1968",
            "1967",
            "1966",
            "1965",
            "1964",
            "1963",
            "1962",
            "1961",
            "1960",
            "1959",
            "1958",
            "1957",
            "1956",
            "1955",
            "1954",
            "1953",
            "1952",
            "1951",
            "1950",
            "1949",
            "1948",
            "1947",
            "1946",
            "1945",
            "1944",
            "1943",
            "1942",
            "1941",
            "1940",
            "1939",
            "1938",
            "1937",
            "1936",
            "1935",
            "1934",
            "1933",
            "1932",
            "1931",
            "1930",
            "1929",
            "1928",
            "1927",
            "1926",
            "1925",
            "1924",
            "1923",
            "1922",
            "1921",
            "1920",
            "1919",
            "1918",
            "1917",
            "1916",
            "1915",
            "1914",
            "1913",
            "1912",
            "1911",
            "1910",
            "1909",
            "1908",
            "1907",
            "1906",
            "1905",
            "1904 ",
            "1903 ",
            "1902",
            "1901"});
            this.yearComboBox.Location = new System.Drawing.Point(184, 48);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(56, 21);
            this.yearComboBox.TabIndex = 9;
            this.yearComboBox.Text = "YEAR";
            this.yearComboBox.Enter += new System.EventHandler(this.yearComboBox_Enter);
            this.yearComboBox.Leave += new System.EventHandler(this.yearComboBox_Leave);
            // 
            // resetDOBButton
            // 
            this.resetDOBButton.ForeColor = System.Drawing.Color.Black;
            this.resetDOBButton.Location = new System.Drawing.Point(82, 78);
            this.resetDOBButton.Name = "resetDOBButton";
            this.resetDOBButton.Size = new System.Drawing.Size(75, 23);
            this.resetDOBButton.TabIndex = 11;
            this.resetDOBButton.Text = "Reset";
            this.resetDOBButton.UseVisualStyleBackColor = true;
            this.resetDOBButton.Click += new System.EventHandler(this.resetDOB_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.confirmDOBButton);
            this.groupBox1.Controls.Add(this.resetDOBButton);
            this.groupBox1.Controls.Add(this.dateOfBirthLabel);
            this.groupBox1.Controls.Add(this.yearComboBox);
            this.groupBox1.Controls.Add(this.dayComboBox);
            this.groupBox1.Controls.Add(this.monthComboBox);
            this.groupBox1.Location = new System.Drawing.Point(-1, 299);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 107);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // confirmDOBButton
            // 
            this.confirmDOBButton.ForeColor = System.Drawing.Color.Black;
            this.confirmDOBButton.Location = new System.Drawing.Point(247, 48);
            this.confirmDOBButton.Name = "confirmDOBButton";
            this.confirmDOBButton.Size = new System.Drawing.Size(75, 23);
            this.confirmDOBButton.TabIndex = 10;
            this.confirmDOBButton.Text = "Confirm";
            this.confirmDOBButton.UseVisualStyleBackColor = true;
            this.confirmDOBButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // detailsHeadingsListBox
            // 
            this.detailsHeadingsListBox.BackColor = System.Drawing.SystemColors.Info;
            this.detailsHeadingsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detailsHeadingsListBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsHeadingsListBox.FormattingEnabled = true;
            this.detailsHeadingsListBox.ItemHeight = 17;
            this.detailsHeadingsListBox.Items.AddRange(new object[] {
            "First Name",
            "",
            "Last Name",
            "",
            "Email",
            "",
            "Contact #",
            "",
            "Sex",
            "",
            "Date of Birth "});
            this.detailsHeadingsListBox.Location = new System.Drawing.Point(0, 7);
            this.detailsHeadingsListBox.Name = "detailsHeadingsListBox";
            this.detailsHeadingsListBox.Size = new System.Drawing.Size(87, 204);
            this.detailsHeadingsListBox.TabIndex = 8;
            this.detailsHeadingsListBox.TabStop = false;
            // 
            // detailsListBox
            // 
            this.detailsListBox.BackColor = System.Drawing.SystemColors.Info;
            this.detailsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detailsListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsListBox.ForeColor = System.Drawing.Color.Green;
            this.detailsListBox.FormattingEnabled = true;
            this.detailsListBox.ItemHeight = 17;
            this.detailsListBox.Items.AddRange(new object[] {
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""});
            this.detailsListBox.Location = new System.Drawing.Point(93, 7);
            this.detailsListBox.Name = "detailsListBox";
            this.detailsListBox.Size = new System.Drawing.Size(246, 204);
            this.detailsListBox.TabIndex = 0;
            this.detailsListBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.detailsHeadingsListBox);
            this.panel1.Controls.Add(this.detailsListBox);
            this.panel1.Location = new System.Drawing.Point(416, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 236);
            this.panel1.TabIndex = 17;
            // 
            // TeamPersonCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 408);
            this.Controls.Add(this.SexComboBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.createPlayerButton);
            this.Controls.Add(this.LastNameTextbox);
            this.Controls.Add(this.FirstNameTextbox);
            this.Controls.Add(this.ContactNumberTextbox);
            this.Controls.Add(this.EmailTextbox);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.contactNumberLabel);
            this.Controls.Add(this.sexLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "TeamPersonCreatorForm";
            this.Text = "PersonCreator";
            this.Load += new System.EventHandler(this.PersonCreatorForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.Label contactNumberLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox EmailTextbox;
        private System.Windows.Forms.TextBox ContactNumberTextbox;
        private System.Windows.Forms.TextBox FirstNameTextbox;
        private System.Windows.Forms.TextBox LastNameTextbox;
        private System.Windows.Forms.Button createPlayerButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ComboBox SexComboBox;
        private System.Windows.Forms.ComboBox dayComboBox;
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.Button resetDOBButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox detailsHeadingsListBox;
        private System.Windows.Forms.ListBox detailsListBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button confirmDOBButton;
    }
}