using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    //A delegate is type safe function pointer
    public delegate void delgA(string a, string b);

    class Program
    {
        public static void MethodA(string a1, string b1)
        {
            Console.Write(a1 + " " + b1);
        }
        static void Main(string[] args)
        {
            delgA dl = new delgA(MethodA);
            dl("Hello", "from delegate");
            // Console.ReadLine();

            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { ID = 1, Name = "Maaryy", Salary = 4000, Experience = 6 });
            empList.Add(new Employee() { ID = 3, Name = "John", Salary = 4000, Experience = 6 });
            empList.Add(new Employee() { ID = 2, Name = "jesi", Salary = 2000, Experience = 3 });
            empList.Add(new Employee() { ID = 4, Name = "jesica", Salary = 2000, Experience = 3 });

            //without delegate
            Employee.PromoteEmployee(empList);

            IsPromotetable isPromotetable = new IsPromotetable(Promote);
            //using delegate
            Employee.PromoteEmployee(empList, isPromotetable);

            IsPromotetable isPromotetable2 = new IsPromotetable(Promote2);
            Employee.PromoteEmployee(empList, isPromotetable2);

            Employee.PromoteEmployee(empList, emp => emp.Experience > 5);


        }
        public static bool Promote(Employee emp)
        {
            if (emp.Experience > 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Promote2(Employee emp)
        {
            if (emp.Salary > 5000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public delegate bool IsPromotetable(Employee employee);
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> employees)
        {
            foreach (Employee emp in employees)
            {
                if (emp.Experience > 5)
                {
                    Console.WriteLine(emp.Name + " is promoted");
                }
            }
        }
        public static void PromoteEmployee(List<Employee> employees, IsPromotetable isPromotetable)
        {
            foreach (Employee emp in employees)
            {
                if (isPromotetable(emp))
                {
                    Console.WriteLine(emp.Name + " is promoted");
                }
            }
        }
    }
}
