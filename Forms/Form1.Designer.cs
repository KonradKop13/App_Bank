namespace APPbank
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            monthCalendar1 = new MonthCalendar();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(534, 41);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 48);
            label1.TabIndex = 0;
            label1.Text = "Bank";
            label1.UseWaitCursor = true;
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(433, 138);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(309, 74);
            button1.TabIndex = 1;
            button1.Text = "Logowanie";
            button1.UseVisualStyleBackColor = true;
            button1.UseWaitCursor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(433, 310);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(309, 74);
            button2.TabIndex = 2;
            button2.Text = "Pomoc";
            button2.UseVisualStyleBackColor = true;
            button2.UseWaitCursor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(433, 220);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(309, 74);
            button3.TabIndex = 3;
            button3.Text = "Załóż konto";
            button3.UseVisualStyleBackColor = true;
            button3.UseWaitCursor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(433, 392);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(309, 74);
            button4.TabIndex = 4;
            button4.Text = "Oferta banku ";
            button4.UseVisualStyleBackColor = true;
            button4.UseWaitCursor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(433, 483);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(309, 74);
            button5.TabIndex = 5;
            button5.Text = "Zamknij";
            button5.UseVisualStyleBackColor = true;
            button5.UseWaitCursor = true;
            button5.Click += button5_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(839, 30);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 6;
            monthCalendar1.Visible = false;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1200, 608);
            Controls.Add(monthCalendar1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            UseWaitCursor = true;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private MonthCalendar monthCalendar1;
    }
}