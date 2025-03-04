using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt_OOP
{
    abstract class  Employee_336 :IEmployee_336
    {
        protected String name_336 { get; set; }
        protected int paymentPerHour_336 { get; set; }

        public Employee_336(string name, int paymentPerHour)
        {
            name_336 = name;
            paymentPerHour_336 = paymentPerHour;
        }


        public String getName_336()
        {
            return name_336;
        }
      


    }
}
