using System;

namespace aula8_constante
{
    class Program
    {
        public const int SAIDA_PROGRAMA = 1;
        static void Main(string[] args)
        {

            while (true) {
                Console.WriteLine("Insira o numero "+SAIDA_PROGRAMA + " Para feichar a aplicacao ");
                int numero = int.Parse(Console.ReadLine());
                if (SAIDA_PROGRAMA ==numero) {
                    break;
                }
            }
           
            Console.Read();
        }
    }
}
