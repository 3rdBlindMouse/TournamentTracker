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

namespace TournamentTrackerUI
{
    public partial class loginForm : Form
    {
        Validator v = new Validator();
        bool login = false;

        public loginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if ((!v.isValidNumber(userIDTextBox.Text) ||( userIDTextBox.Text == "")))
            {
                MessageBox.Show("Please Enter a Valid Numerical ID");
            }
            else
            {
                int userID = int.Parse(userIDTextBox.Text);
                string password = passwordTextBox.Text;
                login = GlobalConfig.Connection.Login(userID, password);
                if(login == false)
                {
                    MessageBox.Show("UserID and Password not found");
                }
                else
                {
                    ScoreCard cs = new ScoreCard(userID);
                    this.Hide();
                    cs.Show();
                    //MessageBox.Show("Success");
                }
            }
        }
    }
}
