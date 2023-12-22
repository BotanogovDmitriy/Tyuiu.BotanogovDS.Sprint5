using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.BotanogovDS.Sprint5.Task7.V5.Lib;

namespace Tyuiu.BotanogovDS.Sprint5.Task7.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Ботаногов Д. С. | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка файлов                                                  *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Ботаногов Дмитрий Сергеевич | ИСТНб-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            string path = @"D:\source\repos\Tyuiu.BotanogovDS.Sprint5\Tyuiu.BotanogovDS.Sprint5.Task7.V5\bin\Debug\InPutDataFileTask7V5.txt";
            string pathSaveFile = @"D:\source\repos\Tyuiu.BotanogovDS.Sprint5\Tyuiu.BotanogovDS.Sprint5.Task7.V5\bin\Debug\OutPutDataFileTask7V5.txt";

            Console.WriteLine("Даннаые находятся в файле: " + path);


            Console.WriteLine();


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Находятся в файле: ");

            pathSaveFile = ds.LoadDataAndSave(path);

            Console.WriteLine(pathSaveFile);



            Console.ReadKey();
        }
    }
}
