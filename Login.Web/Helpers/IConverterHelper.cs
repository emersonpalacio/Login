using Login.Common.Models;
using Login.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Login.Web.Helpers
{
     public interface IConverterHelper
    {
        TripResponse ToTripResponse(TripEntity tripEntity);

    }
}
