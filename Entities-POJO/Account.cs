using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities_POJO
{
    public class Account:BaseEntity
    {
        public int AccountId { get; set; }
        public string AccountName { get; set; }
        public string Currency{ get; set; }
        public double Balance { get; set; }
        public string Fk_Customer_Id { get; set; }

        public Account() { }

        public Account(string[] pinforarray)
        {
            if (pinforarray != null && pinforarray.Length >= 3)
            {
                AccountName = pinforarray[0];
                Currency = pinforarray[1];
                Balance = Double.Parse(pinforarray[2]);
                Fk_Customer_Id = pinforarray[3];
            }
            else
            {
                throw new Exception("Please enter all values");
            }
        }
    }
}
