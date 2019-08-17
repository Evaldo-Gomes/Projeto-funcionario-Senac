using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj15_revisao_funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o nome do Funcionario: ");
            string nome = Console.ReadLine();

            Console.Write("Informe o cargo do funcionario: ");
            string cargo = Console.ReadLine();

            Console.Write("Informe o salário do funcionario: ");
            decimal salario = decimal.Parse(Console.ReadLine());

            Console.Write("Informe o total percentual de desconto: ");
            double desconto = double.Parse(Console.ReadLine());

            Funcionario func = new Funcionario(nome, cargo, salario, desconto);

            Console.WriteLine();
            Console.WriteLine(func);
            
        }
    }
}
