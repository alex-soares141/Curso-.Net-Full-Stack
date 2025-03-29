using System;

namespace Net.Models
{
    public class Pessoa
    {
        public string Nome { get; set; } = string.Empty;

        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"olá meu nome é {Nome}, e minha idade é : {Idade} anos");
        }
    }
}
