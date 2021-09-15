using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategorietiketi = "Kategori";

            int OgrenciSayisi = 32000;
            double FaizOrani = 1.45;
            bool SistemeGirisYapmisMi = true;

            double dolarDun = 7.55;
            double dolarBugun = 7.55;


            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");

            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }


            if (SistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }


            Console.WriteLine(kategorietiketi);




        }
    }
}
