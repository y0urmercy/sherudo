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
    public partial class Меню2 : Form
    {
        public Меню2()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 Form = new Form1();
            Form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Товары Form1 = new Товары();
            Form1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Услуги Form1 = new Услуги();
            Form1.Show();
            this.Hide();
        }

        private void Меню2_Load(object sender, EventArgs e)
        {

        }
    }
}
