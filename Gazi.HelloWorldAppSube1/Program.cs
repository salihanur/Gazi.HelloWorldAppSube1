using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;

namespace Gazi.HelloWorldAppSube1
{
    internal class Program
    {
        static int sayi = 50; //main metodu içine yazamadık bu kodu çünkü onun da ismi static
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //YORUM-AÇIKLAMA SATIRI (1.DERS: 10.10.23)

            ///*DİĞER BİR YORUM SATIRI
            // Bu şekildeki yorum satırı
            // sen yıldız slaş koyana kadar devam eder
            // aynen böyle

            /* BU PROJE .NET 7.0 PROJESİ
              Namespace: İçinde Class'ları bulunduran yapılardır. Namespace'in adı: proje verdiğimiz ad olacaktır. Yukarıda da gördüğün üzere
             -Namespace'in içi: açılan ilk süslü parantez ve kapanan son süslü parantezin içi demektir. Bu iki parantezin içinde de 'Program' 
              isimli bir class var.
             -Parantezler kodlamada çok önemli çünkü bir parantez açıp kapama parantezini eklemeyi unutabiliriz ya da yanlışlıkla silebiliriz
             Dolayısıyla parantez düzeni önemlidir. Açma parantezinin önüne bir kere tıklandığında visual studio editörü otomatik olarak kapanış
             parantezini de seçer. Yani açtığın parantezi kapatmışmısın diye bu şekilde kontrol edebilirsin.Bu çok kullanılan bir özellik olacak
             bizim için. 2. kontrol yöntemi de açılan parantezin altındaki kesikli çizgiyi takip etmektir. Kesikli çizginin devamında mutlaka bir
             kapanış parantezi de olmalıdır.
             -{ } bu parantez içlerine-aralarına 'blok yapıları' denir. Yani bu parantezler blok yapılarıdır.(scope denir ingilizce olarak)
             -Parantez aç: { yani altGr+7   Parantez kapat: }  yani altGr+0
             -Namspace'in de bir scope'u vardır dolayısıyla. Class'ın da bir scope'u vardır çünkü onun da hemen altında açılıp kapanmış bir
             parantezi vardır.
             - İçinde 'Main' yazan satıra da BU PROJE .NET 7.0 PROJESİMETOT denir. hatta MAİN METODU denir ona. Metodun da bir scope'u vardır gördüğün üzere.
             -Her satır sonunda ; kullanılır (scope'lar hariç, farkettiysen hiçbir scope tanımlamasının sonunda yani kapama parantezinin sonunda
              ; yok
             -Class: sınıf. Şimdilik basit bir tanımlama yapalım çünkü 2. dönem Nesne Tabanlı Programlama dersinde çok daha ayrıntılı görücez
             bu kavramı. Class'lar içinde metotları bulunduran yapılardır. 
             -Yukarıdaki class'ın ismi Program, gördüğün üzere. Class'ın içinde de Main isim bir metot var. Metotun içinde de console vs vs 
              diye bir kod var hatta.
             -METOT: İş yapan kod bloklarıdır. İş yapmak; ekrana mesaj yazdırmak, kullanıcının girdiği bir veriyi okumak gibi şeylerdir.
             -MAIN METODU ana metot demektir, adı üstünde. Konsol uygulamalarında olmazsa olmaz bir metodtur.
             -Main Metodu, bir konsol uygulaması başladığında ilk çalışan metodtur. Console uygulamalarının giriş noktası-enter point de denir.
             -Yani programı çalıştırdığımıda main metodu her zaman ilk çalışna metottur. Bulunması zorunludur.
             -Main matodu yoksa console uygulaması giriş noktasız kalır ve çalışmaz
             -Yazdığımız kodları çalıştırmak için yani programı çalıştırmak için F5'e basabilirsin. Hatta yukarıdaki basit haliyle f5'E basarsak
             -siyah arka planda beyaz yazıyla Hello,World yazısını görürürüz program ekranında.
             -Namespace->class->metot diye gider, hiyerarşi böyledir, unutma!
             -Biz burada WriteLine metodunu kullanarak ekrana Hello World yazdırmaya çalışıyoruz
             -WriteLine metotsa WriteLine'ın önünde yazan yeşil renkli Console da class'tır. Çünkü hiyerarşi var aralarında
             - Nokta yani . operatörü hiyerarşi ifade eder. Console.WriteLine da da aynı şekilde işte
             -WriteLine, Console'un içinde demektir bu. Console'un içinde bulunan metotlardan biridir diyebiliriz WriteLine için.
             -Visual Studio bu konuda da bize yardım ediyor. Yukarıda Consele yazısı üstüne imleci getirip beklersen
              class System.Concele yazdığını görürsün. Yani Console bir classtır ve Console classı System NameSpace'i içindedir, anlamına gelir bu.
             -Metotların sonuna her zaman parantez açılır. Örn; WriteLine("Hello, World!");  gibi
             -Kod yazım kurallarına SYNTAX denir.
             -C# syntax'ına göre blok-scope tanımlamalarının sonunda ; kullanılmaz, yani parantez kapamadan sonra ; kullanılmaz
             -istisnası hariç(scope yani), her kod satırının sonuna ; konur çünkü ; yapılması istenen iş bitti anlamına gelir.
             -built: visual studio'nun derleme-oluşturma işine verdiği isimdir. derleme=compile
             -c# dilinin, binary(0-1) yani bilgisayar diline dönüştürülmesine DERLEME denir.
             -Derlemenin başarılı olabilmesi için syntax hatası olmamalı. yani ufak bir yazım hatasında bile bir ; koyman gereken yere 
              koymazsan program çalışmaz 
             -eğer ; koymamız gerekn yere koymazsak ve f5e basarsak bir kutucuk gelir. There were built errors. Would you like to continiou 
             -and run the last succesful built diye sorar. Yani derleme-oluşturma hataları var. devam ederek son başarılı derlemeyi-oluşturmayı
             -çalıştırmak ister misiniz? diye sorar. hayır-no demeliyiz ki son kod çalışsın. çalıştırırsak da hata verir çünkü ; unuttuk.
             -denem yapalım. ;'i silelim. hemen alta error list gelecek ve ; expected-bekleniyor yazacak. hata hangi Dosyadaysa adını da yazıyor
             -mesela bu hata Pogram.cs 'de imiş. Hatta kaçıncı satırda hata olduğunu bile yazıyor.line-çizgi 8 diyerekten. Yani 8. satırda 
              bir hata var diyor. Bazen hata 8de der ama 7de de olabilir, ona çok takılma. Visual Studio yapıyomuş bazen böyle.
             Gereken yere yani kod satırının sonuna ; ekleyince aşağıdaki hata satırı hemen yok oluyor.
             -kod yazarken hata yapmadıysan aşağıda ufak yeşil bir daire görüceksin; no issues found-sorun bulunamadı yazacaktır orada.
             -Ama bir hata varsa orası kırmızı çarpı 1 simgesine dönüşüyor. kaç adet hatan varsa orada o sayı yazıyor hatta.
              ÖNEMLİ KISAYOLLAR:
             -CTRL+S programcı için çok önemli, sıklıkla yaptıklarını kaydetmen gerek ctrl+s ile.
             -Visual Studio'da sadece tekli kısayol kombinasyonları kullanmaz. İkili tuş kombinasyonları da var mesela;
             -Kodların karıştı. Yani yukarıdaki gibi nizamlı durmuyor parantezlerin biri orda biri orada. nasıl düzenliceksin kodlarını;
             -kod satırında herhangi bir yere tıklayıp ctrl'ye basılı tutacak şekilde önce k'ye bas çek sonra d'ye bas çek yaparsan kodları hemen
             olması gerektiği yere düzgünce hizalar. ('kodları düzenle' diye hatırlayabilirsin baş harflerinden)
             -KODLAR NASIL YORUM HALİNE GETİRİLİR: yoruma dönüştürmek istediğin kodları seç ver ctrl'ye basılı tutacak şekilde önce k'ye bas çek
              sonra c'ye bas çek yaparsak tüm seçili alan yoruma dönüşür. 
             -ctrl basılı+ k bas çek+ u bas çek yaparsan da yoruma dönüşmüş satırları tekrar kod haline geri döndürür.
             -sağda menüde 'solution explorer-çözüm gezgini' penceresi var. Eğer açık değilse yukarıdaki 'view-görünüm' menüsü ile de açılabilir.
             -projemizin(c# yazan proje) içinde bir solution bir projemiz var. 
             -SOLUTION: İçinde birden fazla proje bulundurabilen yapılardır
             -Solution'lar içerisinde birden fazla projeyi de tutabilir, burada bir projemiz var ama. Programımızın içinde şu an ismi Program.cs 
              olan bir dosya var. Buradaki 'cs' dosyanın uzantısıdır. cs, program dosyasının  uzantısıdır burada.
              cs= c sharp yani c# , buradaki cs de c# dosyasıdır yani. cs dosyalarının içerisinde c# kodları bulunur.
              -Her dosyanın, dosyanın türünü belirten bir uzantısı vardır.
              -Her zaman açık olması gereken bir özellik var: Görünüm-> DOSYA ADI UZANTILARI seçeneği tikli olsun herhangi bir klasör açtığın
              zaman.
              -Proje dosyasının uzantısı: .csproj
              -Proje klasörünü açtığımda zaten dosyaların sağında değiştirme tarihi ve onun da yanında 
               dosya türü yazar.(sağ tık-görünüm-ayrıntılar seçili olduğundan emin ol)
              -Gazi.HelloWorldAppSube1.csproj dosyasına baktığımızda tür olarak C# Project File yazar hatta.
              -Bu projeyi kaydedip kapatalım. Gazi.HelloWorldAppSube1.sln dosyasına çift tıklarsak projemiz tekrar açılır.
              -solution dosyasını yani .sln uzantılı dosyayı kesip masaüstüne yapıştırsak ve dosyayı masaüstünden açmaya çalışsak hata alırız mesela.
               çünkü sln dosyası yanında csproj dosyasını da arar. eğer csproj dosyasını da masaüstüne yapıştırsaydık o zaman sln dosyası açılırdı.
              -masaüstü de bir klasördür, UNUTMA
              -bin klasörümüz var mesela. bin=binary'nin kısaltmasıdır. Derlenmiş dosyalarımız bu klasörde bulunur.
              -bin içinde debug diye bi klasör de var hatta. sonra bahsedilecek bu klasörden. debug'un da içinde .net7 klasörü var
              -içeride 5 dosyamız var. Bunlardan biri de exe uzantılı dosyamız. exe=executable file=çalıştırılabilir dosyalar
              -exe dosyaları doğrudan çalıştırılabilir dosyalar olduğu için aynı zamanda tehlikeli dosyalardır
               bilmediğin exe dosyalarını AÇMA! Virüs,trojen,zararlı yazılımlar bulaşabilir bilgisayara
              -projeni maille birine gönderemezsin mesela çünkü içinde exe dosyası var,gmail mesela zararlı olabilir diye güvenlik olarak
               göndermez mesela
              -projeni mail atacaksan exe dosyasını sil ve diğerlerini rar haline getir öyle gönder. exe dosyası sonra yine oluşturulabilir çünkü
              -mesela net.7.0 klasörü içindeki 5 dosyayı da silebilirsin sadece exe'yi değil yani, korkma sil.
              - KISAYOL: ctrl+b = b demek built demek yani derleme demek. ctrl+b program derlenir, çalışmaz ama derlenir yani.
              Derlenirse makine dili oluşmuş olur. 
               Şimdi 5 dosyayı da sildik. Burada ctrl+b ye bas ya da f5 e bas ya da yukarıda 'derle->çözümü derle' ye tıklarsan tüm dosyalar 
               tekrar oluşturulacak (o 5 dosya da).
              -Satır numaraları nasıl gösterilir(hani solda alt alta 1,2,3,4.. diye gidiyo ya onlar işte): araçlar-tools -> options-seçenekler
               metin düzenleyici-text editor -> c# ->genel -> satır numaraları-text number tikli olduğundan emin ol
              -hocanın yazdığı readkey... gibi bir kod var, konsolu ekrana sabitlemek için yazmış. çok önemli değil yani
              -Microsoft'un kullandığı bir teknoloji var; derleme işlemi sonrasında c# kodlarını doğrudan makine diline çevirmiyorum diyor
               derleme: program dilinin makine diline dönüşmesi idi hatırlarsan. MAKİNA DİLİ: 1ler ve 0lardır. İşlemciden işlemciye değişebilen
               kodlardır bunlar. Mesela benim bilgisayarımın intel ailesine mensup bir işlemcisi 0 ve 1 diziliminden anlıyor.
               Ama amd işlemcili başka bir bilgisayar farklı 0 ve 1 dizilimlerinden anlıyor. Burada bir farklılık var yani
               Mesela C# ile bir program yazdım diyelim, doğrudan 0 ve 1lere dönüşse hangi işlemcinin anlayacağı dile göre dönüşecek?
               Dolayısıyla burada bir sorun ortaya çıkar. Bizim istediğimiz ise ben bunu bir derliyim bütün işlemciler tarafından okunabilsin
               Ya işlemcilere göre farklı farklı derlemeler oluşturucam(eskiden bu kadar çeşitli işlemci yokken bu yapılıyormuş)
               Ya da ben bir kod yazıcam bir kere derlicem ve tüm işlemcilerde çalşıcak. Bu seçenek en iyisi tabii ki
               Microsoft bunu bu şekilde çözmüş durumda zaten.
               Şimdi biz burada yazdık kodumuzu,derledik ama makine diline dönüştürülmedi. MS-IL(Microsoft Intermediate Language)
               diye bir dil var. makine dili yok yani.
               C# programlama diline Built-derle dersek MS-IL(exe)'e dönüşür. Bu hala makine dili değil tabii.
               Bu haliyle çalışmaz yani. Ama exe'ye çift tıkladığımızda program çalışıyor, nasıl oluyo bu?
               Çünkü exe'ye tıkladığın anda MS-IL makine diline dönüştürülür ve bu sayede çalışır. Dönüşüm şu şekilde oluyor;
               C#->Build->MS-IL(exe)'ye çift tıklayınca ->Runtime yapısı devreye girer->JIT Complier->Binary(0-1)'e dönüştürüyor.
               Böylece makine diline dönüşmüş oluyor
               JIT: Just in Time  Compiler: Derleyici  JIT Complier: Anlık derleme, tıklar tıklamaz derleme yapar, program çalıştırılır
               RUNTIME: Çalışma Zamanı: Programın çalıştığı zaman , Design Time: Dizayn-tasarım zamanı: kodların yazıldığı zaman
              .NET Core projes ile çalışıyoruz şu an ve .Net Core projesinde Core Common Language Runtime bilgisayarda yüklü olmalı
              Neden çünkü exe'izin içinde MS-IL vardı biliyosun, MS-IL normalde çalışmaz, İşlemciler bunu anlamaz. 
              Ama ben exe dosyama çift tıkladığımda arka planda çalışan runtime programı gelip bakıyor içindeki MS-IL'e
              ve benim işlmecim neyse o işlemcinin anlayacağı dile çevirip öyle çalıştırıyor programı
              Dolayısıyla işlemci farkının önemi kalmaz, her farklı işlemcide runtime devreye girerek o işlemcinin anlayacağı binary
              sisteme geçiş yapar yani. Runtime programları çok işlevsel yani bu sorunu çözmede.
              BU PROJE .NET 7.0 PROJESİ
              -Visual Studio'yu yüklediğimizde runtime da otomatik yükleniyor bilgisayara.
              Mesela şu an .NET 7.0 Runtime'ı var bilgisayarımda.
              Mesela exe dosyamı başka birinin bilgisayarında da çalıştırmak istiyorum. gönderdim o kişiye dosyamı ama orada çalışmadı
              Çalışmamasının sebebi o bilgisayarda runtime'ın yüklü olmamasıdır. Exe'mizi çalıştırmak için 
              Visual Studio'yu mu yüklicez her çalıştırmak istediğimiz bilgisayara, tabii ki hayır.
              Mesela Office Word programını Visual Studio ile geliştirdiklerini düşünelim. Word programını çalıştırmak için illa
              o bilgisayarda visual studio mu yüklü olmalı, tabii ki hayır.
              Arka planda runtime yüklenmesi yeterli olacaktır o programı çalıştırmak için
              Bunun için mesela setup programları geliştirilir, bilgisayar bir şey kurmak istediğimizde setup programlarının yaptığı
              bir iş de budur. Hem ilgili yere exe yükler hem de o exe'nin çalıştırılması için alakalı runtime'ı yükler.
              Peki başka birinin bilgisayarında exe dosyamı nasıl çalıştırabilirim. runtime indirilmeli ki çalışsın. Peki hangi runtime
              indirilmeli? google'a .NET 7.0  runtime yazarsan Microsoftun kendi sitesinden ücretsiz indirilebilir.
              - 7.0 diye aratmamızın sebebi bizim projemizin bu versiyon olmasından ötürü. 5.0 kullanıyo olsak o şekilde aratırdık mesela
              .Net Desktop Runtime 7.0.12 yi seçtik çünkü konsol uygulamaları masaüstü uygulamalardır. Bir de web uygulamları var mesela
              ama biz şu an onu yapmıyoruz. İndirecek olsaydım 64 bit seçerdim çünkü benimki 64 bit
              İŞLETİM SİSTEMİ: OPERATING SYSTEM: OS

              C#'da yazılan-geliştirilen Programlar kaç kere derlenir?
              2 kez derlenir. Önce built yapıyoruz, built C#'tan MS-IL'e dönüştürür ve bu 1. derlemedir
              Sonra exe'ye tıklayıp çalıştırırken de runtime MS-IL'i makine diline-binary sisteminde dönüştürüyor bu da 2. derleme oluyor.
              Bu işlemler, işlemci farklılığını ortadan kaldırıyor işte.
              2 kere derlenmesi programın hızlı çalışabilmesi açısından kötü ama programın her işlemcide çalışabilmesi açısından iyi.
              -Mesela bir savaş uçağının hedefe kitlenme yazılımını yaptığımızı düşünelim, ateş edilince gidip hedefi vuracak diyelim
              Bu işin çok çabuk olması gerek malum, hızlı çalışması gerektiği için bir derlemeden sonra bir daha derleyecek zaman yok
              Uçak 1000 km hızla gidiyo düşün, vakit yok yani
              O zaman C# bu tarz işler için uygun bir programlama dili değil diyebiliriz
              C#: Uygulama yazılımları geliştirmek için mesela otomasyon işlemleri yapmak için; öğrenci kayıt otomasyonu,
              muhasebe, stok, raporlama, istatistik vs için kullanılabilir.
              Böyle özel işler için  c# değil de daha low level-düşük seviyeli diller kullanılır mesela; C ya da C++ programlama dilleri gibi
              Mesela uçakta kullanılan o özel işlemciye özel derlenir, bir daha da derlenmez bu dillerde. Ve çok hızlı bir şekilde 
              görevini yerine getir. 
              -Programlama dilleri low level oldukça programlama yapmak zorlaşır, unutma. Bazı düzenlemeleri senin elle yapman gerekibilir.
              Mesela bellek yönetimini bizim yapmamız gerekir. C#'da bellek yönetimini biz yapmayız mesela, high level bir dil olduğu için. 
              NOT: Düşük seviye programlama dilleri makineya yani binary'e daha yakındır, üst seviye programlama dilleri insana daha yakındır
              Dolayısıyla daha rahat yazılır high level dillerle bir program. Bellek yönetimi vs gibi işlerle uğraşmayız ve geliştirme 
              sürecimiz hızlanır bundan dolayı
              JAVA da C# gibi üst seviye bir programlama dilidir.
              -Bellek yönetimi: Bir değişken oluşturduk, o değişken belleğe yani RAM'e gitti ama sürekli orada durmayacak.
              İşi bittikten sonra atılması lazım. C dilinde sen atıyosun onu mesela. C#'da ise kendi atıyo zaten.
              C# ve C++ syntax'ı çok çok benzerdir. syntax: yazım kuralları-dili
              -C# geliştirildikten sonra .NET denilen yapı ortaya çıkıyor.

              .NET: Microsoft tarafından yazılım geliştirmek için tasarlanan bir framework'tür. Yani ortamdır-çatıdır.
               Biz şu an bu yapı altında çalışıyoruz. Bu bir çatı diyebiliriz.  
              .NET içinde;
              -Programlama dilleri: C#, Visual Basic Programlama Dili(artık pek tercih edilmiyor) ve F# var
               Temelde bu 3 dil var
              .NET çatısı altındaki programlama dilleri bunlar.
               Burada C# ön plana çıkıyor çünkü .NET denilen bu çatı, C# ile geliştirildi. 
              -Kod Editörleri: Visual Studio(en üst seviye editör), Visual Studio Code
              -Kütüphaneler(Library): İçinde class'lar bulunur. Aynı namespace gibi. İçinde class'lar bulunduran yapılara namespace diyorduk hatırla
               Class'ların içinde metotlra vardı, metotlar da iş yapan yapılardı, hatırla!
               Mesela yukarıda Console.WriteLine("Hello, World!") kod satırına gel ve tekrar gör, console yazısı üstünde biraz beklersen
               class System.Console yazdığını göreceksin. Bu ne demekti; System kütüphanesi içinde Console class'ı içindeki WriteLine 
               metotu ile ekrana Hello, World! yazdırdım. Low level dillerde ekrana bir şey yazdırmak öyle kolay değildir.
               Ama biz burada tek satırda yazdırabildik. Dolayısıyla kütüphane desteğinin olması çok önemli.
               Mesela .NET içinde System Kütüphanesi olmasaydı Console diye bir class olmayacaktı, içinde WriteLine diye bir metot da olmayacaktı
               Ekrana yazı yazdıramayacaktık mesela.
               Kütüphane sayısı arttıkça class sayısı artar, dolayısıyla metot sayısı da artar dolayısıyla iş yapabilme kabiliyeti artar
               .NET versiyonları arttıkça (mesela şu an 7.0'ı kullanıyoruz) kütüphane destekleri de artar. Daha çok iş yapabiliriz.
               Sadece kütüphane değil editörlerin kabiliyeti de artar versiyon arttıkça tabii. Programlama dillerine yeni özellikler de eklenir.
              -Derleyiciler: Kodları makine diline(binary) çevirmek için gerekli yazılımlar
               bulunur. 
               .NET bize komple yazılım geliştirme ortamı sunuyor, içinde yazılım geliştirmek için ihtiyaç duyduğumuz her şeyi barındırıyor

               .NET çatısını kullanarak C# ile nasıl yazılımlar geliştirebiliriz;
               -Desktop Software(Masaüstü Yazılımları): Bilgisayara yükleyip çalıştırılan uygulamalar
               -Web Based Software(Web Tabanlı Yazılımlar): 
               -Mobile Application(Android-IOS): XAMARIN ile geliştirilir. 
                Sadece C#'da yazarak hem iOS'Da hem Android'te çalışan uygulamalar bile geliştirebiliriz, bu harikadır
               -Game Software: Unity ile
               -IOT(Internet of Things): Yani akıllı cihazlar için yazılımlar, diye Türkçeleştirebiliriz. Mesela robot süpürgeler, tartılar vs
               -AI(Yapay Zeka Uygulamaları)
                yapılabilir. Bir Visual Studio bir C# ile bunların hepsini yapabiliriz, bu gerçekten harika!
               .NET, Cross Platform'dur. Yani Windows, MacOS, Linux işletim sistemlerinde çalışabilen uygulamalardır. Mesela bir uygulama
               geliştiriyorsun özellikle desktop uygulamaları için bunu söyleyebiliriz, tüm işletim sistemlerinde çalışabiliyor. İşlemci ya da
               işletim sistemi sınırı yok yani .NET ile neredeyse her şeyi yapabiliyoruz. 

               Windows bu işe ilk kez .NET Framework ile başlamıştı. Bununla geliştirilen uygulamalar sadece Windows ortamında çalışıyordu.
               Sonra .NET Core çıktı, bu işin Cross Platform tarafı bu işte. Biz şu an .NET Core ile çalışıyoruz mesela.
               Artık .NET Framework'u geliştirmeme kararı aldılar, iki ayrı isme de gerek kalmadı, isim sadece .NET olarak devam ediyor.
               Hala framework ile visual studio'da bir şeyler yapılabilir ama. Windows uygulaması geliştirebiliriz mesela, 
               ONU DA YAPICAKMIŞIZ SONRA
               Google'a C# docs yazarsan bi dünya kaynak var, hatta direkt microsoftun sitesinden kurcala, bir sürü eğitim bilgisi mevcut orada
               Bir de daha basic anlatımı olan w3schoolu kullan hatta önce buna bak bu daha basit anlatıyor.
               1.DERSİN SONU*/





