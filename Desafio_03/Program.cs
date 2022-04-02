using System;

namespace Desafio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // uso de arrays
            string[] nome = new string[100];
            float[] nota = new float[100];

            //variaveis	
            int nomeMaiorNota = 0;
            string numCad;
            float maiorNota = 0;
            bool numInt, numFloat;

            //entrada de dados no console
            msgTela();
            numCad = Console.ReadLine();
            numInt = EhnumInt(numCad);

            //------------------------------------------------------------------------------------

            while (numInt == false) // não deixa digitar outro caracter que não seja numeros
            {
                Console.Clear();
                msgTela();
                numCad = Console.ReadLine();
                numInt = EhnumInt(numCad);

            }

            for (int i = 0; i < int.Parse(numCad); i++) // faz o preenchimento dos arrays em suas posições
            {
                int numeroAluno = i + 1;
                Console.Write("NOME DO ALUNO " + numeroAluno + " ");
                nome[i] = Console.ReadLine();

                Console.Write("NOTA DO ALUNO " + numeroAluno + " ");
                string notaVerificar = Console.ReadLine();
                numFloat = EhnumFloat(notaVerificar);
                while (numFloat == false) // não deixa digitar letras, apenas numeros
                {
                    Console.Clear();
                    Console.WriteLine("Na nota do Aluno , " + nome[i] + ", \nDIgite apenas Numeros:");
                    notaVerificar = Console.ReadLine();
                    numFloat = EhnumFloat(notaVerificar);
                }
                nota[i] = float.Parse(notaVerificar);

                if (maiorNota < nota[i])
                {
                    maiorNota = nota[i];
                    nomeMaiorNota = i;
                }

                Console.WriteLine("____________________________________________");

            }

            Console.Write("O aluno :" + nome[nomeMaiorNota] + " \nTem a maior Nota: " + maiorNota);
            Console.ReadLine();
            //----------------------------------------------------------------------------------

            // Função Imprime na tela digitar quantidade de alunos------------------
            static void msgTela()
            {
                Console.WriteLine("DIGITE APENAS NUMEROS!");
                Console.WriteLine("Quantos alunos deseja cadastrar?");

            }


            // Função verifica se é numero float ------------------------------
            static bool EhnumFloat(string valorDigitado)
            {
                float n;
                bool ehUmNumero = float.TryParse(valorDigitado, out n);
                if (ehUmNumero)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

            // Função verifica se é numero Int----------------------------------
            static bool EhnumInt(string valorDigitado)
            {
                int n;
                bool ehUmNumero = int.TryParse(valorDigitado, out n);
                if (ehUmNumero)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

        }
    }
}
