using System;

namespace GenerıcsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> Isimler = new MyList<string>();
            Isimler.Add("Umit");


            Console.WriteLine(Isimler.Lenght);

        }
    }
}
