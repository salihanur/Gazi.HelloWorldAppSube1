namespace Gazi.DizilerAppSube1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //DİZİLER yani ARRAY 2.01.24

            //int[] numbers = new int[3];
            //numbers[0] = 10;
            //numbers[1] = 20;
            //numbers[2] = 30;


            //referans: heap bölgesindeki değerlerin adreslerini tutan yapılardır.
            //dizideki elemanları tek tek şu şekilde yazdırabiliriz:

            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);

            //ama bu şekilde yazarsak kod tekrarına girmiş , kodu gereksiz uzatmış oluruz.

            //Console.WriteLine(numbers); dersek de tutar numberın ne olduğunu yazar, içindeki elemanları yazdırmaz!

            //for (int i = 0; i<3; i++)    //i<3 yerine numbers.Lenght de yazabildirdik hatta bunu kullanmak daha mantıklı
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //eğer değerler önceden biliniyorsa, dizi oluşturmanın başka bir yolu, kullanıcıdan değer alacağımız zaman bu yöntemi kullanamayız onun için ilk yöntem daha mantıklı
            //burada ise değerleri kendimiz atıyoruz;

            //int[] number = { 50, 20, 30 };

            //Array.Sort(number);  //küçükten büyüğe sıralar elemanları bu kod, ekrana 20,30,50 yazdırır bu kod

            //for (int i = 0;i<number.Length;i++)
            //{
            //    Console.WriteLine(number[i]);
            //}

            //How mnay names do you want to sort? (kaç adet isim sıralamak istiyorsunuz?)
            //kullanıcı kaç derse ona göre mesela
            //Enter 1. name: Ali
            //Enter 2. name:Veli
            //Enter 3. name: Deli
            //Sorted names: (alfabetik olarak sıralanmış isimler)
            //1-Ali
            //2-Veli
            //3-Deli

            //Console.WriteLine("How many names do you want to sort?");
            //byte count =byte.Parse(Console.ReadLine());
            //string[] names = new string[count];   //burada {} koyamayız çünkü değerleri bilmiyoruz, kullanıcıdan alıcaz değerleri. o yüzden new dedik burada!
           
            //for (int i = 0; i < count; i++)
            //{
            //    Console.WriteLine($"Enter {i+1}.Name:");
            //    names[i] = Console.ReadLine();

            //}

            //Array.Sort(names);
            //Console.WriteLine("Sorted names");
            //for(int i = 0; i<count; i++)
            //{
            //    Console.WriteLine($"{i + 1}-{names[i]}");
            //}

            //kullanıcının girdiği sayıda rastgele sayıyı sıralayıp ekrana yazdıralım;

            //Console.WriteLine("How many numbers do you want to sort?");
            //byte count = byte.Parse(Console.ReadLine());
            //int[] numbers = new int[count];  //count elemanlı int tipinde dizi oluşturduk)

            //Random rnd = new Random();
            
            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    numbers[i] = rnd.Next(1000);
            //}

            //Array.Sort(numbers);

            //Console.WriteLine("Sorted numbers:");

            //for (int i = 0;i < numbers.Length; i++)
            //    Console.WriteLine(numbers[i]);

            //ders sonu


            //ödev

            Console.WriteLine("How many numbers do you want to sort?");
            byte count = byte.Parse(Console.ReadLine());

            int[] numbers = new int[count];
            Random rnd = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                int randomNumber;
                do
                {
                    randomNumber = rnd.Next(1000);
                } while (Array.IndexOf(numbers, randomNumber) != -1);

                numbers[i] = randomNumber;
            }

            Array.Sort(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            
            //



















        }
    }
}
