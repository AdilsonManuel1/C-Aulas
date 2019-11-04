using System;

namespace LOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            /* while
            int x = 1;
            while (x<=10) {
                Console.WriteLine(x +" X  2 =" +x*2  );
                x++;
            } */
            // foreach varre todo array e mostra os valores disponives nele.
            /* int[] a = { 1, 2, 4 };
             foreach (int v in a) {
                 Console.WriteLine(v);

             }*/

            //funcao recursiva: aquela que invoca ela mesma.

            // loop(1);

            int[] numeros = {12, 2, 4, 5};

            foreach (int x in numeros) {
                Console.WriteLine(x);
            }
            Console.Read();
        }

        /*
        public static void loop(int a)
        {
            Console.WriteLine(a);
            if (a<=4) {
                // primeiro chama o parametro, depois adicina um valor nele.
                loop(a + 1);
            }
           
            
        }
         */

    }
}
