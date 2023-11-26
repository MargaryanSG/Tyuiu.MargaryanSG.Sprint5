using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.MargaryanSG.Sprint5.Task6.V7.Lib;

namespace Tyuiu.GalyameevMR.Sprint5.Task6.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void FindWordsInFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V7.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
        public void CheckCalc()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V7.txt";
            DataService DataService = new DataService();
            int count = 16;
            int res = DataService.LoadFromDataFile(path);
            Assert.AreEqual(count, res);
        }

    }
}