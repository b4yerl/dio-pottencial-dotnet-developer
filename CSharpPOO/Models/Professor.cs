using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpPOO.Models
{
    public class Professor : Pessoa
    {
        public Professor ()
        {

        }
        public Professor(string nome) : base(nome)
        {
            
        }
        public double Salario { get; set; }

        public sealed override void Apresentar() {
            Console.WriteLine($"Olá meu nome é {Nome} e recebo {Salario.ToString("C")} por mês");
        }
    }
}