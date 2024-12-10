using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BazaDanychPojazdow;

namespace Projekt_winforms
{
    public partial class Form2 : Form
    {
        
        public string usernamein;
        public DateFormatter dateformatter;
        private SqlManager sqlmanager;
        private DateCalculator dateCalculator;


        public Form2(string username)
        {
            InitializeComponent();
            usernamein = username;
            timer1.Start();
            dateformatter = new DateFormatter();
            sqlmanager = new SqlManager(usernamein);
            dateCalculator = new DateCalculator();
            sqlmanager.FillCombo(comboBox1);
            sqlmanager.ShowTableView(dataGridView1);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            DateFormatter dateFormatter = new DateFormatter();
            Date todayDate = new Date(dateTime.Year, dateTime.Month, dateTime.Day);
            this.timer_date.Text = dateFormatter.ToShortDateString(todayDate);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlmanager.AddDate(this.dateTimePicker1.Text, this.textBox1.Text, usernamein);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Editbutton_Click(object sender, EventArgs e)
        {
            sqlmanager.EditDate(int.Parse(this.id_value.Text), this.dateTimePicker1.Text, this.textBox1.Text, usernamein);
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            sqlmanager.DeleteDate(int.Parse(this.id_value.Text), this.dateTimePicker1.Text, this.textBox1.Text, usernamein);
        }

        private void AddStringbutton_Click(object sender, EventArgs e)
        {
            string Descriptstr = textBox1.Text;
            comboBox1.Items.Add(Descriptstr);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlmanager.ComboValuesReader(id_value, comboBox1, textBox1, dateTimePicker1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ZapisDaty_Enter(object sender, EventArgs e)
        {

        }

        private void id_value_Click(object sender, EventArgs e)
        {

        }

        private void Czyscik_Click(object sender, EventArgs e)
        {
            this.id_value.Text = "";
            this.textBox1.Text = "";
            this.dateTimePicker1.Text = "";
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            sqlmanager.RefreshCombo(comboBox1);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            sqlmanager.ShowTableView(dataGridView1);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Odejmij_Click(object sender, EventArgs e)
        {
            dateCalculator.SubtractTimeFromDate(dateTimePicker1, int.Parse(Years.Text), int.Parse(Months.Text), int.Parse(Days.Text));
        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            dateCalculator.AddTimeToDate(dateTimePicker1, int.Parse(Years.Text), int.Parse(Months.Text), int.Parse(Days.Text));
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            // Tworzymy nowy obiekt formularza "Samochody"
            Samochody samochodyForm = new Samochody();

            // Ukrywamy obecny formularz
            this.Hide();

            // Otwieramy nowy formularz "Samochody"
            samochodyForm.Show();
        }
    }
}
