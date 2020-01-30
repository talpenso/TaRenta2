using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    class CarTypeLogic : BaseLogic
    {
        public List<DTOCarType> GetCarTypes()
        {
            return db.CarTypes
                .Select(s => new DTOCarType()
                {
                    CarTypeId = s.CarTypeID,
                    Category = s.Category,
                    DailyCost = (float)s.DailyCost,
                    DailyLateCost = (float)s.DailyLateCost__DailyLateCost,
                    GearType = s.GearType,
                    Manufacturer = s.Manufacturer,
                    ManufactureYear = s.ManufactureYear,
                    Model = s.Model

                }).ToList();
        }

        public DTOCarType GetCarType(int CarTypeNumber)
        {
            CarType DALCarType = db.CarTypes.Find(CarTypeNumber);

            DTOCarType DTOCarType = new DTOCarType();

            DTOCarType.CarTypeId = DALCarType.CarTypeID;
            DTOCarType.Category = DALCarType.Category;
            DTOCarType.DailyCost = (float)DALCarType.DailyCost;
            DTOCarType.DailyLateCost = (float)DALCarType.DailyLateCost__DailyLateCost;
            DTOCarType.GearType = DALCarType.GearType;
            DTOCarType.Manufacturer = DALCarType.Manufacturer;
            DTOCarType.ManufactureYear = DALCarType.ManufactureYear;
            DTOCarType.Model = DALCarType.Model;

            return DTOCarType;
        }

    }
}
