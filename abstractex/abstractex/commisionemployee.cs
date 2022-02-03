using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractex
{
   public class commisionemployee:Employee
    {
        private decimal grossSales;
        private decimal commissionRate;
        public commisionemployee(string firstname,string lastname,string socialsecuritynumber,decimal grosssales,decimal commissionrate):base(firstname,lastname,socialsecuritynumber)
        {
            Grosssales = grosssales;
            Commissionrate = commissionrate;
            

        }
        public decimal Grosssales
        {

            get
            {
                return grossSales;
            }
            set
            {
                if(value<0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Grosssales)} must be >=0");
                }
                grossSales = value;
            }
        }
        public decimal Commissionrate
        {
            get
            {
                return commissionRate;
            }
            set
            {
                if(value<=0||value>=1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Commissionrate)} must be >0 and <1");
                }
                commissionRate = value;
            }
        }
        public override decimal Earnings() => Commissionrate * Grosssales;
        public override string ToString() => $"comissionemployee:{base.ToString()}\n" + $"grosssales:{Grosssales:C}\n" + $"commissionrate:{Commissionrate:F2}";
        

    }  
}
