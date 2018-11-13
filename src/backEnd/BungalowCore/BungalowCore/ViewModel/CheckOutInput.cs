using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bungalow.Web.Host.ViewModel
{
    public class CheckOutInput
    {
       // [Required(ErrorMessage = "Reservation Number is required.")]
        public string ReservationNumber { get; set; }
        public DateTime CheakOutDate { get; set; }
    }

    public class CheckOutOutput
    {
        // [Required(ErrorMessage = "Reservation Number is required.")]
        // public int ReservationNumber { get; set; }
        //  public DateTime EndDate { get; set; }
        public float Price { get; set; }

    }
}
