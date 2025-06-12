
using static System.Reflection.Metadata.BlobBuilder;
using System;

namespace Bibliotheque.Models
{
    public class Methodes
    {
        //Afficher le menu
            public static void Menu()
            {
                Console.WriteLine("Bonjour, que souhaitez vous faire?");
                Console.WriteLine("1 = Encoder un nouveau livre");
                Console.WriteLine("2 = Voir tous les livres de la bibliothèque");
                Console.WriteLine("0 = Supprimer la bibliothèque");
            }
            
            public static void newBook()
            {
                Console.WriteLine("====== NOUVEAU LIVRE ======\n");
                Console.WriteLine("Quel est le titre du livre?");
                
            }
        public static void showAllBooks()
        {
            Console.WriteLine("====== LIVRE(S) DE LA BIBLIOTHEQUE ======");
            
        }
    }
}
