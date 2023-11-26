using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MargaryanSG.Sprint5.Task6.V7.Lib
{
    public class DataService : ISprint5Task6V7
    {
        public int LoadFromDataFile(string path)
        {
            string z = File.ReadAllText(path);
            int c = 0;
            foreach (char word in z)
                if (word >= 'a' && word <= 'z')
                {
                    c++;
                }
            return c;
        }
    }
}