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

namespace Windows_Form_store_into_SQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private MySqlConnection con;

        private void openConnectionToMySql()
        {
            string connectionString;
            connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=userdb;password=vicnesh123";

            con = new MySqlConnection(connectionString);
            try
            {
                con.Open();
                MessageBox.Show("Connection Open ! \n State: " + con.State.ToString());
            }
            catch (Exception conErr)
            {
                MessageBox.Show(conErr.ToString());
                //throw;
            }            
        }

        private void closeConnectionToMySql()
        {
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openConnectionToMySql();


            /*string connectionString;
            connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=userdb;password=vicnesh123";

            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MessageBox.Show("Connection Open !");

            MySqlCommand command;
            MySqlDataReader dataReader;
            String sql, Output = "";

            sql = "SELECT * FROM users";

            command = new MySqlCommand(sql, con);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + " - " + dataReader.GetValue(2) + "\n";
            }
            MessageBox.Show(Output);

            //con.Close();
            */
        }

        private void showDbData_Click(object sender, EventArgs e)
        {
            MySqlCommand command;
            MySqlDataReader dataReader;
            String sql, Output = "";

            sql = "SELECT * FROM users";

            command = new MySqlCommand(sql, con);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + " - " + dataReader.GetValue(2) + "\n";
            }
            MessageBox.Show(Output);

            dataReader.Close();
            command.Dispose();
        }

        private void disconnectFromMySql_Click(object sender, EventArgs e)
        {
            closeConnectionToMySql();
        }

        private void updateDb_Click(object sender, EventArgs e)
        {
            string test = userName.Text + " , " + userPhone.Text + " , " + userEmail.Text;
            MessageBox.Show(test);

            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            String sql = "";

            sql = "INSERT INTO users SET userName='" + userName.Text + "',userPhone='" + userPhone.Text + "',userEmail='" + userEmail.Text + "'";

            command = new MySqlCommand(sql, con);

            adapter.UpdateCommand = new MySqlCommand(sql, con);
            adapter.UpdateCommand.ExecuteNonQuery();

            command.Dispose(); 
        }
    }
}
