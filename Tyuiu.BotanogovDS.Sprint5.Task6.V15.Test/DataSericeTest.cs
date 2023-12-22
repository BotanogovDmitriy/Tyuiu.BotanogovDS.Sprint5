using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.BotanogovDS.Sprint5.Task6.V15.Lib;

namespace Tyuiu.BotanogovDS.Sprint5.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"D:\source\repos\Tyuiu.BotanogovDS.Sprint5\Tyuiu.BotanogovDS.Sprint5.Task6.V15\bin\Debug\InPutDataFileTask6V15.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }

        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            string path = @"D:\source\repos\Tyuiu.BotanogovDS.Sprint5\Tyuiu.BotanogovDS.Sprint5.Task6.V15\bin\Debug\InPutDataFileTask6V15.txt";
            var res = ds.LoadFromDataFile(path);
            int wait = 5;
            Assert.AreEqual(wait, res);
        }
    }
}
