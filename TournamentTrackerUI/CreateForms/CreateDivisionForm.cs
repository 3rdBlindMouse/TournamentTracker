﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using TournamentLibrary;
using TournamentLibrary.Models;
using TournamentTrackerUI.RequestInterfaces;

namespace TournamentTrackerUI
{
    public partial class CreateDivisionForm : Form
    {
        IDivisionRequester callingForm;
        private static string method;
        private static SeasonModel thisSeason = new SeasonModel();
        // A list to hold dates to be skipped
        private static List<DateTime> skippedDates = new List<DateTime>();
 
        // A list of all Divisions in the season
        private static List<DivisionModel> divs = new List<DivisionModel>();

        private static List<string> divNames = new List<string>();

        private static List<int> divNumbers = new List<int>();
        
        // name and number validator variables
        bool nameValid = false;
        bool numberValid = false;
        bool startDateValid = false;


        private static SeasonDivisionsModel sdm = new SeasonDivisionsModel();

        public CreateDivisionForm(IDivisionRequester caller)
        {
            callingForm = caller;

            
            StackFrame frame = new StackFrame(1, true);
            method = (frame.GetMethod().Name);


            InitializeComponent();
         //   WireupTeams();
           // getTeamNames(divs);
           // getTeamNumbers(divs);
        }


        public CreateDivisionForm(IDivisionRequester caller, SeasonModel season)
        {
            callingForm = caller;
            thisSeason = season;

            StackFrame frame = new StackFrame(1, true);
            method = (frame.GetMethod().Name);

            
            
           
            divs = GlobalConfig.Connection.GetSeasonDivisions(thisSeason.SeasonID);

            InitializeComponent();
           
            seasonNameLabel.Text = thisSeason.SeasonName;
        }
       
