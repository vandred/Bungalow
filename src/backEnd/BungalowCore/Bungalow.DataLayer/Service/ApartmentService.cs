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
            new Apartments { AType=1, Name ="Apartments", Price=1 },
            new Apartments { AType=2, Name ="Bungalow", Price=1.5F },
            new Apartments { AType=3, Name ="Villa", Price=2.5F }
        };
        }
    }
}
