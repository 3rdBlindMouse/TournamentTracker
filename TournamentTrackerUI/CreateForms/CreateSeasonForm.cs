using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentLibrary;
using TournamentLibrary.DataAccess;
using TournamentLibrary.Models;
using TournamentTrackerUI.RequestInterfaces;

namespace TournamentTrackerUI.CreateForms
{
    public partial class CreateSeasonForm : Form, IDivisionRequester
    {
        private List<SeasonModel> thisSeasonAsList = GlobalConfig.Connection.GetLastSeason();
        private SeasonModel thisSeason = new SeasonModel();


        private List<DivisionModel> selectedDivisions = new List<DivisionModel>();

        public CreateSeasonForm()
        {
            InitializeComponent();
            ConvertSeasonListToSeasonModel();
            InitializeLabels();
            
        }

        

        /// <summary>
        /// Takes the list containing the last season created (The one that called this form)
        /// and creates a SeasonModel from the data.
        /// </summary>
        private void ConvertSeasonListToSeasonModel()
        {
            foreach(SeasonModel sm in thisSeasonAsList)
            {
                thisSeason.SeasonID = sm.SeasonID;
                thisSeason.SeasonName = sm.SeasonName;
                thisSeason.SeasonYear = sm.SeasonYear;
                thisSeason.SeasonDescription = sm.SeasonDescription;
            }
        }
        /// <summary>
        /// Show Details of Current Season at top of form
        /// </summary>
        private void InitializeLabels()
        {
            displayNameLabel.Text = thisSeason.SeasonName;
            displayYearLabel.Text = thisSeason.SeasonYear.ToString();
            displayDescriptionLabel.Text = thisSeason.SeasonDescription;

        }

        private void createNewDivisionLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateDivisionForm divisionForm = new CreateDivisionForm(this, thisSeason.SeasonID);
            divisionForm.Show();
            this.Hide();
            divisionForm.FormClosing += closeForm;
        }

        public void closeForm(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        public void DivisionComplete(DivisionModel model)
        {
            selectedDivisions.Add(model);
            wireUpDivisionListBox();
        }

        

        private void wireUpDivisionListBox()
        {
            foreach(DivisionModel dm in selectedDivisions)
            {
                divisionsListBox.Items.Add(dm.DivisionName);
            }
        }
    }
}
