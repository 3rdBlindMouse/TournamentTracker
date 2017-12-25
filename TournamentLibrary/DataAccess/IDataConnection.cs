using System.Collections.Generic;
using TournamentLibrary.Models;

namespace TournamentLibrary.DataAccess
{
    public interface IDataConnection
    {
        SeasonModel CreateSeason(SeasonModel model);
        PersonModel CreatePerson(PersonModel model);

        List<PersonModel> GetAllPeople();
        DivisionModel CreateDivision(DivisionModel model);
        SkippedDatesModel CreateSkippedDatesModel(SkippedDatesModel model);
    }
}
