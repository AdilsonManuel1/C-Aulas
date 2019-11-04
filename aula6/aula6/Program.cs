using System;
// Essa biblioteca permite usar lista.
using System.Collections.Generic;

namespace aula6
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
          string [] a = new string[3];
          var aa = new string [3];
          a [0] = "Adilson";
          a[1] = "Morais";
          a[2] = "Manuel";


          // Para mostrar todos elementos dento do vector

          for (int x=0; x<a.Length;x++) {
              Console.WriteLine(a[x]);

          } */

            List<String> a = new List<string>();
            a.Add("Adilson");
            a.Add("Manuel");
            a.Add("Morais");

            foreach (string nomes in a) {

                Console.WriteLine(nomes);
            }
            // O e => e== é a sintaxe do existe.
            if (a.Exists(e => e == "Paula"))
            {
                Console.WriteLine("Eu encontrei o Adilson no meu List! ");
            }
            else {
                Console.WriteLine("Nao encontrei este nome no meu list ");
            }
            int size = a.Count;
            Console.WriteLine("A lista está actualizada com "+ size +" Cadastrados");

            Console.Read();
        }
    }
}
