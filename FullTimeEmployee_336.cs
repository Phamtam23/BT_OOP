using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt_OOP
{
    class FullTimeEmployee_336:Employee_336
    {
        public FullTimeEmployee_336(String name_336, int paymentPerHour_336) :
            base(name_336, paymentPerHour_336)
        { }


        public override int calculateSalary_336()
        {
            return 8 * getPaymentPerHour_336();
        }

    }
}
