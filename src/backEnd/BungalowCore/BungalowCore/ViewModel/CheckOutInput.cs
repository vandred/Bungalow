using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bungalow.Web.Host.ViewModel
{
    public class CheckOutInput
    {
        [Required(ErrorMessage = "Reservation Number is required.")]
        public int ReservationNumber { get; set; }
        public DateTime EndDate { get; set; }
    }
}