            //17.10.23(2.ders)
            //DEĞİŞKEN TANIMLAMA
            //Değişken tanımlarken önce veri tipi tanımlanır
            //her bir veri tipinin büyüklüğü birbirinden farklıdır.

            //BYTE TİPİNDE VERİ:
            //Veri tipindne sonra boşluk bırakılarak değişken adı yazılır
            //değişken tanımlamasını bitirinde ; konur.
            //a değişkenine değer ataması yapıcaz aşağıda; 30 değeri aticaz:
            //byte a = 30;
            // ya da 
            //byte a;
            //a=30;

            //DOUBLE VERİ TİPİ
            //b değişkenine de 40 değerini atayalım:
            //double b = 40;
            //ya da 
            //double b;
            //b=40;

            //BİR SCOPE(İKİ SÜSLÜ PARANTEZ) İÇİNDE AYNI İSİMLİ İKİ DEĞİŞKEN TANIMLAYAMAZSIN:
            //int a=30; int a=40 gibi mesela. hata alırsın bu durumda(altını kırmızı dalgalı çizgiyle çizer)
            //altı kırmızı çizili çizgi varsa kodumuzda, o program DERLENMEZ!Derlenmezse ÇALIŞMAZ!
            //hata kodu: bu skopta zaten a değişkeni tanımlanmış
            //şu an biz main metodu scope'u içindeyiz
            //bazen kodun altında yeşil dalgalı çizgi olabilir. Bu: hata yok kodda ama tanımladığın değişkeni hiç kullanmadın demek.
            //yani belleğin stack bölgesinde boşa yer kaplıyor diye bizi uyarıyor.
            //aşağıdaki kodu eklersek, a ve b değişkenlerinin altındaki yeşil çizgi gider çünkü onları kullanmış oluruz:
            //Console.WriteLine(a + b);

