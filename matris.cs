using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matris
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] dizi = new int[5, 3];
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    dizi[i, j] = rnd.Next(1, 100);
                    Console.Write(dizi[i, j] + "  ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}


