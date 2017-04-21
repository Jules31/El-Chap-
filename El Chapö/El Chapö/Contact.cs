using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Chapö
{
    class Contact
    {
        string Nom;
        string Type_de_Catcheur;
        int Vie;
        int Attaque;
        int Defense;
        string Etat_Catcheur;


        public Personnage(string nom, string type_de_catcheur, int vie, int attaque, int defense, string etat_catcheur)
        {

            this.nom = nom;
            this.type_de_catcheur = type_de_catcheur;
            this.vie = vie;
            this.attaque = attaque;
            this.defense = defense;
            this.etat_catcheur = etat_catcheur;
        }
    }




    class program
    {
        static void main()
        {
            Personnage perso1 = new Personnage("Judy Sunny", "brute", 5, 100, 1, "Opérationnel");
            Personnage perso2 = new Personnage("Tripple H", "Agile", 3, 125, 3, "Opérationnel");
            Personnage perso3 = new Personnage("Dead Poule", "Agile", 3, 125, 3, "Opérationnel");
            Personnage perso4 = new Personnage("Jarvan cinquième du nom", "brute", 5, 100, 1, "En convalescence");
            Personnage perso5 = new Personnage("Madusa", "Agile", 3, 125, 3, "Opérationnel");
            Personnage perso6 = new Personnage("John Cinema", "Agile", 3, 125, 3, "En convalescence");
            Personnage perso7 = new Personnage("Jeff Radis", "Brute", 5, 100, 1, "En convalescence");
            Personnage perso8 = new Personnage("Raie Mystérieuse", "Brute", 5, 100, 1, "Opérationnel");
            Personnage perso9 = new Personnage("Chris Hart", "Brute", 5, 100, 1, "Opérationnel");
            Personnage perso10 = new Personnage("Bret Benoit", "Agile", 3, 125, 3, "Opérationnel");

            Console.WriteLine(Personnage.nom());
        }
    }
}