            //Aynı türden(veri tipinden) değişkenler tek satırda tanımlanıp değer atamaları yapılabilir:
            //byte a,b;
            //a =30; b=40;
            //ya da 
            //byte a=30,b;
            //b=40; gibi
            //bir kod ne kadar kısa yazılabilirse o kadar iyidir!

            //YAZDIĞIN KODLARI ctrl+k+c ile açıklama/yorum satırına çevirebilirsin!

            //STATİC DEĞİŞKEN TANIMLAMASI
            //Static değişkenler, program çalıştığı sürece bellekte/hafızada tutulan, bellekten atılmayan değişkenlerdir.
            //static olmayan değişkenler, işleri bittikten bir süre sonra atılırlar bellekten çünkü bir değişkenin sürekli yer kaplaması gerekmez bellekte
            //çünkü bilgisayarda çalışan tüm programlar RAM'i kullanır sadece bizim programımız değil yani
            //Dolayısıyla sınırlı RAM'i efektif kullanmak zorundayız
            //ama bazen öyle değişkenlere ihtiyacımız olur ki o değişkenin bellekten atılmaması, bellekte hep kalması gerekir
            //mesela online bir oyun tasarladık ve oyuncu sayısını tutan bir değişkenimiz var
            //oyundaki oyuncu sayısını sürekli göstermek istiyorsak ekranda, o zaman oyun çalıştığı sürece o değişkenin bellekte kalması gerek
            //o zaman değişkeni ''static'' anahtar kelimesiyle tanımlarız:
            //static bir değişkeni main metodu içine yazarsak hata alabilir çünkü main metodu da statictir. class içine tanımlanabilir ama. hoca bu konuyu sonra açıklayacak.


