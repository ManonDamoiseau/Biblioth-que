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
            
            Dictionary<string, string> library = new Dictionary<string, string>();

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
                        string titre = Console.ReadLine().Trim();
                        if (titre == "")
                        {
                            Console.WriteLine("Tu dois entrer un titre");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Entre le nom de l'auteur");
                            library.Add(titre, Console.ReadLine());
                        }
                        Console.Clear();
                        break;

                    case 2: //Montrer tous les livres
                        
                        Methodes.showAllBooks();
                        foreach (var book in library)
                        {
                            Console.WriteLine($"Titre : {book.Key} | Auteur.ice : {book.Value}");
                        }
                        Methodes.backMenu();
                        break;

                    case 3: // Modifier auteur d'un livre
                        Methodes.ModifBook();
                        string index = Console.ReadLine();
                        if (library.ContainsKey(index))
                        {
                            Console.WriteLine("Quel est l'auteur.ice pour ce livre?");
                            library[index] = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Ce livre n'existe pas");
                        }
                        Methodes.backMenu();
                        break;

                    case 4: // Supprimer un livre
                        Methodes.RemoveBook();
                        string remove= Console.ReadLine();
                        remove.Trim();
                        library.Remove(remove);
                        break;

                    case 0: // Sortir du programme
                        over = true;
                        break;

                }
            }
        }
    }
}

