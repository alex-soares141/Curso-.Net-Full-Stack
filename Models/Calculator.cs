using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Net.Models
{
    public class Calculator
    {
        public void Somar(int a, int b)
        {
            Console.WriteLine($"A soma de {a} + {b} é : {a + b}");
        }
        public void Subtrair(int a, int b)
        {
            Console.WriteLine($"A subtração de {a} - {b} é : {a - b}");
        }
        public void Multiplicar(int a, int b)
        {
            Console.WriteLine($"A multiplicação de {a} vezes {b} é : {a * b}");
        }
    }
}