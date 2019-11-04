using System;
using System.Collections.Generic;
using System.Text;

namespace calculo
{
    class Media
    {

        public static void MediaAluno()
        {
            int quantidadeNota = 3;
            int total_notas = 0;
            Console.WriteLine("Insira o nome do aluno");
            string nomeAluno = Console.ReadLine();

            List<int> notas = new List<int>();
            for (int i = 1; i <= quantidadeNota; i++)
            {
                Console.WriteLine("Insiras a " + i + " Nota do aluno" + nomeAluno);
                int nota = int.Parse(Console.ReadLine());
                notas.Add(nota);
                total_notas += nota;
            }
            // notas.cout. basicamente esta a contar o numero de notas acrescentada no fluxo e armazenar o seu valor.
            int media = total_notas / notas.Count;
            Console.WriteLine("A media do aluno " + nomeAluno + " é " + media);
            Console.WriteLine("Suas notas sao");
            foreach (int nota in notas)
            {
                Console.WriteLine("Nota " + nota + " \n");
            }
            // Media aritimetrica, aqui vai acontecer magia.
            /*

            public static void mediaAritimetrica(float nota1, float nota2, float nota3) {
                float media = (nota1 + nota2 + nota3) / 3;
                Console.WriteLine("A media aritimetrica do aluno é " + media);
             */


            //Ler arquivo USAR OUTRO METODO DE CALCULAR MEDIA ARITIMETRICA
        }

    }
}