            //static byte a;
            //a = 30;
            //static byte a = 30;

            //SABİT DEĞİŞKEN TANIMLAMA
            //Tanımladıktan sonra bir daha değiştiremeyeceğimiz değişkenlere sabit değişkenler denir.
            //mesela pi sayısını tanımladığımız bir değişkenin sabit olmasını isteyebiliriz, değeri değişmeyeceği için
            //Değişkeni tanımlamadan önce başına ''const'' anahtar kelimesi eklenir:

            //const byte a =30;

            //int number = 100; 
            //Console.WriteLine(number);
            //number = 50;
            //Console.WriteLine(number);
            //ekrana önce 100 sonra 50 yazar eğer çalıştırırsak bu kodu. değişenimin değerini sonradan değiştirebildim burada.
            //number=50; yerine int number=50; yazsaydık iki tane aynı isimli değişken tanımladığımız için hata alırdık, dikkat!
            //number=50; yazınca tekrar tanımlama yapmış olmadık sadece değeri değiştirdik.

            //const int number dersek bu değişken daha sonra değiştirilemez.hatta yukarıda const int number diye
            //tanımlarsak değişkeni, hata verir. çünkü sonradan değerini 50 diye değiştirmesini istedik.

            //const byte a;
            //a = 30;

            //yukarıdaki kod çalışmaz çünkü önce a'yı sabit olarak tanımladın değer vermedin ona. sonra alttaki kodda 
            //değeri 30 olsun dedik. haliyle bu program hata verir.
            //const bir değişkene değer atayacaksan aynı satırda atamalısın değeri.
            //const ile işaretlenen değişkenler de aynı static gibidir yani program çalıştığı sürece bellekte kalırlar.

