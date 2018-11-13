using Bungalow.Core.Model;
using Bungalow.DataLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bungalow.DataLayer.Service
{
    public class ApartmentService : IApartmentService
    {
        private IBaseSingleService _dataBook;

        public ApartmentService(IBaseSingleService dataBook)
        {
            _dataBook = dataBook;
        }
        public bool BookAppartment()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Apartments> GetAllAppartments()
        {
            return new List<Apartments>
        {
            new Apartments { Id=1, Name ="Apartments", Price=1 },
            new Apartments { Id=2, Name ="Bungalow", Price=1.5F },
            new Apartments { Id=3, Name ="Villa", Price=2.5F }
        };
        }
    }
}
