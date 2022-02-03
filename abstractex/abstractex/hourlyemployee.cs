using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractex
{
    public class hourlyemployee : Employee
    {
        private decimal wage;
        private decimal hours;
        public hourlyemployee(string firstname, string lastname, string socialsecuritynumber, decimal hourlyWage, decimal hoursWorked) : base(firstname, lastname, socialsecuritynumber)
        {
            Wage = hourlyWage;
            Hours = hoursWorked;
        }


        public decimal Wage
        {
            get { return wage; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Wage)} must be >=0");
                }
                wage = value;
            }
        }


        public decimal Hours
        {
            get
            {
                return hours;
            }
            set
            {
                if (value < 0 || value > 168)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Hours)} must be >=0 and <=168");
                }
                hours = value;
            }
        }
        public override decimal Earnings()
        {
            if (hours <= 40)
            {
                return wage * hours;
            }
            else
            {
                return (40 * wage) + ((hours - 40) * wage * 1.5M);
            }
        }
        public override string ToString() => $"hourlyemployee:{base.ToString()}\n" + $"hourly wage:{Wage:c}\n hours worked:{Hours:F2}";






    }




}


