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
using MySql.Data.MySqlClient;


namespace BazaDanychPojazdow
{
    public partial class Form1 : Form
    {
        private SqlManager sqlmanager;
        public Form1()
        {
            InitializeComponent();
            sqlmanager = new SqlManager();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sqlmanager.AddRecord("Testowa", "imie, nazwisko", "'Testowy', 'Test'");
            //GlobalVariables.username = "admin";
            //GlobalVariables.username = username_txt.Text;
            //MessageBox.Show("Pomyślnie zalogowano");
            //this.Hide();
            //Form2 f2 = new Form2(GlobalVariables.username);
            //f2.ShowDialog();
            try
            {
                string myConnection = "datasource=sql7.freesqldatabase.com;port=3306;username=sql7751795;password=rWIrzXsbFL;";
                MySqlConnection myConn = new MySqlConnection(myConnection);

                MySqlCommand userSelect = new MySqlCommand(" select * from sql7751795.Users where username = '" + this.username_txt.Text + "' and password = '" + this.password_txt.Text + "' ;", myConn);
                MySqlDataReader myReader;
                myConn.Open();
                myReader = userSelect.ExecuteReader();
                bool connected = false;
                while (myReader.Read())
                {
                    connected = true;
                }

                if (connected)
                {
                    GlobalVariables.username = username_txt.Text;
                    MessageBox.Show("Pomyślnie zalogowano");
                    this.Hide();
                    Form2 f2 = new Form2(GlobalVariables.username);
                    f2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Logowanie zakończone niepowodzeniem. Upewnij się, że dane logowania zostały wpisane poprawnie.");
                }
                myConn.Close();
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
