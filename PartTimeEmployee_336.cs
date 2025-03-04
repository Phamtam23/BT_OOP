using System;

namespace Bt_OOP
{
    class PartTimeEmployee_336 : Employee_336
    {
        private int workingHours_336;

        // Constructor với tên đúng
        public PartTimeEmployee_336(string name_336, int paymentPerHour_336, int workingHours_336)
            : base(name_336, paymentPerHour_336) // Gọi constructor lớp cha
        {
            this.workingHours_336 = workingHours_336;
        }

     
        public  int calculateSalary_336()
        {
            return workingHours_336 * paymentPerHour_336;
        }
    }
}
