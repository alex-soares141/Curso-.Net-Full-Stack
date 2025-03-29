// See https://aka.ms/new-console-template for more information
using Net.Models;

Pessoa p = new Pessoa();

p.Nome = "Alex";
p.Idade = 30;
p.Apresentar();


Calculator calc = new Calculator();
calc.Somar(10, 20);
calc.Subtrair(20, 10);
calc.Multiplicar (10, 10);