using System.Runtime.CompilerServices;

namespace DiamanteDeX
{
    internal class Program
    {
        // Desenvolver um programa em que, dado um número ímpar como entrada, exibirá um diamante desenhado com a letra 'X'.
        // O programa deve solicitar ao usuário um número inteiro.
        // O número deve ser ímpar.Caso contrário, o programa deve informar que entrada é inválida e solicitar um novo número.
        // O número de linhas e colunas deve ser igual ao número ímpar fornecido.
        // A linha central do diamante deve conter o número máximo de 'X's.
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Digite um número ímpar: ");
            int tamanhoDiamante = Convert.ToInt32(Console.ReadLine());

            while (tamanhoDiamante % 2 == 0)
            {
                Console.WriteLine("O número é invalido digite novamente!!!!!");
                Console.Write("Digite um número ímpar:   ");
                tamanhoDiamante = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"O seu diamante tem o tamanho de: {tamanhoDiamante} linhas.");

            //____________________________________________parte superior da linha central______________________________________________________________________

            int meioDoDiamante = tamanhoDiamante / 2;
            for (int posicaoLinha = 0; posicaoLinha <= meioDoDiamante; posicaoLinha++) // percorre as linhas
            {
                for (int posicaoColuna = 0; posicaoColuna < tamanhoDiamante; posicaoColuna++) //percorre as colunas parte esquerda
                {
                    if (posicaoColuna < meioDoDiamante - posicaoLinha || posicaoColuna > meioDoDiamante + posicaoLinha) // imprime (" ") se verdadeiro de acordo com a condicao e (x) se falso
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("X");
                    }
                }

                Console.WriteLine();
            }
            //_____________________________________________parte inferior da linha central_____________________________________________________________________

            for (int posicaoLinha = meioDoDiamante + 1; posicaoLinha < tamanhoDiamante; posicaoLinha++) // percorre as linhas
            {
                for (int posicaoColuna = 0; posicaoColuna < tamanhoDiamante; posicaoColuna++) //percorre as colunas parte direita 
                {
                    if (posicaoColuna < posicaoLinha - meioDoDiamante || posicaoColuna >= tamanhoDiamante - (posicaoLinha - meioDoDiamante)) // imprime (" ") se verdadeiro de acordo com a condicao e (x) 
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("X");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
