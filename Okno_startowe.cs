using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BazaDanychPojazdow
{
    public partial class Okno_startowe : Form
    {
        public Okno_startowe()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Tworzymy nowy obiekt formularza "Samochody"
            Samochody samochodyForm = new Samochody();

            // Ukrywamy obecny formularz
            this.Hide();

            // Otwieramy nowy formularz "Samochody"
            samochodyForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Busy_forms Busy_forms = new Busy_forms();

            this.Hide();

            Busy_forms.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Motocykle motocykleForm = new Motocykle();

            this.Hide();

            motocykleForm.Show();
        }
    }
}
