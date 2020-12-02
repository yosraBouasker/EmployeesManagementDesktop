using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesManagementDesktop
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new EmployeesManagement())
            {
                db.Employees.Add(new Employee { Employee_Name = "Another Blog " });
                db.SaveChanges();

                foreach (var employee in db.Employees)
                {
                    Console.WriteLine(employee.Employee_Name);
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        public class employeeOperation
        {
            public void insertData()
            {
                Employee o = new Employee();
                o.Employee_Id = 1;
                o.Employee_Name = "Maissa";
                EmployeesManagement eo = new EmployeesManagement();
                eo.Employees.Add(o);

            }
        }
    }
}
