namespace APPbank
{
    partial class Form4
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(505, 0);
            label1.Name = "label1";
            label1.Size = new Size(134, 44);
            label1.TabIndex = 0;
            label1.Text = "Pomoc";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 56);
            label2.Name = "label2";
            label2.Size = new Size(372, 20);
            label2.TabIndex = 1;
            label2.Text = "Aby utworzyć nowe konto: wybierz opcję Utwórz konto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 76);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 85);
            label4.Name = "label4";
            label4.Size = new Size(1151, 20);
            label4.TabIndex = 3;
            label4.Text = "Jeżeli posiadasz konto i chcesz się zalogować, wybierz: Logowanie. Po zalogowaniu będziesz miał możliwość zarządzania swoim kontami bankowymi, które do ciebie należą";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 117);
            label5.Name = "label5";
            label5.Size = new Size(1229, 20);
            label5.TabIndex = 4;
            label5.Text = "Aby utworzyć nowe konto bankowwe przypisane do twojego konta wybierz opcję Utwórz Nowe Konto widoczną po zalogowaniu się. W razie problemów prosimy o kontakt z adminem ";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1268, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}