using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CalculTaMoyenne


{
    class Calc
    
    {
        static void Main(string[] args)

        {
            // Création du titre.
            string title = "Calcule Ta Moyenne V0.3";
            Console.Title = title;
            // Envoie de la fonction principale.
            Send();

            // Création de la fonction générale.
            // Les boucles ne sont pas possibles ici.
            void Send () {
                Console.ReadLine();
                Console.WriteLine("Si vous n'écrivez pas de valeur correct l'application se fermera.");
                Console.ReadLine();
                Console.WriteLine("Choissisez votre première note");
                string noteune = Console.ReadLine();
                int resultun = int.Parse(noteune);
                Console.WriteLine("Choissisez votre deuxième note");
                string notedeux = Console.ReadLine();
                int resultdeux = int.Parse(notedeux);
                Console.WriteLine("Choissisez votre note");
                string notetrois = Console.ReadLine();
                int resulttrois = int.Parse(notetrois);
                Console.WriteLine("Choissisez votre quatrième note");
                string notequatre = Console.ReadLine();
                int resultquatre = int.Parse(notequatre);
                Console.WriteLine("Choissisez votre cinquième note");
                string notecinq = Console.ReadLine();
                int resultcinq = int.Parse(notecinq);
                Console.WriteLine("Choissisez votre sixième note");
                string notesix = Console.ReadLine();
                int resultsix = int.Parse(notesix);
                Console.WriteLine("Choissisez votre septième note");
                string notesept = Console.ReadLine();
                int resultsept = int.Parse(notesept);
                Console.WriteLine("Choissisez votre huitième note");
                string notehuit = Console.ReadLine();
                int resulthuit = int.Parse(notehuit);
                Console.WriteLine("Choissisez votre neuvième note");
                string noteneuf = Console.ReadLine();
                int resultneuf = int.Parse(noteneuf);
                Console.WriteLine("Choissisez votre dixième note");
                string notedix = Console.ReadLine();
                int resultdix = int.Parse(notedix);
                Console.WriteLine("Choissisez votre onzième note");
                string noteonze = Console.ReadLine();
                int resultonze = int.Parse(noteonze);
                Console.WriteLine("Choissisez votre douzième note");
                string notedouze = Console.ReadLine();
                int resultdouze = int.Parse(notedouze);
                int total = resultun + resultdeux + resultquatre + resultcinq + resultsix + resultsept + resulthuit + resultneuf + resultdix + resultonze + resultdouze;
                int nbnote = 11;
                int all = total / nbnote;
                Console.WriteLine("Votre moyenne est de : " + all + "/20");
                if (all >= 20)
                {
                    Console.ReadLine();
                    Console.WriteLine("Vous avez écrit des valeur supérieur à 20 !");
                }
                Console.ReadKey();
                Console.WriteLine("Appuyez sur \"Entrez\" pour quittez l'application.");
                Console.ReadKey();
            }
        }
    }
}