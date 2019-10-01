using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities_POJO
{
    public class Customer:BaseEntity
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime BornDate { get; set; }
        public string CivilStatus { get; set; }
        public string Gender { get; set; }


        public Customer()
        {

        }

        public Customer(string[] infoArray)
        {
            if (infoArray != null && infoArray.Length >= 6)
            {
                Id = infoArray[0];
                Name = infoArray[1];
                LastName = infoArray[2];
                CivilStatus = infoArray[5];
                Gender = infoArray[6];
                var age = 0;
                var bornDate = this.BornDate;
                if (Int32.TryParse(infoArray[3], out age))
                    Age = age;
                else
                    throw new Exception("Age must be a number");

                if (DateTime.TryParse(infoArray[4], out bornDate))
                    BornDate = bornDate;
                else
                    throw new Exception("Bad date format");

            }
            else
            {
                throw new Exception("All values are require[id,name,last_name,age]");
            }

        }
    }
}
