using System;
using System.IO;
using System.Collections.Generic;
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
                    string json = sr.ReadToEnd();
                    List<Holiday> holidays = JsonConvert.DeserializeObject<List<Holiday>>(json);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("The holidays file couldn't be read or parsed.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
