using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MargaryanSG.Sprint5.Task2.V22.Lib;

namespace Tyuiu.MargaryanSG.Sprint5.Task2.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService DataService = new DataService();
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("****************************************************************");
            int[,] matrix = { {-8, -1, -9}, {8, 5, 5}, {9, 6, -2} };
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                     ");
            Console.WriteLine("****************************************************************");
            string res = DataService.SaveToFileTextData(matrix);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}