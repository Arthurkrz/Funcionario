using System;

namespace Funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao programa Calculador de Salario!\n\nInsira, linha por linha, o nome do funcionário, seu salário bruto e imposto deduzido (em porcentagem).");
            string nome = Console.ReadLine();
            double salarioBruto = double.Parse(Console.ReadLine());
            int imposto = int.Parse(Console.ReadLine());
            if (salarioBruto > 0 && imposto > 0)
            {
                Salario f = new Salario(nome, salarioBruto, imposto);
                Console.Clear();
                Console.WriteLine($"Funcionário {f.nome} apresenta salário líquido de R${f.CalcularSalario(f.salarioBruto, f.imposto):F2}.");
                Console.WriteLine("Digite o valor do incremento em porcentagem:");
                double porcentagem = double.Parse(Console.ReadLine());
                f.Incremento(porcentagem);
                Console.WriteLine($"Funcionário {f.nome} apresenta salário líquido de R${f.CalcularSalario(f.salarioBruto, f.imposto):F2}.");
            }
            else
            {
                Console.WriteLine("Valores inválidos.");
            }
        }
    }
}
