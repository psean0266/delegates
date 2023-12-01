using System;
using System.Linq;

namespace delegates
{
     class Program
    {
        public delegate string ValidationChaine(string s);
        static void Main(string[] args)
        {
            // Demander le nom de l'utilisateur 
            // Demander le numero de telephone de l'utilisateur

            string nom = DemanderChaineUtilisateur("Quel est votre nom", CheckValidationNom);

            // 0610101010
            string tel = DemanderChaineUtilisateur("Quel est votre numero de téléphone ?", CheckValidationTel);

            Console.WriteLine();
            Console.WriteLine("Bonjour "+nom+ " , vous êtes joignable au " + tel);
        }

        static string DemanderChaineUtilisateur(string message, ValidationChaine fonctionValidation = null)
        {
            Console.WriteLine(message+ " ");
            string response = Console.ReadLine();   
           // string erreur = CheckValidationNom(response);

            if(fonctionValidation != null)
            {
                string erreur = fonctionValidation(response);

                if (erreur != null)
                {
                    Console.WriteLine("ERREUR : " + erreur);
                    return DemanderChaineUtilisateur(message, fonctionValidation);
                }
                
            }
            return response;

        }

        static string CheckValidationNom (string s)
        {
            if(string.IsNullOrEmpty(s))
            {
                return "le nom ne doit pas être vide";
            }
            if (s.Any(char.IsDigit))
            {
                return "le nom ne doit pas contenir des chiffres";
            }
            return null;
        }

        static string CheckValidationTel(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return "le nom ne doit pas être vide";
            }

            if(s.Length != 10) 
            {
                return "le numero de téléphone doit contenir 10 chiffres";
            }

            if (!s.All(char.IsDigit))
            {
                return "le numero de téléphone doit contenir uniquement des chiffres";
            }
            return null;
        }
    }
}
