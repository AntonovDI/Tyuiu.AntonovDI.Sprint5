using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.AntonovDI.Sprint5.Task1.V20.Lib
{
    public class DataService : ISprint5Task1V20
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }
            double y;
            string strY;
            for(int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round(((5*x + 2.5)/(Math.Sin(x) + 3) + 2 * x + Math.Cos(x)), 2);
                strY = Convert.ToString(y);

                if ((Math.Sin(x) + 3) == 0)
                {
                    File.AppendAllText(path, Convert.ToString(0));
                }
                else
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
            }
            return path;
        }
    }
}
