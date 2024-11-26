using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KorolevES.Sprint5.Task7.V22.Lib
{
    public class DataService : ISprint5Task7V22
    {
        public string LoadDataAndSave(string path)
        {
            string pathsavefile = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V22.txt");
            FileInfo file = new FileInfo(pathsavefile);
            if (file.Exists ) 
            {
                File.Delete(pathsavefile);
            }
            string strline = "";
            using(StreamReader reader = new StreamReader(path))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    for(int i = 0; i < line.Length; i++)
                    {
                        if ((line[i] != '-') && (line[i] != ',') && (line[i] != '.') && (line[i] != '!') && (line[i] != '?') && (line[i] != ';') && (line[i] != ':') && (line[i] != '"'))
                        {
                            strline += line[i];
                        }
                        else 
                        {
                            strline += '#';
                        }
                    }
                    File.AppendAllText(pathsavefile, strline + Environment.NewLine);
                    strline = "";
                } 
            }
            return pathsavefile;
        }
    }
}
