using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    public class DTORental
    {
        public int RentId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime PlannedReturnDate { get; set; }
        public DateTime EffectiveReturnDate { get; set; }
        public int UserId { get; set; }
        public int CarNumber { get; set; }

    }
}
