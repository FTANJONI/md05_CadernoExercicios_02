using System;

namespace md05_CadernoExercicios_02
{
    class Program
    {
        /*
         2. Faça um algoritmo que leia uma matriz mat 2 x 3 e imprima na tela a soma
            de todos os elementos pares da matriz mat.
         */
        static void Main(string[] args)
        {
            double[] v = new double[3];

            int nrPar, soma=0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Digite o " + (i + 1) + "° vetor:");
                v[i] = Convert.ToDouble(Console.ReadLine());
                nrPar = Convert.ToInt32(v[i]);
                if (nrPar > 1)
                {
                    soma =soma + Convert.ToInt32(v[i]);
                }

            }
            Console.WriteLine("Somatório dos elementos pares: {0}",soma.ToString("0.00"));
        }
    }
}
