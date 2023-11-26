using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Tyuiu.MargaryanSG.Sprint5.Task4.V27.Lib;

namespace Tyuiu.MargaryanSG.Sprint5.Task4.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService DataService = new DataService();
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("****************************************************************");
            string path = $@"C:\DataSprint5\InPutDataFileTask4V27.txt";
            Console.WriteLine("Путь к файлу: " + path);
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                     ");
            Console.WriteLine("****************************************************************");
            double y = DataService.LoadFromDataFile(path);
            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
}