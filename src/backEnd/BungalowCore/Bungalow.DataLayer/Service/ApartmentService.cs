using Bungalow.Core.Model;
using Bungalow.DataLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bungalow.DataLayer.Service
{
    public class ApartmentService : IApartmentService
    {
        public IEnumerable<Apartments> GetAllAppartments()
        {
            return new List<Apartments>
        {
            new Apartments { AType=1, Name ="Apartments" },
            new Apartments { AType=2, Name ="Bungalow" },
            new Apartments { AType=3, Name ="Villa" }
        };
        }
    }
}
