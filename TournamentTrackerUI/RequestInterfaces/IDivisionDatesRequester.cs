using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentLibrary.Models;

namespace TournamentTrackerUI.RequestInterfaces
{
    public interface IDivisionDatesRequester
    {
        void DatesComplete(SeasonDivisionsModel model);
    }
}
