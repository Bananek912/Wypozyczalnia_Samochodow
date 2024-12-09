using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projekt_winforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource=localhost;port = 3306;username=root";
                MySqlConnection myConn = new MySqlConnection(myConnection);

                MySqlCommand userSelect = new MySqlCommand(" select * from daty.users where username = '" + this.username_txt.Text + "' and password = '" + this.password_txt.Text +  "' ;", myConn);
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
                    string username = username_txt.Text;
                    MessageBox.Show("Pomyślnie zalogowano");
                    this.Hide();
                    Form2 f2 = new Form2(username);
                    f2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Wystąpił błąd w zalogowaniu do bazy");
                }
                myConn.Close();
            }

            catch ( Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
