﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentLibrary.Models;

namespace TournamentTrackerUI.RequestInterfaces
{
    public interface IVenueRequester
    {
        void VenueComplete(VenueModel model);
    }
}
