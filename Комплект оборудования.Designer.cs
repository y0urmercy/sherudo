﻿namespace sherudo
{
    partial class Комплект_оборудования
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
            Номер_комплекта_оборудования = new DataGridViewTextBoxColumn();
            Форма = new DataGridViewTextBoxColumn();
            Моющие_средства = new DataGridViewTextBoxColumn();
            Техника = new DataGridViewTextBoxColumn();
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Номер_комплекта_оборудования, Форма, Моющие_средства, Техника });
            dataGridView1.Location = new Point(51, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(444, 373);
            dataGridView1.TabIndex = 0;
            // 
            // Номер_комплекта_оборудования
            // 
            Номер_комплекта_оборудования.HeaderText = "Номер комплекта оборудования";
            Номер_комплекта_оборудования.Name = "Номер_комплекта_оборудования";
            // 
            // Форма
            // 
            Форма.HeaderText = "Форма";
            Форма.Name = "Форма";
            // 
            // Моющие_средства
            // 
            Моющие_средства.HeaderText = "Моющие средства";
            Моющие_средства.Name = "Моющие_средства";
            // 
            // Техника
            // 
            Техника.HeaderText = "Техника";
            Техника.Name = "Техника";
            // 
            // button1
            // 
            button1.BackColor = Color.Thistle;
            button1.Font = new Font("Courier New", 11.25F, FontStyle.Bold);
            button1.Location = new Point(206, 382);
            button1.Name = "button1";
            button1.Size = new Size(107, 30);
            button1.TabIndex = 2;
            button1.Text = "Выход";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(206, 415);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 5;
            label1.Text = "☆ ★ ✮ ★ ☆";
            // 
            // button4
            // 
            button4.BackColor = Color.Thistle;
            button4.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold);
            button4.Location = new Point(768, 172);
            button4.Name = "button4";
            button4.Size = new Size(22, 23);
            button4.TabIndex = 25;
            button4.Text = "★ ";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(615, 172);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(147, 23);
            textBox4.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(510, 172);
            label6.Name = "label6";
            label6.Size = new Size(107, 15);
            label6.TabIndex = 23;
            label6.Text = "Условие удаления";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(592, 107);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(170, 23);
            textBox3.TabIndex = 22;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(615, 78);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(147, 23);
            textBox2.TabIndex = 21;
            // 
            // button3
            // 
            button3.BackColor = Color.Thistle;
            button3.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold);
            button3.Location = new Point(768, 109);
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
            label5.Location = new Point(510, 109);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 19;
            label5.Text = "Условие";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(510, 82);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 18;
            label4.Text = "Изменение поля";
            // 
            // button2
            // 
            button2.BackColor = Color.Thistle;
            button2.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold);
            button2.Location = new Point(768, 13);
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
            label3.Location = new Point(509, 15);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 16;
            label3.Text = "Новая запись";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(592, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 23);
            textBox1.TabIndex = 15;
            // 
            // Комплект_оборудования
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 450);
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
            Name = "Комплект_оборудования";
            Text = "Комплект_оборудования";
            Load += Комплект_оборудования_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Номер_комплекта_оборудования;
        private DataGridViewTextBoxColumn Форма;
        private DataGridViewTextBoxColumn Моющие_средства;
        private DataGridViewTextBoxColumn Техника;
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