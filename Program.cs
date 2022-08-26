using System.Globalization;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            System.Console.Write("Digite o número da conta: ");
            int numero = int.Parse(Console.ReadLine()!);

            System.Console.Write("Digite o nome do titular da conta: ");
            string titular = Console.ReadLine()!;

            System.Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine()!);

            if (resp == 's' || resp == 'S')
            {
                System.Console.Write("Digite o valor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Dados da conta:");
            System.Console.WriteLine(conta);

            System.Console.WriteLine();
            System.Console.Write("Digite um valor para o depósito: ");
            double quantia = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            conta.Deposito(quantia);

            System.Console.WriteLine("Dados da conta atualizados:");
            System.Console.WriteLine(conta);

            System.Console.WriteLine();
            System.Console.Write("Digite um valor para o saque: ");
            quantia = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            conta.Saque(quantia);

            System.Console.WriteLine("Dados da conta atualizados:");
            System.Console.WriteLine(conta);
        }
    }    
}