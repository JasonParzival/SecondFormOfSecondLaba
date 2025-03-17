namespace SecondFormOfSecondLaba
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 18);
            label1.Name = "label1";
            label1.Size = new Size(426, 20);
            label1.TabIndex = 0;
            label1.Text = "В тексте удалить каждое слово с четным числом символов, ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 38);
            label2.Name = "label2";
            label2.Size = new Size(442, 20);
            label2.TabIndex = 1;
            label2.Text = "продублировать каждое слово с нечетным числом символов,";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 58);
            label3.Name = "label3";
            label3.Size = new Size(309, 20);
            label3.TabIndex = 2;
            label3.Text = "заменив все вхождения букв ‘d’ на букву ‘t’";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 97);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 3;
            label4.Text = "Введите текст:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(132, 97);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(310, 27);
            textBox1.TabIndex = 4;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // button1
            // 
            button1.Location = new Point(348, 137);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Результат";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 179);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Задача на str";
            FormClosed += Form1_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private Button button1;
    }
}
