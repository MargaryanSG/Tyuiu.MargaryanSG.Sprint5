using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.MargaryanSG.Sprint5.Task7.V19.Lib;

namespace Tyuiu.MargaryanSG.Sprint5.Task7.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService DataService = new DataService();
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("****************************************************************");
            string path = $@"C:\DataSprint5\InPutDataFileTask7V19.txt";
            string res = File.ReadAllText(path);
            Console.WriteLine(res); Console.WriteLine("Файл находится тут: " + path);
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                     ");
            Console.WriteLine("****************************************************************");
            string w = DataService.LoadDataAndSave(path);
            Console.WriteLine("Cоздан!");
            Console.ReadKey();
        }
    }
}