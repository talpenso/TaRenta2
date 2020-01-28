using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    public class DTOCar
    {
        public int CarNumber { get; set; }
        public int CarTypeId { get; set; }
        public int CurrentKilometers { get; set; }
        public string CarPicture { get; set; }
        public bool IsServiceable { get; set; }
        public bool IsAvailable { get; set; }
        public int BranchId { get; set; }


    }
}
