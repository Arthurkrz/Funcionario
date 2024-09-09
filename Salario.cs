using System;
using System.Collections.Generic;
using System.Text;

namespace Funcionario
{
    class Salario
    {
        private string _nome;
        public double SalarioBruto { get; set; }
        public int Imposto { get; set; }
        public Salario(string nome, double salarioBruto, int imposto)
        {
            Nome = nome;
            this.SalarioBruto = salarioBruto;
            this.Imposto = imposto;
        }
        public string Nome
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_nome))
                {
                    return "N/A";
                }
                return _nome;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _nome = value;
                }
                else
                {
                    _nome = "N/A";
                }
            }
        }
        public double CalcularSalario(double salarioBruto, int imposto)
        {
            return salarioBruto - (salarioBruto * (imposto / 100.0));
        }
        public void Incremento(double porcentagem)
        {
            SalarioBruto += SalarioBruto * (porcentagem / 100);
        }
    }
}
