using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo02
{
    class Program
    {
        static void PrintStars(int[] tab)
        {
            Console.WriteLine(); //saut de ligne
            for (int i = 0; i < tab.Length; i++)
            {
                for (int k = 0; k < tab[i]; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine(); //saut de ligne
            }
        }
        static void Affichage(int[] tab)
        {
            Console.Write("Voici le contenu du tableau : ");
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write("{0} ", tab[i]);
            }
            Console.WriteLine();
        }
        static int[] Insertion(int[] tab)
        {
            Console.Write("Première valeur : ");
            tab[0] = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < tab.Length + 1; i++)
            {

                Console.Write("{0}ème valeur : ", i);
                tab[i - 1] = Convert.ToInt32(Console.ReadLine());
            }
            return tab;
        }
        static void Main(string[] args)
        {
            Console.Write("Nombre de lignes : ");
            int nbPoste = Convert.ToInt32(Console.ReadLine());
            int[] tab = new int[nbPoste];
            Affichage(Insertion(tab));
            PrintStars(tab);
            Console.ReadLine();
            
        }
    }
}
