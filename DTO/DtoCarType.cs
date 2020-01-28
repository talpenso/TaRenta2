using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    public class DTOCarType 
    {
        public int CarTypeId { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public float DailyCoast { get; set; }
        public float DailyLateCoast { get; set; }
        public string GearType { get; set; }
        public string Category { get; set; }

    }
}
