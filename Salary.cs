using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalryApp
{
    class Salary
    {
        public Salary(double basic, double med, double conv)
            : this()
        {
            Basic = basic;
            Med = med;
            Conv = conv;
        }

        public Salary()
        {
            Basic = 0;
            Med = 0;
            Conv = 0;
        }

        public double Basic { get; set; }
        public double Med { get; set; }
        public double Conv { get; set; }
        public double Total { get; set; }
        public double MedAm { get; set; }
        public double ConvAm { get; set; }

        //private int NumberOfIncrement = 0;
        public double TotalSalary(double increment)
        {
            if (increment > 0)
            {
                Basic += (Basic * increment) / 100;
                MedAm = (Basic * Med) / 100;
                ConvAm = (Basic * Conv) / 100;
                Total = Basic + MedAm + ConvAm;

            }
            else if (increment == 0)
            {
                double t1 = ((Basic * Conv) / 100) + ((Basic * Med) / 100) + Basic;
                Total = ((increment * Basic) / 100) + t1;
            }
            return Total;
        }

        public double FindMed()
        {
            return (Basic * Med) / 100;
        }
        public double FindConv()
        {
            return (Basic * Conv) / 100;
        }
    }

}
