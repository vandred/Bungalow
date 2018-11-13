using System;
using System.Collections.Generic;
using System.Text;

namespace Bungalow.Core.Model
{
    public class Apartments
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
    }

    public class BookRecords
    {
        public Apartments AType { get; set; }
        public string ReservationNumber { get; set; }
        public string FName { get; set; }
        public string lName { get; set; }
        public string Email { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public float TotalPrice { get; set; }
    }
}
