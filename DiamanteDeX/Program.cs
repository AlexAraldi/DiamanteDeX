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
            int numImp = Convert.ToInt32(Console.ReadLine());

            while (numImp % 2 == 0)
            {
                Console.WriteLine("O número é invalido digite novamente!!!!!");
                Console.Write("Digite um número ímpar:   ");
                numImp = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"O seu numero impar é: {numImp} ");
            //__________________________________________________________________________________________________________________
            
            for (int i = 0; i < numImp; i++)
            {
                Console.WriteLine("X");

                
            }
            Console.ReadLine();
        }
    }
}
