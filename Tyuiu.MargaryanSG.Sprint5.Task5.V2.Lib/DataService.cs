using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;


namespace Tyuiu.MargaryanSG.Sprint5.Task5.V2.Lib
{
    public class DataService : ISprint5Task5V2
    {
        public double LoadFromDataFile(string path)
        {

            using (StreamReader reader = new StreamReader(path))
            {
                int c = 0;
                double y = 0;
                double z = 0;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    double x = Convert.ToDouble(line);
                    if (x > 0)
                    {
                        c += 1;
                        y += x;
                    }
                }
                z = y / c;
                return Math.Round(z, 3);
            }

        }
    }
}
