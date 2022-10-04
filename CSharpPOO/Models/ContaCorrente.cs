using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpPOO.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial) {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }

        public int NumeroConta { get; set; }
        
        private decimal saldo;

        public void Sacar() {
            Console.Write("Quanto gostaria de sacar?: ");
            decimal valor = Decimal.Parse(Console.ReadLine());

            if(saldo >= valor) {
                saldo -= valor;
                Console.WriteLine("Saque Realizado com sucesso");
            }
            else {
                Console.WriteLine("Valor desejado é maior que o seu saldo");
            }
        }

        public void ExibirSaldo() {
            Console.WriteLine($"Agora você tem {saldo:C} disponível em conta");
        }
    }
}