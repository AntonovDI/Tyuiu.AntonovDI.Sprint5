using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AntonovDI.Sprint5.Task7.V3.Lib
{
    public class DataService : ISprint5Task7V9
    {
        public string LoadDataAndSave(string path)
        {
            string path1 = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V3.txt");

            FileInfo fileInfo = new FileInfo(path1);

            if (fileInfo.Exists)
            {
                File.Delete(path1);
            }

            string text = File.ReadAllText(path);

            string res = Regex.Replace(text, @"[а-яА-ЯёЁ]", "");
            File.WriteAllText(path1, res);
            return path1;
        }
    }
}
