using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AntonovDI.Sprint5.Task6.V9.Lib
{
    public class DataService : ISprint5Task6V9
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Replace(",", "");
                    string[] a = line.Split(' ');
                    for (int i = 0; i < a.Length; i++)
                    {
                        if (a[i].Length == 3)
                        { 
                            count++;
                        }
                    }
                }

            }
            return count;
     
        }
    }
}
