﻿namespace sherudo
{
    partial class Операторы
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
            Номер_оператора = new DataGridViewTextBoxColumn();
            Фамилия = new DataGridViewTextBoxColumn();
            Имя = new DataGridViewTextBoxColumn();
            Отчество = new DataGridViewTextBoxColumn();
            Дата_приема = new DataGridViewTextBoxColumn();
            Паспортные_данные = new DataGridViewTextBoxColumn();
            Имя_пользователя = new DataGridViewTextBoxColumn();
            Пароль = new DataGridViewTextBoxColumn();
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Номер_оператора, Фамилия, Имя, Отчество, Дата_приема, Паспортные_данные, Имя_пользователя, Пароль });
            dataGridView1.Location = new Point(-4, -2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(804, 377);
            dataGridView1.TabIndex = 0;
            // 
            // Номер_оператора
            // 
            Номер_оператора.HeaderText = "Номер оператора";
            Номер_оператора.Name = "Номер_оператора";
            // 
            // Фамилия
            // 
            Фамилия.HeaderText = "Фамилия";
            Фамилия.Name = "Фамилия";
            // 
            // Имя
            // 
            Имя.HeaderText = "Имя";
            Имя.Name = "Имя";
            // 
            // Отчество
            // 
            Отчество.HeaderText = "Отчество";
            Отчество.Name = "Отчество";
            // 
            // Дата_приема
            // 
            Дата_приема.HeaderText = "Дата приема";
            Дата_приема.Name = "Дата_приема";
            // 
            // Паспортные_данные
            // 
            Паспортные_данные.HeaderText = "Паспортные данные";
            Паспортные_данные.Name = "Паспортные_данные";
            // 
            // Имя_пользователя
            // 
            Имя_пользователя.HeaderText = "Имя пользователя";
            Имя_пользователя.Name = "Имя_пользователя";
            // 
            // Пароль
            // 
            Пароль.HeaderText = "Пароль";
            Пароль.Name = "Пароль";
            // 
            // button1
            // 
            button1.BackColor = Color.Thistle;
            button1.Font = new Font("Courier New", 11.25F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(319, 381);
            button1.Name = "button1";
            button1.Size = new Size(107, 29);
            button1.TabIndex = 2;
            button1.Text = "Выход";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(319, 413);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 5;
            label1.Text = "☆ ★ ✮ ★ ☆";
            // 
            // button4
            // 
            button4.BackColor = Color.Thistle;
            button4.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold);
            button4.Location = new Point(1068, 186);
            button4.Name = "button4";
            button4.Size = new Size(22, 23);
            button4.TabIndex = 25;
            button4.Text = "★ ";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(915, 186);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(147, 23);
            textBox4.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(810, 186);
            label6.Name = "label6";
            label6.Size = new Size(107, 15);
            label6.TabIndex = 23;
            label6.Text = "Условие удаления";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(892, 121);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(170, 23);
            textBox3.TabIndex = 22;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(915, 92);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(147, 23);
            textBox2.TabIndex = 21;
            // 
            // button3
            // 
            button3.BackColor = Color.Thistle;
            button3.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold);
            button3.Location = new Point(1068, 123);
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
            label5.Location = new Point(810, 123);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 19;
            label5.Text = "Условие";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(810, 96);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 18;
            label4.Text = "Изменение поля";
            // 
            // button2
            // 
            button2.BackColor = Color.Thistle;
            button2.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold);
            button2.Location = new Point(1068, 27);
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
            label3.Location = new Point(809, 29);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 16;
            label3.Text = "Новая запись";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(892, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 23);
            textBox1.TabIndex = 15;
            // 
            // Операторы
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 450);
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
            Name = "Операторы";
            Text = "Операторы";
            Load += Операторы_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Номер_оператора;
        private DataGridViewTextBoxColumn Фамилия;
        private DataGridViewTextBoxColumn Имя;
        private DataGridViewTextBoxColumn Отчество;
        private DataGridViewTextBoxColumn Дата_приема;
        private DataGridViewTextBoxColumn Паспортные_данные;
        private DataGridViewTextBoxColumn Имя_пользователя;
        private DataGridViewTextBoxColumn Пароль;
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