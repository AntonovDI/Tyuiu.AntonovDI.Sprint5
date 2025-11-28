using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AntonovDI.Sprint5.Task5.V2.Lib
{
    public class DataService : ISprint5Task5V2
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (Convert.ToDouble(line) > 0)
                    {
                        res += Convert.ToDouble(line);
                        count++;
                    }
                }
            }
            double sred = Math.Round(res / count, 3);
            return sred;
        }
    }
}
