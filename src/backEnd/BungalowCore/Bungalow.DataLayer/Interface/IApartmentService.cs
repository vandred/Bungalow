using Bungalow.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bungalow.DataLayer.Interface
{
    public interface IApartmentService
    {
        IEnumerable<Apartments> GetAllAppartments ();

        bool BookAppartment();
    }
}
