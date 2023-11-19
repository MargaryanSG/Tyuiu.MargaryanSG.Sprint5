using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MargaryanSG.Sprint5.Task1.V5.Lib;

namespace Tyuiu.MargaryanSG.Sprint5.Task1.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService DataService = new DataService();
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("****************************************************************");
            int x = -5, y = 5;
            Console.WriteLine("Начальное значение = " + x);
            Console.WriteLine("Конечное значение = " + y);
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                     ");
            Console.WriteLine("****************************************************************");
            string res = DataService.SaveToFileTextData(-5, 5);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}