namespace APPbank
{
    partial class Form3
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
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button5 = new Button();
            button1 = new Button();
            label1 = new Label();
            checkBox1 = new CheckBox();
            label4 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(307, 230);
            label3.Name = "label3";
            label3.Size = new Size(108, 23);
            label3.TabIndex = 22;
            label3.Text = "Podaj hasło:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(307, 163);
            label2.Name = "label2";
            label2.Size = new Size(107, 23);
            label2.TabIndex = 21;
            label2.Text = "Podaj login:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(447, 230);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(319, 27);
            textBox2.TabIndex = 20;
            textBox2.UseSystemPasswordChar = true;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(447, 162);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(319, 27);
            textBox1.TabIndex = 19;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button5
            // 
            button5.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(664, 427);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(309, 74);
            button5.TabIndex = 18;
            button5.Text = "Anuluj";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(148, 427);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(309, 74);
            button1.TabIndex = 17;
            button1.Text = "Utwórz konto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += CreateAccount_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(497, 43);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 48);
            label1.TabIndex = 16;
            label1.Text = "Bank";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(426, 294);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(340, 27);
            checkBox1.TabIndex = 23;
            checkBox1.Text = "Konto z uprawnieniami administratora";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(282, 344);
            label4.Name = "label4";
            label4.Size = new Size(132, 23);
            label4.TabIndex = 24;
            label4.Text = "Podaj dostepu:";
            label4.Visible = false;
            label4.Click += label4_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(447, 344);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(319, 27);
            textBox3.TabIndex = 25;
            textBox3.Visible = false;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1200, 608);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button5);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button5;
        private Button button1;
        private Label label1;
        private CheckBox checkBox1;
        private Label label4;
        private TextBox textBox3;
    }
}