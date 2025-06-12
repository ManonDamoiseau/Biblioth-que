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
            int num = 1;

            while (over == false)
            {
                Dictionary<int, string> books = new Dictionary<int, string>();

                //Méthode menu
                Methodes.Menu();
                int.TryParse(Console.ReadLine(), out int instructUser);
                switch (instructUser)
                {
                    case 1:
                        //méthode newBook
                        Console.Clear();
                        Methodes.newBook();
                        books.Add(num, Console.ReadLine());
                        num += 1;
                        break;

                    case 2:
                        //méthode showAllBooks
                        //Méthode montrer un livre
                        Console.Clear();
                        Methodes.showAllBooks();
                        foreach (KeyValuePair<int, string> kvp in books)
                        {
                            Console.WriteLine($"{0} {1}, kvp.Key, kvp.Value");
                        }
                        break;

                    case 0:
                        over = true;
                        break;

                }
            }
        }
    }
}

