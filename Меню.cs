using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sherudo
{
    public partial class Меню : Form
    {
        public Меню()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Услуги Form1 = new Услуги();
            Form1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Заказы Form1 = new Заказы();
            Form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Клиенты Form1 = new Клиенты();
            Form1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Операторы Form1 = new Операторы();
            Form1.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Производители Form1 = new Производители();
            Form1.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Товары Form1 = new Товары();
            Form1.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Товары_на_складе Form1 = new Товары_на_складе();
            Form1.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Комплект_оборудования Form1 = new Комплект_оборудования();
            Form1.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Склады Form1 = new Склады();
            Form1.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 Form = new Form1();
            Form.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Меню_Load(object sender, EventArgs e)
        {

        }
    }
}
