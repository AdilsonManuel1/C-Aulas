using System;
// Biblioteca que permite ler ficheiros
using System.IO;

namespace arquivo8
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Hello World!");
            LerArquivo(1);
            Console.Read();
        }

        private static void LerArquivo(int numeroArquivo)
        {
            string arquivoComCaminho = @"C:\arquivos\arq" + numeroArquivo+".txt";
            if (File.Exists(arquivoComCaminho)) {

                using (StreamReader arquivo = File.OpenText(arquivoComCaminho))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }

                }
            }
            string arquivoComCaminho2 = @"C:\arquivos\arq" + (numeroArquivo +1)+ ".txt";
            if (File.Exists(arquivoComCaminho2)) {
                LerArquivo((numeroArquivo + 1));
            
            }




        }
    }
}
