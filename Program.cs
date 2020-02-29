using Newtonsoft.Json;
using System.IO;

namespace JsonCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            string JSONresult = JsonConvert.SerializeObject(emp);
            string path = @"D:\projectTesting\employee.json";

            using (var tw = new StreamWriter(path, true))
            {
                tw.WriteLine(JSONresult.ToString());
                tw.Close();
            }
        }
    }
}
