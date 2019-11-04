using calculo;
using Diretorio;
using funcoes;
using System;
using System.Collections.Generic;
using System.Text;

namespace funcional9.Tela
{
    class Menu

    {
        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVO = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;


        public static void opcaoMenu()
        {
            while (true)
            {

                string mensagem = "Ola Usuario, Ben-vindo ao programa " +
                    "\n utilizando programacao funcional" +
                    "\n\n Digite uma das Opcoes a baixo:" +
                    "\n   0- Sair do Programa" +
                    "\n    1- Ler arquivos" +
                    "\n    2- Tabuada" +
                    "\n    3-Calcular media de alunos ";
                Console.WriteLine(mensagem);
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite " + SAIDA_PROGRAMA + " Para sair do programa");

                if (SAIDA_PROGRAMA == n)
                {
                    break;
                }
                else if (n == LER_ARQUIVO)
                {
                    Console.WriteLine("============= Opcao Ler Arquivo ===============");
                    Arquivo.LerArquivo(1);
                }
                else if (n == TABUADA)
                {
                    Console.WriteLine("============= Opcao Tabuda ===============");
                    Console.WriteLine("\nDigite o numero que deseja na Tabuada");
                    int numero = int.Parse(Console.ReadLine());

                    tabuada.calcular(numero);
                }
                else if (n == CALCULO_MEDIA)
                {
                    Console.WriteLine("============= Opcao Média ===============");

                    /*
                     * oUTRO METODO DE CALCULAR MEDIA.
                    Console.WriteLine("Insira a primeira nota ");
                    float nota1 = float.Parse(Console.ReadLine());

                    Console.WriteLine("Insira a Segunda nota ");
                    float nota2 = float.Parse(Console.ReadLine());

                    Console.WriteLine("Insira a Terceira nota ");
                    float nota3 = float.Parse(Console.ReadLine());
                    mediaAritimetrica(nota1,nota2,nota3);

    */
                    Media.MediaAluno();



                }
            }
        }

    }
}
