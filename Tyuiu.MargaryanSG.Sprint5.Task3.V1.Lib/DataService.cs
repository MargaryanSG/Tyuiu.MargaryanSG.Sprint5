using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MargaryanSG.Sprint5.Task3.V1.Lib
{
    public class DataService : ISprint5Task3V1
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            double y = Math.Round((Math.Pow(x, 3) - 8) / (2 * Math.Pow(x, 2)), 3);
            string strY = Convert.ToString(y);
            File.AppendAllText(path, strY);
            return path;
        }
    }
}