        /// <summary>
        /// Creates a list of Team Names in selected Divisions
        /// </summary>
        /// <param name="d">A list of Divisions</param>
        private void getDivNames(List<DivisionModel> d)
        {
            foreach (DivisionModel dm in d)
            {
                divNames.Add(dm.DivisionName.ToString());
            }
        }
        /// <summary>
        /// Creates a list of Team Numbers in selected Divisions
        /// </summary>
        /// <param name="d">A list of Divisions</param>
        private void getDivNumbers(List<DivisionModel> d)
        {
            foreach (DivisionModel dm in d)
            {
                divNumbers.Add(dm.DivisionNumber);
            }
        }
        /// <summary>
        /// Actions taken when user Types a Name in DivisionNameTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DivisionNameTextbox_TextChanged(object sender, EventArgs e)
        {
            // If TexBox is empty
            if (DivisionNameTextbox.Text == "")
            {
                DivisionNameTextbox.BackColor = SystemColors.Info;
                DisplayName.Text = "Please Enter a Name";
            }
            else
            {
                // If Entered Name already exists as a Team name in selected Season Divisions
                if (divNames.Contains(DivisionNameTextbox.Text))
                {
                    DisplayName.BackColor = Color.Crimson;
                    DivisionNameTextbox.BackColor = Color.Crimson;
                    DisplayName.Text = "Name Already Exists";
                }
                // If name is not a valid string
                else if (!ValidateDivisionName(DivisionNameTextbox))
                {
                    DisplayName.BackColor = Color.Crimson;
                    DivisionNameTextbox.BackColor = Color.Crimson;
                }
                else
                {
                    DivisionNameTextbox.BackColor = Color.LightGreen;
                    DisplayName.Text = DivisionNameTextbox.Text;
                    DisplayName.BackColor = Color.LightGreen;
                    nameValid = true;
                }
            }
        }
        /// <summary>
        /// validates user input division name as a valid alphabetical string
        /// </summary>
        /// <param name="tb"></param>
        private bool ValidateDivisionName(TextBox tb)
        {
            bool valid = true;
            Validator validator = new Validator();
            // If name contains a number
            if (!validator.noNumbers(tb.Text))
            {
                DisplayName.Text = "No Numbers Allowed";
                valid = false;
            }
            else
            {
                // If spaces at start/end of name of multiple consecutive spaces exist in name
                if (!validator.noSpaces(tb.Text))
                {
                    DisplayName.Text = "No Leading or Ending Spaces Allowed";
                    valid = false;
                }
            }
            return valid;
        }
        /// <summary>
        /// Actions taken when user Types a Number in DivisionNumberTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DivisionNumberTextbox_TextChanged(object sender, EventArgs e)
        {
            // If DivisonNumberTextBox is empty
            if (DivisionNumberTextbox.Text == "")
            {
                DivisionNumberTextbox.BackColor = SystemColors.Info;
                DisplayNumber.Text = "Please Enter a Number";
            }
            else
            {
                if(DivisionNumberTextbox.Text.Length > 6)
                {
                    MessageBox.Show("Please enter a smaller number");
                    DivisionNumberTextbox.Text = "";
                }
                // If number is not a valid number
                if (!ValidateDivisionNumber(DivisionNumberTextbox))
                {
                    DisplayNumber.BackColor = Color.Crimson;
                    DivisionNumberTextbox.BackColor = Color.Crimson;
                    DisplayNumber.Text = "Please Enter a Valid Number";
                }
                //If team Number exists in list of season Division teams
                else if (divNumbers.Contains(int.Parse(DivisionNumberTextbox.Text)))
                {
                    DisplayNumber.BackColor = Color.Crimson;
                    DivisionNumberTextbox.BackColor = Color.Crimson;
                    DisplayNumber.Text = "Number Already Exists";
                }

                else
                {
                    DivisionNumberTextbox.BackColor = Color.LightGreen;
                    DisplayNumber.Text = DivisionNumberTextbox.Text;
                    DisplayNumber.BackColor = Color.LightGreen;
                    numberValid = true;
                }
            }
        }
        /// <summary>
        /// validates user input division number as a valid number
        /// </summary>
        /// <param name="tb"></param>
        private bool ValidateDivisionNumber(TextBox tb)
        {
            Validator check = new Validator();
            if ((check.isValidNumber(tb.Text) && (tb.Text != "")))
            {

                return true;
            }
            else
            {

                return false;
            }
        }              
       /// <summary>
       /// Update display to show start date user has selected
       /// </summary>
        private void UpdateStartDate()
        {
            selectedStartDate.Text = StartDate.Value.ToString("D");
            if(selectedStartDate.Text != "")
            {
                startDateValid = true;
                SkipDatesdateTimePicker.MinDate = StartDate.Value;
                SkipDatesdateTimePicker.MaxDate = StartDate.Value.AddDays(364);
            }
            else
            {
                MessageBox.Show("Please Select a Start Date");
                startDateValid = false;
            }
        }
        /// <summary>
        /// Updates display to show selected date(s) to skip
        /// </summary>
        private void addSkipdates()
        {
            if (selectedStartDate.Text == "")
            {
                MessageBox.Show("Please Select a Start Date");
            }
            else
            {
                var date = SkipDatesdateTimePicker.Value.ToString("D");
                // check to see if date is already selected as a skipped date
                if (!skippedDates.Contains(DateTime.Parse(date)))
                {
                    skippedDates.Add(DateTime.Parse(date));
                    updateSkippedDatesBox();
                }
            }
        }
        /// <summary>
        /// Updates display to remove selected date(s)
        /// </summary>
        private void removeSkippedDates()
        {
            if (skippedDatesListbox.SelectedItem != null)
            {
                var sortedDates = skippedDates.OrderBy(x => x).ToList();
                var date = DateTime.Parse(skippedDatesListbox.SelectedItem.ToString());
                skippedDates.Remove(date);

                updateSkippedDatesBox();
            }
        }
        /// <summary>
        /// Updates skippedDatesListbox when dates are added or removed
        /// </summary>
        private void updateSkippedDatesBox()
        {
            skippedDatesListbox.Items.Clear();
            var sortedDates = skippedDates.OrderBy(x => x).ToList();
            foreach (DateTime dates in sortedDates)
            {
                skippedDatesListbox.Items.Add(dates.ToString("D"));
            }
        }
        private void StartDate_ValueChanged(object sender, EventArgs e)
        {
            UpdateStartDate();
        }
        private void skipDatesAddButton_Click(object sender, EventArgs e)
        {
            addSkipdates();
        }
        private void skipDatesRemoveButton_Click(object sender, EventArgs e)
        {
            removeSkippedDates();
        }
       
