using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KorolevES.Sprint5.Task2.V11.Lib
{
    public class DataService : ISprint5Task2V11
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask2.csv" });
            FileInfo f = new FileInfo(path);
            if (f.Exists)
            {
                File.Delete(path);
            }
            int x = matrix.GetLength(0);
            int y = matrix.GetLength(1);
            string str;
            for (int i = 0; i < x; i++)
            {
                str = "";
                for (int j = 0; j < y; j++)
                {
                    if (matrix[i, j]%2 != 0)
                    {
                        matrix[i, j] = 0;
                    }
                    if (j != y - 1)
                    {
                        str += matrix[i, j] + ";";
                    }
                    else
                    {
                        str += matrix[i, j];
                    }
                }
                if (i != x - 1)
                {
                    File.AppendAllText(path, str+Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, str);
                }
                
            }
            return path;
        }
    }
}
