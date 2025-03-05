using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt_OOP
{
    abstract class  Employee_336 :IEmployee_336
    {
        protected String name_336;
        protected int paymentPerHour_336;

        public Employee_336(string name, int paymentPerHour)
        {
            name_336 = name;
            paymentPerHour_336 = paymentPerHour;
        }


        public string getName_336()
        {
            return name_336;
        }
        public void setName_336(string name_336)
        {
            this.name_336 = name_336;
        }

        public int getPaymentPerHour_336()
        {
            return paymentPerHour_336;
        }

        public void setPaymentPerHour_336(int paymentPerHour_336)
        {
            this.paymentPerHour_336 = paymentPerHour_336;
        }
        public abstract int calculateSalary_336();
       

    }
}
