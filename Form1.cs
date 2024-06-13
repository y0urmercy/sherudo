using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Data.Common;
using System.Diagnostics.Eventing.Reader;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace sherudo
{
    public partial class Form1 : Form
    {
        public static string login;
        public static string pswd;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


                if (textBox1.Text == "admin" && textBox2.Text == "123")
                {
                    login = "admin";
                    pswd = "123";
                    Меню Form1 = new Меню();
                    Form1.Show();
                this.Hide();
                }
                else if (textBox1.Text == "user" && textBox2.Text == "123")
                {
                login = "user";
                pswd = "123";
                Меню2 Form1 = new Меню2();
                    Form1.Show();
                this.Hide();
            }
                else
                {
                    MessageBox.Show("Неверное имя пользователя или пароль! ;<");
                }
            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    
