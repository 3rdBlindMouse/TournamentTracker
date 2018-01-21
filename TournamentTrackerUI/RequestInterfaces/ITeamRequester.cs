using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentLibrary.Models;

namespace TournamentTrackerUI.RequestInterfaces
{
    public interface ITeamRequester
    {
        void TeamComplete(TeamModel model);
        string DivisionName();

        // pass the seasondivison model to the called form;
        SeasonDivisionsModel SeasonDivision();
    }
}
