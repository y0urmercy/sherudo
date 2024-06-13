namespace sherudo
{
    partial class Заказы
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Номер_заказа = new DataGridViewTextBoxColumn();
            Дата = new DataGridViewTextBoxColumn();
            Стоимость = new DataGridViewTextBoxColumn();
            Номер_бригады = new DataGridViewTextBoxColumn();
            Адрес = new DataGridViewTextBoxColumn();
            Номер_услуги = new DataGridViewTextBoxColumn();
            Код_клиента = new DataGridViewTextBoxColumn();
            Номер_оператора = new DataGridViewTextBoxColumn();
            button1 = new Button();
            label1 = new Label();
            button4 = new Button();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            button3 = new Button();
            label5 = new Label();
            label4 = new Label();
            button2 = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Номер_заказа, Дата, Стоимость, Номер_бригады, Адрес, Номер_услуги, Код_клиента, Номер_оператора });
            dataGridView1.Location = new Point(-7, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(848, 381);
            dataGridView1.TabIndex = 0;
            // 
            // Номер_заказа
            // 
            Номер_заказа.HeaderText = "Номер заказа";
            Номер_заказа.Name = "Номер_заказа";
            // 
            // Дата
            // 
            Дата.HeaderText = "Дата";
            Дата.Name = "Дата";
            // 
            // Стоимость
            // 
            Стоимость.HeaderText = "Стоимость";
            Стоимость.Name = "Стоимость";
            // 
            // Номер_бригады
            // 
            Номер_бригады.HeaderText = "Номер бригады";
            Номер_бригады.Name = "Номер_бригады";
            // 
            // Адрес
            // 
            Адрес.HeaderText = "Адрес";
            Адрес.Name = "Адрес";
            // 
            // Номер_услуги
            // 
            Номер_услуги.HeaderText = "Номер услуги";
            Номер_услуги.Name = "Номер_услуги";
            // 
            // Код_клиента
            // 
            Код_клиента.HeaderText = "Код клиента";
            Код_клиента.Name = "Код_клиента";
            // 
            // Номер_оператора
            // 
            Номер_оператора.HeaderText = "Номер оператора";
            Номер_оператора.Name = "Номер_оператора";
            // 
            // button1
            // 
            button1.BackColor = Color.Thistle;
            button1.Font = new Font("Courier New", 11.25F, FontStyle.Bold);
            button1.Location = new Point(348, 387);
            button1.Name = "button1";
            button1.Size = new Size(107, 26);
            button1.TabIndex = 1;
            button1.Text = "Выход";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(348, 416);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 3;
            label1.Text = "☆ ★ ✮ ★ ☆";
            // 
            // button4
            // 
            button4.BackColor = Color.Thistle;
            button4.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold);
            button4.Location = new Point(1114, 194);
            button4.Name = "button4";
            button4.Size = new Size(22, 23);
            button4.TabIndex = 25;
            button4.Text = "★ ";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(961, 194);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(147, 23);
            textBox4.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(856, 194);
            label6.Name = "label6";
            label6.Size = new Size(107, 15);
            label6.TabIndex = 23;
            label6.Text = "Условие удаления";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(938, 129);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(170, 23);
            textBox3.TabIndex = 22;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(961, 100);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(147, 23);
            textBox2.TabIndex = 21;
            // 
            // button3
            // 
            button3.BackColor = Color.Thistle;
            button3.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold);
            button3.Location = new Point(1114, 131);
            button3.Name = "button3";
            button3.Size = new Size(22, 23);
            button3.TabIndex = 20;
            button3.Text = "★ ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(856, 131);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 19;
            label5.Text = "Условие";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(856, 104);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 18;
            label4.Text = "Изменение поля";
            // 
            // button2
            // 
            button2.BackColor = Color.Thistle;
            button2.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold);
            button2.Location = new Point(1114, 35);
            button2.Name = "button2";
            button2.Size = new Size(22, 23);
            button2.TabIndex = 17;
            button2.Text = "★ ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(855, 37);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 16;
            label3.Text = "Новая запись";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(938, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 23);
            textBox1.TabIndex = 15;
            // 
            // Заказы
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1279, 450);
            Controls.Add(button4);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Заказы";
            Text = "Заказы";
            Load += Заказы_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Номер_заказа;
        private DataGridViewTextBoxColumn Дата;
        private DataGridViewTextBoxColumn Стоимость;
        private DataGridViewTextBoxColumn Номер_бригады;
        private DataGridViewTextBoxColumn Адрес;
        private DataGridViewTextBoxColumn Номер_услуги;
        private DataGridViewTextBoxColumn Код_клиента;
        private DataGridViewTextBoxColumn Номер_оператора;
        private Button button1;
        private Label label1;
        private Button button4;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button3;
        private Label label5;
        private Label label4;
        private Button button2;
        private Label label3;
        private TextBox textBox1;
    }
}