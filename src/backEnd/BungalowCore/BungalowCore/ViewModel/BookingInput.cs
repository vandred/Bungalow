using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bungalow.Web.Host.ViewModel
{
    public class BookingInput
    {
        public string ApartmentId { get; set; }
        // type of appartment
        public string Lname { get; set; }
        public string Fname { get; set; }
        public string Email { get; set; }
        public string PersonalNumber { get; set; }
        public DateTime StartDate { get; set; }

    }

    public class BookingOut
    {
        public string ReservationNumber { get; set; }
        // type of appartment

    }
}
