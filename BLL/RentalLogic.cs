using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    class RentalLogic : BaseLogic
    {

        public List<DTORental> GetRentals()
        {
            return db.Rentals
                .Select(s => new DTORental()
                {
                    RentId = s.RentID,
                    CarNumber = s.CarNumber,
                    EffectiveReturnDate = s.EffectiveReturnDate,
                    PlannedReturnDate = s.PlannedReturnDate,
                    StartDate = s.StartDate,
                    UserId = s.UserID
                }).ToList();
        }

    }
}
