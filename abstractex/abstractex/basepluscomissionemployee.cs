using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractex
{
    public class basepluscomissionemployee:commisionemployee
    {
        private decimal baseSalary;
        public basepluscomissionemployee(string firstname,string lastname,string socialsecuritynumber,decimal grosssales,decimal comissionrate,decimal basesalary):base(firstname,lastname,socialsecuritynumber,grosssales,comissionrate)
        {
            baseSalary = basesalary;
        }
        public decimal Basesalary
        {
            get
            {
                return baseSalary;
            }
            set
            {
                if(value<0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Basesalary)} must be >=0");
                }
                baseSalary = value;
            }
        }
        public override decimal Earnings() => Basesalary + base.Earnings();
        public override string ToString() => $"base-salaried {base.ToString()}\nbase salary: {Basesalary:C}";
    }



}

