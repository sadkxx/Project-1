namespace Project_1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Görmek istediğiniz projeyi seçiniz :\n" +
                "Proje 1 (İki sayının farkını bulan kod)\n" +
                "Proje 2 (5 sayısının karesini bulan kod)\n" +
                "Proje 3 (10 sayısının 3 ' e bölümünden kalanını bulan kod\n" +
                "Proje 4 (Klavyeden girilen 4 sayının toplamını ve çarpımını bulan kod)\n" +
                "Proje 5 (Klavyeden girilen 2 sayının bölümünü bulan kod)\n" +
                "Proje 6 (Klavyeden kenarları girilen dikdörtgenler prizmasının hacmini hesaplayan kod)\n" +
                "Seçiminiz :");
            int deger;
            deger = Convert.ToInt32(Console.ReadLine());
            if (deger == 1)
            {
                Console.Clear();
                fonk1();
                sorgu();
            }
            else if (deger == 2)
            {
                Console.Clear();
                fonk2();
                sorgu();
            }
            else if (deger == 3)
            {
                Console.Clear();
                fonk3();
                sorgu();
            }
            else if (deger == 4)
            {
                Console.Clear();
                fonk4();
                sorgu();
            }
            else if (deger == 5)
            {
                Console.Clear();
                fonk5();
                sorgu();
            }
            else if (deger == 6)
            {
                Console.Clear();
                fonk6();
                sorgu();
            }
            else {
                Console.Clear();
                Console.WriteLine("Geçersiz seçim. Lütfen 1 ile 6 arası seçim yapınız.");
                Main();
            }
        }
        
        static void sorgu()
        {
            Console.WriteLine("------------------------------------------------");
            Console.Write("Diğer projelere bakmak ister misiniz? (e / h) ");
            char cevap = Convert.ToChar(Console.ReadLine());
            if (cevap == 'h' || cevap == 'H')
            {
                Console.WriteLine("Program 3 saniye içinde kapanacaktır.\nHoşçakalın ! ");
                Thread.Sleep(3000);  // 3 saniye bekleme fonksiyonu
                return;
            }
            if (cevap == 'e' || cevap == 'E')
            {
                Console.WriteLine("-------------------------");
                Main();
            }
        }
        static void fonk1()
        {
            //İKİ SAYININ FARKINI BULAN KOD
            Console.WriteLine("-----------------------------");
            Console.WriteLine("İKİ SAYININ FARKINI BULAN KOD");
            Console.WriteLine("-----------------------------");
            double a, b, fark;
            Console.Write("İlk sayıyı giriniz :");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz :");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("İki sayının farkı : {0}\n", fark = a - b);
            Console.WriteLine("-----------------------------");
        }
        static void fonk2()
        {
            //5 SAYISININ KARESİNİ BULAN KOD
            Console.WriteLine("------------------------------");
            Console.WriteLine("5 SAYISININ KARESİNİ BULAN KOD");
            Console.WriteLine("------------------------------");
            int sonuc = 5 * 5;    
            Console.WriteLine("5 sayısının karesi : " + sonuc);
        }
        static void fonk3()
        {
            //10 SAYISININ 3'E BÖLÜMÜNDEN KALANINI BULAN KOD
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("10 SAYISININ 3'E BÖLÜMÜNDEN KALANINI BULAN KOD");
            Console.WriteLine("----------------------------------------------");
            float cevap;
            cevap = 10 % 3; //modu
            Console.WriteLine("10 sayısının 3'e bölümünden kalanı (yani modu): " + cevap);
        }
        static void fonk4()
        {
            //KLAVYEDEN GİRİLEN 4 SAYININ TOPLAMINI VE ÇARPIMINI BULAN KOD
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("KLAVYEDEN GİRİLEN 4 SAYININ TOPLAMINI VE ÇARPIMINI BULAN KOD");
            Console.WriteLine("------------------------------------------------------------");
            double sayi1 , sayi2 , sayi3 , sayi4 ;
            Console.Write("1. sayıyı giriniz :");
            sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2. sayıyı giriniz :");
            sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("3. sayıyı giriniz :");
            sayi3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("4. sayıyı giriniz :");
            sayi4 = Convert.ToDouble(Console.ReadLine());
            double toplam = sayi1 + sayi2 + sayi3 + sayi4 ;
            double carpim = sayi1 * sayi2 * sayi3 * sayi4 ;
            Console.WriteLine("4 sayının toplamı : " + toplam);
            Console.WriteLine("4 sayının çarpımı : " + carpim);
        }
        static void fonk5()
        {
            //KLAVYEDEN GİRİLEN 2 SAYININ BÖLÜMÜNÜ BULAN KOD
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("KLAVYEDEN GİRİLEN 2 SAYININ BÖLÜMÜNÜ BULAN KOD");
            Console.WriteLine("----------------------------------------------");
            double sayi1, sayi2;
            Console.Write("1. sayıyı giriniz :");
            sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2. sayıyı giriniz :");
            sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Girilen ilk sayının ikinci sayıya bölümü : {0}\n" +
                "Girilen ikinci sayının birinci sayıya bölümü : {1} ", sayi1/sayi2 , sayi2/sayi1);
        }
        static void fonk6()
        {
            //KLAVYEDEN KENARLARI GİRİLEN DİKDÖRTGENLER PRİZMASININ HACMİNİ HESAPLAYAN KOD
            Console.WriteLine("-----------------------------------------" +
                "-----------------------------------");
            Console.WriteLine("KLAVYEDEN KENARLARI GİRİLEN DİKDÖRTGENLER" +
                " PRİZMASININ HACMİNİ HESAPLAYAN KOD");
            Console.WriteLine("-----------------------------------------" +
                "-----------------------------------");
            double kenar1 , kenar2 , kenar3;
            Console.Write("1. kenarı giriniz : ");
            kenar1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2. kenarı giriniz : ");
            kenar2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("3. kenarı giriniz : ");
            kenar3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kenarları girilen dikdörtgenin hacmi : " +kenar1*kenar2*kenar3);
        }
    }
}