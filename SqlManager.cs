using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlX.XDevAPI.CRUD;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;
using TextBox = System.Windows.Forms.TextBox;


namespace BazaDanychPojazdow
{
    public class SqlManager
    {
        public string username;
        public DateFormatter dateFormatter;
        public SqlManager(string username)
        {
            this.username = username;
        }

        public void AddRecord(string loggedusername, string sqltable, string sqlcolumns, string sqlvalues)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;database=Wypozyczalnia;";
            string insertRecord = "insert into Wypozyczalnia." + sqltable +" (" + sqlcolumns + ") VALUES (" + sqlvalues + ");";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand command = new MySqlCommand(insertRecord, myConn); 
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = command.ExecuteReader();
                MessageBox.Show("Data została wpsiana");
                while (myReader.Read())
                {
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void EditDate(int id, string date, string description, string loggedusername)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;database=Daty;";
            string editDate = "update Daty.dates set date = '" + date + "',description =  '" + description + "' ,user_id = (select users.id from users where username = '" + username + "') where id = " + id + ";";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand command = new MySqlCommand(editDate, myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = command.ExecuteReader();
                MessageBox.Show("Data została zaktualizowana");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DeleteDate(int id, string date, string description, string loggedusername)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;database=Daty;";
            string deleteDate = "delete from Daty.dates where id = " + id + ";";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand command = new MySqlCommand(deleteDate, myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = command.ExecuteReader();
                MessageBox.Show("Data została Usunięta");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void FillCombo(ComboBox comboBox)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;database=Daty;";
            string fillDate = "select * from Daty.dates";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand command = new MySqlCommand(fillDate, myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    string sDesc = myReader.GetString("description");
                    comboBox.Items.Add(sDesc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void RefreshCombo(ComboBox comboBox)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;database=Daty;";
            string refreshDate = "select * from Daty.dates";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand command = new MySqlCommand(refreshDate, myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = command.ExecuteReader();
                comboBox.Items.Clear();
                while (myReader.Read())
                {
                    string sDesc = myReader.GetString("description");
                    comboBox.Items.Add(sDesc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void ComboValuesReader(Label id, ComboBox comboBox, TextBox textbox, DateTimePicker dateTimePicker)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;database=Daty;";
            string editDate = "select * from Daty.dates where description = '" + comboBox.Text + "'  ;";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand command = new MySqlCommand(editDate, myConn);
            MySqlDataReader myReader;
            try
            {
                myConn.Open();
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    string sId = myReader.GetInt32("id").ToString();
                    string sDesc = myReader.GetString("description");
                    DateTime sDate = myReader.GetDateTime("date");

                    textbox.Text = sDesc;
                    dateTimePicker.Value = sDate;
                    id.Text = sId;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ShowTableView(DataGridView dataGridView)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;database=Daty;";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand tableselect = new MySqlCommand("select * from Daty.dates ;", myConn);
            try
            {
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                myDataAdapter.SelectCommand = tableselect;
                DataTable dataTable = new DataTable();
                myDataAdapter.Fill(dataTable);
                BindingSource bindingSource = new BindingSource();

                bindingSource.DataSource = dataTable;
                dataGridView.DataSource = bindingSource;
                myDataAdapter.Update(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
