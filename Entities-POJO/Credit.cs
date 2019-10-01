using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities_POJO
{
    public class Credit : BaseEntity
    {
        public int CreditId{ get; set; }
        public double Amount { get; set; }
        public double Rate { get; set; }
        public string Name { get; set; }
        public double Fee { get; set; }
        public DateTime StartDate { get; set; }
        public string Status { get; set; }
        public double OperationalBalance { get; set; }
        public string FK_CUSTOMER_ID { get; set; }

        public Credit(){}

        public Credit(string[] pinfoArray)
        {
            if (pinfoArray != null && pinfoArray.Length >= 7)
            {
                
                var amount = 0.0;
                var rate = 0.0;
                var fee = 0.0;
                var startDate = this.StartDate;
                Name = pinfoArray[2];
                Status = pinfoArray[5];
                OperationalBalance = Double.Parse(pinfoArray[6]);
                FK_CUSTOMER_ID = pinfoArray[7];

                if (Double.TryParse(pinfoArray[0], out amount) && Double.TryParse(pinfoArray[1], out rate) && Double.TryParse(pinfoArray[3], out fee)&& DateTime.TryParse(pinfoArray[4], out startDate))
                {
                    Amount = amount;
                    Rate = rate;
                    Fee = fee;
                    StartDate = startDate;
                }
                else
                {
                    throw new Exception("Values are incorrect please enter valid values");
                }            

            }
            else
            {
                throw new Exception("There are missing values");
            }
        }
    }
}
