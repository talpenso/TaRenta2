using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    public class BaseLogic : IDisposable
    {

        protected TaRentaEntities db = new TaRentaEntities();

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
