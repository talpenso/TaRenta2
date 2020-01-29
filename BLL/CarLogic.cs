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


        public List<DTOCar> GetCars()
        {
            return db.Cars
                .Select(s => new DTOCar()
                {

                    CarNumber = s.CarNumber,
                    CarTypeId = s.CarTypeID,
                    CurrentKilometers = s.CurrentKilometrage,
                    CarPicture = s.CarPicture,
                    IsServiceable = s.IsServiceable,
                    IsAvailable = s.IsAvailable,
                    BranchId = s.BranchID

                }).ToList();
        }

        public void UpdateCar(DTOCar DTOCar)
        {
            Car DALCar = db.Cars.Find(DTOCar.CarNumber);

            DALCar.CarNumber = DTOCar.CarNumber;
            DALCar.CarTypeID = DTOCar.CarTypeId;
            DALCar.CurrentKilometrage = DTOCar.CurrentKilometers;
            DALCar.CarPicture = DTOCar.CarPicture;
            DALCar.IsServiceable = DTOCar.IsServiceable;
            DALCar.IsAvailable = DTOCar.IsAvailable;
            DALCar.BranchID = DTOCar.BranchId;

            db.SaveChanges();
        }

        public DTOCar GetCar(int CarNumber)
        {
            Car DALCar = db.Cars.Find(CarNumber);

            DTOCar DTOCar = new DTOCar();

            DTOCar.CarNumber = DALCar.CarNumber;
            DTOCar.CarTypeId = DALCar.CarTypeID;
            DTOCar.CurrentKilometers = DALCar.CurrentKilometrage;
            DTOCar.CarPicture = DALCar.CarPicture;
            DTOCar.IsServiceable = DALCar.IsServiceable;
            DTOCar.IsAvailable = DALCar.IsAvailable;
            DTOCar.BranchId = DALCar.BranchID;

            return DTOCar;
        }

    }
}
