using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Chapö
{
    class Program
    {
        private static string key;
        private static string key2;
        private static string key3;

        static void Main(string[] args)
        {

            while (key != "4")
            {
                Console.Clear();
                Console.WriteLine("1. Créer le match de samedi prochain");
                Console.WriteLine("2. Consulter l'historique");
                Console.WriteLine("3. Consulter la base de contacts");
                Console.WriteLine("4. Quitter l'application");
                key = Console.ReadLine();
                if (key == "1")
                {
                    while (key2 != "0")
                    {

                        Console.Clear();
                        Console.WriteLine("0. Retour");
                        Console.WriteLine("1. Créer un match");
                        Console.WriteLine("2. Afficher récapitulatif du match en cours");
                        key2 = Console.ReadLine();
                        if (key2 == "2")
                        {
                            while (key3 != "0")
                            {
                                Console.Clear();
                                Console.WriteLine("0. Retour");
                                Console.WriteLine("récapitulatif du match en direct...");
                                key3 = Console.ReadLine();
                            }
                        }
                    }
                }
                else if (key == "2")
                {
                    Console.Clear();
                    Console.WriteLine("0. Retour");
                    Console.WriteLine("Voici les résultat du match précédent : ");
                    Console.ReadLine();
                }
                else if (key == "3")
                {
                    Console.Clear();
                    Console.WriteLine("1. Afficher la liste des catcheur");
                    Console.WriteLine("2. Chercher un catcheur avec un nom");
                    Console.ReadLine();
                }
                else if (key == "4")
                {
                    Console.Clear();
                    Console.WriteLine("Etes vous sure de vouoir quitter ?");
                    Console.WriteLine("1. Oui");
                    Console.WriteLine("2. Non");
                    Console.ReadLine();
                }
            }
        }
    }
}