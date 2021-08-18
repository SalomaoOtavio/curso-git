using System;
using System.Globalization;

namespace Banco {
    class Program {
        static void Main(string[] args) {

            double saldo;
            Conta c;
            Console.Write("Informe o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Havera deposito inicial (s/n): ");
            char resposta = char.Parse(Console.ReadLine());

            if (resposta == 's') {
                Console.Write("Digite o valor  de deposito inicial: ");
                saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                 c = new Conta(numero, titular, saldo);
            }
            else {
                 c = new Conta(numero, titular);
            }
           
            

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(c.ToString());
            Console.WriteLine();

            Console.Write("Digite o valor de deposito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Deposito(deposito);
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(c.ToString());
            
            Console.WriteLine();
            Console.Write("Entre com um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Saque(saque);

            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(c.ToString());

        }
    }
}
