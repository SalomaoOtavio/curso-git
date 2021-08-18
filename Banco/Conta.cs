using System;
using System.Globalization;

namespace Banco {
    class Conta {

        public int NumConta { get; private set;}
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public Conta(int numConta, string titular) {
            NumConta = numConta;
            Titular = titular;
            Saldo = 0.00;
        }

        public Conta (int numero, string titular, double depositoinicial) {
            NumConta = numero;
            Titular = titular;
            Deposito(depositoinicial);
        }
        
        public void Deposito(double deposito) {
            Saldo += deposito;            
        }
        
        public void Saque(double saque) {
            Saldo -= (saque + 5);
        }

        public override string ToString() {
            return "Conta: "
                + NumConta 
                + ", Titular: " 
                + Titular 
                + ", Saldo: $" 
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
