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
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Replace(".", ",");
                    array = line.Split(" ");
                    int max = 0;
                    for (int i = 0; i < array.Length; i++)
                    {
                        double a = Convert.ToDouble(array[i]);
                        if ((a > 1) && (Math.Round(a) == a))
                        {
                            max = Math.Max(max, Convert.ToInt32(a));
                        }
                    }
                    bool[] prost = new bool[max + 1];
                    prost[0] = false;
                    prost[1] = false;
                    for (int i = 2; i < prost.Length; i++)
                    {
                        int b = 0;
                        for (int j = 2; j < i; j++)
                        {
                            if (i % j == 0)
                            {
                                b = 1;
                                break;
                            }
                        }
                        if (b == 0)
                        {
                            prost[i] = true;
                        }
                        else
                        {
                            prost[i] = false;
                        }
                    }
                    for (int i = 0; i < array.Length; i++)
                    {
                        double a = Convert.ToDouble(array[i]);
                        if ((a > 1) && (Math.Round(a, 0) == a) && (prost[Convert.ToInt32(a)] = true))
                        {
                            res += a;
                        }
                    }
                }
            }
            return res;
        }
    }
}