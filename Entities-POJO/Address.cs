using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities_POJO
{
    public class Address:BaseEntity
    {
        public int AddresId { get; set; }
        public string Province { get; set; }
        public string Town { get; set; }
        public string District { get; set; }
        public string Fk_Customer_ID { get; set; }

        public Address() { }

        public Address(string[] pInfoArray)
        {
            if (pInfoArray != null && pInfoArray.Length >= 3)
            {
                Province = pInfoArray[0];
                Town = pInfoArray[1];
                District = pInfoArray[2];
                Fk_Customer_ID = pInfoArray[3];
            }
            else
            {
                throw new Exception("Please enter all values");
            }
        }       
    }
}
