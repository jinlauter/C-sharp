using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //matriz.rank = quantidade de linhas
            //matriz.GetLenght(0) = qtd da primeira dimensão da matriz, no caso, linhas (duas), getlenght(1) traria a qtd de colunas

            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Diagonal principal: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(matriz[i, i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i,j] < 0)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine("Negativos: " + count);
        }
    }
}

