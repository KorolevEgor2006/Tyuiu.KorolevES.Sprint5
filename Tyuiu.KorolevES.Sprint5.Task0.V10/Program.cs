﻿using Tyuiu.KorolevES.Sprint5.Task0.V10.Lib;
namespace Tyuiu.KorolevES.Sprint5.Task0.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил:Королев Е.С.| АСОиУб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил Королев Егор Сергеевич  | АСОиУб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение F(x)=1.6x^3-2.1x^2+7x, вычислить его значение при x = 2, *");
            Console.WriteLine("* результат сохранить в текстовый файл OutPutFileTask0.txt и вывести      *");
            Console.WriteLine("* на консоль. Округлить до трёх знаков после запятой.                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int x = 2;
            Console.WriteLine("x = "+x);
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
