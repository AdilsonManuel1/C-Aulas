using System;
using System.Collections.Generic;
using System.Text;

namespace funcoes
{
    class tabuada
    {
        public static void calcular(int numero)
        {
            Console.WriteLine("=============== Calculo da Tabuada ===========");
            for (int x = 1; x <= 10; x++)
            {
                Console.WriteLine(numero + " X " + x + " = " + (numero * x));
            }
        }
    }
}
