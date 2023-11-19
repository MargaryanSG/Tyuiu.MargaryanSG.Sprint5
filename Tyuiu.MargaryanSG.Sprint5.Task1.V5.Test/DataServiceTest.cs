using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.MargaryanSG.Sprint5.Task1.V5.Lib;

namespace Tyuiu.MargaryanSG.Sprint5.Task1.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFileInFolder()
        {
            string path = @"C:\Users/POWER PC TYUMEN\source\repos\Tyuiu.MargaryanSG.Sprint5\Tyuiu.MargaryanSG.Sprint5.Task0.V5\bin\Debug\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}