            //Değer atanmamış değişkenler program içinde kullanılamaz:

            //byte yas;
            //Console.WriteLine(yas);

            //yukarıdaki kod çalışmaz, program hata verir.
            //hata kodu: değer atanmamış değişken kullanımı

            //Değişken ismi, özel karakter veya sayı ile başlayamaz:
            //byte 1yas; ya da int *yas; gibi.mesela yıldız (*) çarpma operatörüdür çünkü.
            //illa önüne bir şey koymak istersen sadece alt tire _ kullanabilirsin:
            //byte _yas; olabilir. ya da int __yas; olabilir. ya da byte yas1; olabilir.

            //Değişken isminde Türkçe karakter kullanılmaz!
            //byte yaş; ya da int tür; gibi

            //Değişken isminde boşluk kullanılmaz:
            //byte ogrenci yas; gibi ya da int annem inyasi; gibi
            //boşluk yerine alt tire kullanılabilir:
            //byte ogrenci_yas;

            //VAR TYPE(var anahtar sözcüğü)
            //C# 3.0 ile birlikte gelen dahili bir veri tipidir. 
            //Var ile yapılan tanımlamalar implicit olarak değerlendirilir.
            //Örneğin;
            //var sayi = 5;  //Implicit Bu sayının veri tipi int olur. olur
            //int sayi = 5;  //Explicit



            //TEMEL TAM SAYI TÜRLERİ:
            /*
            BYTE
            8 Bitlik işaretsiz(yani negatif olmayan sayılar, önünde eksi - işareti olmayan sayılar) için kullanılır.
            Değer aralığı 0-255'tir. Yani 2üzeri^8 
            byte a=0; doğru
            byte b = 250; doğru
            byte c= 256;  Oweflow hatası verir
            */

            /*
            INT
            32 bitlik işaretli sayılar için kullanılır.
            Değer aralığı -2147483648 ile 2147483647 arasında değişir. Yani 2^üzeri 32
            int yaz sonra sağ tıkla, tanıma göz at(go to definition) de, 32 bitlik olduğu otomatikmen çıkacaktır.max ve min değerleri de yazar.
            ya da sadece int yazısının üzerine gel yine 32 bitlik veri aralığı olduğu belirecektir ekranda
            int sayi=3500000;
            int sayi=-3500000;
            */

            /*
            SBYTE
            8 bitlik işaretli yer kaplar. (2^8)
            -128 ile 127 arasında değer alır

            SHORT
            16 bitlik işaretli yer kaplar (2^16)
            -32768 ile 32767 arasında değer alır

            USHORT
            16 bitlik işaretsiz yer kaplar (2^16)
            0 ile 65536 arasında değer alır

            LONG
            64 bitlik işaretli sayılar için kullanılır. (2^64)
            -9.223.372.036.854.775.808 ile + 9.223.372.036.854.775.807 arasında değer alır
            Çok elzem durumlar dışında long kullanılmamalı çünkü çok yer kaplıyor

            ULONG
            64 bitlik işaretsiz sayılar için kullanılır. (2^64)
            0 ile +18.446.744.073.709.551.615 arasında değer alır.


            TEMEL REEL SAYI TÜRLERİ(ondalıklı sayı da var içlerinde)

            FLOAT
            32 bitlik reel değerleri saklamak için kullanılır. 
            float f = 3.12f; veya float f = 3.12F


            DOUBLE
            64 bitlik reel değerleri saklamak için kullanılır. 
            double a = 3.12; veya double a = 3.12D;
            tam sayılar da sonlarına .0 konarak double şeklinde yazılabilir:
            double sayi=11.0;


            DECİMAL
            128 bitlik reel değerleri saklamak için kullanılır. 
            decimal a = 3.12m; veya decimal a = 3.12M;


            TEMEL VERİ TÜRLERİ

            BOOL
            Doğru veya Yanlış (true veya false) değerlerini saklamak için kullanılır. 
            Genellikle karşılaştırma işlemlerinde başvurulur. 
            bool sonuc = false;


            CHAR
            Tek bir karakter saklamak için kullanılır. 16 bitlik alan kaplar. 
            Burada char tipi değişkene atanan değer tek tırnaklar (‘ ‘) arasına yazılır
            char c=‘A’;
            char a='\u0041'; //Unicode kodu 41 //olan //karakter (A harfidir) a değişkenine atanıyor.
            char d=(char)65; // Ascii kodu 65 olan karakter (A harfidir) d değişkenine atanıyor. 


            STRİNG
            Metinsel verileri saklamak için kullanılan değişken tipidir. 
            Değer ataması yapılırken değer çift tırnak (“ ”) işareti arasında yazılır.
            string isim=“Ahmet Mehmet”

            STRİNG BİÇİMLENDİRME

            Interpolated String
            string isim = "Cihan";
            string msg = $"Hello {isim,10}";
            Console.WriteLine(msg);

            Composite String
            Console.WriteLine("İsminiz:{0}",isim);


            Değişkenlerin Faaliyet Alanları:

            Değişkenler tanımlandıkları bloklar(yani süslü parantezler) arasında değerlerini korurlar, yani kullanılabilirler.
            ->static olarak tanımlanmış değişkenler program sonlanana kadar değerlerini korurlar.
            ->const olarak tanımlanan değişkenler program boyunca değerlerini korurlar.

            */


