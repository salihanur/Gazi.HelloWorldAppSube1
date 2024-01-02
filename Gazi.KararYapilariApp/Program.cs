namespace Gazi.KararYapilariApp
{
    internal class Program
    {
        static void Main(string[] args)


        {
            //KARAR YAPILARI
            //Karar vermekte kullanılan yapılardır
            //?: operatörü de karar veriyordu hatırlarsan
            //Şimdi onun daha gelişmiş versiyonlarından bahsedelim

            //elimde 2sayı olsun:
            //int s1 = 10;
            //int s2 = 20;
            //hangi sayı büyükse o büyüktür yazsın, sayılar eşitse de eşittir yazsın istiyoruz:

            //if yaz 2.seçeneği seç tab ve tab tuşuna bas aşağıdaki gelecek;

            //if (s1 > s2)
            //{
            //    Console.WriteLine(" Sayı 1 büyüktür");
            //}
            //eğer if parantezinin içi true ise if bloğunun içine girer ve oradaki komutu yapar
            //mesela yukarıda s2 sayısı daha büyük olduğu için yani false olduğu için, aşağıya gider:

            //else   (else: değilse, demektir)
            //{
            //    Console.WriteLine("sayı 2 büyüktür ya da iki sayı birbirine eşittir.")
            //}
            //ama ben daha kesin sonuçlar istiyorum, eşitse de eşit yazsın istiyorum o yüzden if bloğunun altına else if bloğu ekleriz:

            //if (s1 > s2)
            //{
            //    Console.WriteLine(" Sayı 1 büyüktür");
            //}
            //else if (s2>s1)
            //{
            //    Console.WriteLine("sayı 2 büyüktür"); 
            //}
            //ÇOK ÖNEMLİ: İstediğin kadar else if koyabilirsin ama if ve else'i bir kere yazabilirsin sadece

            //if ve else if durumları haricindeki durumlar için else bloğu kullanılır.
            //sayı2 sayı1den büyük değilse o zaman tek bir seçenek kalır geriye onu da else ile yazdırırız:
            //yukarıdaki if ve else if/else iflerin hiçbiri çalışmazsa en alttaki else bloğu kesinlikle çalışır!

            //else 
            //{
            //    Console.WriteLine("Sayılar eşittir");
            //}


            //Kullanıcının yazdığı 2 sayıyı işleme sokan ve sonucu yazdıran bir program yazalım:

            //Console.WriteLine("İlk sayıyı gir:");
            //double s1=double.Parse(Console.ReadLine()); //burada double yazmamızın sebebi ondalıklı sonuç alabilmek bölme işleminde, int yazsaydık sonucu tam sayı verecekti
            //Console.WriteLine("2. sayıyı girin:");
            //double s2 = double.Parse(Console.ReadLine()); //ilkine double yazdıysan diğerine de double yaz
            //Console.WriteLine("İşlem seçiniz: +,-,/,*");  
            //char islem = char.Parse(Console.ReadLine());  //işlem tipleri(+,-,/,*) tek karakter olduğu için char veri tipini kullandık
            //kullanıcı mesela +'ya basarsa islem değişkeni içerisinde + değer olacak.neye basarsa o değer olacak



            //string msg = "İşlemin Sonucu:";
            //diye değişken atarsak her yere sting şekilde işlemin sonucu, sonucu işlemin sonucu yazıp kod tekrarı yapmamış oluruz


            //if (islem == '+')  //char olduğu için tek tırnak içinde yazdık! string olsa çift tırnak arasına alırdık
            //{
            //    Console.WriteLine(s1 + s2);  //Console.Writeline($"{msg}{s1+s2}"); diye değiştirin dedi hoca kodları, msg değişkenini yazıcaz her bir koda yani
            //dolar işareti koymasak s1+s2 diye direkt bu ifadeyi yazdırırdı ekrana, dolar işareti koyunca s1 ve s2nin süslü parantez içindeyse değişken olduklarını anlıyor
            //}
            //else if (islem == '-') 
            //{
            //    Console.WriteLine(s1 - s2); //Console.Writeline($"{msg}{s1-s2}")
            //}
            //else if (islem == '/')
            //{
            //    Console.WriteLine(s1 / s2);  //Console.Writeline($"{msg}{s1/s2}")
            //}

            //else if (islem == '*')
            //{
            //    Console.WriteLine(s1 * s2);  //Console.Writeline($"{msg}{s1*s2}")
            //}

            //else
            //{ Console.WriteLine("Hatalı giriş yaptınız. Lütfen işlemi doğru giriniz");
            //}





            //7.11.23 (3.ders)(geçen hafta ders yoktu)




            //şu programı yazalım(aslında yukarıdaki hesaplama kodumuza dil seçeneği eklemiş olucaz);
            //dil seçiniz: select language: EN
            //En seçerse program ingilizce başlayacak
            //Enter first number:10
            //Enter second number:20
            //Select operation: +
            //Result: 30
            //Dil seçiniz/select language:Tr derse; türkçe başlayacak
            //ilk sayıyı gir:10
            //2.sayıyı gir:20
            //işlemi seçin: +
            //sonuç: 30

            //string msg1, msg2, msg3, msg4, msg5;
            //Console.WriteLine("DİLİ SEÇİN/SELECT LANGUAGE(TR/EN)"); 
            //string cevap = Console.ReadLine();  //cevap değişkeninin değerine göre karar veriyor program burada
            //if (cevap.ToUpper() == "TR") 
            //KULLANICI  küçük tr yazarsa program yine ingilizce başlar çünkü c# büyük küçük harf duyarlılığı olan bir programlama dili
            //toupper kodu kullanıcı ne girerse girsin büyük harfe çevir ve TR ile karşılaştır o değeri, anlamına gelir
            //BÜYÜK YA DA KÜÇÜK GİRSE DE FARKETMEKSİZİN BÜYÜK HARFE ÇEVİRİYOR TOUPPER KODU.
            //TERSİ DE LOWER'DIR. KÜÇÜK HARFE ÇEVİRİR.
            //kullanıcı tr yazarsa türkçe seçenekler gelecek,programın default ayarını ingilizce seçtik ki kullanıcı en ya da tr seçenkleri haricinde bir değer girerse diye
            //{
            //    msg1 = "Bir sayı giriniz:";
            //    msg2 = "Bir sayı daha giriniz:";
            //    msg3 = "İşlem seçiniz";
            //    msg4 = "İşlemin sonucu:";
            //    msg5 = "Hatalı işlem seçtiniz";
            //}
            //else  //tr yerine en ya da başka bir şey yazarsa default olarak ingilizce seçenek devreye giriyor burada

            //{
            //    msg1 = "Enter first number";
            //    msg2 = "Enter second number";
            //    msg3 = "Select operation";
            //    msg4 = "Result:";
            //    msg5 = "Incorrect operation selected";

            //}
            //    Console.WriteLine(msg1);
            //    double s1 = double.Parse(Console.ReadLine());
            //    Console.WriteLine(msg2);
            //    double s2 = double.Parse(Console.ReadLine());
            //    Console.WriteLine(msg3);
            //    char islem = char.Parse(Console.ReadLine());


            //    if (islem == '+')
            //    {
            //        Console.WriteLine($"{msg4}{s1 + s2}");
            //    }
            //    else if (islem == '-')
            //    {
            //        Console.WriteLine($"{msg4}{s1 - s2}");
            //    }
            //    else if (islem == '*')
            //    {
            //        Console.WriteLine($"{msg4}{s1 * s2}");
            //    }

            //    else if (islem == '/')
            //    {
            //        Console.WriteLine($"{msg4}{s1 / s2}");
            //    }

            //    else
            //    {
            //        Console.WriteLine(msg5);
            //    }


            //githubda şube1 bizim notlarımız
            //download zip dersen proje zip dosyası halinde indirilir repositories'ten
            //kullanıcıya hava nasıl diye sor, güzel derse dışarı çık, kötü derse evde kal diyen bir program yaz


            //Console.WriteLine("HAVA NASIL?");
            //string durum = Console.ReadLine().ToLower();
            //if (durum == "güzel"  || durum=="iyi")
            //{ Console.WriteLine("DIŞARI ÇIK"); }
            //else if
            //    (durum == "kötü")
            //{ Console.WriteLine("EVDE KAL"); }
            //else
            //{
            //    Console.WriteLine("CEVABINIZI KONTROL EDİN");
            //}


            //Console.WriteLine("HAVA NASIL?");
            //string durum = Console.ReadLine().ToLower();
            //if (durum == "güzel" || durum == "iyi")
            //{
            //    Console.WriteLine("hava kaç derece"); //kullanıcı onbeş yazsa ve programı çalıştırsak sistemsel bir hata oluştu uyarısı görür
            //eğer biz bunu öngöremeyip hiçbir önlem almazsak kullanıcı anlamlı bir hata mesajıyla karşılaşmaz
            //    sbyte derece = sbyte.Parse(Console.ReadLine());


            //    if (derece < 15)
            //    {
            //        Console.WriteLine("Hava soğuk evde otur");
            //    }
            //    else if (derece >= 15 && derece <= 40)  (aralık bu şekilde yazılır. mesela 25 derce olsun hava
            //    derece>=15 true olur. derece<=40 da true olur. true ve true= true olur. o yüzden && yani ve operatörü kullanıyoruz aralık belirtirken
            //    {
            //        Console.WriteLine("Hava iyi dışarı çık");
            //    }
            //    else
            //    {
            //        Console.WriteLine("cok sıcak evde otur");
            //    }
            //}
            //else if (durum == "kötü")
            //{

            //    Console.WriteLine("evde otur");
            //}
            //else
            //{
            //    Console.WriteLine("CEVABINIZI KONTROL EDİN");
            //}

            //exception: sistemsel hata
            //unhandled exception: yakalanmamış hata
            //format exception: biçimsel hata (mesela 15 yazması gerekirken onbeş yazması buna örnek)(sayısal veri girmesi gerekirken string veri girdi, biçimsel hata yaptı)
            //yeni konumuz exception handling; hata yakalama

            //HATA YÖNETİMİ

            //exceptionların yakalanıp kullanıcıya anlamlı hata mesajları verilmesi gerekir
            //otherwise; kullanıcı gördüğü hata mesajından hiçbir şey anlamaz



            //burada eğer sayı değil yazı girersek hata alırız exception yani. mesela yüziki yaz burada, hata alırsın.
            //bug:hata
            //f5: start debugging (hata ayıklamayı başla, yani hatanın olduğu yeri bul)
            //ctrl+f5= start without debugging (yani kullanıcı gözüyle başlatır programı, programı daha hızlı başlatır çünkü debug yapmaz)
            //hatanın nerede olduğunu göstermez, direkt kullanıcıya hata mesajını gösterir
            //atılan exceptionları kullanıcı tarafında anlamlı bir hale getirmek durumundayız.
            //c#'da bu işi try catch blokları yapar!!!!
            //try yazıp tab+tab basarsan visual studio otomatikmen istediğimiz yapıyı aşağıdaki gibi oluşturur:
            /*try
            {

            }
            catch (Exception)
            {

                throw;
            }
            */

            //aşağıdaki 2 satır kodu seçip yukarıdaki try bloğu içine sürükleyip bırakırsan aşağıdaki görüntü oluşur, hızlıca kodunu taşımış olursun

            //try          
            //{ 
            //try adı üstünde kendi bloğundaki kodları çalıştırmayı dene, komutudur
            //    Console.WriteLine("Bir sayı girin");
            //    byte sayi = byte.Parse(Console.ReadLine());  kullanıcı burada 15 yerine onbeş yazarsa format exception oluşur burada, programı durdurmak için yukarıdaki kırmızı kareye basabilirsin
            //}
            //catch (FormatException)   eğer try bloğunda bir hata oluşursa kod catch bloğuna düşer, throw bloğunda da hata atılır. catch; try içerisindeki kodlar tarafından atılan exception'ları yakalar
            //format exception: biçimsel hatadır. biçimsel hataları yakalar bu blok
            //{
            //    Console.WriteLine("Sadece sayı girin");     //buraya  throw;  dersen hatayı bulur ve atar ancak catch'in içinde throw yazmak şu an doğru değil, sorunumuzu çözmüyor
            //}                                               //burada f5e basarsan ve 15 yerine on yazarsan ekranda sadece sayı giriniz mesajı görürsün
            //kullanıcıyı o anlayamayacağı hata mesajlarından kurtarmış olduk

            //catch (OverflowException)                        //kullanıcı 30 yazacakken yanlışlıkla 300 yazsa, byte'a sığmayacağı için 300 değeri, hata alır                  
            //{                                                //eğer kodu exception şeklinde bıraksaydık ekranda hala sadece sayı girin mesajını görürdük. tek bir hata mesajı verip işin içinden sıyrılamayız gördüğün üzere
            //overflow:taşma demektir, sınırların dışına çıkma hatası

            //    Console.WriteLine("0-255 arası bir sayı girin");
            //}

            //catch (Exception)    Bütün hataları yakalayan catch bloğu exception bloğudur. bu bloğu en başa yazarsak tüm hataları yakalar ve altında yazılan OverflowException ya da FormatException bloklarının hiçbir anlamı kalmaz
            //Dolayısıyla catch (Exception) bloğu hep en son yazılır ki format ya da overflow'un yakalayamadığı hataları yakalasın diye. exception bloğu, else'e benziyor son durak olması açısından :D
            //{
            //    Console.WriteLine("Bilinmeyen bir hata oluştu");
            //}

            //kodunu try bloğu içine almak için bir diğer kısayol;
            //kodunu seç, ctrl+k+s(kodları sar'dan aklında kalsın) tuşla ve try seçip enter'a tıkla hızlıca kodları sardı diyebiliriz.
            //tüm kodlarını try içine alırsan aşağıda yaptığımız gibi, kodlarının altına yazdığın catch blokları da kodundaki hataları yakalamış olur.
            //kısayol: tüm kodlarını seç ctrl+k+s tuşla ve try'ı seçip enter'a bas, tüm kodların try bloğu içine alınmış olur
            //try içinde hata oluşursa, altındaki catch'e gidecek demektir bu.
            
            try
            {
                Console.WriteLine("HAVA NASIL?");
                string durum = Console.ReadLine().ToLower();
                if (durum == "güzel" || durum == "iyi")
                {
                    Console.WriteLine("hava kaç derece");
                    sbyte derece = sbyte.Parse(Console.ReadLine());


                    if (derece < 15)
                    {
                        Console.WriteLine("Hava soğuk evde otur");
                    }
                    else if (derece >= 15 && derece <= 40)
                    {
                        Console.WriteLine("Hava iyi dışarı çık");
                    }
                    else
                    {
                        Console.WriteLine("cok sıcak evde otur");
                    }
                }
                else if (durum == "kötü")
                {

                    Console.WriteLine("evde otur");
                }
                else
                {
                    Console.WriteLine("CEVABINIZI KONTROL EDİN");
                }


            }
            catch (FormatException)
            {
                Console.WriteLine("Sadece sayı girin");
            }
            catch (OverflowException)
            {
                Console.WriteLine("0-255 arası bir sayı girin");
            }

            catch (Exception ex)
            {
                Console.WriteLine("Bilinmeyen bir hata oluştu");
                Console.WriteLine($"Hata Mesajı:{ex.Message}\nTarih:{DateTime.Now}\nDetaylar:{ex.StackTrace}");

            }
            //catch (Exception)
            //{
            //    Console.WriteLine("Bilinmeyen bir hata oluştu");

            //}


            //14.11.23 tekrar dersi(4.ders)(sınav haftaya)

            Console.WriteLine("Bir sayı girin");
            byte sayi = byte.Parse(Console.ReadLine());

            if (sayi == 1)   //en sola ama enn sola tıkla kırmızı nokta gelecek, f5e basıp 1 yazarsan şu anki görüntüsü gibisola ok gelecek kırmızı noktanın üstüne
                             //herahngi bir yere sağ tıkla hızlı izleme de sayi==1 yaz enter yap, doğru mu yanlış mı söyler
                             //sayi+10 yaz enter de, ekrana 11 yazdıracak mesela
                             //f10a tıkla sırayla tarıyor hangi kodların çalıştığını
                             //debug modunu yukarıdaki kırmızı kareye tıklayarak kapatabilirsin
                             //bunun görüntüsü telefonda var saat 15.20de çektim
            {
                Console.WriteLine("bir");
            }
            else if (sayi == 2)
            {
                Console.WriteLine("iki");
            }
            else if (sayi == 3)
            {
                Console.WriteLine("üç");
            }
            else
            {
                Console.WriteLine("yanlış girdiniz");
            }


            switch (sayi)

            {
                case 1:
                    Console.WriteLine("Bir");
                    break;
                case 2:
                    Console.WriteLine("iki");
                    break;
                case 3:
                    Console.WriteLine("üç");
                    break;
                default:
                    Console.WriteLine("Yanlış giriş!");
                    break;
            }








        }
    }
}
