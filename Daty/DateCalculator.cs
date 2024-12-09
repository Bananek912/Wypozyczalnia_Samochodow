using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_winforms
{
    public class DateCalculator
    {
        public void AddTimeToDate(DateTimePicker dateTimePicker, int years, int months, int days)
        {
            DateTime newDate = dateTimePicker.Value.AddYears(years).AddMonths(months).AddDays(days);
            if (newDate >= dateTimePicker.MinDate && newDate <= dateTimePicker.MaxDate)
            {
                dateTimePicker.Value = newDate;
            }
            else
            {
                // Obsługa sytuacji, gdy data jest poza zakresem
                MessageBox.Show("Nowa data jest poza dozwolonym zakresem.");
            }
        }

        public void SubtractTimeFromDate(DateTimePicker dateTimePicker, int years, int months, int days)
        {
            DateTime newDate = dateTimePicker.Value.AddYears(-years).AddMonths(-months).AddDays(-days);
            if (newDate >= dateTimePicker.MinDate && newDate <= dateTimePicker.MaxDate)
            {
                dateTimePicker.Value = newDate;
            }
            else
            {
                // Obsługa sytuacji, gdy data jest poza zakresem
                MessageBox.Show("Nowa data jest poza dozwolonym zakresem.");
            }
        }
    }
}
