using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.MargaryanSG.Sprint5.Task5.V2.Lib;

namespace Tyuiu.MargaryanSG.Sprint5.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFileInFolder()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V2.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}