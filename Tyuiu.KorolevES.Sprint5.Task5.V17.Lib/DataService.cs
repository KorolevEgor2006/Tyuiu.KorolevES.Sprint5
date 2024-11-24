using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KorolevES.Sprint5.Task5.V17.Lib
{
    public class DataService : ISprint5Task5V17
    {
        public double LoadFromDataFile(string path)
        {

            double res = 0;
            string[] array;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine())!= null)
                {
                    line = line.Replace(".", ",");
                    array = line.Split(" ");
                    int max = 0;
                    for (int i = 0; i < array.Length; i++)
                    {
                        double a = Convert.ToDouble(array[i]);
                        if (a > 0)
                        {
                            res+=a;
                        }
                    }
                }
            }
            return Math.Round(res,3);
        }
    }
}
