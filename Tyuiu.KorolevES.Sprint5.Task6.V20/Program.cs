using Tyuiu.KorolevES.Sprint5.Task6.V20.Lib;
    namespace Tyuiu.KorolevES.Sprint5.Task6.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил:Королев Е.С.| АСОиУб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка текстовых файлов                                        *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил Королев Егор Сергеевич  | АСОиУб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask6V20.txt в котором есть      *");
            Console.WriteLine("* набор символьных данных.Найти количество слов длиной шесть символов в   *");
            Console.WriteLine("* заданной строке.                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = @"C:\DataSprint5\InPutDataFileTask6V20.txt";
            Console.WriteLine("Путь к файлу:" + path);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            Console.WriteLine("Количество слов длинной 6 в файле:" + ds.LoadFromDataFile(path));
            Console.ReadKey();
        }
    }
}
