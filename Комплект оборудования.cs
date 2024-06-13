using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sherudo
{
    public partial class Комплект_оборудования : Form
    {
        public Комплект_оборудования()
        {
            InitializeComponent();
        }
        public string table = "dbo.Комплект_оборудования$";
        private void Комплект_оборудования_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=last;Trusted_Connection=True;";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM dbo.Комплект_оборудования$";

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[reader.FieldCount]);
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    data[data.Count - 1][i] = reader[i].ToString();

                }

            }

            reader.Close();

            connection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            if (Form1.login == "admin")
            {
                Меню Form = new Меню();
                Form.Show();
                this.Hide();
            }
            else if (Form1.login == "user")
            {
                Меню2 Form = new Меню2();
                Form.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=last;Trusted_Connection=True;";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "INSERT INTO " + table + " VALUES (" + textBox1.Text + ");";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            dataGridView1.Rows.Clear();
            query = "SELECT * FROM " + table;

            command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[reader.FieldCount]);
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    data[data.Count - 1][i] = reader[i].ToString();

                }

            }

            reader.Close();

            connection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=last;Trusted_Connection=True;";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "UPDATE " + table + " SET " + textBox2.Text + " WHERE " + textBox3.Text + ";";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            dataGridView1.Rows.Clear();
            query = "SELECT * FROM " + table;

            command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[reader.FieldCount]);
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    data[data.Count - 1][i] = reader[i].ToString();

                }

            }

            reader.Close();

            connection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=last;Trusted_Connection=True;";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "DELETE FROM " + table + " WHERE " + textBox4.Text + ";";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            dataGridView1.Rows.Clear();
            query = "SELECT * FROM " + table;

            command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[reader.FieldCount]);
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    data[data.Count - 1][i] = reader[i].ToString();

                }

            }

            reader.Close();

            connection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }
    }
}