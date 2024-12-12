using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_winforms
{
    public class DateFormatter
    {
        public string FormatDate(Date date, string format)
        {
            return date.Value.ToString(format);
        }

        // Dodatkowa metoda dla wygodnego formatowania do krótkiej postaci daty
        public string ToShortDateString(Date date)
        {
            return date.Value.ToShortDateString();
        }

        public string ToSQLString(Date date)
        {
            return $"{date.Year:D4}-{date.Month:D2}-{date.Day:D2}";
        }
    }
}
