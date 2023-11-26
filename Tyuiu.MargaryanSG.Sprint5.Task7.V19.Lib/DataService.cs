using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;


namespace Tyuiu.MargaryanSG.Sprint5.Task7.V19.Lib
{
    public class DataService : ISprint5Task7V19
    {
        public string LoadDataAndSave(string path)
        {
            string res = File.ReadAllText(path);
            string x = "cc";
            char[] result = new char[res.Length];

            for (int i = 0; i < res.Length - 1; i++)
            {

                if (Convert.ToString((res[i] + res[i + 1])) == x)
                {
                    x = "cc";
                }
                else
                {
                    result[i] = res[i];
                }
            }
            using (StreamWriter writer = new StreamWriter(res))
            {
                writer.Write(result);
            }
            return path;
        }
    }
}