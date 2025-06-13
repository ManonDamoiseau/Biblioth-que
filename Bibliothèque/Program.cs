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
            Dictionary<int, string> library = new Dictionary<int, string>();

            while (over == false)
            {
                //Méthode menu
                Methodes.Menu();
                int.TryParse(Console.ReadLine(), out int instructUser);

                switch (instructUser)
                {
                    case 1:
                        //Ajouter un livre
                        Methodes.newBook();
                        library.Add(num, Console.ReadLine());
                        num ++;
                        Methodes.backMenu();
                        break;

                    case 2: //Montrer tous les livres
                        
                        Methodes.showAllBooks();
                        foreach (var book in library)
                        {
                            Console.WriteLine($"id : {book.Key} | Titre livre : {book.Value}");
                        }
                        Methodes.backMenu();
                        break;

                    case 3: // Modifier un livre
                        Methodes.ModifBook();
                        int.TryParse(Console.ReadLine(), out int index);
                        if (library.ContainsKey(index))
                        {
                            Console.WriteLine("Quel est le nouveau titre pour ce livre?");
                            library[index] = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Cet index n'existe pas");
                        }
                        Methodes.backMenu();
                        break;

                    case 0: // Sortir du programme
                        over = true;
                        break;

                }
            }
        }
    }
}

