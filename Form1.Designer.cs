namespace Gelecegi_Yazanlar_1
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
            folderBrowserDialog1 = new FolderBrowserDialog();
            button1_KonumSec = new Button();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            button_DosyaAc = new Button();
            button_DosyaOlustur = new Button();
            saveFileDialog1 = new SaveFileDialog();
            label2 = new Label();
            label3 = new Label();
            textBox1_Konum = new TextBox();
            textBox2_Ad = new TextBox();
            button1_KONUM = new Button();
            button2_OLUSTUR = new Button();
            listBox1 = new ListBox();
            button_oku = new Button();
            button_yazdir = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // button1_KonumSec
            // 
            button1_KonumSec.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1_KonumSec.Location = new Point(13, 241);
            button1_KonumSec.Name = "button1_KonumSec";
            button1_KonumSec.Size = new Size(206, 56);
            button1_KonumSec.TabIndex = 0;
            button1_KonumSec.Text = "Folder Browser Dialog";
            button1_KonumSec.UseVisualStyleBackColor = true;
            button1_KonumSec.Click += button1_KonumSec_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 200);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button_DosyaAc
            // 
            button_DosyaAc.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_DosyaAc.Location = new Point(13, 314);
            button_DosyaAc.Name = "button_DosyaAc";
            button_DosyaAc.Size = new Size(206, 49);
            button_DosyaAc.TabIndex = 2;
            button_DosyaAc.Text = "Open File Dialog";
            button_DosyaAc.UseVisualStyleBackColor = true;
            button_DosyaAc.Click += button_DosyaAc_Click;
            // 
            // button_DosyaOlustur
            // 
            button_DosyaOlustur.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_DosyaOlustur.Location = new Point(13, 382);
            button_DosyaOlustur.Name = "button_DosyaOlustur";
            button_DosyaOlustur.Size = new Size(206, 49);
            button_DosyaOlustur.TabIndex = 3;
            button_DosyaOlustur.Text = "Save File Dialog";
            button_DosyaOlustur.UseVisualStyleBackColor = true;
            button_DosyaOlustur.Click += button_DosyaOlustur_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(154, 76);
            label2.Name = "label2";
            label2.Size = new Size(131, 23);
            label2.TabIndex = 4;
            label2.Text = "Dosya Konumu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(194, 106);
            label3.Name = "label3";
            label3.Size = new Size(91, 23);
            label3.TabIndex = 5;
            label3.Text = "Dosya Adı:";
            // 
            // textBox1_Konum
            // 
            textBox1_Konum.Location = new Point(291, 65);
            textBox1_Konum.Multiline = true;
            textBox1_Konum.Name = "textBox1_Konum";
            textBox1_Konum.Size = new Size(372, 34);
            textBox1_Konum.TabIndex = 6;
            // 
            // textBox2_Ad
            // 
            textBox2_Ad.Location = new Point(291, 105);
            textBox2_Ad.Multiline = true;
            textBox2_Ad.Name = "textBox2_Ad";
            textBox2_Ad.Size = new Size(372, 34);
            textBox2_Ad.TabIndex = 7;
            // 
            // button1_KONUM
            // 
            button1_KONUM.BackColor = Color.Turquoise;
            button1_KONUM.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1_KONUM.ForeColor = Color.Black;
            button1_KONUM.Location = new Point(669, 61);
            button1_KONUM.Name = "button1_KONUM";
            button1_KONUM.Size = new Size(105, 35);
            button1_KONUM.TabIndex = 8;
            button1_KONUM.Text = "KONUM SEÇ";
            button1_KONUM.UseVisualStyleBackColor = false;
            button1_KONUM.Click += button1_KONUM_Click;
            // 
            // button2_OLUSTUR
            // 
            button2_OLUSTUR.BackColor = Color.Turquoise;
            button2_OLUSTUR.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2_OLUSTUR.Location = new Point(669, 107);
            button2_OLUSTUR.Name = "button2_OLUSTUR";
            button2_OLUSTUR.Size = new Size(105, 33);
            button2_OLUSTUR.TabIndex = 9;
            button2_OLUSTUR.Text = "OLUŞTUR";
            button2_OLUSTUR.UseVisualStyleBackColor = false;
            button2_OLUSTUR.Click += button2_OLUSTUR_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(399, 275);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(312, 304);
            listBox1.TabIndex = 10;
            // 
            // button_oku
            // 
            button_oku.BackColor = Color.Navy;
            button_oku.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button_oku.ForeColor = Color.Transparent;
            button_oku.Location = new Point(717, 275);
            button_oku.Name = "button_oku";
            button_oku.Size = new Size(105, 49);
            button_oku.TabIndex = 11;
            button_oku.Text = "OKU";
            button_oku.UseVisualStyleBackColor = false;
            button_oku.Click += button_oku_Click;
            // 
            // button_yazdir
            // 
            button_yazdir.BackColor = Color.Chartreuse;
            button_yazdir.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button_yazdir.Location = new Point(1052, 275);
            button_yazdir.Name = "button_yazdir";
            button_yazdir.Size = new Size(108, 49);
            button_yazdir.TabIndex = 12;
            button_yazdir.Text = "YAZDIR";
            button_yazdir.UseVisualStyleBackColor = false;
            button_yazdir.Click += button_yazdir_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(875, 29);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(285, 240);
            richTextBox1.TabIndex = 13;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(1189, 606);
            Controls.Add(richTextBox1);
            Controls.Add(button_yazdir);
            Controls.Add(button_oku);
            Controls.Add(listBox1);
            Controls.Add(button2_OLUSTUR);
            Controls.Add(button1_KONUM);
            Controls.Add(textBox2_Ad);
            Controls.Add(textBox1_Konum);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button_DosyaOlustur);
            Controls.Add(button_DosyaAc);
            Controls.Add(label1);
            Controls.Add(button1_KonumSec);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FolderBrowserDialog folderBrowserDialog1;
        private Button button1_KonumSec;
        private Label label1;
        private OpenFileDialog openFileDialog1;
        private Button button_DosyaAc;
        private Button button_DosyaOlustur;
        private SaveFileDialog saveFileDialog1;
        private Label label2;
        private Label label3;
        private TextBox textBox1_Konum;
        private TextBox textBox2_Ad;
        private Button button1_KONUM;
        private Button button2_OLUSTUR;
        private ListBox listBox1;
        private Button button_oku;
        private Button button_yazdir;
        private RichTextBox richTextBox1;
    }
}