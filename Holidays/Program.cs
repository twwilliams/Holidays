using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Holidays
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader sr = new StreamReader("2018-holidays.json"))
                {
                    string line = sr.ReadToEnd();
                    Console.WriteLine(line);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("The holidays file couldn't be read");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
