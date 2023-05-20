namespace LengthKullanımı
{
    partial class Form1
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
            textBox1 = new TextBox();
            lblKisa = new Label();
            lblUzun = new Label();
            lblBosluk = new Label();
            lblKelime = new Label();
            lblKarakter = new Label();
            lblBoslukDahil = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            lblKisa.AutoSize = true;
            lblKisa.Location = new Point(393, 250);
            lblKisa.Name = "lblKisa";
            lblKisa.Size = new Size(83, 15);
            lblKisa.TabIndex = 7;
            lblKisa.Text = "En Kısa Kelime";
            // 
            // label2
            // 
            lblUzun.AutoSize = true;
            lblUzun.Location = new Point(393, 197);
            lblUzun.Name = "lblUzun";
            lblUzun.Size = new Size(87, 15);
            lblUzun.TabIndex = 8;
            lblUzun.Text = "En uzun kelime";
            // 
            // label3
            // 
            lblBosluk.AutoSize = true;
            lblBosluk.Location = new Point(98, 279);
            lblBosluk.Name = "lblBosluk";
            lblBosluk.Size = new Size(77, 15);
            lblBosluk.TabIndex = 9;
            lblBosluk.Text = "Boşluk Sayısı ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(97, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(567, 169);
            textBox1.TabIndex = 10;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            lblKelime.AutoSize = true;
            lblKelime.Location = new Point(97, 250);
            lblKelime.Name = "lblKelime";
            lblKelime.Size = new Size(78, 15);
            lblKelime.TabIndex = 6;
            lblKelime.Text = "Kelime Sayısı ";
            // 
            // label5
            // 
            lblKarakter.AutoSize = true;
            lblKarakter.Location = new Point(98, 223);
            lblKarakter.Name = "lblKarakter";
            lblKarakter.Size = new Size(85, 15);
            lblKarakter.TabIndex = 4;
            lblKarakter.Text = "Karakter Sayısı ";
            // 
            // label6
            // 
            lblBoslukDahil.AutoSize = true;
            lblBoslukDahil.Location = new Point(98, 197);
            lblBoslukDahil.Name = "lblBoslukDahil";
            lblBoslukDahil.Size = new Size(153, 15);
            lblBoslukDahil.TabIndex = 5;
            lblBoslukDahil.Text = "Boşluk Dahil Karakter Sayısı ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(lblKisa);
            Controls.Add(lblUzun);
            Controls.Add(lblBosluk);
            Controls.Add(lblKelime);
            Controls.Add(lblKarakter);
            Controls.Add(lblBoslukDahil);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label lblKisa;
        private Label lblUzun;
        private Label lblBosluk;
        private Label lblKelime;
        private Label lblKarakter;
        private Label lblBoslukDahil;
    }
}