using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, BirthYear = 1985, FirstName = "Umit", LastName = "Akbas", IdentityNumber = 1234556 });
            
            
            Console.WriteLine("Hello World!");
        }
    }
}
