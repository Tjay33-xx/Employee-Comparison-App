using System;

namespace EmployeeComparisonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();

            employee1.Id = 1;
            employee1.FirstName = "John";
            employee1.LastName = "Smith";

            Employee employee2 = new Employee();

            employee2.Id = 1;
            employee2.FirstName = "Jane";
            employee2.LastName = "Doe";

            Console.WriteLine(employee1 == employee2);

            Console.WriteLine(employee1 != employee2);
        }
    }
}
