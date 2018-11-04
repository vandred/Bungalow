using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bungalow.Web.Host.ViewModel
{
    public class BookingInput
    {
        [Required(ErrorMessage = "Apartment Number is required.")]
        public int ApartmentId { get; set; }
        // type of appartment
        [Required(ErrorMessage = "Type of apartment is required.")]
        public int TypeA { get; set; }
        public int PersonalNumber { get; set; }
        [Required(ErrorMessage = "Date of Start is required.")]
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
