using System;
using System.Collections.Generic;
using System.Text;

namespace Funcionario
{
    class Salario
    {
        public string nome;
        public double salarioBruto;
        public int imposto;
        public double CalcularSalario(double salarioBruto, int imposto)
        {
            return salarioBruto - (salarioBruto * (imposto / 100.0));
        }
        public Salario(string nome, double salarioBruto, int imposto)
        {
            this.nome = nome;
            this.salarioBruto = salarioBruto;
            this.imposto = imposto;
        }
    }
}
