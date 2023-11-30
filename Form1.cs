namespace Gelecegi_Yazanlar_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_KonumSec_Click(object sender, EventArgs e)
        {
            //konum seçmek için kullanýlýr
            //tek baþýna kullanýlmasý bir þey ifade etmez birlikte kullanýlmasý gerekir
            folderBrowserDialog1.ShowDialog();
            label1.Text = folderBrowserDialog1.SelectedPath;
        }

        private void button_DosyaAc_Click(object sender, EventArgs e)
        {
            //folder browser dan farký sadece klasörleri deðil dosyalarý da gösterir
            //bazý filtreleme yöntemleriyle sadece istenen türde belge gösterilebilir
            openFileDialog1.ShowDialog();
            label1.Text = openFileDialog1.FileName;
        }

        private void button_DosyaOlustur_Click(object sender, EventArgs e)
        {
            //form üzerinden herhangi bir dosya türüne kayýt yapar
            saveFileDialog1.ShowDialog();
        }
        string belgeyolu, belgeadi;
        private void button1_KONUM_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                belgeyolu = folderBrowserDialog1.SelectedPath;
                textBox1_Konum.Text = belgeyolu;
            }
        }

        private void button2_OLUSTUR_Click(object sender, EventArgs e)
        {
            belgeadi = textBox2_Ad.Text;
            StreamWriter sw = File.CreateText(belgeyolu + "\\" + belgeadi + ".txt");
            MessageBox.Show("Belgeniz baþarýyla oluþturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_oku_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader oku = new StreamReader(openFileDialog1.FileName);
                string satir = oku.ReadLine();

                while (satir != null)
                {
                    listBox1.Items.Add(satir);
                    satir = oku.ReadLine();

                }
            }
        }

        private void button_yazdir_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Metin Dosyasý | *.txt";
            saveFileDialog1.ShowDialog();
            StreamWriter kaydet = new StreamWriter(saveFileDialog1.FileName);
            kaydet.WriteLine(richTextBox1.Text);
            kaydet.Close();
            MessageBox.Show("Metin belgesine kayýt yapýldý.", "BÝLGÝ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}