            /*
             50 değerini aşağıdaki 4 veri tipiyle de temsil edebiliriz ancak en mantıklısı byte kullanmak çünkü bellekte en az yer kaplayan odur

            byte s1=50;
            short s2=50;
            int s3=50;
            long s4=50;
            */

            //kısayol: windows + L: ekranı kilitler


            /*
            bit: 0 ve 1'lere bit denir.Büyüklük birimidir.En küçük birimdir.
            Bir harf, 16 bitlik yer kaplar.
            8 bit: 1 byte
            1024 byte: 1 kb(kilobyte)
            1024 kb: 1 mb(megabyte)
            1024 mb: 1gb(gigabyte)
            1024 gb: 1 tb(terabyte)
            2li sayı sistemi: binary, 0 ve 1
            10 tabanlı sayı sistemi: decimal(desımıl)
            0-255 aralığı 10 tabanındadır.
            google'a binary(2li sayı sistemi) to decimal(10 tabanlı sayı sistemi) converter yazarsan online dönüştürücüler var
            bitleri decimal'a çevirince neden 0-255 aralığında olduğunu anlayabiliyoruz
            8 bit= 2^8(2 üzeri 8) demek yani 256(0dan 255e kadar 0 ve 255 dahil yani 256 sayıyı tutabilir demek bu)
            */
            string sayi1 = "50"; byte number=Convert.ToByte(sayi1);
            int sayi = int.Parse(Console.ReadLine());
            //KULLANICIDAN VERİ ALMA

            //Console.WriteLine("İsminizi Girin:");
            //sadece yukarıdaki kodu yazarsak ekrana yazı yazdırmış oluruz. kullanıcı kendi ismini giremez
            //Ama kullanıcının girdiği değeri okuyan bir metot kullanırsak kullanıcıdan veri alabiliriz:
            //Console.ReadLine();
            //Console class'ı içindeki ReadLine metodunu kullanmış olduk yukarıda
            //şunu yapalım, readline ile veriyi okuyup o veriyi bir değişkene aktarıp cevap olarak ismini söyleyip hoş geldin yazdırayım ekrana:
            //ReadLine metodu, okuduğu veriyi string veri tipinde bize geri verir.
            //yani ReadLine metodunun önüne string tipinde bir değişken tanımlayabilirim:

            //string isim = Console.ReadLine();
            //yukarıdaki kodda; kullanıcı isim olarak hangi değeri girerse konsolda,o değer aktarılsın dedik.
            //ReadLine'ın verdiği stringi isim değişkenine aktardık yani
            //Değişkenlere veri ataması yaparken metotların ürettiği sonuçları da alıp atama yapabiliyoruz
            //metotun geri dönüş tipine dikkat etmeliyiz.
            //ReadLine metotu geriye string döner.

            //Console.WriteLine("Soyadınızı Girin:");
            //string soyad = Console.ReadLine();
            //Console.WriteLine($"Hoşgeldin {isim} {soyad}");


            //string isim = "Ahmet";
            //var sayi = 5.4m;
            //var sayı = 100;
            //var harf = 'A';
            //string soyad = "Mehmet";
            //Console.WriteLine("merhaba " + isim + " " + soyad);   //ekrana merhaba ahmet mehmet yazdırır bu kod
            //Console.WriteLine("Merhaba {0} {1}",isim,soyad);      //ekrana merhaba ahmet mehmet yazdırır ama bu daha tercih edilir olan yazım şekli(yukarıdaki koda kıyasla)
            //Console.WriteLine($"Merhaba {isim}{soyad}");          //kodun başına dolar işareti eklemesek ekrana merhaba isim soyad yazdırırdı, biz onu istemiyoruz o yüzden dolar işareti ekledik koda(en efektif kullanım bu, kodun başına dolar koymak yani)
            //metnin içine değişken yazdırmak için dolar işareti kullanılır.

            //kısayol: altgr+4= $ işareti
            //kısayol: altgr+7= süslü parantez aç 
            //kısayol: altgr+0= süslü parantez kapat
            //kısayol: ctrl+k+d= kodları düzenler
            //kısayol: ctrl+b= built yani derleme c#dan ms-ıl'e derler
            //kısayol: ctrl+f5= hata ayıklama(debug) olmadan programı çalıştırır







            //24.10.23(3. ders)
            //OPERATÖRLER
            //Önceden tanımlanmış olan ve birtakım matematiksel veya mantıksal işlemleri gerçekleştirmek için kullanılan özel karakterlerdir.
            // +, -, *, /, ++ (1 artırır), -- (1 azaltır), % (bir sayının bir sayıya bölümünden kalanı veren mod operatörüdür)
            //mesela: a + b = c işleminde a ve b OPERANTLAR, + yani artı işareti OPERATÖR ve c de SONUÇtur.
            // a ve b sayısal ifadeyse yukarıdaki işlem sonucu toplanır
            // a ve b metinsel yani string bir ifadeyse de birleştirir.

            //Aritmetiksel Operatörler
            //Atritmetiksel, matematiksel işlemler için kullanılır.
            //byte a=10; string s;
            //byte b = 3, c = 20;
            //int d = a + c * b;
            //normalde kodlar soldan sağa doğru çalışır ama nurada çarpım işleminde öncelik olduğu için matematikte,
            //önce c ve b'yi çarpıp sonra a ile ekledi.
            //Sonuçta d = 70 olur.

            //Son ek olarak ++ eklersek:  a=4 b=a++ ise a=5 b=4 olur
            //kodu soldan sağa doğru okumalıyız. Bu durumda yukarıda b=a++ kodunda önce b=a yazılı. o zaman a'nın değerini b'ye aktardık. a=4 olduğu için b de 4 olur.
            //devam ediyoruz a++ yazıyor kodun devamında. yani a'nın değerini 1 artır diyor. o zaman a=5 olur
            //aşağıdaki de aynı mantık:
            //Son ek olarak -- eklersek: a=4 ve b=a-- ise a=3 b=4 olur
            //aşağıdaki kodlarda ise durum farklı çünkü mesela b=++a diyor. b==++ diye bir atama yapamayız mantıksız olur. o yüzden önce 1 artırıp sonra atıyor:
            //Ön ek olarak ++ eklersek: a=4 ve b=++a ise a=5 b=5 olur
            //Ön ek olarak -- eklersek: a=4 ve b=--a ise a=3 b=3 olur


            //Karşılaştırma operatörleri;

            //Mantıksal karşılaştırmalar için kullanılır.
            //Ürettiği sonuç değerleri true ya da false’dur.
            // <,>, <=,>=, ==(eşit midir diye bakılır); !=(eşit değil midir diye bakılır),   as ve is(bunları sonra öğrenicez)
            //byte a=10; 
            //byte b = 3, c = 20;
            //Console.WriteLine(a == b);
            //Yukarıdaki kodun sonucu;  a=10 ve b=3 olduğundan a, b'ye eşit olmadığından FALSE yazar



