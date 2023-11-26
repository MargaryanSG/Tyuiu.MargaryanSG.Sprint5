using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.Threading.Tasks;

namespace Tyuiu.MargaryanSG.Sprint5.Task4.V27.Lib
{
    public class DataService : ISprint5Task4V27
    {
        
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            string z = strX.Replace('.', ',');
            double x = (Convert.ToDouble(z));
            double y = (Math.Pow(x, 3) - 4 * x) / Math.Cos(x);
            return Math.Round(y);
        }
    }
}
