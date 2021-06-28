using System;

namespace Destructor
{
    class Employee
    {
        private int _emplId;
        private String _emlName;
        private int _age;
        private double _salary;
        Employee(int id, String name, int age, double sal)
        {
            Console.WriteLine("Contructor for Employee called");
            _emplId = id;
            _emlName = name;
            _age = age;
            _salary = sal;

        }
        ~Employee()
        {
            Console.WriteLine("Destructor for Employee called");
        }
        static void Main(string[] args)
        {
            Employee emp = new Employee(1, "John", 45, 350000);
            Console.WriteLine("Employee ID:" + emp._emplId);
            Console.WriteLine("Employee Name:" + emp._emlName);
            Console.WriteLine("Employee Age:" + emp._age);
            Console.WriteLine("Employee Salary:" + emp._salary);

        }
    }
}
