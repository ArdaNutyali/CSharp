using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayisalLoto
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] loto = new int[6];
            Random rnd = new Random();
            int sayi;
            int indis = 0;
            while (indis < 6)
            {
                int kontrol = 0;
                sayi = rnd.Next(1, 49);
                for (int i = 0; i < 6; i++)
                {
                    if (loto[i] == sayi)
                    {
                        kontrol++;
                    }
                }
                if (kontrol == 0)
                {
                    loto[indis] = sayi;
                    indis++;
                }
            }
            for (int i = 0; i < 6; i++)
            {
                Console.Write(loto[i] + " ");
            }
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (loto[i] < loto[j])
                    {
                        int tmp = loto[i];
                        loto[i] = loto[j];
                        loto[j] = tmp;
                    }
                }
            }
            Console.WriteLine("\n\nDizinin Küçükten Büyüğe Sıralı Hali\n");
            for (int i = 0; i < 6; i++)
            {
                Console.Write(loto[i] + " ");
            }
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (loto[i] > loto[j])
                    {
                        int tmp = loto[i];
                        loto[i] = loto[j];
                        loto[j] = tmp;
                    }
                }
            }
            Console.WriteLine("\n\nDizinin Büyükten Küçüğe Sıralı Hali\n");
            for (int i = 0; i < 6; i++)
            {
                Console.Write(loto[i] + " ");
            }
            Console.ReadKey();
        }
    }
}


