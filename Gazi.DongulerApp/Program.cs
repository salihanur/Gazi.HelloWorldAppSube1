using System;

namespace Gazi.DongulerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!"); 

            //5.12.23
            //vizeden sonraki ilk ders(geçen hafta sınav sorularını çözdük sadece)
            //Sağdaki Çözüm gezgininde Gazi.HelloWorldAppSube1 çözümü yazan kısma sağ tıklayıp yeni proje ekle diyerek bu projeyi oluşturduk
            //DÖNGÜLER
            //yukarıdaki yazıyı 10 kere yazdırmak istesek alt alta bu koddan yazabiliriz ama efektif değil

            //for (int i = 0; i <3; i++)
            //{
            //    Console.WriteLine("Gazi");
            //    //bu kod ekrana 3 kez gazi yazdırır alt alta
            //    //break point soldaki kırmızı buton, onu ekledikten sonra f10a basarak sürekli, ilerlet kodun nasıl çalıştığını izle
            //}

            //Console.WriteLine("İsminizi girin");
            //string isim=Console.ReadLine();
            //Console.WriteLine("İsminiz kaç kere yazılsın?");
            //byte dongu= byte.Parse(Console.ReadLine());
            //// int dongu=Convert.ToInt32(Console.ReadLine());  //hüseyinin kodu: yukarıdaki hocanın koduna alternatif olarak yazdığı kod
            //for (int i = 0; i <= dongu; i++) {
            //    Console.WriteLine(isim);
            //}
            //Console.WriteLine("İsminizi girin");
            //string isim = Console.ReadLine();
            //Console.WriteLine("İsminiz kaç kere yazılsın?");
            //byte dongu = byte.Parse(Console.ReadLine());

            //for (int i = 0; i < dongu; i++)
            //{
            //    Console.WriteLine($"{i+1}.{isim}");
            //}

            //ekrana 1 ile 10 arasındaki sayıları yazdıralım;
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //aşağıya kullanıcının girdiği 2 değer arasındaki sayıları ekrana yazdıran bir kod yazalım;

            //Console.WriteLine("Başlangıç Değerini Girin:");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Bitiş Değerini Girin:");
            //int sayi2 = int.Parse(Console.ReadLine());
            //for (int i = sayi1; i <=sayi2; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Şimdi de aralıktaki sayıları toplasın:

            //BUNU DÖNGÜSÜZ YAPMAYA ÇALIŞALIM MESELA SAYILARIM DA 10,11,12 VE 13OLSUN
            //int sonuc = 0;
            //sonuc = sonuc + 10;
            //sonuc=sonuc+11; 
            //sonuc=sonuc+12;
            //sonuc = sonuc + 13;
            //Console.WriteLine(sonuc);
            //ama bu kodda sürekli kendimizi tekrarladık
            //o yüzden döngülerle yazalım bu kodu;


            //Console.WriteLine("Başlangıç Değerini Girin:");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Bitiş Değerini Girin:");
            //int sayi2 = int.Parse(Console.ReadLine());
            //int sonuc = 0;

            //sayi1= 10 sayi2= 5 yazmış olsun kullanıcı diyelim;
            //if (sayi1 > sayi2) {
            //    int temp = sayi1;    temp temporaryden geliyor,başka bir şey de diyebilirdik ama genelde bu isim kullanılırmış
            //                         TEMP ÇOK ÖNEMLİ BURADA, BUNU İYİ ÖĞREN
            //    sayi1 = sayi2;
            //    sayi2 = temp;
            //}
            //for (int i = sayi1; i <= sayi2; i++)   
            //{ 

            //    Console.WriteLine(i);
            //    sonuc = sonuc + i;
            //}
            //Console.WriteLine(sonuc);


            //şimdide kullanıcıya çifter çifter mi gitsin diye sorup yine toplayalım tüm değerleri:

            //Console.WriteLine("Başlangıç Değerini Girin:");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Bitiş Değerini Girin:");
            //int sayi2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Çift mi tek mi?");
            //string cevap = Console.ReadLine();
            //int sonuc = 0;
            //// mod: yüzde işareti yani % i%2=0 ise i 2ye tam bölünüyor kalanı 0 demektir yani i çift sayı demektir.
            //if (sayi1 > sayi2)
            //{
            //    int temp = sayi1; 
            //    sayi1 = sayi2;
            //    sayi2 = temp;
            //}
            //for (int i = sayi1; i <= sayi2; i++)
            //{
            //    if(i%2 == (cevap =="tek"? 1 : 0))
            //    {
            //    Console.WriteLine(i);
            //    //sonuc = sonuc + i;  Buffer kodun yerine aşağıdakini tercih edelim çünkü daha kısa:
            //    sonuc += i;
            //}

            //}
            //Console.WriteLine(sonuc);

            //şimdi bütün programa tüm kodu seçerek exeption ekleyelim cttrl+k+s ile try diyelim;
            //try
            //{
            //    Console.WriteLine("Başlangıç Değerini Girin:");
            //    int sayi1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Bitiş Değerini Girin:");
            //    int sayi2 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Çift mi tek mi?");
            //    string cevap = Console.ReadLine();
            //    int sonuc = 0;

            //    if (sayi1 > sayi2)
            //    {
            //        int temp = sayi1;
            //        sayi1 = sayi2;
            //        sayi2 = temp;
            //    }
            //    for (int i = sayi1; i <= sayi2; i++)
            //    {
            //        if (i % 2 == (cevap == "tek" ? 1 : 0))
            //        {
            //            Console.WriteLine(i);

            //            sonuc += i;
            //        }

            //    }
            //    Console.WriteLine(sonuc);
            //}
            //catch (OverflowException)
            //{

            //    Console.WriteLine("Çok büyük ya da küçük değer girdiniz");
            //}

            //catch (FormatException)
            //{
            //    Console.WriteLine("Lütfen sayı giriniz");

            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Bilinmeyen bir hata oluştu");
            //}

            //DERS BİTTİ (HOCA KODLARI PAYLAŞTIĞI LİNKİN FOTOĞRAFINI FAVORİLERDE BULABİLİRSİN



            //12.12.23
            //aşağıdaki ekran çıktısını veren kodları yazın:

            //Taban giriniz:2
            //Üs giriniz:3
            //İşlemin sonucu:8


            //Console.WriteLine("Taban değeri giriniz");
            //int taban=int.Parse(Console.ReadLine());
            //Console.WriteLine("Üs değeri giriniz");
            //int us=int.Parse(Console.ReadLine());

            //int sonuc = 1;
            //for (int i = 0; i < us; i++)

            //{
            //    sonuc *= taban;
            //}
            //Console.WriteLine(sonuc);

            //aşağıdaki ekran çıktısını gösterecek kodu yazın:

            //sayi giriniz:5
            //Girilen sayının faktöriyeli:120

            //Console.WriteLine("Sayı giriniz:");
            //int sayi = int.Parse(Console.ReadLine());

            //int sonuc = 1;
            //for (int i = 1; i <= sayi; i++)

            //{
            //    sonuc *=i; 
            //}
            //Console.WriteLine(sonuc);

            //sayı giriniz: 11
            //girdiğiniz sayı asaldır/asal değildir.

            //Console.WriteLine("Sayı giriniz:");
            //int sayi = int.Parse(Console.ReadLine());

            //int sonuc = 1;
            //for (int i = 1; i <= sayi; i++)

            //{
            //    if { (i % sayi == (sonuc == "Sayı asaldır" ? 1 : 0))
            //        sonuc *= i; }
            //    else if (i % sayi == ())
            //    {
            //        Console.WriteLine("Sayı asal değildir");
            //    }
            //}
            //Console.WriteLine(sonuc);

            //kodumuzu optimize edelim yani daha kısa yazmaya çalışalım:
            //int sayac = 0;
            //Console.WriteLine("Sayıyı Girin");
            //int sayi = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= (sayi/2); i++)
            //{
            //    if (sayi % i == 0)
            //    {
            //        sayac++;
            //        break;
            //    }
            //}


            //Console.WriteLine(sayac == 2 ? "Sayı asaldır" : "Sayı asal değildir");

            //sonsuz döngü şu şekilde oluyo:
            //for (; ; )
            //{
            //    Console.WriteLine("Kullanıcı adını girin:");
            //    string user=Console.ReadLine();
            //    Console.WriteLine("Şifreyi girin:");
            //    string password=Console.ReadLine();
            //    if (user == "ali" && password == "veli") 

            //    {
            //        Console.WriteLine("Hoş geldiniz");
            //        break;
            //    }
            //    else
            //    {   
            //        Console.Clear();  //bu kod kullanıcının girdiği tüm verileri siler
            //        Console.WriteLine("Tekrar deneyiniz");
            //    }

            //}
            //şu programı yazalım:

            //sayı giriniz:5
            //devam etmek istiyor musunuz?E derse 
            //sayı giriniz:10
            //devam etmek istiyor musunuz?E derse 
            //Sayı giriniz:8
            //Devam etmek istiyor musunuz?H derse
            //Girdiğiniz en büyük sayı:10
            //bir de girilen sayıların toplamını da yazsın
            //bir de girilen sayıların aritmetik ortalamasını yazsın

            //double max = double.MinValue, toplam = 0, sayac = 0;

            //for (; ; )
            //{
            //    Console.Write("Sayı giriniz:");
            //    double sayi = double.Parse(Console.ReadLine());
            //    sayac++;
            //    toplam += sayi;

            //    if (sayi > max)
            //    {
            //        max = sayi;

            //    }
            //    Console.WriteLine("Devam etmek istiyor musunuz?");
            //    string cevap = Console.ReadLine();
            //    if (cevap == "H")
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine($"Girdiğiniz en büyük sayı:{max}\n Girilen sayıların toplamı:{toplam} \n Girilen sayıların ortalaması:{toplam / sayac}");

            //DERS SONUUU


            //19.12.23(3 hafta daha ders yapıcaz sonra finaller başlıyo)

            //hoca excelde bazı veriler girdi fotosu var

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write($"{i},{j}\t");   //ters slaş t boşluk at demek  //.csproj dosyasına tıklayarak proje açılır klasörde açmak istersen

            //    }
            //    Console.WriteLine();

            //dıştaki döngü sadece satırlarda dönüyor
            //yıldızlı görüntü fotolarda var (her satırda satır sayısı kadar yıldız var)

            //}
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //}

            //aşağıya bir yıldız var bir yıldız yok görüntüsü oluşturacak kodu yazalım;

            //for (int i = 0; i <= 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {

            //        Console.Write((i + j) % 2 == 0 ? "*" : " ");
            //    }

            //    Console.WriteLine();
            //}

            //kullanıcıya sütun sayısını gir satır sayısını gir diye sorup aynı işlmeleri yaptıralım;

            //Console.WriteLine("Enter column count:");  //sütun sayısı
            //int column = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter row count:");     //satır sayısı
            //int row = int.Parse(Console.ReadLine());

            //for (int i = 0; i <= row; i++)
            //{
            //    for (int j = 0; j < column; j++)
            //    {

            //        Console.Write((i + j) % 2 == 0 ? "*" : " ");
            //    }

            //    Console.WriteLine();

            //ara verdik

            //abcd=4*dcba  yani 4 basamaklı bir sayı, rakamları ters çevrildiğinde 4 ile çarpımına eşittir. bu 4 basamaklı sayı kaçtır?
            //abcd nedir? 
            bool sonuc = false;
            //for (int a = 1; a < 9; a++)
            //{
            //    for (int b = 0; b < 9; b++)
            //    {
            //        for (int c = 0; c < 9; c++)
            //        {
            //            for (int d = 0; d < 9; d++)
            //            {
            //                if (1000 * a + 100 * b + 10 * c + d == 4 * (1000 * d + 100 * c + 10 * b + a))
            //                {
            //                    Console.WriteLine($"{a}{b}{c}{d}");
            //                    //break; sayıyı bulunca döngüden çıkmaya yarar. break kodunu yazmasak 15 ms, break yazınca 2 ms sürüyor. break koymak mantıklı. break yazınca, bulunca daha dönmüyor döngün gereksiz yere
            //            sonuc=true;
            //    break;
            //    //                }
            //    //            }
            //    if (sonuc)
            //    {
            //        break;
            //        //        }
            //        //    }
            //        if (sonuc)
            //        {
            //            break;
            //        }
            //    }
            //    if (sonuc)
            //    {
            //        break;
            //    }
            //}
            //

            //sayı 8712 imiş, f5 yaparsan gösterir sana.

            //Hipotenüs uzunluğu 100 birime kadar olan dik üçgenleri yazdırınız.
            //mesela 3-4-5, 5-12-12, 6-8-10 gibi
            //a2 +b2=c2 ise o bir dik üçgendir. c=en uzun kenar=hipotenüs=dik açının karşısındaki kenar

            //for (int i = 1; i < 100; i++)  //kenar uzunluğu 0 ile başlamayacağı için i=1 dedik
            //{
            //    for(int j = 1;j <100; j++)
            //    {
            //        for (int k= 0; k <100; k++)
            //        {
            //            if (i*i+j*j==k*k)
            //            {
            //                Console.WriteLine($"{i}{j}{k}");
            //                break;
            //            }
            //        }
            //    }
            //}


            //Enter starting number: 3
            //Enter end number: 15
            //5-7-11-13
            //girilen iki sayı arasındaki asal sayıları bul ve yazdır
            //aşağıdaki şekilde yazsın
            //4=not prime number
            //5=prime number
            //6=not prime number
            //7=prime number ..... gibi gibi yazsın
            //2 den küçük sayı girerse hata versin bi de 
            //aşağıdaki kodda bir eksiklik yaptım çünkü 2den küçük sayı girince uyarı vermiyor, bi ara kontrol et kodu!!

            //int start;
            //for (; ; ) 
            //{
            //    Console.WriteLine("Enter starting number");
            //    start= int.Parse(Console.ReadLine());
            //    if (start<2)
            //    {

            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("You can not enter lower than 2!");
            //    }
            //}

            //Console.WriteLine("Enter end number");
            //int end = int.Parse(Console.ReadLine());

            //for (int i = start; i < end; i++)
            //{
            //    int count = 0;
            //    for (int j = 2; j <= (i/2); j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            count++;
            //            break;
            //        }
            //    }
            //    Console.WriteLine(count>0 ? $"{i}-is not prime" : $"{i}-prime");
            //}



            //13. hafta 26.12.23

            //int count = 0;
            //while (true)
            //{
            //    //parantezin içi true olduğu sürece dönen döngü, sonsuz bir döngüdür yani

            //    Console.WriteLine("Gazi");
            //    count++;   //ekrana 5 tane alt alta Gazi yazar bu kod!!!!

            //}


            //hayır diyene kadar sayıları iste ve her sayı söyledikten sonra topla sayıları, her sayıyı sorduktan sonra devam mı diye soruyoruz
            //kullanıcı devam dediği müddetçe deavm ediyo program, verilen sayıları toplamaya

            //    while (true)
            //    {
            //        Console.WriteLine("Enter a number");
            //        int number = int.Parse(Console.ReadLine());
            //        sum += num
            //        Console.WriteLine("Would you like to enter another number?Y/N");
            //        string answer = Console.ReadLine
            //            if (answer == "N")
            //            break;
            //    }
            //    Console.WriteLine(sum);

            //}

            //do
            //{
            //    Console.WriteLine("Gazi");
            //}  while(false);





            //        int sum = 0;
            //        string answer;
            //        do
            //      {
            //        Console.WriteLine("Enter anumber");
            //         int number = int.Parse(Console.ReadLine());
            //        sum +=number;
            //Console.WriteLine("Would you like to continue");
            //      answer = Console.ReadLine();
            //        } while (answer=="Y") ;
            //        Console.WriteLine(sum);

            //rastgele sayılar yazan kod aşağıda:

            //for (int i = 0; i < 10; i++)
            //{
            //    Random rnd = new Random();
            //    int number = rnd.Next(33,127);

            //    Console.WriteLine((char)number);

            //    //ascıı table( aski table yani)
            //}

            //sayı tahmin oyunu yapalım. kullanıcı bigisayarın belirlediği sayıyı bulana kadar tekra deneyiniz, yazısıno görsün:

           


            //Random rdn = new Random();
            //int number = rdn.Next(10);
            

            //while (true)
            //{
            //    Console.WriteLine("Guess the number:");
            //    int user = int.Parse(Console.ReadLine());

            //    if (user == number)
            //    {
            //        Console.WriteLine("You won!");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Wrong number, try again!");
            //        Console.ReadKey();
            //        Console.Clear();
            //    }

            //}

            //kullanıcın belli sayıda tahmin hakkı olsun:

            //Random rdn = new Random();
            //int number = rdn.Next(10);
            //byte attemp = 3;
            //while (true)
            //{
            //    Console.WriteLine(" Guess the number");
            //    int user = int.Parse(Console.ReadLine());

            //    if (user==number)
            //    {
            //        Console.WriteLine("You won!");
            //        break;
            //    }

               
            //    else 
            //    {
            //        attemp--;
            //        Console.WriteLine("Wrong numberi try again!");
            //        Console.ReadKey();
            //        Console.Clear();
            //    }
            //    if (attemp == 0)
            //    {
            //        Console.WriteLine("You lost!");
            //        break;
            //    }
            //}

            //ÖDEV:
            //3 ayrı seviye olsun, select level desin oyunun başında easy, medium,hard diye. hangisini seçerse ona göre devam edicek oyun; aralıkları değiştir ve hak sayısını azalt seviyeler için
            //puanlama sistemi de olsun. kolay seviyedeyken her hatasında 5 puan azaltsın, ortada 10, zorda 20 azalsın. 
            //ödevi yapıp githuba yükle.

            Random rdn = new Random();
            int number = rdn.Next(10);
            byte attemp = 3;
            while (true)
            {
                Console.WriteLine("Enter the level");
                int level = int.Parse(Console.ReadLine());
                Console.WriteLine(" Guess the number");
                int user = int.Parse(Console.ReadLine());

                if (user == number)
                {
                    Console.WriteLine("You won!");
                    break;
                }


                else
                {
                    attemp--;
                    Console.WriteLine("Wrong numberi try again!");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (attemp == 0)
                {
                    Console.WriteLine("You lost!");
                    break;
                }
            }





            //aşağıdaki kodları internetten aldım:
            Random rdn = new Random();
            int tahmin, sayi = rdn.Next(0, 100);
            int hak = 5;

            while (true)
            {
                Console.WriteLine("\n\n" + hak-- + " hakkınız var.");
                if (hak < 0)
                {
                    Console.WriteLine("KAYBETTİNİZ!");
                    break;
                }

                Console.Write("SAYI GİRİNİZ: ");
                tahmin = Convert.ToInt32(Console.ReadLine());

                if (tahmin > sayi)
                {
                    Console.WriteLine("Daha KÜÇÜK bir sayı giriniz.");
                }
                else if (tahmin < sayi)
                {
                    Console.WriteLine("Daha BÜYÜK bir sayı giriniz.");
                }
                else
                {
                    Console.WriteLine("TEBRİKLER!");
                }
            }



            //2.1.24


            //ödev:









        }
    }
}
