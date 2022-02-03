using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractex
{
    public abstract class Employee
    {
        public string Fisrtname { get; set; }
        public string Lastname { get; set; }
        public string Socialsecuritynumber { get; set; }
        public Employee(string firstnamevalue, string lastnamevalue, string socialsecuritynumber)
        {
            this.Fisrtname = firstnamevalue;
            this.Lastname = lastnamevalue;
            this.Socialsecuritynumber = socialsecuritynumber;
        }
        public override string ToString() => $"{Fisrtname}{Lastname}\n" + $"socialsecuritynumber{Socialsecuritynumber}";
        //public void display()
        //{
        //    Console.WriteLine("firstname is:" + Fisrtname);
        //    Console.WriteLine("lastname is:" + Lastname);
        //    Console.WriteLine("socialsecuritynumber is:" + Socialsecuritynumber);





        //}

        public abstract decimal Earnings();


    }
}
