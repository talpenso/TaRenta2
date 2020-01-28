using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental 
{
    class CarLogic : BaseLogic
    {

        //public DTOBranch AddBranch(DTOBranch DTOBranch)

        public DTOCar ADDCar(DTOCar DTOCar)
        {

        //public int CarNumber { get; set; }
        //public int CarTypeID { get; set; }
        //public int CurrentKilometrage { get; set; }
        //public string CarPicture { get; set; }
        //public bool IsServiceable { get; set; }
        //public bool IsAvailable { get; set; }
        //public int BranchID { get; set; }

        Car dbCar = new Car();

            dbCar.CarNumber = DTOCar.CarNumber;
            dbCar.CarTypeID = DTOCar.CarTypeId;
            dbCar.CurrentKilometrage = DTOCar.CurrentKilometers;
            dbCar.CarPicture = DTOCar.CarPicture;
            dbCar.IsServiceable = DTOCar.IsServiceable;
            dbCar.IsAvailable = DTOCar.IsAvailable;
            dbCar.BranchID = DTOCar.BranchId;

            dbCar = db.Cars.Add(dbCar);
            db.SaveChanges();

            return DTOCar;
        }

    }
}
