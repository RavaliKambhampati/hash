using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractex
{
    class Program
    {
        static void Main(string[] args)
        {
            var salariedemployee = new salariedemployee("ravali", "kambhampati", "23243546565", 40000);
            Console.WriteLine($"{salariedemployee}\nearned: " + $"{salariedemployee.Earnings():C}\n");
                hourlyemployee obj = new hourlyemployee("ravi", "kumar", "23456789", 16.75M, 40.0M);
            Console.WriteLine($"{obj}\nearned: " + $"{obj.Earnings():C}\n");
            commisionemployee ce = new commisionemployee("sue", "jones", "3456789", 10000.00M, .06M);
            Console.WriteLine($"{ce}\nearned: " + $"{ce.Earnings():C}\n");
            basepluscomissionemployee be = new basepluscomissionemployee("ravva", "kambha", "1234567",5000.00M,0.4M,300.00M);
            Console.WriteLine($"{be}\nearned: " + $"{be.Earnings():C}\n");
            var employees = new List<Employee>() { salariedemployee, obj, ce,be };
            Console.WriteLine("employees processed polymorphically:\n");
            foreach(var currentEmployee in employees)
            {
                Console.WriteLine(currentEmployee);
                if(currentEmployee is basepluscomissionemployee)
                {
                    var employee = (basepluscomissionemployee)currentEmployee;
                    employee.Basesalary = 1.10M;
                    Console.WriteLine("new basesalary with 10% increase is:"+$"{employee.Basesalary:C}");
                }
                Console.WriteLine($"earned:{currentEmployee.Earnings():C}\n");
            }
            for (int j = 0; j < employees.Count; j++)
            {
                Console.WriteLine($"Employee{j} is a {employees[j].GetType()}");
            }
            Console.ReadLine();
        }
    }
}
