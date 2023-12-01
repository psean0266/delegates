using System;

namespace delegates
{
     class Program
    {
        static void Main(string[] args)
        {
            // Demander le nom de l'utilisateur 
            // Demander le numero de telephone de l'utilisateur

            string nom = DemanderChaineUtilisateur("Quel est votre nom");

            // 0610101010
            string tel = DemanderChaineUtilisateur("Quel est votre numero de téléphone ?");

            Console.WriteLine();
            Console.WriteLine("Bonjour "+nom+ " , vous êtes joignable au" + tel);
        }

        static string DemanderChaineUtilisateur(string message)
        {
            Console.WriteLine(message);
            string response = Console.ReadLine();   
            return response;
        }
    }
}
