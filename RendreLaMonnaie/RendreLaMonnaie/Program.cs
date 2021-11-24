using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RendreLaMonnaie
{
    class Program
    {
        static void Main(string[] args)
        { /** A faire: Faire marcher décimal,
           * Mettre en place système de pieces et billets */
            Random Montant = new Random();
            decimal MontantAPayer = Montant.Next(1,200);
            Console.WriteLine($"Montant à payer : {MontantAPayer}");
            while (true)
            {
                Console.Write("Entrer le montant réglé (entrer 0 pour mettre fin au programme) : ");
                decimal MontantRegle = decimal.Parse(Console.ReadLine());
                if (MontantRegle == MontantAPayer)
                {
                    Console.WriteLine("Montant a rendre : 0, 00");
                    Console.ReadKey();
                    MontantAPayer = Montant.Next(1, 200);
                    Console.WriteLine($"Montant à payer : {MontantAPayer}");
                }
                else if (MontantRegle == 0)
                {
                    break;
                }
                else if (MontantRegle < MontantAPayer)
                {
                    Console.WriteLine($"Le montant ne réglé ne peut pas être inférieur à {MontantAPayer} ");
                    Console.ReadKey();
                }
                else if (MontantRegle > MontantAPayer)
                {
                    decimal MontantRendre = MontantRegle - MontantAPayer;
                    Console.WriteLine($"Montant a rendre : {MontantRendre} ");
                    Console.ReadKey();
                    MontantAPayer = Montant.Next(1, 200);
                    Console.WriteLine($"Montant à payer : {MontantAPayer}");
                }
            }
        }
    }
}