            //Mantıksal Operatörler;

            //Mantıksal karşılaştırmalar için kullanılır
            // ||(veya), &&(ve), !(değil, yani false'u true; true'yu false yapar)
            // kısayol: altgr+< işareti yani |


            /*

            O = FALSE 
            1 = TRUE
            0 && 0 = 0
            0 && 1 = 0
            1 && 0 = 0
            1 && 1 = 1
            1 && 0 && 1 = 0
            kısayol: altgr+> işareti yani |
            0 || 0 = 0
            0 || 1 = 1
            1 || 0 = 1
            1 || 1 = 1
            1 || 0 || 0 = 1

            */

            //byte a=10; string s;
            //byte b = 3, c = 20;
            //Console.WriteLine((!(a == b) && (b == 3)));
            //Bu işlemin sonucunda ekrana true yazar. 
            //Çünkü a eşit midir b ye diyor, değildir yani false.
            //ama başında ünlem var dolayısıyla true olur. b eşit midir 3'e, evet. dolayısıyla true'dur.
            //true ve true ekrana true yazdırır.


            /*
            Atama ve İşlemli Atama Operatörleri

            Bir değişkene operatörün sağ tarafında bulunan değeri atamak için kullanılır. Atama işlemi operatörü “=“ dir.
            Atama İşlemleri: 
            int num1 = 5;
            int result = num1 * 6; 
            result = 30;  olur
            int num1, num2, num3 = 5;   burada num1 ve num2’ye değer atanmadı ama num3= 5 oldu.
            Aynı tipte değişkenler, aynı satırda; aralarına virgül konarak tanımlanabilirler
            int i, j = 5, k;   i ve k’ya değer atanmadı; j ise  5 oldu
           
            */



            //double maas = 5000;
            //maas=maas+1000; ile maas += 1000; aynı şeydir
            //maas += 1000; kodu daha kısa olduğu için bunu tercih etmeliyiz
            //+= (üstüne ekle operatörü) operatörü çok sık kulllanılır
            //Console.WriteLine(maas);
            //Heriki işlemin sonucunda da maas değişkenine 6000 değeri atanacaktır.


            //Özel Amaçlı   Operatörler:

            //Bazı özel işlemlerde kullanılırlar.
            // ?: Operatörü: c#'da 3 operand alan tek operatördür. Çok kullanışlı bir operatördür
            //Bu nedenle adına genelde ternary operatör de denir.
            //Kullanımı:
            //koşul? Doğru_değer : yanlış_değer
            //Burada koşul ifadesi true gelirse doğru değer, false gelirse yanlış değer döndürülmektedir.
            // () Tür Dönüştürme Operatörü: (tür)ifade;
            // [] Dizi elemanlarına ulaşmak için kullanılan operatör.
            
            //Nokta (.) Operatörü
            //Bir sınıfın ya da bir yapının elemanlarına ulaşmak için kullanılır. Örneğin console sınıfının writeline metoduna ulaşmak için console.writeline yazarız.



            // ++ operatörü 1 operand alır çünkü bir sayıyı 1 artırır mesela
            // - operatörü 2 operand alır mesela. 
            // if else ile aynı mantıkla çalışır, if else'in kısa versiyonudur
            //soru işareti= ise iki nokta üst üste= değilse anlamına gelir

            //int sayi1 = 10;
            //int sayi2 = 20;

            //string sonuc = sayi2 > sayi1 ? "Sayı 2 büyüktür " : "Sayı 1 büyüktür ya da sayılar eşittir";
            //yukarıdaki kodun anlamı; sayi2 sayi1'den büyükse sonuc değişkenine Sayı 2 büyüktür değerini ata
            //değilse sonuç değişkenine sayı 1 büyüktür ya da sayılar eşittir değerini ata.
            //Console.WriteLine(sonuc);
            //sonuçta Sayı 2 büyüktür, yazdırılır ekrana
            //Yani sayi2>sayi1 true ise ?'nin sağındaki değer atanır
            //false ise :'nın sağındaki değer atanır
            //burada sadece 2 durum olabilir. mesela sayi1=sayi2 ise gibi bir 3.seçenek ekeleyemiyoruz
            //çoklu durumlarda if else yapısını kullanıcaz ileride

            //kısayol: editörün önerdiği şekilde kodu tamamlamak için tab tuşuna bas
            //kısayol: cw yaz ve tab tuşuna bas -> Console.WriteLine(); kodu yazdırılır ekrana
            //geçen hafta isminizi giriniz, soyadınızı giriniz diye bi kod yazmıştık. aşağıya kopyalıyorum o kodu;


            //Console.WriteLine("İsminizi Girin:");

            //string isim = Console.ReadLine();
            //Console.WriteLine("Soyadınızı Girin:");
            //string soyad = Console.ReadLine();
            //Console.WriteLine($"Yaşınızı Giriniz");
            //byte yas = Console.ReadLine();
            //yukarıdaki kodlar hata verir çünkü ReadLine metodu çalıştıktan sonra string döner, biz byte yazdık
            //c# tip güvenliği (type safety) sağlayan bir programlama dilidir. Bu özellik veri tipine uygun olmayan tipte değer
            //atanmasının önüne geçer. Eğer bu değeri uygun hale getirerek atamak istersek TÜR DÖNÜŞÜMÜ(Type casting) yapmamız gerekir.


            //TÜR DÖNÜŞÜMLERİ(Type Casting)

            //byte sayi = 20;
            //int number = sayi;  
            //burada byte veri tipinde bir değeri, int veri tipinde bir değere atadık ama tip güvenliği hata vermedi, neden?
            //çünkü int, byte'ı da kapsadığı için her türlü byte değerini alabilir
            //yani byte sayi değeri ne olursa olsun max 255 olabilir, int zaten o değeri kapsar
            //BURADA yapılan tür dönüşümünü biz yapmadık, arka planda kendisi tür dönüşümünü yaptı (byte'ı int'e çevirdi)
            //buna Implicit Type Casting(biz açık açık yapmadan aypılan tür dönüşümü, arka planda kendi kendine yapılan tür dönüşümü) denir.


            //int sayi = 30;
            //byte number = sayi;
            //dersek hata verir çünkü byte, intten küçük
            //sayının veri tipi int oldu bu sefer de
            //int'i bu şekilde byte'a atamak istersek hata verir haliyle
            //ama int sayi'nın değeri 20, neden byte'a atayamayalım ki dersen
            //program çalışmazken int'in değerine bakmaz kod editörü da ondan
            //değer ataması ancak derleme zamanında yapılır yani biz programı çalıştırdığımızda yapılır
            // byte number = sayi; kodundaki sayi'ninn altı kırmızı çizili
            // sayi'nin üstüne gelip beklersek olası düzeltmeleri gör seçeneği çıkar
            //tıklarsan ona, aşağıda göreceğimiz byte number = (byte)sayi; düzeltmesini önerir
            //ki bu harika bişey, kodu bile düzeltiyor adam :D


            //int sayi = 20;
            //byte number = (byte)sayi;
            //yazarsak sorun kalmaz artık
            //Burada yapılan tür dönüşümünü biz yaptık, buna Explicit Type Casting(açık açık yapılan tür dönüşümü) denir.


