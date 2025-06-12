using System;
using System.Collections.Generic;

namespace Bibliothèque
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            Dictionary<int, string> books = new Dictionary<int, string>();

            Console.WriteLine("Bonjour, que souhaitez vous faire?");
            Console.WriteLine("1 = Encoder un nouveau livre");
            int.TryParse(Console.ReadLine(), out int instructUser);
            if (instructUser == 1)
            {
                //méthode newBook
            }


            //Méthode newBook
            books.Add(num, Console.ReadLine());
                num + 1;
        }
    }
}
