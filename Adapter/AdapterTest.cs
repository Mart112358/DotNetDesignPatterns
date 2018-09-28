using System.Collections.Generic;

namespace DotNetDesignPatterns.Adapter
{
    public class AdapterTest
    {
        public static void Test()
        {
            var employees = new List<IEmployee>
            {
                new Employee("Tom"),
                new Employee("Jerry"),
                new ConsultantToEmployeeAdapter("Bruno")
            };

            //consultant from existing class
            foreach (var employee in employees) employee.ShowHappiness();
        }
    }
}