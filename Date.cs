using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt_winforms;

namespace Projekt_winforms
{
    public class Date
    {
        public DateTime Value { get; private set; }
        public int Year { get; private set; }
        public int Month { get; private set; }
        public int Day { get; private set; }

        public Date(int year, int month, int day)
        {
            Value = new DateTime(year, month, day);
            Year = year;
            Month = month;
            Day = day;
        }

        public static TimeSpan Difference(Date date1, Date date2)
        {
            return date1.Value - date2.Value;
        }

        public override string ToString()
        {
            return Value.ToShortDateString();
        }
    }
}