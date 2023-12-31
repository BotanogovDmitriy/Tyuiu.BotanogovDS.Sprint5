﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.BotanogovDS.Sprint5.Task0.V25.Lib;

namespace Tyuiu.BotanogovDS.Sprint5.Task0.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService(); 
            
            Console.Title = "Спринт #5 | Выполнил: Ботаногов Д. С. | ИСТНб-23-1";
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Спринт #5                                                                *");
            Console.WriteLine("*Тема: Класс File. Запись данных в текстовый файл                         *");
            Console.WriteLine("*Задание #0                                                               *");
            Console.WriteLine("*Вариант #25                                                              *");
            Console.WriteLine("*Выполнил: Ботаногов Дмитрий Сергеевич | ИСТНб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                 *");
            Console.WriteLine("*Дано выражение вычислить его значение при x = 3, результат сохранить в   *");
            Console.WriteLine("*текстовый файл OutPutFileTask0.txt и вывести на консоль. Округлить до    *");
            Console.WriteLine("*трёх знаков после запятой.                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ                                                          *");
            Console.WriteLine("***************************************************************************");

            int x = 3;

            Console.WriteLine("x = " + x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(x);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
