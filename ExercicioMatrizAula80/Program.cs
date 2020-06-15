using System;

namespace ExercicioMatrizAula80
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Fazer um programa p/ ler um numero inteiro N e a matriz de ordem N contendo numeros inteiros.
            Em seguida, mostrar a diagonal principal e a qtde de valores negativos da matriz.
            */
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];

            for (int l = 0; l < n; l++)                       // Aqui estou percorrendo apenas as linhas
            {
                string[] valores = Console.ReadLine().Split(' '); // Declaracao d um vetor para cortar cada string, e guardano os pedacos no vetor --> valores
                for (int c = 0; c < n; c++)                   // Aqui estou percorrendo apenas as colunas
                {
                    mat[l, c] = int.Parse(valores[c]);
                }
            }
            Console.WriteLine();

            // Imprimir Diogonal Principal:
            Console.WriteLine("Diagonal Principal: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();


            int contadora = 0;
            // Percorrer a matriz inteira, linhas e colunas:
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        contadora++; // Guardando valores negativos na variavel
                    }
                }
            }
            Console.WriteLine("Numeros negativos: " + contadora);

        }

    }
}
