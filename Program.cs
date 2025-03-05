using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Phạm Thiện Tâm MSV:22115053122336\n");
            List<Employee_336> employees = new List<Employee_336>();
            employees.Add(new FullTimeEmployee_336("Phạm Tâm", 40000));
            employees.Add(new FullTimeEmployee_336("Phạm Hoa", 40000));
            employees.Add(new PartTimeEmployee_336("Phạm Thanh", 30000,6));
            employees.Add(new PartTimeEmployee_336("Nguyễn Huy", 30000, 6));
            

            foreach (Employee_336 nhanvien in employees)
            {
                string type = nhanvien is FullTimeEmployee_336 ? "Fulltime" : "Parttime";
                Console.WriteLine($"Tên: {nhanvien.getName_336()}, Loại: {type}, Lương: {nhanvien.calculateSalary_336()}");
            }
            Console.ReadLine();
        }
    }
}
