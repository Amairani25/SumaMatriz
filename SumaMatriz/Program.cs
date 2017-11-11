using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaMatriz
{
    class Program
        {
            static void Main(string[] args)
            {
                int[,] m = { { 8, 6, 4 }, { 9, 3, 2 }, { 5, 1, 7 } };
                int Suma = 0;
                for (int x = 0; x < 3; x++)
                {
                    Suma = Suma + m[x, x];

                }
                Console.WriteLine(" La suma de la diagonal es:" + Suma);
                Console.ReadKey();
            }
        }
    }
