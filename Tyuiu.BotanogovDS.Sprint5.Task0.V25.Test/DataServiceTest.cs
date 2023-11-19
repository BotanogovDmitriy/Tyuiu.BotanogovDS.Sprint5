using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.BotanogovDS.Sprint5.Task0.V25.Lib;

namespace Tyuiu.BotanogovDS.Sprint5.Task0.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"D:\source\repos\Tyuiu.BotanogovDS.Sprint5\Tyuiu.BotanogovDS.Sprint5.Task0.V25\bin\Debug\OutPutFileTask0.txt";
            FileInfo fi = new FileInfo(path);
            bool fileex = fi.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileex);
        }
    }
}
