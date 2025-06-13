using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Bibliotheque.Models;

namespace Bibliothèque
{
    class Program
    {
        static void Main(string[] args)
        {

            bool over = false;
            int num = 0;
            Dictionary<int, string> library = new Dictionary<int, string>();

            while (over == false)
            {
                

                //Méthode menu
                Console.Clear();
                Methodes.Menu();
                int.TryParse(Console.ReadLine(), out int instructUser);
                switch (instructUser)
                {
                    case 1:
                        //méthode newBook
                        Console.Clear();
                        Methodes.newBook();
                        library.Add(num, Console.ReadLine());
                        num += 1;
                        break;

                    case 2:
                        //méthode showAllBooks
                        //Méthode montrer un livre
                        Console.Clear();
                        Methodes.showAllBooks();
                        foreach (var element in library)
                        {
                            Console.WriteLine($"{element.Key}, {element.Value}");
                        }



                        Console.ReadKey();
                        break;

                    case 0:
                        over = true;
                        break;

                }
              


            }
        }
    }
}

