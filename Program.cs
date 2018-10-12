using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindIntegerInList
{
    class Program
    {
        static void Main(string[] args)
        {   // La idea es que cada valor de values se ubique en test
            // en la posición del valor mismo: test[values[j]] = values[j]
            // y luego recorrer test y en cuyo valor encontremos el 0
            // en ese índice nos dirá el valor que falta al conjunto.
            // Obviamos la posición 0 de cada vector.
            int[] values = new int[] { 0, 1, 2, 4, 6, 3, 7 };
            int[] test = new int[8];

            for (int i = 0; i < test.Length - 1; i++)
                test[i] = 0;

            for(int j = 1; j < values.Length - 1; j++)
            {
                test[values[j]] = values[j];
            }

            for(int k = 1; k<test.Length -1; k++)
            {
                if (test[k] == 0)
                    Console.WriteLine("{0}", k);
            }

            Console.Read();
        }
    }
}
