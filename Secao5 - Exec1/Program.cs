using System;
using System.Globalization;

namespace Secao5___Exec1
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta;
            Console.Write("Digite o número da conta: ");
            int numConta = int.Parse(Console.ReadLine());
            Console.Write("Digite o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Deseja realizar um depósito inicial? (s/n) ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                Console.Write("Digite o valor do depósito: ");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(numConta, nome, valor);
            }
            else
            {
                conta = new Conta(numConta, nome);
            }
            Console.WriteLine(conta.ToString());
        }
    }
}
