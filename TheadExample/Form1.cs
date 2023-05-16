using System.Net;

namespace TheadExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            System.Windows.Forms.Form.CheckForIllegalCrossThreadCalls = false;//windows bazen kendi olu�turdu�umuz thread'lere izin vermiyor bu engeli a�mak i�in
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread resimDonder = new Thread(resimCekici);//g�sterece�imiz resimler i�in olu�turdu�umuz thread
            resimDonder.Start();//thread ba�latma


            Thread textDondur = new Thread(GetText);
            textDondur.Start();
        }
        private void resimCekici()//resimleri siteden �ekmek i�in yazd���m�z thread fonksiyonu
        {
            while (true)//resimler picture box'�m�zda 1 er saniye ara ile g�steriliyor
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;//gelen resmi picture box'�n boyutuna g�re �l�eklendiriyoruz
                pictureBox1.Image = resimGetir(@"https://fiverr-res.cloudinary.com/images/t_main1,q_auto,f_auto,q_auto,f_auto/gigs/19005252/original/5a12046d74ffa8c53c4eb6334894f0fcca967f39/make-your-piture-with-neon-glow-effect.jpg");
                Thread.Sleep(1000);//thread fonksiyonunu 1 saniye duraklat�p di�er resmi �ekiyoruz
                pictureBox1.Image = resimGetir(@"https://fiverr-res.cloudinary.com/images/t_main1,q_auto,f_auto,q_auto,f_auto/gigs2/19005252/original/57ddbc9199a432b4778e5aba3d24235e8ba86fc0/make-your-piture-with-neon-glow-effect.jpg");
                Thread.Sleep(1000);
                pictureBox1.Image = resimGetir(@"https://fiverr-res.cloudinary.com/images/t_main1,q_auto,f_auto,q_auto,f_auto/gigs3/19005252/original/967de46b83b470c48ef255290a25a0ab4f93aa82/make-your-piture-with-neon-glow-effect.jpg");
                Thread.Sleep(1000);
                pictureBox1.Image = resimGetir(@"https://fiverr-res.cloudinary.com/images/t_smartwm/t_main1,q_auto,f_auto,q_auto,f_auto/attachments/delivery/asset/02cd649322c3ddc2367d1ddfe87413d7-1600171415/fff/make-your-piture-with-neon-glow-effect.jpg");
                Thread.Sleep(1000);
            }
        }

        Bitmap resimGetir(String url)//siteden gelen url ile resimler �ekiliyor
        {
            WebRequest resimIstek = WebRequest.Create(url);//url i�in istek yap�yoruz
            return (Bitmap)Bitmap.FromStream(resimIstek.GetResponse().GetResponseStream());//geri d�nen resmi resimCekici fonksiyonuna g�nderiyoruz
        }
        private void GetText()
        {
            while (true)
            {
                textBox1.Text = "Tav�an";
                Thread.Sleep(1000);
                textBox1.Text = "Tilki";
                Thread.Sleep(1000);
                textBox1.Text = "Kaplumba�a";
                Thread.Sleep(1000);
            }
        }

        private void buttonProgres_Click(object sender, EventArgs e)
        {
            Thread progresDoldurThread = new Thread(progresDoldurucu);//�lk thread'imiz progres bar doldurmak i�in 
            progresDoldurThread.Start();//Thread'i ba�lat�yoruz
        }
        private void progresDoldurucu()//progresDoldurThread'i i�in yazd���m�z fonksiyon
        {
            while (true)//progres bar dolana kadar d�nen d�ng�m�z
            {
                progressBar1.Maximum = 100;//progres bar'�n maximum de�eri
                if (progressBar1.Value == 90)
                {
                    progressBar1.Value = 0;
                }
                progressBar1.Value += 10;//de�erinin ka�ar ka�ar artaca��
                Thread.Sleep(1000);//fonksiyonun bekleme s�resi mili saniye cinsinden
            }

        }

        private void buttonlistBox_Click(object sender, EventArgs e)
        {
            Thread listBoxThread = new Thread(listBoxDoldur);//listbox'�&amp;amp;nbsp; doldurmak i�in kulland���m�z thread
            listBoxThread.Start();//thread ba�lat�l�yor
        }
        private void listBoxDoldur()//thread fonksiyonumuz
        {
            while (true)
            {
                listBox1.Items.Add("Ahmet �zdemir");//thread �al���nca s�rekli listbox'a ekliyor
                Thread.Sleep(500);//yar�m saniye bekleme s�resi
            }
        }

        private void buttonProgres_Click_1(object sender, EventArgs e)
        {
            Thread progresDoldurThread = new Thread(progresDoldurucu);//�lk thread'imiz progres bar doldurmak i�in 
            progresDoldurThread.Start();//Thread'i ba�lat�yoruz
        }

        private void buttonlistBox_Click_1(object sender, EventArgs e)
        {
            Thread listBoxThread = new Thread(listBoxDoldur);//listbox'�&amp;amp;nbsp; doldurmak i�in kulland���m�z thread
            listBoxThread.Start();//thread ba�lat�l�yor
        }
    }
}

/* Thread olu�turma s�reci
System.Windows.Forms.Form.CheckForIllegalCrossThreadCalls = false;//windows bazen kendi olu�turdu�umuz thread'lere izin vermiyor bu engeli a�mak i�in 
using System.Threading;//thread kullan�m� i�in eklmemiz gereken k�t�phane
Thread thread = new Thread(threadFonk);//burada bir fonksiyon ismi yazaca��z thread bu fonksiyonu �al��t�racak
thread.Start();//thread'i ba�latmam�z gerekir 
thread.Suspend();//thread'i durdurur ama yok edemez sadece susturur
thread.Resume();//duran thread'i geri �al��t�r�r 
void threadFonk()//�al��acak fonksiyon
{
    ....�al��acak i�lemler
    Thread.Sleep(1000);//thread'i yava�latmak istersek kullanaca��m�z fonksiyon

}
*/