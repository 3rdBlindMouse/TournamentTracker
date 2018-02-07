using System;
using System.Windows.Forms;
using TournamentLibrary;
using TournamentTrackerUI.CreateForms;

namespace TournamentTrackerUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Initiaise the database/text connections
            TournamentLibrary.GlobalConfig.InitialiseConnections(DatabaseType.MySql);

            //Application.Run(new TournamentCreator());
            //Application.Run(new DivisionCreator());
            //Application.Run(new TeamCreatorForm());
            //Application.Run(new PersonCreatorForm());
            //Application.Run(new VenueCreatorForm());
            //Application.Run(new FirstForm());
            //Application.Run(new EditDivisionForm());
            Application.Run(new TournamentCreatorForm());
            //Application.Run(new CreateSeasonForm());
            //Application.Run(new CreateDivisionForm());
        }
    }
}
