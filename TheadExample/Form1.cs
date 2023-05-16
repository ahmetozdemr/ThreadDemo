using System.Net;

namespace TheadExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            System.Windows.Forms.Form.CheckForIllegalCrossThreadCalls = false;//windows bazen kendi oluþturduðumuz thread'lere izin vermiyor bu engeli aþmak için
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread resimDonder = new Thread(resimCekici);//göstereceðimiz resimler için oluþturduðumuz thread
            resimDonder.Start();//thread baþlatma


            Thread textDondur = new Thread(GetText);
            textDondur.Start();
        }
        private void resimCekici()//resimleri siteden çekmek için yazdýðýmýz thread fonksiyonu
        {
            while (true)//resimler picture box'ýmýzda 1 er saniye ara ile gösteriliyor
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;//gelen resmi picture box'ýn boyutuna göre ölçeklendiriyoruz
                pictureBox1.Image = resimGetir(@"https://fiverr-res.cloudinary.com/images/t_main1,q_auto,f_auto,q_auto,f_auto/gigs/19005252/original/5a12046d74ffa8c53c4eb6334894f0fcca967f39/make-your-piture-with-neon-glow-effect.jpg");
                Thread.Sleep(1000);//thread fonksiyonunu 1 saniye duraklatýp diðer resmi çekiyoruz
                pictureBox1.Image = resimGetir(@"https://fiverr-res.cloudinary.com/images/t_main1,q_auto,f_auto,q_auto,f_auto/gigs2/19005252/original/57ddbc9199a432b4778e5aba3d24235e8ba86fc0/make-your-piture-with-neon-glow-effect.jpg");
                Thread.Sleep(1000);
                pictureBox1.Image = resimGetir(@"https://fiverr-res.cloudinary.com/images/t_main1,q_auto,f_auto,q_auto,f_auto/gigs3/19005252/original/967de46b83b470c48ef255290a25a0ab4f93aa82/make-your-piture-with-neon-glow-effect.jpg");
                Thread.Sleep(1000);
                pictureBox1.Image = resimGetir(@"https://fiverr-res.cloudinary.com/images/t_smartwm/t_main1,q_auto,f_auto,q_auto,f_auto/attachments/delivery/asset/02cd649322c3ddc2367d1ddfe87413d7-1600171415/fff/make-your-piture-with-neon-glow-effect.jpg");
                Thread.Sleep(1000);
            }
        }

        Bitmap resimGetir(String url)//siteden gelen url ile resimler çekiliyor
        {
            WebRequest resimIstek = WebRequest.Create(url);//url için istek yapýyoruz
            return (Bitmap)Bitmap.FromStream(resimIstek.GetResponse().GetResponseStream());//geri dönen resmi resimCekici fonksiyonuna gönderiyoruz
        }
        private void GetText()
        {
            while (true)
            {
                textBox1.Text = "Tavþan";
                Thread.Sleep(1000);
                textBox1.Text = "Tilki";
                Thread.Sleep(1000);
                textBox1.Text = "Kaplumbaða";
                Thread.Sleep(1000);
            }
        }

        private void buttonProgres_Click(object sender, EventArgs e)
        {
            Thread progresDoldurThread = new Thread(progresDoldurucu);//Ýlk thread'imiz progres bar doldurmak için 
            progresDoldurThread.Start();//Thread'i baþlatýyoruz
        }
        private void progresDoldurucu()//progresDoldurThread'i için yazdýðýmýz fonksiyon
        {
            while (true)//progres bar dolana kadar dönen döngümüz
            {
                progressBar1.Maximum = 100;//progres bar'ýn maximum deðeri
                if (progressBar1.Value == 90)
                {
                    progressBar1.Value = 0;
                }
                progressBar1.Value += 10;//deðerinin kaçar kaçar artacaðý
                Thread.Sleep(1000);//fonksiyonun bekleme süresi mili saniye cinsinden
            }

        }

        private void buttonlistBox_Click(object sender, EventArgs e)
        {
            Thread listBoxThread = new Thread(listBoxDoldur);//listbox'ý&amp;amp;nbsp; doldurmak için kullandýðýmýz thread
            listBoxThread.Start();//thread baþlatýlýyor
        }
        private void listBoxDoldur()//thread fonksiyonumuz
        {
            while (true)
            {
                listBox1.Items.Add("Ahmet Özdemir");//thread çalýþýnca sürekli listbox'a ekliyor
                Thread.Sleep(500);//yarým saniye bekleme süresi
            }
        }

        private void buttonProgres_Click_1(object sender, EventArgs e)
        {
            Thread progresDoldurThread = new Thread(progresDoldurucu);//Ýlk thread'imiz progres bar doldurmak için 
            progresDoldurThread.Start();//Thread'i baþlatýyoruz
        }

        private void buttonlistBox_Click_1(object sender, EventArgs e)
        {
            Thread listBoxThread = new Thread(listBoxDoldur);//listbox'ý&amp;amp;nbsp; doldurmak için kullandýðýmýz thread
            listBoxThread.Start();//thread baþlatýlýyor
        }
    }
}

/* Thread oluþturma süreci
System.Windows.Forms.Form.CheckForIllegalCrossThreadCalls = false;//windows bazen kendi oluþturduðumuz thread'lere izin vermiyor bu engeli aþmak için 
using System.Threading;//thread kullanýmý için eklmemiz gereken kütüphane
Thread thread = new Thread(threadFonk);//burada bir fonksiyon ismi yazacaðýz thread bu fonksiyonu çalýþtýracak
thread.Start();//thread'i baþlatmamýz gerekir 
thread.Suspend();//thread'i durdurur ama yok edemez sadece susturur
thread.Resume();//duran thread'i geri çalýþtýrýr 
void threadFonk()//çalýþacak fonksiyon
{
    ....çalýþacak iþlemler
    Thread.Sleep(1000);//thread'i yavaþlatmak istersek kullanacaðýmýz fonksiyon

}
*/