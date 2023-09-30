using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KomanichRM.Sprint1.Task7.V2.Lib
{
    public class DataService : ISprint1Task7V2
    {
        public double Calculate(double x, double y)
        {
            double z = Math.Round((Math.Asin(x) + Math.Acos(y)) / (Math.Acos(x) - Math.Asin(y)) * Math.Atan(x * y),3);
            return z;
        }
    }
}
