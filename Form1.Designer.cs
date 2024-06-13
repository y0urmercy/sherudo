namespace sherudo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            imageList1 = new ImageList(components);
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Thistle;
            button1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            button1.ForeColor = SystemColors.WindowFrame;
            button1.Location = new Point(103, 177);
            button1.Name = "button1";
            button1.Size = new Size(109, 30);
            button1.TabIndex = 0;
            button1.Text = "Войти";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(23, 20);
            label1.Name = "label1";
            label1.Size = new Size(229, 39);
            label1.TabIndex = 1;
            label1.Text = "Авторизация";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(69, 130);
            label2.Name = "label2";
            label2.Size = new Size(62, 19);
            label2.TabIndex = 2;
            label2.Text = "Пароль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(69, 94);
            label3.Name = "label3";
            label3.Size = new Size(54, 19);
            label3.TabIndex = 3;
            label3.Text = "Логин";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.Location = new Point(152, 94);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.WhiteSmoke;
            textBox2.Location = new Point(152, 130);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "1669354770_7-pibig-info-p-lotos-simvol-krasivo-7.png");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 22F);
            label4.Location = new Point(243, 20);
            label4.Name = "label4";
            label4.Size = new Size(55, 41);
            label4.TabIndex = 6;
            label4.Text = "𓇢𓆸";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(328, 266);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private ImageList imageList1;
        private Label label4;
    }
}
