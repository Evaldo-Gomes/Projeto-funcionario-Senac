using System;
using System.Globalization;


namespace prj15_revisao_funcionario
{
    class Funcionario
    {
        public string Nome { get; private set; }
        public string Cargo { get; private set; }
        public decimal Salario { get; private set; }
        public double Desconto { get; private set; }

        public Funcionario(string nome, string cargo, decimal salario, double desconto)
        {
            this.Nome = nome;
            this.Cargo = cargo;
            this.Salario = salario;
            this.Desconto = desconto;
        }

        public decimal SaLiquido()
        {
            return Salario -= (Salario *(decimal) Desconto) / 100;
        }

        public override string ToString()
        {
            return string.Format("{0} você possui o cargo de {1} com o desconto de {2}% " +
                "receberá o salario de R$ {3}", Nome, Cargo,
                Desconto.ToString("f2", CultureInfo.InvariantCulture), SaLiquido().ToString("f2"));
        }

    }
}
