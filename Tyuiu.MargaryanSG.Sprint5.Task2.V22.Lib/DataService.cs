using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MargaryanSG.Sprint5.Task2.V22.Lib
{
    public class DataService : ISprint5Task2V22
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        matrix[i, j] = 0;
                    }
                    else
                    {
                        matrix[i, j] = 1;
                    }
                }
            }
            string res = "";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j < 2)
                    {
                        res += matrix[i, j] + ";";
                    }
                    else
                    {
                        res += matrix[i, j];
                    }
                }
                if (i != matrix.GetLength(0) - 1)
                {
                    File.AppendAllText(path, res + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, res);
                }
            }
            return path;
        }
    }
}