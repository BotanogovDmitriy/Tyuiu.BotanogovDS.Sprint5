using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.BotanogovDS.Sprint5.Task7.V5.Lib;

namespace Tyuiu.BotanogovDS.Sprint5.Task7.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"D:\source\repos\Tyuiu.BotanogovDS.Sprint5\Tyuiu.BotanogovDS.Sprint5.Task7.V5\bin\Debug\OutPutDataFileTask7V5.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
