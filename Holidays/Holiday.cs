using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holidays
{
    public class Holiday
    {
        public Holiday(string name, DateTime date, bool isWorkHoliday)
        {
            Name = name;
            Date = date;
            IsWorkHoliday = isWorkHoliday;
        }

        public string Name { get; }

        public DateTime Date { get; }

        public bool IsWorkHoliday { get; }
    }
}
