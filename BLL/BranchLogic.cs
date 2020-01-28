using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    class BranchLogic : BaseLogic
    {
        // Receiving DTO Branch, and sending it to the DataBase
        public DTOBranch AddBranch(DTOBranch DTOBranch)
        {

            // Creating a empty new DAL Branch object
            Branch dbBranch = new Branch();

            // Copying values from incomming DTO Branch to empty new DAL Branch object
            dbBranch.BranchName = DTOBranch.BranchName;
            dbBranch.BranchAddress = DTOBranch.BranchAddress;
            dbBranch.Geodata = DTOBranch.GeoData;

            // Adding new filled DAL Branch object to DB
            dbBranch = db.Branches.Add(dbBranch);
            db.SaveChanges();

            //  == Now the DAL Branch object has an ID ==

            // Returning the DTO Branch with the new ID to the UI 

            DTOBranch.BranchId = dbBranch.BranchID;
            
            return DTOBranch;
        }

        public List<DTOBranch> GetBranches()
        {
            return db.Branches
                .Select(s => new DTOBranch() {
                    BranchId = s.BranchID,
                    BranchName = s.BranchName,
                    BranchAddress = s.BranchAddress,
                    GeoData = (float)s.Geodata }).ToList();
        }

        public void UpdateBranch(DTOBranch DTOBranch)
        {
            // Get the DAL Branch object from database using the ID as key
            Branch DALBranch = db.Branches.Find(DTOBranch.BranchId);

            // Copy new values from incomming DTOBranch
            DALBranch.BranchName = DTOBranch.BranchName;
            DALBranch.BranchAddress = DTOBranch.BranchAddress;
            DALBranch.Geodata = DTOBranch.GeoData;

            // Save changes to DB (make sure this works for the changed DALBranch !)
            db.SaveChanges();

        }

        public DTOBranch GetBranch(int BranchId)
        {
            Branch DALBranch = db.Branches.Find(BranchId);

            DTOBranch DTOBranch = new DTOBranch();

            DTOBranch.BranchName = DALBranch.BranchName;
            DTOBranch.BranchAddress = DALBranch.BranchAddress;
            DTOBranch.GeoData = (float)DALBranch.Geodata;

            return DTOBranch;
        }

    }
}
