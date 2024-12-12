using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projekt_winforms;

namespace BazaDanychWypozyczen
{
    public partial class Samochody : Form
    {
        public Samochody()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
            //przycisk wczytaj
        private void button5_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = @"Txt Files (*.txt)|*.txt";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                    {
                        while (!reader.EndOfStream)
                        {

                            string line = reader.ReadLine();

                            string[] data = line.Split(';');

                            dataGridView1.Rows.Add(data[0], data[1], data[2], data[3]);
                        }
                    }

                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
            //przycisk zapisz
        private void button6_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = @"Txt Files (*.txt)|*.txt";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var writer = new StreamWriter(openFileDialog.FileName))
                    {
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                            writer.WriteLine($"{row.Cells[0].Value.ToString()};{row.Cells[1].Value.ToString()};{row.Cells[2].Value.ToString()};{row.Cells[3].Value.ToString()}");
                    }
                }
            }
        }
            //przycisk powrot
        private void button4_Click(object sender, EventArgs e)
        {
            // Tworzymy nowy obiekt formularza Okno_startowe
            Form2 Form_2 = new Form2();

            // Zamykamy obecny formularz
            this.Close();

            // Otwieramy formularz Okno_startowe
            okno_Startowe.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
            //przycisk modyfikuj
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                var row = dataGridView1.SelectedCells[0].RowIndex;

                textBox1.Text = dataGridView1.Rows[row].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.Rows[row].Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.Rows[row].Cells[3].Value.ToString();

                dataGridView1.Rows.RemoveAt(row);
            }
        }
        //przycisk usuń
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedCells[0].RowIndex);
            }
        }
        //przycisk dodaj
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Samochody_Load(object sender, EventArgs e)
        {

        }
    }
}
