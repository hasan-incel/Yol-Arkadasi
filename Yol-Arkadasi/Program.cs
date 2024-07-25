using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Pratik - Yol Arkadaşı : Tatil uygulamasına hoş geldiniz!");

        bool devam = true;
        while (devam)
        {
            Console.WriteLine("\nLütfen aşağıdaki lokasyonlardan birini seçiniz:");
            Console.WriteLine("1 - Bodrum (Paket başlangıç fiyatı 4000 TL)");
            Console.WriteLine("2 - Marmaris (Paket başlangıç fiyatı 3000 TL)");
            Console.WriteLine("3 - Çeşme (Paket başlangıç fiyatı 5000 TL)");
            Console.Write("Lokasyon seçiniz: ");

            // Kullanıcının girdiği lokasyonu alalım
            string lokasyon = Console.ReadLine().ToLower(); // Küçük harfe çevirip trim yaparak boşlukları temizliyoruz

            int paketFiyati = 0;

            // Kullanıcının seçtiği lokasyona göre fiyatı belirleyelim
            switch (lokasyon)
            {
                case "1":
                case "bodrum":
                    paketFiyati = 4000;
                    lokasyon = "Bodrum";
                    Console.WriteLine("Bodrum: Yalıkavak ve Türkbükü'nde beach cluba gidilebilir. Akşamda güzel bir restorantta yemek yiyebilirsiniz.");
                    break;
                case "2":
                case "marmaris":
                    paketFiyati = 3000;
                    lokasyon = "Marmaris";
                    Console.WriteLine("Marmaris: Tekne turuna katılabilir ayrıca doğa yürüşü yapabilirsiniz.");
                    break;
                case "3":
                case "çeşme":
                    paketFiyati = 5000;
                    lokasyon = "Çeşme";
                    Console.WriteLine("Çeşme: Sabah beach club'a gidebilir. Akşamda Alaçatıda eğlenebilirsiniz.");
                    break;
                default:
                    Console.WriteLine("Hata: Geçersiz lokasyon girdiniz. Lütfen belirtilen lokasyon numarasını veya ismini giriniz.");
                    continue; // Döngünün başına dönerek kullanıcıdan yeniden giriş yapmasını istiyoruz
            }

            // Kullanıcıdan kişi sayısını alalım
            Console.Write("\nKaç kişi için tatil planlamak istiyorsunuz? ");
            int kisiSayisi = int.Parse(Console.ReadLine());

            // Lokasyon ve bilgi özetini kullanıcıya gösterelim
            Console.WriteLine($"\n{lokasyon} lokasyonunda {kisiSayisi} kişi için planlanacak tatil:");

            bool gecerliUlasimSecimi = false;
            int ulasimUcreti = 0;

            while (!gecerliUlasimSecimi)
            {
                Console.WriteLine();
                Console.WriteLine("Lütfen tatiliniz için ulaşım şeklini seçiniz:");
                Console.WriteLine("1 - Kara yolu (Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL)");
                Console.WriteLine("2 - Hava yolu (Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)");
                Console.Write("Ulaşım yolu seçiniz (1 veya 2): ");
                string ulasimSecimi = Console.ReadLine();

                switch (ulasimSecimi)
                {
                    case "1":
                        ulasimUcreti = 1500;
                        gecerliUlasimSecimi = true;
                        break;
                    case "2":
                        ulasimUcreti = 4000;
                        gecerliUlasimSecimi = true;
                        break;
                    default:
                        Console.WriteLine("Hatalı giriş! Lütfen geçerli bir ulaşım seçiniz.");
                        break;
                }
            }

            int toplamFiyat =  (kisiSayisi * (ulasimUcreti + paketFiyati));
            Console.WriteLine();
            Console.WriteLine($"Toplam tatil maliyetiniz: {toplamFiyat} TL");

            Console.WriteLine();
            Console.Write("Başka bir tatil planlamak ister misiniz? (Evet/Hayır): ");
            string devamSecimi = Console.ReadLine();

            if (devamSecimi.ToLower() != "evet")
            {
                devam = false;
            }

            Console.WriteLine();
        }

        Console.WriteLine("İyi günler dileriz!");
    }
}