        private void createDivisionButton_Click(object sender, EventArgs e)
        {
            { 
                // make sure form is valid
                // == "" checks incase data was valid but was deleted before pressing create
                if ((nameValid == true) && (DivisionNameTextbox.Text != "") 
                    && (numberValid == true) && (DivisionNumberTextbox.Text != "")
                    && (startDateValid == true))
                {
                    // create a division model
                    DivisionModel model = createDivision();
                    sdm = createSeasonDivisionsModel(model);
                    
                    createSkippedDates(sdm);
                    //GlobalConfig.Connection.createSeasonDivisions(sdm);
                    callingForm.DivisionComplete(model);
                    updateData();      
                    MessageBox.Show("Division Successfully Created");
                    if (method == "createNewDivisionLinkLabel_LinkClicked")
                    {
                        this.Close();
                        //MessageBox.Show("From Create Division Form");
                    }
                    //clearForm();    
                }
                else
                {
                    formFilledIn();
                }
            }
        }

        private SeasonDivisionsModel createSeasonDivisionsModel(DivisionModel model)
        {
            SeasonDivisionsModel sdm = new SeasonDivisionsModel();
            sdm.SeasonID = model.SeasonID;
            sdm.DivisionID = model.DivisionID;
            sdm.StartDate = model.StartDate;
            return GlobalConfig.Connection.createSeasonDivisions(sdm);
        }

        /// <summary>
        /// Grab any changes from DB (to stop duplicates being made before form closes)
        /// </summary>
        private void updateData()
        {
            divs = GlobalConfig.Connection.GetSeasonDivisions(thisSeason.SeasonID);
            getDivNames(divs);
            getDivNumbers(divs);
        }

        

        /// <summary>
        /// Create a basic DivsionModel frame and Update DB et.al
        /// </summary>
        /// <returns>Return created DivisionModel</returns>
        private DivisionModel createDivision()
        {
            DivisionModel model = new DivisionModel();
            model.DivisionName = DivisionNameTextbox.Text;
            model.DivisionNumber = int.Parse(DivisionNumberTextbox.Text);
            model.SeasonID = thisSeason.SeasonID;
            
            model.StartDate = StartDate.Value;
            // store division in Db and return ID
            GlobalConfig.Connection.CreateDivision(model);
           
            return model;
        }
        /// <summary>
        /// Create SkippedDates Model and Update DB et.al
        /// </summary>
        /// <param name="model"></param>
        private void createSkippedDates(SeasonDivisionsModel model)
        {
            List<SkippedDatesModel> skModels = new List<SkippedDatesModel>();
            foreach (DateTime date in skippedDates)
            {
                SkippedDatesModel skDates = new SkippedDatesModel(model.SeasonDivisionsID, date);
                //skDates.SeasonDivisionsID = model.SeasonDivisionsID;
                //skDates.DateToSkip = date;
                GlobalConfig.Connection.CreateSkippedDates(skDates);
                skModels.Add(skDates);
            }
            sdm.skippedDates = skModels;
            skippedDates = new List<DateTime>();
        }
        
        /// <summary>
        /// Clear data from Form
        /// </summary>
        private void clearForm()
        {
            DivisionNameTextbox.Text = "" ;
            DivisionNumberTextbox.Text = "";
            StartDate.ResetText();
            selectedStartDate.Text = "";
            SkipDatesdateTimePicker.ResetText();
            if (skippedDatesListbox.Items.Count > 0)
            {
                skippedDatesListbox.Items.Clear();
            }
            DisplayName.Text = "";
            DisplayNumber.Text = "";
            
        }
       
        /// <summary>
        /// When new Create team form has team successfully created
        /// </summary>
        /// <param name="model"></param>
       
        private void ExitToMainMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void closeForm(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }
        /// <summary>
        /// Prompt User to Enter a Name and/or Number
        /// Redundant Method
        /// </summary>
        /// <param name="model"></param>
        private void formFilledIn()
        {
            int i = 0;
            string message = "Please enter a ";
            if (DivisionNameTextbox.Text == "") 
            {
                i++;
            }
            if (DivisionNumberTextbox.Text == "") 
            {
                i = i + 2;
            }
            if (selectedStartDate.Text == "" )
            {
                i = i + 4;
            }

            if (i != 0)
            {
                switch (i)
                {
                    case 1:
                        message += "Name";
                        break;
                    case 2:
                        message += "Number";
                        break;
                    case 3:
                        message += "Name and Number";
                        break;
                    case 4:
                        message += "Start Date";
                        break;
                    case 5:
                        message += "Name and Start Date";
                        break;
                    case 6:
                        message += "Number and Start Date";
                        break;
                    case 7:
                        message += "Name and Number and Start Date";
                        break;
                }
                MessageBox.Show(message);
            }
        }

        public string DivisionName()
        {
            throw new NotImplementedException();
        }

        public SeasonDivisionsModel SeasonDivision()
        {
            throw new NotImplementedException();
        }
    }
    }

