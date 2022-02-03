using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractex
{
    public class salariedemployee:Employee
    {
        private  decimal weeklySalary;
            public salariedemployee(string firstname,string lastname,string socialsecuritynumber,decimal weeklysalary):base(firstname,lastname,socialsecuritynumber)
        {
            Weeklysalary = weeklysalary;
                
        
        }
        public decimal Weeklysalary
        {
            get
            {
                return weeklySalary;
            }
            set
            {
                if(value<0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Weeklysalary)} must be >=0");
                }
                weeklySalary = value;
            }
        }
        public override decimal Earnings() => Weeklysalary;
        public override string ToString() => $"salaried employee:{base.ToString()}\n" + $"weeklysalary:{Weeklysalary:c}";




    }
}
