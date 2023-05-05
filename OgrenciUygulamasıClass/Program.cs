namespace OgrenciUygulamasıClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool kontrol = true;
            Ogrenci ogrenci1 = new Ogrenci(7819 , "İrem" , "İlgin" , 95 , 85 , 78 , "İstanbul Bilgi Üniversitesi");

            Console.WriteLine("Uygulamamıza Hoşgeldiniz... Yapmak istediğiniz işlemi seçiniz");
            IslemleriGoster();


            while (kontrol) 
            {

                string secim = Console.ReadLine();

                switch (secim)
                {
                        case "1":
                        ogrenci1.OgrenciBilgileriGoster();
                        break;

                        case "2":
                        double ogrenciOrtalama =  ogrenci1.OgrenciNotuBul();
                        Console.WriteLine("Öğrenci Ortalaması: " + ogrenciOrtalama);
                        break;


                        case "3":
                        ogrenci1.OkulGetir();
                        break;

                        
                        case "4":   
                        kontrol = false;    
                        break;
                }

            }
           
        }


        static void IslemleriGoster()
        {
            Console.WriteLine("1- Öğrenci Bilgileri göster");
            Console.WriteLine("2- Öğrenci Ortalamasını Göster");
            Console.WriteLine("3- Öğrenci Okulunu Göster");
            Console.WriteLine("4- Çıkış yap");
        }
    }
}