using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentLibrary;
using TournamentLibrary.Models;
using TournamentTrackerUI.RequestInterfaces;

namespace TournamentTrackerUI
{
    public partial class DivisionDatesForm : Form
    {
        IDivisionDatesRequester callingForm;
        // A list to hold dates to be skipped
        private static List<DateTime> skippedDates = new List<DateTime>();
        private static DivisionModel division = new DivisionModel();
        private static int seasonID;

        public DivisionDatesForm(IDivisionDatesRequester caller, int sID, DivisionModel dModel)
        {
            callingForm = caller;
            InitializeComponent();
            division = dModel;
            seasonID = sID;
            WireUpLabels();
        }

        private void WireUpLabels()
        {
            DivNameLabel2.Text = division.DivisionName;
            DivNumberLabel2.Text = division.DivisionNumber.ToString();
        }



        /*
       * User notifications
       */

        private void UpdateStartDate()
        {
            selectedStartDate.Text = StartDate.Value.ToString("D");
        }
        /// <summary>
        /// Updates display to show selected date(s) to skip
        /// </summary>
        private void addSkipdates()
        {
            var date = SkipDatesdateTimePicker.Value.ToString("D");
            // check to see if date is already selected as a skipped date
            if (!skippedDates.Contains(DateTime.Parse(date)))
            {
                skippedDates.Add(DateTime.Parse(date));
                updateSkippedDatesBox();
            }
        }

        private void updateSkippedDatesBox()
        {
            skippedDatesListbox.Items.Clear();
            var sortedDates = skippedDates.OrderBy(x => x).ToList();
            foreach (DateTime dates in sortedDates)
            {
                skippedDatesListbox.Items.Add(dates.ToString("D"));
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
        
        /*
         * Select Events
         */
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

        private void ExitToMainMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addDatesButton_Click(object sender, EventArgs e)
        {
            // create a new SeasonDivisionsModel
            SeasonDivisionsModel model = new SeasonDivisionsModel();
            model.SeasonID = seasonID;
            model.DivisionID = division.DivisionID;
            model.StartDate = StartDate.Value;
            // store division in Db and return ID
            GlobalConfig.Connection.createSeasonDivisions(model);


            foreach (DateTime date in skippedDates)
            {
                SkippedDatesModel skDates = new SkippedDatesModel();
                skDates.SeasonDivisionsID = model.SeasonDivisionsID;
                skDates.DateToSkip = date;
                GlobalConfig.Connection.CreateSkippedDates(skDates);
            }

            model.skippedDates = GlobalConfig.Connection.GetSkippedDates(model);
            skippedDates.Clear();
            this.Close();

            callingForm.DatesComplete(model);
        }
    }
}

