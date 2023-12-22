﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.BotanogovDS.Sprint5.Task4.V8.Lib;

namespace Tyuiu.BotanogovDS.Sprint5.Task4.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"D:\source\repos\Tyuiu.BotanogovDS.Sprint5\Tyuiu.BotanogovDS.Sprint5.Task4.V8\bin\Debug\InPutDataFileTask4V8.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
