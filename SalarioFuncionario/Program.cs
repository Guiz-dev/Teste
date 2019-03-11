using System;
using System.Globalization;

namespace SalarioFuncionario {
    class Program {
        static void Main(string[] args) {
            Funcionario f = new Funcionario();

            Console.Write("Nome do funcionário: ");
            f.Nome = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\n\nFuncionário: " + f+"\n");

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumentarSalario(porcentagem);

            Console.WriteLine("\n\nDados atualizados: " + f + "\n");
        }
    }
}
