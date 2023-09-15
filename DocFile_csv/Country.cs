
using System.IO;
class Country
{
    public string Name { get; set; }

    public static void ReadFromFile()
    {
        StreamReader reader = new StreamReader("countries.csv");
        List<string> list=new List<string>();
        while (!reader.EndOfStream)
        {
            var line = reader.ReadLine();
            var values = line.Split(',');

            list.Add(values[0]);
            list.Add(values[1]);
            list.Add(values[2]);
            list.Add(values[3]);
            list.Add(values[4]);
            list.Add(values[5]);
        }
    }

    static void Main(string[] args)
    {
 
        ReadFromFile();
    }
}