            //büyük tür'den küçük türe dönüşümlerde bir risk vardır
            //Risk: Değer kaybı
            //bu riskin nasıl ortaya çıktığına ve bu riski nasıl çözeceğimize bakalım:

            //int sayi = 256;
            //byte number = (byte)sayi;  //explicit type castinglerdeki değer kaybına dikkat etmek gerekir
            //Console.WriteLine(number);
            //bu kod ekrana 1 yazdırır, 257 yazsak 2 yazdırırdı bu böyle 255'e kadar devam ederdi tekrar sıfırlardı 255'ten sonra
            //çünkü byte maksimum 255 değerini alır.

            //Checked ve Unchecked Operatörleri
            //Bilinçli tür dönüştürme esnasında hatalı tür dönüşümünü engellemek amacıyla kullanılır.


            //kısayol: checked içine almak istediğin kodları seç ve
            //ctrl+k+s(kodları sar'dan aklına gelsin) tıkla.açılan pencereden 'checked'i seçersen aşağıdaki kod:
            //int sayi = 256;
            // byte number = (byte)sayi;

            //şu hale gelir;
            //checked
            // {
            //    int sayi = 256;
            //    byte number = (byte)sayi; (burada sarı alt metinli hata oldu. checked yapıldıktan sonra. 256 olduğu anda int sayi değeri,
            //checked sayesinde kurtuluyoruz hata yapmaktan, checked tür dönüşümünü kontrollü bir şekilde yapar. 257 yazsak mesela değere
            //program hata verecek ve dönüşüm yapmayacak
            // }

            //String'den değer türlerine dönüşüm:

            //string sayi = "25";
            //byte number = sayi; hata alırsın, burada sayi değişkenini byte'a dönüştürmemiz gerek
            //string sayi = "25";
            //byte number =(byte) sayi; şeklide bir dönüşüm string'lerde olmuyor
            //parantez açıp beklersen  byte.convert.tobyte(bool bla bla) diye bi seçenek çıkıyo 
            //string veri tipinde bir değişkeni byte', double'a, flow'a vs dönüştürmek için
            //2 yöntem var
            //ilki: convert class'ındaki metotları kullanmak

            //string sayi = "25";
            //byte number =Convert.ToByte(sayi);
            //Convert.To yazınca bisürü seçenek çıkıyor, ok ile aşağı inersen 19 kullanımı var
            //sonra parantez aç bekle, metot kullanırken parantez açıp bekle her zaman
            //öneri olarak sayi, gelecek. tab tab yaparsan otomatik yazar yukarıda gördüğün gibi
            //toByte metodu üstüne gelip beklersen byte.Convert.... yazar
            //demek ki toByte metodu geriye byte dönüyormuş
            //ToByte metodu parametre olarak bool ister. Yani bana bool gönder sana byte göndereyim diyor :D
            //sayi stringini byte'a dönüştürerek number'a atamış olduk

            //2.yol:
            //string sayi = "25";
            //int number = int.Parse(sayi);

            //parse metodunun geri dönüş tipi int imiş
            //parse'ın üzerine gelip beklersen en başta yazan, geri dönüş tipidir
            //parametre olarak da string istiyormuş. Yine parse'ın üzerine gelip bekleyince
            //parantez içinde yazandan anladık onu da.
            //6 tane daha kullanımı varmış parse'ın, onu da aynı yerden öğrendik
            //neredeyse hepsi stringe çeviriyor
            //parse metodunun uzmanlık alanı stringi, ilgili veri tipilerine çevirmektir
            //elimizde bir string varsa parse kullanmak, convert'teki metodlara göre daha hızlı çalışır!
            //çünkü parse daha performanslı bir metodtur.
            //byte.number = int.parse bla bla hata verirdi
            //byte.number = byte.numberparse bla bla çalışırdı

            //Console.WriteLine("İsminizi Girin:");
            //string isim = Console.ReadLine();
            //Console.WriteLine("Soyadınızı Girin:");
            //string soyad = Console.ReadLine();
            //Console.WriteLine($"Yaşınızı Giriniz");
            //byte yas = Console.ReadLine(); burada console.readline altı kırmızı çizgili ya yukarıda. hoca bunu nasıl düzelticez dedi
            //Console.Writeline($"Hoş geldiniz {isim} {soyad}");

            //byte yas... kodunu şu şekilde değiştirirsek hata vermez artık;
            //byte yas = byte.Parse(Console.Readline());  Readline metodu string döndüğü için tür dönüşümü yapmamız gerekti burada
            //kullanıcıdan aldığım değeri byte.Parse ile byte'a dönüştürdüm ve yas değişkenine atadım
            //istersen en yukarıdaki kodu da düzeltebilirsin istersen

            //kullanıcıdan 2 tane sayı alalım, 1.sayıyı giriniz, 2.sayıyı giriniz diyerek
            //aldığımız sayılar int olsun;
            //sonra girdiğiniz sayıların toplayıp şudur diyelim:

            //cerenin kodu;
            //Console.WriteLine("1. sayıyı girin:");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("2. sayıyı girin:");
            //int sayi2 = int.Parse(Console.ReadLine();
            //int sonuc = sayi1 + sayi2;
            //Console.WriteLine("Sonuç:");
            //int sayi1 + int sayi2= int sonuc;
            //hoca dedi ki: ekstra sonuc değişkeni tanımlamışsın, buna gerek yoktu

            //hocanın kodu;
            //Console.WriteLine("1. sayıyı girin:");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("2. sayıyı girin:");
            //int sayi2 = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Girilen sayıların toplamı: {sayi1 + sayi2}");
            //kısayol: altgr+4= $

            //başka bir proje açalım burayı kapatıp
            //solution'a yeni bir proje eklicez
            //solution'lar içlerinde 1'den fazla projeyi tutabilirler
            //solution explorer'ı yani çözüm gezginini açabiliriz sağda
            //çözüm gezgini sağda aç, Gazi.HelloWorldAppSube1'e sağ tıkla ekle de yeni proje de
            //konsol uygulamasını seç(windows, linux vs hepsini içereni)
            //Proje adını Gazi.KararYapilariApp olarak ver.
            // .NET 7.0 ı seç, üst düzey deyimler kullanmayı da tikle
            //yukarıda any cpu yanından hangi projenin başlangıç projesi olmasını istiyorsan onu seç.
            //bold yani kalın beyaz olan ana projedir (sağda çözüm gezgininde) ana projeyi set as start project diyerek ayarlayabiliriz.
            //ya da yukarıda any cpu yanındaki seçenekten ayarlayabilirsin
            //buraya geri dönmek için sağda çözüm gezgininden Gazi.HelloWorldAppSube1 içindeki program.cs'ye tıklayabilirsin.
            //hangi proje başlangıç projesi olsun istersen onun ismine sağ tıkla sağdaki menüde ve başlangıç projesi olarak ayarla de
            //başlangıç projesi bold yani kalın görünür sağda
            //Gazi.KararYapilariApp içindeki Program.cs'ye geçiyoruz





















        }
    }
}


















