using DataAccess1.Crud;
using Entities_POJO;
using Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LocationManagement
    {
        private LocationCrudFactory crudLocation;

        public LocationManagement()
        {
            crudLocation = new LocationCrudFactory();
        }

        public void Create(Location location)
        {
            try
            {
                var c = crudLocation.Retrieve<Location>(location);

                if (c != null)
                {
                    throw new BusinessException(3);
                }
                else
                {
                    crudLocation.Create(location);
                }
               
            }
            catch (Exception ex)
            {

                ExceptionManager.GetInstance().Process(ex);
            }


        }


        public List<Location> RetrieveAll()
        {
            return crudLocation.RetrieveAll<Location>();
        }

        public Location RetrieveById(Location location)
        {
            return crudLocation.Retrieve<Location>(location);
        }

        public void Update(Location location)
        {
            crudLocation.Update(location);
        }

        public void Delete(Location location)
        {
            crudLocation.Delete(location);
        }
    }
}
