using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CalculTaMoyenne
{
    class main
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Choissisez votre première note");
            string noteune = Console.ReadLine();
            int resultun = int.Parse(noteune);
            Console.WriteLine("Choissisez votre deuxième note");
            string notedeux = Console.ReadLine();
            int resultdeux = int.Parse(notedeux);
            Console.WriteLine("Choissisez votre troisième note");
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
            Console.WriteLine("Votre moyenne est de : " + total / nbnote + "/20");
            Console.WriteLine("Appuyez sur \"Entrez\" pour quittez l'application.");
            Console.ReadKey();
        }
    }
}