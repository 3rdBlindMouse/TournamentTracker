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

namespace TournamentTrackerUI.CreateForms
{
    public partial class CreateNewLogin : Form
    {
        List<PersonModel> people = new List<PersonModel>();
        PersonModel person = new PersonModel();
        List<sdtpModel> sdtps = new List<sdtpModel>();
        sdtpModel sdtp = new sdtpModel();
        List<SeasonModel> seasons = new List<SeasonModel>();

        string password;

        bool formValid = false;

        public CreateNewLogin()
        {
            InitializeComponent();
            seasons = GlobalConfig.Connection.GetAllSeasons();

            wireUpSeasonsComboBox();
            
        }

        private void wireUpSeasonsComboBox()
        {
            seasonsComboBox.DataSource = null;
            seasonsComboBox.DataSource = seasons;
            seasonsComboBox.DisplayMember = "SeasonName";
        }

        private void seasonsComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            SeasonModel season = (SeasonModel)seasonsComboBox.SelectedValue;
            sdtps = GlobalConfig.Connection.GetSdtps(season.SeasonID);
            wireUpSelectpersonComboBox(season.SeasonID);
            clearPasswordBoxes();
        }

        private void wireUpSelectpersonComboBox(int seasonID)
        {
            people = GlobalConfig.Connection.GetSeasonPlayers(seasonID);
            selectPersonComboBox.DataSource = null;
            selectPersonComboBox.DataSource = people;
            selectPersonComboBox.DisplayMember = "FullName";
        }

        private void selectPersonComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            person = (PersonModel)selectPersonComboBox.SelectedValue;
            clearPasswordBoxes();
            if(person != null)
            {
                userIDLabel2.Text = person.SdtpID.ToString();
            }
            
        }

        private void passwordTextBox1_Leave(object sender, EventArgs e)
        {
            password = passwordTextBox1.Text;
        }

        private void passwordtextBox2_TextChanged(object sender, EventArgs e)
        {
            if(passwordtextBox2.Text == password)
            {
                passwordTextBox1.BackColor = Color.LightGreen;
                passwordtextBox2.BackColor = Color.LightGreen;
                formValid = true;
            }
        }

        private void clearPasswordBoxes()
        {
            passwordTextBox1.BackColor = Color.White;
            passwordtextBox2.BackColor = Color.White;
            passwordtextBox2.Text = "";
            passwordTextBox1.Text = "";
            userIDLabel2.Text = "";
            passwordMatchLabel.Text = "";
            formValid = false;
        }

        private void createLoginButton_Click(object sender, EventArgs e)
        {

            //TODO clean validation up
            if(userIDLabel2.Text == "")
            {
                formValid = false;
                MessageBox.Show("Please Select a Player");
            }
            if(passwordtextBox2.Text != password)
            {
                passwordMatchLabel.Text = "Passwords do not match";
            }
            if(formValid)
            {
                GlobalConfig.Connection.CreateLogin(person.SdtpID, password);
                MessageBox.Show($"New User Created \n UserID :{userIDLabel2.Text} \n Password : {password}");
                this.Close();
            }
        }

        private void passwordTextBox1_Enter(object sender, EventArgs e)
        {
            passwordMatchLabel.Text = "";
        }

        private void passwordtextBox2_Enter(object sender, EventArgs e)
        {
            passwordMatchLabel.Text = "";
        }
    }
}
