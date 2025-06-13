
using static System.Reflection.Metadata.BlobBuilder;
using System;
using System.Runtime.InteropServices;

namespace Bibliotheque.Models
{
    public class Methodes
    {


        public static void Menu() //Afficher le menu
        {
            Console.Clear();
            Console.WriteLine("********** Bonjour, que souhaitez vous faire? **********\n");
            Console.WriteLine("1 = Encoder un nouveau livre");
            Console.WriteLine("2 = Voir tous les livres de la bibliothèque");
            Console.WriteLine("3 = Modifier un livre");
            Console.WriteLine("0 = Supprimer la bibliothèque");
        }

        public static void backMenu() // Retour au menu
        {
            Console.WriteLine("(Tapes sur une touche pour retourner au menu)");
            Console.ReadKey();
            Console.Clear();
        }
        #region Instruction menu
        public static void newBook() // 1 = Ajouter un livre
        {
            Console.Clear();
            Console.WriteLine("====== NOUVEAU LIVRE ======\n");
            Console.WriteLine("Quel est le titre du livre?");

        }
        public static void showAllBooks() // 2 = Montrer tous les livres
        {
            Console.Clear();
            Console.WriteLine("====== LIVRE(S) DE LA BIBLIOTHEQUE ======\n");

        }

        public static void ModifBook() // 3 = Modifier un livre
        {
            Console.Clear();
            Console.WriteLine("====== MODIFICATION D'UN LIVRE ======\n");
            Console.WriteLine("Indique l'index (le numéro) du livre à modifier");

        }
        #endregion
    }

}
